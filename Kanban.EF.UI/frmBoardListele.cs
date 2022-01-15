using Kanban.EF.BLL;
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
    public partial class frmBoardListele : Form
    {
        BoardBLL boardBLL;
        int boardID ;
        public frmBoardListele()
        {
            InitializeComponent();
            boardBLL = new BoardBLL();
        }

        private void frmBoardListele_Load(object sender, EventArgs e)
        {
            lstTahtalar.DisplayMember = "BoardName";
            lstTahtalar.ValueMember = "BoardID";
            lstTahtalar.DataSource = boardBLL.GetBoardListe();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            boardID = (int)lstTahtalar.SelectedValue;
            frmBoard boardForm = new frmBoard(boardID);
            boardForm.MdiParent = this.Owner;
            this.Close();
            boardForm.Show();

        }
    }
}
