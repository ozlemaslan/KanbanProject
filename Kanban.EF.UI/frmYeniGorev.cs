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
    public partial class frmYeniGorev : Form
    {
        GorevBLL gorevBLL;
        int boardID;
        public frmYeniGorev(int _boardID)
        {
            InitializeComponent();
            boardID = _boardID;
            gorevBLL = new GorevBLL();
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Gorev gorev = new Gorev();
                gorev.Aciklama = txtGorev.Text;
                gorev.BoardID = boardID;
                gorev.DurumID = (int)Durum.TODO;

                if (gorevBLL.Add(gorev))
                {
                    MessageBox.Show("Görev başarıyla eklendi.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
