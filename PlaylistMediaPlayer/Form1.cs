using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace PlaylistMediaPlayer
{
    public partial class Form1 : Form
    {
        int selectedItem = 0;
        int itemNum = 0;
        int removedItemNum;
        string[] files, path;

        bool blPlayIsActive = false;
        bool blLoopList = false;

        bool blShuffle = false;
        bool blOnOff = true;
        int songsPlayed;
        List<bool> blListSongsPlayed = new List<bool>();

        int selectedVideo = 0;
        int selectVideoItemNum = 0;

        public Form1()
        {
            InitializeComponent();


            menuStrip1.Enabled = true;
            listActiveList.MouseDoubleClick += new MouseEventHandler(listActiveList_MouseDoubleClick);

            btnMP3Add.Enabled = true;
            btnNext.Enabled = true;
            btnPlay.Enabled = true;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnRemove.Enabled = true;
            btnResetPlay.Enabled = false;
            btnShuffle.Enabled = true;
            listVideosAdded.Enabled = false;
            btnAddVideo.Enabled = false;
            btnPreviewVideo.Enabled = false;
            btnRefreshList.Enabled = false;

            axVLCPlayer.Visible = true;
            axVLCPlayer.FullscreenEnabled = true;
            axVLCPlayer.CtlVisible = false;

            
        }

        #region New Playlist MP3s
        private void newMP3PlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axVLCPlayer.playlist.stop();
            listActiveList.Items.Clear();
            listActiveListAddress.Items.Clear();
            axVLCPlayer.playlist.items.clear();
            lblCurrentSong.Text = "Empty";

            picBoxMain.Visible = false;
            axShockwaveYoutube.Visible = false;
            axVLCPlayer.Visible = true;

            blShuffle = false;
            blOnOff = false;
            btnShuffle.BackColor = Color.Red;
            lbShuffleText.Visible = false;

            btnMP3Add.Enabled = true;
            btnNext.Enabled = true;
            btnPlay.Enabled = true;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnRemove.Enabled = true;
            btnResetPlay.Enabled = true;
            btnShuffle.Enabled = true;

            listVideosAdded.Enabled = false;
            btnAddVideo.Enabled = false;
            btnPreviewVideo.Enabled = false;
            btnRefreshList.Enabled = false;
        }
        #endregion

        #region New Playlist Youtube
        private void newYouTubePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBoxMain.Visible = false;
            axVLCPlayer.Visible = false;
            axShockwaveYoutube.Visible = true;
            listActiveList.Items.Clear();
            listCurrentVideoAddress.Items.Clear();

            btnShuffle.BackColor = Color.Red;

            btnMP3Add.Enabled = false;
            btnNext.Enabled = true;
            btnPlay.Enabled = true;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnRemove.Enabled = true;
            btnResetPlay.Enabled = true;
            btnShuffle.Enabled = true;

            listVideosAdded.Enabled = true;
            btnAddVideo.Enabled = true;
            btnPreviewVideo.Enabled = true;
            btnRefreshList.Enabled = true;
        }
        #endregion

        #region Add Songs to MP3 Playlist
        private void btnMP3Add_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files (*.mp3, *.mp4, *.avi,...)|*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    listActiveList.Items.Add(files[i]);
                    listActiveListAddress.Items.Add(path[i]);
                    //axVLCPlayer.playlist.add("file:///" + path[i], files[i], null);
                }
                axVLCPlayer.playlist.add("file:///" + path[0], files[0], null);
                listActiveList.SelectedIndex = 0;
                picBoxMain.Visible = false;

            }
        }
        #endregion

        #region Control Buttons
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (blShuffle == false)
            {
                blPlayIsActive = true;
                itemNum = selectedItem;
                lblCurrentSong.Text = listActiveList.Items[itemNum].ToString();

                try
                {
                    SetNextSong(itemNum);
                    //axVLCPlayer.playlist.playItem(itemNum);

                    //lblCurrentSong.Text = listActiveList.Items[itemNum].ToString();
                }
                catch
                {
                }
            }
            if (blShuffle == true)
            {
                blPlayIsActive = true;
                RandomizePlaylist();
            }

        }


        private void listActiveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = listActiveList.SelectedIndex;
        }

        private void listActiveList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listActiveList.SelectedItem != null)
            {
                // axVLCPlayer.playlist.playItem(listActiveList.SelectedIndex);
                SetNextSong(listActiveList.SelectedIndex);
                lblCurrentSong.Text = listActiveList.Items[listActiveList.SelectedIndex].ToString();
                //selectedItem = listActiveList.SelectedIndex;
                itemNum = selectedItem;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //itemNum = selectedItem;

            if (blShuffle == false)
            {
                // axVLCPlayer.playlist.next();
                blPlayIsActive = true;
                itemNum++;
                SetNextSong(itemNum);
                

                if (itemNum < listActiveList.Items.Count)
                {
                    lblCurrentSong.Text = listActiveList.Items[itemNum].ToString();
                    listActiveList.SelectedIndex = itemNum;
                }
                else if (itemNum == listActiveList.Items.Count)
                {
                    itemNum = 0;
                    //axVLCPlayer.playlist.playItem(itemNum);
                    SetNextSong(itemNum);
                    lblCurrentSong.Text = listActiveList.Items[itemNum].ToString();
                    listActiveList.SelectedIndex = itemNum;
                }
            }
            if (blShuffle == true)
            {
                blPlayIsActive = true;
                RandomizePlaylist();
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removedItemNum = selectedItem;

            try
            {
                axVLCPlayer.playlist.items.remove(removedItemNum);
                listActiveListAddress.Items.RemoveAt(removedItemNum);
                listActiveList.Items.RemoveAt(removedItemNum);
                listActiveList.SelectedIndex = removedItemNum - 1;
            }
            catch
            {
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            blPlayIsActive = !blPlayIsActive;

            axVLCPlayer.playlist.togglePause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            blPlayIsActive = false;
            axVLCPlayer.playlist.stop();
        }
        #endregion

        #region Save MP3 Playlist
        private void saveMP3PlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveMP3Playlist = new SaveFileDialog();
            saveMP3Playlist.Filter = "Text File |*.txt";

            if (saveMP3Playlist.ShowDialog() == DialogResult.OK)
            {
                string name = saveMP3Playlist.FileName;
                lblPlaylist.Text = "* " + lblPlaylist.Text;

                StringBuilder sb = new StringBuilder();
                StringBuilder sb1 = new StringBuilder();

                for (int i = 0; i < listActiveList.Items.Count; i++)
                {
                    try
                    {
                        sb.AppendLine(listActiveList.Items[i].ToString());
                        sb1.AppendLine(listActiveListAddress.Items[i].ToString());
                    }
                    catch
                    {
                    }
                }
                File.WriteAllText(name, listActiveList.Items.Count + Environment.NewLine + sb.ToString() + sb1.ToString());

            }

        }
        #endregion

        #region Open MP3 Playlist
        private void openMP3PlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region UI Controls
            listActiveList.Items.Clear();
            listActiveListAddress.Items.Clear();
            axVLCPlayer.playlist.items.clear();
            lblCurrentSong.Text = "Empty";

            picBoxMain.Visible = false;
            axShockwaveYoutube.Visible = false;
            axVLCPlayer.Visible = true;

            btnShuffle.BackColor = Color.Red;

            btnMP3Add.Enabled = true;
            btnNext.Enabled = true;
            btnPlay.Enabled = true;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnRemove.Enabled = true;
            btnResetPlay.Enabled = true;
            btnShuffle.Enabled = true;

            listVideosAdded.Enabled = false;
            btnAddVideo.Enabled = false;
            btnPreviewVideo.Enabled = false;
            btnRefreshList.Enabled = false;
            #endregion

            #region Load MP3 PlayList
            OpenFileDialog openMP3PlayList = new OpenFileDialog();
            openMP3PlayList.Filter = "Text File | *.txt";            

            if (openMP3PlayList.ShowDialog() == DialogResult.OK)
            {
                string opfn = openMP3PlayList.FileName;
                lblPlaylist.Text = openMP3PlayList.SafeFileName.ToString();

                using (StreamReader sr = new StreamReader(opfn))
                {
                    for (int a = 0; a < 1; a++)
                    {
                        string count = sr.ReadLine();

                        for (int c = 1; c <= Convert.ToInt16(count); c++)
                        {
                            listActiveList.Items.Add(sr.ReadLine());
                        }

                        for (int d = Convert.ToInt16(count) + 2; d <= Convert.ToInt16(count) * 2 + 1; d++)
                        {
                            listActiveListAddress.Items.Add(sr.ReadLine());
                            
                        }

                        //Loading ListActiveList and ListActiveListAddress into the VLC Playlist ///////////////
                        //for (int x = 0; x < Convert.ToInt16(count); x++)
                        //{
                        //    axVLCPlayer.playlist.add("file:///" + listActiveListAddress.Items[x].ToString(), listActiveList.Items[x].ToString(), null);
                        //}
                    }
                }
                listActiveList.SelectedIndex = 0;
            }
            #endregion
        }
        #endregion

        #region Other MP3 Controls
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            blOnOff = !blOnOff;

            if (blOnOff == false)
            {
                for (int i = 0; i <= listActiveList.Items.Count; i++)
                {
                    blListSongsPlayed.Add(false);
                }
                blShuffle = true;
                lbShuffleText.Visible = true;
                btnShuffle.BackColor = Color.Green;
                lbShuffleText.Text = "" + songsPlayed + " / " + listActiveList.Items.Count;

                btnMP3Add.Enabled = false;
                btnRemove.Enabled = false;
                
            }

            if (blOnOff == true)
            {
                btnShuffle.BackColor = Color.Red;
                lbShuffleText.Visible = false;
                blShuffle = false;
                blListSongsPlayed.Clear();
                songsPlayed = 0;
                itemNum = listActiveList.SelectedIndex;

                btnMP3Add.Enabled = true;
                btnRemove.Enabled = true;
            }

            //RandomizePlaylist();

            //Random rand = new Random();
            //int randomNum = rand.Next(0, listActiveList.Items.Count);

            //while (blListSongsPlayed[randomNum] == true && songsPlayed < listActiveList.Items.Count)
            //{
            //    randomNum = rand.Next(0, listActiveList.Items.Count);
            //}

            //if (blListSongsPlayed[randomNum] == false && songsPlayed <= listActiveList.Items.Count)
            //{
            //    axVLCPlayer.playlist.playItem(randomNum);
            //    blListSongsPlayed[randomNum] = true;
            //    listActiveList.SelectedIndex = randomNum;
            //    songsPlayed++;
            //    label3.Text = Convert.ToString(songsPlayed);
                
                
            //}
            
        }

        private void btnResetPlay_Click(object sender, EventArgs e)
        {
            songsPlayed = 0;
            itemNum = listActiveList.SelectedIndex;
            blShuffle = false;
            blOnOff = false;
            btnShuffle.BackColor = Color.Red;
            lbShuffleText.Visible = false;
            blListSongsPlayed.Clear();
            label3.Text = Convert.ToString(songsPlayed);

            btnMP3Add.Enabled = true;
            btnRemove.Enabled = true;
        }

        public void RandomizePlaylist()
        {
            Random rand = new Random();
            int randomNum = rand.Next(0, listActiveList.Items.Count);

            while (blListSongsPlayed[randomNum] == true && songsPlayed < listActiveList.Items.Count)
            {
                randomNum = rand.Next(0, listActiveList.Items.Count);
            }

            if (blListSongsPlayed[randomNum] == false && songsPlayed <= listActiveList.Items.Count)
            {
                //axVLCPlayer.playlist.playItem(randomNum);
                SetNextSong(randomNum);
                blListSongsPlayed[randomNum] = true;
                listActiveList.SelectedIndex = randomNum;
                songsPlayed++;
                label3.Text = Convert.ToString(songsPlayed);
                lblCurrentSong.Text = listActiveList.Items[randomNum].ToString();
                lbShuffleText.Text = "" + songsPlayed + " / " + listActiveList.Items.Count;


            }
        }

        public void SetNextSong(int NumberSong)
        {
            int songNum = NumberSong;

            try
            {
                timer1.Start();
                axVLCPlayer.playlist.items.clear();

                axVLCPlayer.playlist.add("file:///" + listActiveListAddress.Items[songNum].ToString(), listActiveList.Items[songNum].ToString(), null);

                axVLCPlayer.playlist.playItem(0);
            }
            catch
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (blPlayIsActive == true)
            {
                if (blShuffle == false)
                {
                    if (axVLCPlayer.playlist.isPlaying == false)
                    {
                        itemNum++;
                        if (itemNum < listActiveList.Items.Count)
                        {
                            SetNextSong(itemNum);
                            lblCurrentSong.Text = listActiveList.Items[itemNum].ToString();
                            listActiveList.SelectedIndex = itemNum;
                        }
                        if (itemNum >= listActiveList.Items.Count)
                        {
                            if (blLoopList == true)
                            {
                                itemNum = 0;
                                SetNextSong(itemNum);
                                lblCurrentSong.Text = listActiveList.Items[itemNum].ToString();
                                listActiveList.SelectedIndex = itemNum;
                            }
                            if (blLoopList == false)
                            {
                                blPlayIsActive = false;
                                axVLCPlayer.playlist.stop();
                            }
                        }
                    }
                }
                if (blShuffle == true)
                {
                    if (axVLCPlayer.playlist.isPlaying == false)
                    {
                        RandomizePlaylist();
                    }
                }
            }
        }
        #endregion
        
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            listVideosAdded.Items.Clear();
            listVideosAddedAddress.Items.Clear();

            OpenFileDialog openYouTubeFiles = new OpenFileDialog();
            openYouTubeFiles.FileName = @"C:\AddedVideoFiles\YouTubeVideoNames.txt";
            string openNamesFile = openYouTubeFiles.FileName;

            using (StreamReader sr = new StreamReader(openNamesFile))
            {
                int lineCountNames = File.ReadLines(openNamesFile).Count();
                for (int x = lineCountNames - 1; x >= 0; x--)
                {
                    try
                    {
                        listVideosAdded.Items.Add(sr.ReadLine());
                    }
                    catch
                    {
                    }
                }
            }

            OpenFileDialog openYouTubeAddress = new OpenFileDialog();
            openYouTubeAddress.FileName = @"C:\AddedVideoFiles\YouTubeVideoAddress.txt";
            string openAddresses = openYouTubeAddress.FileName;


            using (StreamReader sr1 = new StreamReader(openAddresses))
            {
                int lineCountAddress = File.ReadLines(openAddresses).Count();
                for (int y = lineCountAddress - 1; y >= 0; y--)
                {
                    try
                    {
                        listVideosAddedAddress.Items.Add(sr1.ReadLine());
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void btnPreviewVideo_Click(object sender, EventArgs e)
        {
            axShockwaveYoutube.LoadMovie(0, listVideosAddedAddress.Items[selectVideoItemNum].ToString());
            //axShockwaveYoutube.Movie = "" +  listVideosAddedAddress.Items[selectVideoItemNum].ToString() + "";
            
        }

        private void listVideosAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectVideoItemNum = listVideosAdded.SelectedIndex;
        }

    }
}
