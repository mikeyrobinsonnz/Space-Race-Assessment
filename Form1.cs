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
        // declare space for an array of 10 objects called planet 
        Planet[] planet = new Planet[10];
        Random yspeed = new Random();








        public FrmSpace()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
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
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 10; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                planet[i].DrawPlanet(g);
            }


        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            PictureMain.Visible = false;
            BtnStart.Visible = false;
            lblinstruct1.Visible = true;
            lblinstruct2.Visible = true;
            PnlGame.Visible = true;
            btncontinue.Visible = true;
            TmrPlanet.Enabled = false;
         
               
        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                planet[i].MovePlanet();

                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (planet[i].y >= PnlGame.Height)
                {
                    planet[i].y = 10;
                }


            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel

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
            TmrPlanet.Enabled = true;





        }
    }
}
