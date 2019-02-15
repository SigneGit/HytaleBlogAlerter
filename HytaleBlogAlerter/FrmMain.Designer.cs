namespace HytaleBlogAlerter
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chkbox_ShowMsgBox = new System.Windows.Forms.CheckBox();
            this.Chkbox_PlaySound = new System.Windows.Forms.CheckBox();
            this.Label_UpdateTime = new System.Windows.Forms.Label();
            this.TrackBar_Counter = new System.Windows.Forms.TrackBar();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.DataGrid_HytaleAPI = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Notify_Alerter = new System.Windows.Forms.NotifyIcon(this.components);
            this.Timer_GetApi = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Label_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Notify_Alerter_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_HytaleAPI)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Notify_Alerter_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Chkbox_ShowMsgBox);
            this.groupBox1.Controls.Add(this.Chkbox_PlaySound);
            this.groupBox1.Controls.Add(this.Label_UpdateTime);
            this.groupBox1.Controls.Add(this.TrackBar_Counter);
            this.groupBox1.Controls.Add(this.Btn_Start);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // Chkbox_ShowMsgBox
            // 
            this.Chkbox_ShowMsgBox.AutoSize = true;
            this.Chkbox_ShowMsgBox.Location = new System.Drawing.Point(173, 23);
            this.Chkbox_ShowMsgBox.Name = "Chkbox_ShowMsgBox";
            this.Chkbox_ShowMsgBox.Size = new System.Drawing.Size(94, 17);
            this.Chkbox_ShowMsgBox.TabIndex = 4;
            this.Chkbox_ShowMsgBox.Text = "Show MsgBox";
            this.Chkbox_ShowMsgBox.UseVisualStyleBackColor = true;
            // 
            // Chkbox_PlaySound
            // 
            this.Chkbox_PlaySound.AutoSize = true;
            this.Chkbox_PlaySound.Location = new System.Drawing.Point(87, 23);
            this.Chkbox_PlaySound.Name = "Chkbox_PlaySound";
            this.Chkbox_PlaySound.Size = new System.Drawing.Size(80, 17);
            this.Chkbox_PlaySound.TabIndex = 3;
            this.Chkbox_PlaySound.Text = "Play Sound";
            this.Chkbox_PlaySound.UseVisualStyleBackColor = true;
            // 
            // Label_UpdateTime
            // 
            this.Label_UpdateTime.AutoSize = true;
            this.Label_UpdateTime.Location = new System.Drawing.Point(15, 94);
            this.Label_UpdateTime.Name = "Label_UpdateTime";
            this.Label_UpdateTime.Size = new System.Drawing.Size(117, 13);
            this.Label_UpdateTime.TabIndex = 2;
            this.Label_UpdateTime.Text = "1 Second Update Time";
            // 
            // TrackBar_Counter
            // 
            this.TrackBar_Counter.Location = new System.Drawing.Point(6, 48);
            this.TrackBar_Counter.Maximum = 60;
            this.TrackBar_Counter.Minimum = 1;
            this.TrackBar_Counter.Name = "TrackBar_Counter";
            this.TrackBar_Counter.Size = new System.Drawing.Size(323, 45);
            this.TrackBar_Counter.TabIndex = 1;
            this.TrackBar_Counter.Value = 1;
            this.TrackBar_Counter.ValueChanged += new System.EventHandler(this.TrackBar_Counter_ValueChanged);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(6, 19);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // DataGrid_HytaleAPI
            // 
            this.DataGrid_HytaleAPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_HytaleAPI.Location = new System.Drawing.Point(6, 19);
            this.DataGrid_HytaleAPI.Name = "DataGrid_HytaleAPI";
            this.DataGrid_HytaleAPI.ReadOnly = true;
            this.DataGrid_HytaleAPI.Size = new System.Drawing.Size(323, 159);
            this.DataGrid_HytaleAPI.TabIndex = 1;
            this.DataGrid_HytaleAPI.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_HytaleAPI_CellContentDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGrid_HytaleAPI);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hytale API Response";
            // 
            // Notify_Alerter
            // 
            this.Notify_Alerter.Text = "Hytale Blog Alerter";
            this.Notify_Alerter.Visible = true;
            this.Notify_Alerter.BalloonTipClicked += new System.EventHandler(this.Notify_Alerter_BalloonTipClicked);
            this.Notify_Alerter.DoubleClick += new System.EventHandler(this.Notify_Alerter_DoubleClick);
            // 
            // Timer_GetApi
            // 
            this.Timer_GetApi.Interval = 5000;
            this.Timer_GetApi.Tick += new System.EventHandler(this.Timer_GetApi_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(359, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Label_Status
            // 
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(47, 17);
            this.Label_Status.Text = "[Status]";
            // 
            // Notify_Alerter_contextMenuStrip
            // 
            this.Notify_Alerter_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Open,
            this.toolStripSeparator1,
            this.Btn_Exit});
            this.Notify_Alerter_contextMenuStrip.Name = "Notify_Alerter_contextMenuStrip";
            this.Notify_Alerter_contextMenuStrip.Size = new System.Drawing.Size(104, 54);
            // 
            // Btn_Open
            // 
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(103, 22);
            this.Btn_Open.Text = "Open";
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(103, 22);
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 342);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Hytale Blog Alerter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_HytaleAPI)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Notify_Alerter_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar TrackBar_Counter;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label Label_UpdateTime;
        private System.Windows.Forms.DataGridView DataGrid_HytaleAPI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NotifyIcon Notify_Alerter;
        private System.Windows.Forms.Timer Timer_GetApi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Label_Status;
        private System.Windows.Forms.ContextMenuStrip Notify_Alerter_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Btn_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Btn_Exit;
        private System.Windows.Forms.CheckBox Chkbox_ShowMsgBox;
        private System.Windows.Forms.CheckBox Chkbox_PlaySound;
    }
}

