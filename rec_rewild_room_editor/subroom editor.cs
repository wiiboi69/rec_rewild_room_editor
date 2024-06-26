using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rec_rewild_room_editor
{
    public partial class subroom_editor : Form
    {
        public subroom_editor()
        {
            InitializeComponent();
        }

        private void discardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.subroomEditorHide();
        }
        private void subroomeditor_quit(object sender, EventArgs e)
        {
            Program.LoadingScreenEditorQuit();
        }
    }
}
