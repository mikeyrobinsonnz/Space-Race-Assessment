using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Race
{
    public partial class FrmSpace : Form
    {

        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called planet 
        Planet[] planet = new Planet[7];




        bool left, right;
        int score, lives = 5;
        string move;



        public FrmSpace()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                planet[i] = new Planet(x);
            }



            PictureMain.Visible = true;
            BtnStart.Visible = true;
            lblinstruct1.Visible = false;
            lblinstruct2.Visible = false;
            PnlGame.Visible = true;
            btncontinue.Visible = false;
            

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            for (int i = 0; i < 7; i++)
         
                //call the Planet class's drawPlanet method to draw the images
                planet[i].DrawPlanet(g);
            




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
