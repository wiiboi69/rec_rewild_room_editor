using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rec_rewild_room_editor;
using static System.Windows.Forms.DataFormats;

namespace rec_rewild_room_editor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void discardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadingScreenEditorHide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_quit(object sender, EventArgs e)
        {
            Program.LoadingScreenEditorQuit();
        }
    }
}
