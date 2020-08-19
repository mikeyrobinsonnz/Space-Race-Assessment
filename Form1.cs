using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Race
{
    public partial class FrmSpace : Form
    {
        public FrmSpace()
        {
            InitializeComponent();
            PictureMain.Visible = true;
            BtnStart.Visible = true;
            lblinstruct1.Visible = false;
            lblinstruct2.Visible = false;
            PnlGame.Visible = true;
            btncontinue.Visible = false;

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            PictureMain.Visible = false;
            BtnStart.Visible = false;
            lblinstruct1.Visible = true;
            lblinstruct2.Visible = true;
            PnlGame.Visible = true;
            btncontinue.Visible = true;
         
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            lblinstruct1.Visible = false;
            lblinstruct2.Visible = false;
            PnlGame.Visible = true;
            btncontinue.Visible = false;
        }
    }
}
