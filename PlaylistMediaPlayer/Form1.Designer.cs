namespace PlaylistMediaPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVLCPlayer = new AxAXVLC.AxVLCPlugin2();
            this.axShockwaveYoutube = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.listActiveList = new System.Windows.Forms.ListBox();
            this.btnMP3Add = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnResetPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnPreviewVideo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.listActiveListAddress = new System.Windows.Forms.ListBox();
            this.listVideosAddedAddress = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.listVideosAdded = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3PlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMP3PlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMP3PlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMP3PlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newYouTubePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openYouTubePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveYouTubePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentSong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbShuffleText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listCurrentVideoAddress = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axVLCPlayer
            // 
            this.axVLCPlayer.Enabled = true;
            this.axVLCPlayer.Location = new System.Drawing.Point(12, 50);
            this.axVLCPlayer.Name = "axVLCPlayer";
            this.axVLCPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlayer.OcxState")));
            this.axVLCPlayer.Size = new System.Drawing.Size(320, 237);
            this.axVLCPlayer.TabIndex = 0;
            this.axVLCPlayer.Visible = false;
            // 
            // axShockwaveYoutube
            // 
            this.axShockwaveYoutube.Enabled = true;
            this.axShockwaveYoutube.Location = new System.Drawing.Point(21, 59);
            this.axShockwaveYoutube.Name = "axShockwaveYoutube";
            this.axShockwaveYoutube.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveYoutube.OcxState")));
            this.axShockwaveYoutube.Size = new System.Drawing.Size(300, 220);
            this.axShockwaveYoutube.TabIndex = 1;
            this.axShockwaveYoutube.Visible = false;
            // 
            // listActiveList
            // 
            this.listActiveList.BackColor = System.Drawing.Color.Silver;
            this.listActiveList.FormattingEnabled = true;
            this.listActiveList.Location = new System.Drawing.Point(349, 40);
            this.listActiveList.Name = "listActiveList";
            this.listActiveList.Size = new System.Drawing.Size(237, 251);
            this.listActiveList.TabIndex = 4;
            this.listActiveList.SelectedIndexChanged += new System.EventHandler(this.listActiveList_SelectedIndexChanged);
            // 
            // btnMP3Add
            // 
            this.btnMP3Add.Location = new System.Drawing.Point(349, 297);
            this.btnMP3Add.Name = "btnMP3Add";
            this.btnMP3Add.Size = new System.Drawing.Size(75, 34);
            this.btnMP3Add.TabIndex = 5;
            this.btnMP3Add.Text = "ADD";
            this.btnMP3Add.UseVisualStyleBackColor = true;
            this.btnMP3Add.Click += new System.EventHandler(this.btnMP3Add_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(430, 297);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 34);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(209, 299);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(123, 34);
            this.btnShuffle.TabIndex = 9;
            this.btnShuffle.Text = "SHUFFLE";
            this.btnShuffle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnResetPlay
            // 
            this.btnResetPlay.Location = new System.Drawing.Point(511, 296);
            this.btnResetPlay.Name = "btnResetPlay";
            this.btnResetPlay.Size = new System.Drawing.Size(75, 35);
            this.btnResetPlay.TabIndex = 10;
            this.btnResetPlay.Text = "RESET PLAY";
            this.btnResetPlay.UseVisualStyleBackColor = true;
            this.btnResetPlay.Visible = false;
            this.btnResetPlay.Click += new System.EventHandler(this.btnResetPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Recently Added Youtube Videos";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(511, 520);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshList.TabIndex = 14;
            this.btnRefreshList.Text = "REFRESH";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(511, 357);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAddVideo.TabIndex = 15;
            this.btnAddVideo.Text = "ADD VIDEO";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            // 
            // btnPreviewVideo
            // 
            this.btnPreviewVideo.Location = new System.Drawing.Point(511, 400);
            this.btnPreviewVideo.Name = "btnPreviewVideo";
            this.btnPreviewVideo.Size = new System.Drawing.Size(75, 23);
            this.btnPreviewVideo.TabIndex = 16;
            this.btnPreviewVideo.Text = "PREVIEW";
            this.btnPreviewVideo.UseVisualStyleBackColor = true;
            this.btnPreviewVideo.Click += new System.EventHandler(this.btnPreviewVideo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Playlist Name:";
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlaylist.Location = new System.Drawing.Point(439, 27);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(147, 13);
            this.lblPlaylist.TabIndex = 18;
            this.lblPlaylist.Text = "New Playlist";
            // 
            // listActiveListAddress
            // 
            this.listActiveListAddress.Enabled = false;
            this.listActiveListAddress.FormattingEnabled = true;
            this.listActiveListAddress.Location = new System.Drawing.Point(12, 372);
            this.listActiveListAddress.Name = "listActiveListAddress";
            this.listActiveListAddress.Size = new System.Drawing.Size(176, 82);
            this.listActiveListAddress.TabIndex = 19;
            // 
            // listVideosAddedAddress
            // 
            this.listVideosAddedAddress.FormattingEnabled = true;
            this.listVideosAddedAddress.Location = new System.Drawing.Point(194, 372);
            this.listVideosAddedAddress.Name = "listVideosAddedAddress";
            this.listVideosAddedAddress.Size = new System.Drawing.Size(154, 82);
            this.listVideosAddedAddress.TabIndex = 20;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Image = global::PlaylistMediaPlayer.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(113, 296);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 22;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPause.Image = global::PlaylistMediaPlayer.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(67, 296);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 40);
            this.btnPause.TabIndex = 21;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Image = global::PlaylistMediaPlayer.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(159, 295);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlay.Image = global::PlaylistMediaPlayer.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(13, 296);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 40);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // picBoxMain
            // 
            this.picBoxMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBoxMain.Image = global::PlaylistMediaPlayer.Properties.Resources.p1_walk04;
            this.picBoxMain.Location = new System.Drawing.Point(31, 51);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(277, 201);
            this.picBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxMain.TabIndex = 3;
            this.picBoxMain.TabStop = false;
            // 
            // listVideosAdded
            // 
            this.listVideosAdded.BackColor = System.Drawing.Color.Silver;
            this.listVideosAdded.FormattingEnabled = true;
            this.listVideosAdded.Location = new System.Drawing.Point(13, 468);
            this.listVideosAdded.Name = "listVideosAdded";
            this.listVideosAdded.Size = new System.Drawing.Size(335, 134);
            this.listVideosAdded.TabIndex = 23;
            this.listVideosAdded.SelectedIndexChanged += new System.EventHandler(this.listVideosAdded_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mP3PlaylistToolStripMenuItem,
            this.youTubePlaylistToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mP3PlaylistToolStripMenuItem
            // 
            this.mP3PlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMP3PlaylistToolStripMenuItem,
            this.openMP3PlaylistToolStripMenuItem,
            this.saveMP3PlaylistToolStripMenuItem});
            this.mP3PlaylistToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.mP3PlaylistToolStripMenuItem.Name = "mP3PlaylistToolStripMenuItem";
            this.mP3PlaylistToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.mP3PlaylistToolStripMenuItem.Text = "MP3 Playlist";
            // 
            // newMP3PlaylistToolStripMenuItem
            // 
            this.newMP3PlaylistToolStripMenuItem.Name = "newMP3PlaylistToolStripMenuItem";
            this.newMP3PlaylistToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.newMP3PlaylistToolStripMenuItem.Text = "New MP3 Playlist";
            this.newMP3PlaylistToolStripMenuItem.Click += new System.EventHandler(this.newMP3PlaylistToolStripMenuItem_Click);
            // 
            // openMP3PlaylistToolStripMenuItem
            // 
            this.openMP3PlaylistToolStripMenuItem.Name = "openMP3PlaylistToolStripMenuItem";
            this.openMP3PlaylistToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openMP3PlaylistToolStripMenuItem.Text = "Open MP3 Playlist";
            this.openMP3PlaylistToolStripMenuItem.Click += new System.EventHandler(this.openMP3PlaylistToolStripMenuItem_Click);
            // 
            // saveMP3PlaylistToolStripMenuItem
            // 
            this.saveMP3PlaylistToolStripMenuItem.Name = "saveMP3PlaylistToolStripMenuItem";
            this.saveMP3PlaylistToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveMP3PlaylistToolStripMenuItem.Text = "Save MP3 Playlist";
            this.saveMP3PlaylistToolStripMenuItem.Click += new System.EventHandler(this.saveMP3PlaylistToolStripMenuItem_Click);
            // 
            // youTubePlaylistToolStripMenuItem
            // 
            this.youTubePlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newYouTubePlaylistToolStripMenuItem,
            this.openYouTubePlaylistToolStripMenuItem,
            this.saveYouTubePlaylistToolStripMenuItem});
            this.youTubePlaylistToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.youTubePlaylistToolStripMenuItem.Name = "youTubePlaylistToolStripMenuItem";
            this.youTubePlaylistToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.youTubePlaylistToolStripMenuItem.Text = "YouTube Playlist";
            this.youTubePlaylistToolStripMenuItem.Visible = false;
            // 
            // newYouTubePlaylistToolStripMenuItem
            // 
            this.newYouTubePlaylistToolStripMenuItem.Name = "newYouTubePlaylistToolStripMenuItem";
            this.newYouTubePlaylistToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newYouTubePlaylistToolStripMenuItem.Text = "New YouTube Playlist";
            this.newYouTubePlaylistToolStripMenuItem.Click += new System.EventHandler(this.newYouTubePlaylistToolStripMenuItem_Click);
            // 
            // openYouTubePlaylistToolStripMenuItem
            // 
            this.openYouTubePlaylistToolStripMenuItem.Name = "openYouTubePlaylistToolStripMenuItem";
            this.openYouTubePlaylistToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openYouTubePlaylistToolStripMenuItem.Text = "Open YouTube Playlist";
            // 
            // saveYouTubePlaylistToolStripMenuItem
            // 
            this.saveYouTubePlaylistToolStripMenuItem.Name = "saveYouTubePlaylistToolStripMenuItem";
            this.saveYouTubePlaylistToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveYouTubePlaylistToolStripMenuItem.Text = "Save YouTube Playlist";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Playing:";
            // 
            // lblCurrentSong
            // 
            this.lblCurrentSong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentSong.Location = new System.Drawing.Point(64, 31);
            this.lblCurrentSong.Name = "lblCurrentSong";
            this.lblCurrentSong.Size = new System.Drawing.Size(268, 16);
            this.lblCurrentSong.TabIndex = 26;
            this.lblCurrentSong.Text = "Empty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(511, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "label3";
            // 
            // lbShuffleText
            // 
            this.lbShuffleText.AutoSize = true;
            this.lbShuffleText.BackColor = System.Drawing.Color.White;
            this.lbShuffleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShuffleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbShuffleText.Location = new System.Drawing.Point(280, 307);
            this.lbShuffleText.Name = "lbShuffleText";
            this.lbShuffleText.Size = new System.Drawing.Size(46, 17);
            this.lbShuffleText.TabIndex = 28;
            this.lbShuffleText.Text = "label5";
            this.lbShuffleText.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listCurrentVideoAddress
            // 
            this.listCurrentVideoAddress.Enabled = false;
            this.listCurrentVideoAddress.FormattingEnabled = true;
            this.listCurrentVideoAddress.Location = new System.Drawing.Point(354, 400);
            this.listCurrentVideoAddress.Name = "listCurrentVideoAddress";
            this.listCurrentVideoAddress.Size = new System.Drawing.Size(120, 95);
            this.listCurrentVideoAddress.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(594, 339);
            this.Controls.Add(this.listCurrentVideoAddress);
            this.Controls.Add(this.lbShuffleText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCurrentSong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listVideosAdded);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.listVideosAddedAddress);
            this.Controls.Add(this.listActiveListAddress);
            this.Controls.Add(this.lblPlaylist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPreviewVideo);
            this.Controls.Add(this.btnAddVideo);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetPlay);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMP3Add);
            this.Controls.Add(this.listActiveList);
            this.Controls.Add(this.picBoxMain);
            this.Controls.Add(this.axShockwaveYoutube);
            this.Controls.Add(this.axVLCPlayer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLAYlist Media Player v01";
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlayer;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveYoutube;
        private System.Windows.Forms.PictureBox picBoxMain;
        private System.Windows.Forms.ListBox listActiveList;
        private System.Windows.Forms.Button btnMP3Add;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnResetPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Button btnPreviewVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.ListBox listActiveListAddress;
        private System.Windows.Forms.ListBox listVideosAddedAddress;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listVideosAdded;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3PlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMP3PlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newYouTubePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMP3PlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMP3PlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openYouTubePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveYouTubePlaylistToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentSong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbShuffleText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listCurrentVideoAddress;
    }
}

