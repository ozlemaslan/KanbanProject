using Kanban.EF.BLL;
using KanbanModel;
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
    public partial class frmYeniTahta : Form
    {
        BoardBLL boardBLL;
        public frmYeniTahta()
        {
            InitializeComponent();
            boardBLL = new BoardBLL();
        }

        private void btnTahtaEkle_Click(object sender, EventArgs e)
        {
            Board board = new Board();
            board.BoardName = txtTahta.Text;

            if (boardBLL.Add(board))
            {
                MessageBox.Show("Tahta başarıyla eklendi.");
            }
        }
    }
}
