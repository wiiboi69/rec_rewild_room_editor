using api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using static api.roomdata;
using rec_rewild_room_editor;

namespace rec_rewild_room_editor
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1);
        }
        public static void RoomSetValues(string textfile)
        {
            roomdata = textfile;
            RoomRootv2 root = JsonConvert.DeserializeObject<RoomRootv2>(textfile);
            RoomRootdata = root;
            form1.textBox1.Text = root.Description;
            form1.textBox2.Text = root.CustomWarning;
            form1.textBox3.Text = root.ImageName;
            form1.textBox4.Text = root.Name;
            form1.textBox5.Text = root.RoomId.ToString();
            form1.CheerCountBox.Text = root.Stats.CheerCount.ToString();
            form1.FavoriteCountBox.Text = root.Stats.FavoriteCount.ToString();
            form1.VisitorCountBox.Text = root.Stats.VisitorCount.ToString();
            form1.VisitCountBox.Text = root.Stats.VisitCount.ToString();
            form1.dateTimePicker1.Value = DateTime.Parse(root.CreatedAt);
            form1.dateTimePicker2.Value = DateTime.Parse(root.CreatedAt);
            RoomSetValuesCheckbox(root);
            /*
            form1.textBox1.Text = root.Name;
            form1.textBox2.Text = root.Description;
            form1.textBox3.Text = root.ImageName;
            form1.textBox4.Text = root.CustomWarning;
             */
            byte[] ImgBytes;
            try
            {

                ImgBytes = new WebClient().DownloadData("https://raw.githubusercontent.com/wiiboi69/Rec_rewild_server_data/main/Images/" + root.ImageName);
            }
            catch
            {
                Console.WriteLine("[ImageServer.cs] Image not found on img.rec.net. using Default Room Image");
                ImgBytes = new WebClient().DownloadData("https://raw.githubusercontent.com/wiiboi69/Rec_rewild/master/Update/notfoundimage.jpg");
            }

            MemoryStream stream = new MemoryStream(ImgBytes);
            form1.pictureBox1.Image = System.Drawing.Image.FromStream(stream);
            /*
            form1.textBox1.Text = File.ReadAllText("SaveData\\Profile\\username.txt");
            form1.textBox2.Text = File.ReadAllText("SaveData\\Profile\\level.txt");
            form1.checkBox1.Checked = bool.Parse(File.ReadAllText("SaveData\\Profile\\isdev.txt"));
            form1.checkBox2.Checked = bool.Parse(File.ReadAllText("SaveData\\Profile\\isjun.txt"));
            form1.pictureBox1.Image = Images.bytearraytoimage(File.ReadAllBytes("SaveData\\Profile\\profileimage.png"));
            */
        }
        public static void RoomSetValuesCheckbox(RoomRootv2 root)
        {
            if (root == null)
                return;
            if (form1 == null)
                return;
            int Scary = (int)(root.WarningMask
                & WarningMask.WarningMaskType.Scary);
            bool isScary = Scary == 1;
            int Mature = (int)(root.WarningMask
                & WarningMask.WarningMaskType.Mature);
            bool isMature = Mature == 2;
            int FlashingLights = (int)(root.WarningMask
                & WarningMask.WarningMaskType.FlashingLights);
            bool isFlashingLights = FlashingLights == 4;
            int IntenseMotion = (int)(root.WarningMask
                & WarningMask.WarningMaskType.IntenseMotion);
            bool isIntenseMotion = IntenseMotion == 8;
            int Violence = (int)(root.WarningMask
                & WarningMask.WarningMaskType.Violence);
            bool isViolence = Violence == 16;
            int Custom = (int)(root.WarningMask
                & WarningMask.WarningMaskType.Custom);
            bool isCustom = Custom == 32;
            int Reports = (int)(root.WarningMask
                & WarningMask.WarningMaskType.Reports);
            bool isReports = Reports == 64;
            form1.checkBox1.Checked = isScary;
            form1.checkBox2.Checked = isMature;
            form1.checkBox3.Checked = isFlashingLights;
            form1.checkBox4.Checked = isIntenseMotion;
            form1.checkBox5.Checked = isViolence;
            form1.checkBox6.Checked = isCustom;
        }
        public static int RoomGetValuesCheckbox()
        {
            if (form1 == null)
                return 127;
            int temp = 0;
            if (form1.checkBox1.Checked)
                temp += 1;
            if (form1.checkBox2.Checked)
                temp += 2;
            if (form1.checkBox3.Checked)
                temp += 4;
            if (form1.checkBox4.Checked)
                temp += 8;
            if (form1.checkBox5.Checked)
                temp += 16;
            if (form1.checkBox6.Checked)
                temp += 32;

            return temp;
        }
        //loading screen editor menu
        public static void LoadingScreenEditorVisible()
        {
            LoadingScreenEditor.Visible = true;
        }
        public static void LoadingScreenEditorHide()
        {
            LoadingScreenEditor.Visible = false;
            form1.Visible = true;

        }
        public static void LoadingScreenEditorQuit()
        {
            form1.Visible = true;
            LoadingScreenEditor = new Form2();
        }
        public static void LoadingScreenEditorSave()
        {
            
        }
        //subroom screen editor menu
        public static void subroomEditorVisible()
        {
            subroomEditor.Visible = true;
        }
        public static void subroomEditorHide()
        {
            subroomEditor.Visible = false;
            form1.Visible = true;

        }
        public static void subroomEditorQuit()
        {
            form1.Visible = true;
            subroomEditor = new subroom_editor();
        }
        public static void subroomEditorSave()
        {

        }
        public static Form1 form1 = new Form1();

        public static Form2 LoadingScreenEditor = new Form2();

        public static subroom_editor subroomEditor = new subroom_editor();

        internal static string? roomdata;

        internal static List<SubRooms> subroomsv2data;
        internal static string filepath;

        public static RoomRootv2 RoomRootdata { get; set; }
        public static Stats Stats { get; set; }
    }
}
