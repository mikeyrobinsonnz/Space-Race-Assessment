﻿using System;
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

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            PictureMain.Visible = false;
            BtnStart.Visible = false;
         
               
        }
    }
}
