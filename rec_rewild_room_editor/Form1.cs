using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using api;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;
using rec_rewild_room_editor;
using static api.roomdata;
using System.Net;
namespace rec_rewild_room_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            bool pathcheck = openFileDialog1.CheckPathExists;
            if (path == "openFileDialog1" || !pathcheck)
            {
                return;
            }
            try
            {
                string? textfile = File.ReadAllText(path);
                Debug.WriteLine(textfile);
                Program.RoomSetValues(textfile);
                Program.filepath = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail to open file: " + ex);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadingScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadingScreenEditorVisible();
            this.Visible = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.RoomRootdata is null)
            {
                MessageBox.Show("no file was open");
                return;
            }
            saveFileDialog1.ShowDialog(this);
            Program.filepath = saveFileDialog1.FileName;
            try
            {
                Program.Stats = new roomdata.Stats();
                Program.Stats.CheerCount = int.Parse(CheerCountBox.Text);
                Program.Stats.FavoriteCount = int.Parse(FavoriteCountBox.Text);
                Program.Stats.VisitCount = int.Parse(VisitCountBox.Text);
                Program.Stats.VisitorCount = int.Parse(VisitorCountBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("file fail to save: " + ex.Message);
                return;
            }
            Program.subroomsv2data = Program.RoomRootdata.SubRooms;
            Program.RoomRootdata.WarningMask = (WarningMask.WarningMaskType)Program.RoomGetValuesCheckbox();
            RoomRootv2 rootv2 = new RoomRootv2
            {
                Accessibility = Program.RoomRootdata.Accessibility,
                AutoLocalizeRoom = Program.RoomRootdata.AutoLocalizeRoom,
                CloningAllowed = Program.RoomRootdata.CloningAllowed,
                CreatedAt = Program.RoomRootdata.CreatedAt,
                CreatorAccountId = Program.RoomRootdata.CreatorAccountId,
                CustomWarning = Program.form1.textBox2.Text,
                DisableRoomComments = Program.RoomRootdata.DisableRoomComments,
                EncryptVoiceChat = Program.RoomRootdata.EncryptVoiceChat,
                MaxPlayerCalculationMode = Program.RoomRootdata.MaxPlayers,
                PromoExternalContent = Program.RoomRootdata.PromoExternalContent,
                RankingContext = Program.RoomRootdata.RankingContext,
                DataBlob = Program.RoomRootdata.DataBlob,
                Description = Program.form1.textBox1.Text,
                DisableMicAutoMute = Program.RoomRootdata.DisableMicAutoMute,
                IsDeveloperOwned = Program.RoomRootdata.IsDeveloperOwned,
                IsDorm = Program.RoomRootdata.IsDorm,
                ImageName = Program.form1.textBox3.Text,
                IsRRO = Program.RoomRootdata.IsRRO,
                LoadScreenLocked = Program.RoomRootdata.LoadScreenLocked,
                LoadScreens = Program.RoomRootdata.LoadScreens,
                MaxPlayers = Program.RoomRootdata.MaxPlayers,
                MinLevel = Program.RoomRootdata.MinLevel,
                Name = Program.form1.textBox4.Text,
                PersistenceVersion = Program.RoomRootdata.PersistenceVersion,
                PromoImages = Program.RoomRootdata.PromoImages,
                RankedEntityId = Program.RoomRootdata.RankedEntityId,
                Roles = Program.RoomRootdata.Roles,
                RoomId = ulong.Parse(Program.form1.textBox5.Text),
                State = Program.RoomRootdata.State,
                Stats = Program.Stats,
                SubRooms = Program.subroomsv2data,
                SupportsJuniors = Program.RoomRootdata.SupportsJuniors,
                SupportsLevelVoting = Program.RoomRootdata.SupportsLevelVoting,
                SupportsMobile = Program.RoomRootdata.SupportsMobile,
                SupportsQuest2 = Program.RoomRootdata.SupportsMobile,
                SupportsScreens = Program.RoomRootdata.SupportsScreens,
                SupportsTeleportVR = Program.RoomRootdata.SupportsTeleportVR,
                SupportsVRLow = Program.RoomRootdata.SupportsVRLow,
                SupportsWalkVR = Program.RoomRootdata.SupportsWalkVR,
                Tags = Program.RoomRootdata.Tags,
                ToxmodEnabled = Program.RoomRootdata.ToxmodEnabled,
                UgcVersion = Program.RoomRootdata.UgcVersion,
                WarningMask = Program.RoomRootdata.WarningMask,
            };

            File.WriteAllText(Program.filepath, JsonConvert.SerializeObject(rootv2));

        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte[] ImgBytes;
            try
            {
                if (Program.RoomRootdata != null)
                {
                    ImgBytes = new WebClient().DownloadData("https://raw.githubusercontent.com/wiiboi69/Rec_rewild_server_data/main/Images/" + Program.RoomRootdata.ImageName);
                }
                else
                {
                    ImgBytes = new WebClient().DownloadData("https://raw.githubusercontent.com/wiiboi69/Rec_rewild/master/Update/notfoundimage.jpg");
                }
            }
            catch
            {
                Console.WriteLine("Image not found on img.rec.net. using Default Room Image");
                ImgBytes = new WebClient().DownloadData("https://raw.githubusercontent.com/wiiboi69/Rec_rewild/master/Update/notfoundimage.jpg");
            }

            MemoryStream stream = new MemoryStream(ImgBytes);
            Program.form1.pictureBox1.Image = System.Drawing.Image.FromStream(stream);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.RoomRootdata != null)
            {
                Program.RoomRootdata.ImageName = Program.form1.textBox3.Text;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.RoomRootdata is null)
            {
                MessageBox.Show("no file was open");
                return;
            }
            try
            {
                Program.Stats = new roomdata.Stats();
                Program.Stats.CheerCount = int.Parse(CheerCountBox.Text);
                Program.Stats.FavoriteCount = int.Parse(FavoriteCountBox.Text);
                Program.Stats.VisitCount = int.Parse(VisitCountBox.Text);
                Program.Stats.VisitorCount = int.Parse(VisitorCountBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("file fail to save: " + ex.Message);
                return;
            }
            Program.subroomsv2data = Program.RoomRootdata.SubRooms;
            Program.RoomRootdata.WarningMask = (WarningMask.WarningMaskType)Program.RoomGetValuesCheckbox();
            RoomRootv2 rootv2 = new RoomRootv2
            {
                Accessibility = Program.RoomRootdata.Accessibility,
                AutoLocalizeRoom = Program.RoomRootdata.AutoLocalizeRoom,
                CloningAllowed = Program.RoomRootdata.CloningAllowed,
                CreatedAt = Program.RoomRootdata.CreatedAt,
                CreatorAccountId = Program.RoomRootdata.CreatorAccountId,
                CustomWarning = Program.form1.textBox2.Text,
                DisableRoomComments = Program.RoomRootdata.DisableRoomComments,
                EncryptVoiceChat = Program.RoomRootdata.EncryptVoiceChat,
                MaxPlayerCalculationMode = Program.RoomRootdata.MaxPlayers,
                PromoExternalContent = Program.RoomRootdata.PromoExternalContent,
                RankingContext = Program.RoomRootdata.RankingContext,
                DataBlob = Program.RoomRootdata.DataBlob,
                Description = Program.form1.textBox1.Text,
                DisableMicAutoMute = Program.RoomRootdata.DisableMicAutoMute,
                IsDeveloperOwned = Program.RoomRootdata.IsDeveloperOwned,
                IsDorm = Program.RoomRootdata.IsDorm,
                ImageName = Program.form1.textBox3.Text,
                IsRRO = Program.RoomRootdata.IsRRO,
                LoadScreenLocked = Program.RoomRootdata.LoadScreenLocked,
                LoadScreens = Program.RoomRootdata.LoadScreens,
                MaxPlayers = Program.RoomRootdata.MaxPlayers,
                MinLevel = Program.RoomRootdata.MinLevel,
                Name = Program.form1.textBox4.Text,
                PersistenceVersion = Program.RoomRootdata.PersistenceVersion,
                PromoImages = Program.RoomRootdata.PromoImages,
                RankedEntityId = Program.RoomRootdata.RankedEntityId,
                Roles = Program.RoomRootdata.Roles,
                RoomId = ulong.Parse(Program.form1.textBox5.Text),
                State = Program.RoomRootdata.State,
                Stats = Program.Stats,
                SubRooms = Program.subroomsv2data,
                SupportsJuniors = Program.RoomRootdata.SupportsJuniors,
                SupportsLevelVoting = Program.RoomRootdata.SupportsLevelVoting,
                SupportsMobile = Program.RoomRootdata.SupportsMobile,
                SupportsQuest2 = Program.RoomRootdata.SupportsMobile,
                SupportsScreens = Program.RoomRootdata.SupportsScreens,
                SupportsTeleportVR = Program.RoomRootdata.SupportsTeleportVR,
                SupportsVRLow = Program.RoomRootdata.SupportsVRLow,
                SupportsWalkVR = Program.RoomRootdata.SupportsWalkVR,
                Tags = Program.RoomRootdata.Tags,
                ToxmodEnabled = Program.RoomRootdata.ToxmodEnabled,
                UgcVersion = Program.RoomRootdata.UgcVersion,
                WarningMask = Program.RoomRootdata.WarningMask,
            };

            File.WriteAllText(Program.filepath, JsonConvert.SerializeObject(rootv2));
        }

        private void subroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.subroomEditorVisible();
        }
    }
}
