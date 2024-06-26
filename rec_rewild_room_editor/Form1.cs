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

                Program.RoomSetValues(textfile, this);
            }
            catch
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
