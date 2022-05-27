
namespace SingleClick
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.blockedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.blockedTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.passedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.passedTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadRedditcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.startStopButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clickTimer = new System.Windows.Forms.Timer(this.components);
            this.mainStatusStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // logSaveFileDialog
            // 
            this.logSaveFileDialog.DefaultExt = "txt";
            this.logSaveFileDialog.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            this.logSaveFileDialog.Title = "Set log file";
            // 
            // blockedToolStripStatusLabel
            // 
            this.blockedToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.blockedToolStripStatusLabel.Name = "blockedToolStripStatusLabel";
            this.blockedToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.blockedToolStripStatusLabel.Text = "0";
            // 
            // blockedTextToolStripStatusLabel
            // 
            this.blockedTextToolStripStatusLabel.Name = "blockedTextToolStripStatusLabel";
            this.blockedTextToolStripStatusLabel.Size = new System.Drawing.Size(52, 17);
            this.blockedTextToolStripStatusLabel.Text = "Blocked:";
            // 
            // passedToolStripStatusLabel
            // 
            this.passedToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.passedToolStripStatusLabel.Name = "passedToolStripStatusLabel";
            this.passedToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.passedToolStripStatusLabel.Text = "0";
            // 
            // passedTextToolStripStatusLabel
            // 
            this.passedTextToolStripStatusLabel.Name = "passedTextToolStripStatusLabel";
            this.passedTextToolStripStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.passedTextToolStripStatusLabel.Text = "Passed:";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.passedTextToolStripStatusLabel,
                                    this.passedToolStripStatusLabel,
                                    this.blockedTextToolStripStatusLabel,
                                    this.blockedToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 120);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(230, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 53;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
            // 
            // originalThreadRedditcomToolStripMenuItem
            // 
            this.originalThreadRedditcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadRedditcomToolStripMenuItem.Image")));
            this.originalThreadRedditcomToolStripMenuItem.Name = "originalThreadRedditcomToolStripMenuItem";
            this.originalThreadRedditcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.originalThreadRedditcomToolStripMenuItem.Text = "Original thread @ Reddit.com";
            this.originalThreadRedditcomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadRedditcomToolStripMenuItemClick);
            // 
            // freeReleasesPublicDomainisToolStripMenuItem
            // 
            this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
            this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
            this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.freeReleasesPublicDomainisToolStripMenuItem,
                                    this.originalThreadRedditcomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Checked = true;
            this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.alwaysOnTopToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.toolStripSeparator3,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem1,
                                    this.optionsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(230, 24);
            this.mainMenuStrip.TabIndex = 54;
            // 
            // startStopButton
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.startStopButton, 2);
            this.startStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startStopButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.startStopButton.Location = new System.Drawing.Point(3, 33);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(224, 60);
            this.startStopButton.TabIndex = 5;
            this.startStopButton.Text = "&Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.OnStartStopButtonClick);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.Controls.Add(this.startStopButton, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.timeLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.timeNumericUpDown, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(230, 96);
            this.mainTableLayoutPanel.TabIndex = 55;
            // 
            // timeLabel
            // 
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(3, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(86, 30);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "&Time (ms):";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeNumericUpDown
            // 
            this.timeNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNumericUpDown.Location = new System.Drawing.Point(95, 3);
            this.timeNumericUpDown.Maximum = new decimal(new int[] {
                                    3600000,
                                    0,
                                    0,
                                    0});
            this.timeNumericUpDown.Minimum = new decimal(new int[] {
                                    1,
                                    0,
                                    0,
                                    0});
            this.timeNumericUpDown.Name = "timeNumericUpDown";
            this.timeNumericUpDown.Size = new System.Drawing.Size(132, 26);
            this.timeNumericUpDown.TabIndex = 7;
            this.timeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeNumericUpDown.Value = new decimal(new int[] {
                                    100,
                                    0,
                                    0,
                                    0});
            this.timeNumericUpDown.ValueChanged += new System.EventHandler(this.OnTimeNumericUpDownValueChanged);
            // 
            // clickTimer
            // 
            this.clickTimer.Tick += new System.EventHandler(this.OnClickTimerTick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.startStopButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 142);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingleClick";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Timer clickTimer;
        private System.Windows.Forms.NumericUpDown timeNumericUpDown;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadRedditcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel passedTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel passedToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel blockedTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel blockedToolStripStatusLabel;
        private System.Windows.Forms.SaveFileDialog logSaveFileDialog;
    }
}
