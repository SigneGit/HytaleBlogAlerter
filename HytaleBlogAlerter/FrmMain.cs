using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Net;
using System.Media;
using System.Threading;
using System.Diagnostics;

namespace HytaleBlogAlerter
{
    public partial class FrmMain : Form
    {
        public struct ApiData
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string BodyExcerpt { get; set; }

            public ApiData(string _title, string _author, string _bodyExcerpt)
            {
                Title = _title;
                Author = _author;
                BodyExcerpt = _bodyExcerpt;
            }
        }
        public const string APIEndPoint = "https://hytale.com/api/blog/post/published";
        public int UpdateTime;

        public int CurrentUpdateWaitTime;

        public bool FirstRun;
        public WebClient Web;

        //public List<ApiData> DataGridApi = new List<ApiData>();

        public List<BlogApi> BlogPostList;

        public FrmMain()
        {
            InitializeComponent();
        }


        //Init everything
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Chkbox_PlaySound.Checked = Properties.Settings.Default.PlaySound;
            Chkbox_ShowMsgBox.Checked = Properties.Settings.Default.ShowMsgBox;
            DataGrid_HytaleAPI.RowHeadersVisible = false;
            FirstRun = true;
            Web = new WebClient();
            BlogPostList = new List<BlogApi>();
            Notify_Alerter.Icon = Properties.Resources.icon;

            UpdateTime = Properties.Settings.Default.UpdateTime;
            if (UpdateTime > 60)
                UpdateTime = 60;

            TrackBar_Counter.Value = UpdateTime;
            Label_UpdateTime.Text = UpdateTime + " Second Update Time";
            //Timer_GetApi.Interval = UpdateTime * 1000;
            Timer_GetApi.Interval = 1 * 1000;

            Label_Status.Text = "Idle";
            Notify_Alerter.ContextMenuStrip = Notify_Alerter_contextMenuStrip;
        }

        public void SendNotification(string title, string message)
        {
            Notify_Alerter.BalloonTipIcon = ToolTipIcon.Info;
            Notify_Alerter.BalloonTipTitle = title;
            Notify_Alerter.BalloonTipText = message;
            Notify_Alerter.ShowBalloonTip(500);

            if (Chkbox_PlaySound.Checked)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
                player.Play();
            }
            if (Chkbox_ShowMsgBox.Checked)
                MessageBox.Show(message, title);
        }

        public void RefreshHytaleAPIDataGrid()
        {
            var bindinglist = new BindingList<ApiData>();
            foreach (BlogApi post in BlogPostList)
            {
                bindinglist.Add(new ApiData(post.Title, post.Author, post.BodyExcerpt));
            }
            DataGrid_HytaleAPI.DataSource = bindinglist;
        }

        public string GetHytaleBlogURL(BlogApi api)
        {
            /*string baseUrl = "https://hytale.com/news/";
            if (DateTime.TryParse(api.CreatedAt, out DateTime result))
            {
                baseUrl += result.Year.ToString() + "/" + result.Day.ToString() + "/" + api.Slug;
            }
            return string.Empty;*/

            if (DateTime.TryParse(api.PublishedAt, out DateTime result))
                return "https://hytale.com/news/" + result.Year.ToString() + "/" + result.Month.ToString() + "/" + api.Slug;
            return string.Empty;
        }

        public void ShowSelf()
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }
        public void HideSelf()
        {
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void TrackBar_Counter_ValueChanged(object sender, EventArgs e)
        {
            Label_UpdateTime.Text = TrackBar_Counter.Value + " Second Update Time";
            UpdateTime = TrackBar_Counter.Value;
        }

        
        Stopwatch stopwatch = new Stopwatch();
        private void Timer_GetApi_Tick(object sender, EventArgs e)
        {
            //Timers run on the GUI thread which I don't like
            //I should change this to be a task.
            
            if (FirstRun)
            {
                if (BlogPostList.Count > 0)
                    FirstRun = false;
            }
            
            if (CurrentUpdateWaitTime <= 0 || FirstRun)
            {
                stopwatch.Reset();
                stopwatch.Start();
                try
                {
                    Label_Status.Text = "Getting Hytale Blog API";
                    string data = Web.DownloadString(APIEndPoint);
                    stopwatch.Stop();
                    BlogApi[] results = JsonConvert.DeserializeObject<BlogApi[]>(data);

                    Label_Status.Text = "Parsing API";
                    for (int i = 0; i < results.Length; i++)
                    {
                        int index = BlogPostList.FindIndex(x => x._id == results[i]._id);
                        if (index == -1)
                        {
                            

                            if (!FirstRun)
                            {
                                BlogPostList.Insert(0,results[i]);
                                //New Blog Post send a notification
                                string BlogPost = results[i].Title + "\n" + results[i].Author + "\n" + results[i].BodyExcerpt;
                                SendNotification("New Blog Post", BlogPost);
                            }
                            else
                            {
                                BlogPostList.Add(results[i]);
                            }
                        }
                    }
                    Label_Status.Text = "Finished Parsing";
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Web exception\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception\n" + ex.Message);
                }
                RefreshHytaleAPIDataGrid();
                CurrentUpdateWaitTime = UpdateTime;
            }
            else
            {
                string elapsed = stopwatch.Elapsed.Milliseconds.ToString() + " milliseconds";
                if (stopwatch.Elapsed.Seconds > 0)
                    elapsed = stopwatch.Elapsed.Seconds.ToString() + " second(s)";
                Label_Status.Text = String.Format("Idling for {0} second(s), got Hytale API in {1}", CurrentUpdateWaitTime, elapsed);
                CurrentUpdateWaitTime--;
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (Btn_Start.Text == "Start")
            {
                Timer_GetApi.Start();
                Btn_Start.Text = "Stop";
                Label_Status.Text = "Starting...";
            }
            else
            {
                Timer_GetApi.Stop();
                Btn_Start.Text = "Start";
                Label_Status.Text = "Idle";
            }
        }

        private void Notify_Alerter_DoubleClick(object sender, EventArgs e)
        {
            ShowSelf();
        }

        private void Notify_Alerter_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowSelf();
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            ShowSelf();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.UpdateTime = UpdateTime;
            Properties.Settings.Default.PlaySound = Chkbox_PlaySound.Checked;
            Properties.Settings.Default.ShowMsgBox = Chkbox_ShowMsgBox.Checked;
            Properties.Settings.Default.Save();
            Notify_Alerter.Icon = null;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HideSelf();
            }
            else
            {
                ShowSelf();
            }
        }

        private void DataGrid_HytaleAPI_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = GetHytaleBlogURL(BlogPostList[e.RowIndex]);
            if(!string.IsNullOrEmpty(url))
                Process.Start(url);
            
        }
    }
}
