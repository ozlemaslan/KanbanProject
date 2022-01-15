using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban.EF.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void newBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYeniTahta tahtaForm = new frmYeniTahta();
            tahtaForm.Owner = this;
            tahtaForm.ShowDialog();

        }

        private void openBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoardListele listeleForm = new frmBoardListele();
            listeleForm.Owner = this;
            listeleForm.ShowDialog();
        }
    }
}
