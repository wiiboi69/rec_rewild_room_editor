using api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using static api.roomdata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Application.Run(new Form1());
        }
        public static void RoomSetValues(string textfile, Form1 form1)
        {
            RoomRootv2 root = JsonConvert.DeserializeObject<RoomRootv2>(textfile);

            form1.textBox1.Text = root.Description;
            form1.textBox2.Text = root.CustomWarning;
            form1.textBox3.Text = root.ImageName;
            form1.textBox4.Text = root.Name;
            form1.textBox5.Text = root.RoomId.ToString();
            form1.CheerCountBox.Text = root.Stats.CheerCount.ToString();
            form1.FavoriteCountBox.Text = root.Stats.FavoriteCount.ToString();
            form1.VisitorCountBox.Text = root.Stats.VisitorCount.ToString();
            form1.VisitCountBox.Text = root.Stats.VisitCount.ToString();
            /*
            form1.textBox1.Text = root.Name;
            form1.textBox2.Text = root.Description;
            form1.textBox3.Text = root.ImageName;
            form1.textBox4.Text = root.CustomWarning;
             */
            byte[] ImgBytes = new WebClient().DownloadData("https://raw.githubusercontent.com/wiiboi69/Rec_rewild/master/Update/notfoundimage.jpg");
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
    }
}
