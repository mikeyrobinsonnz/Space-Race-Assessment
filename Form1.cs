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
        Spaceship spaceship = new Spaceship();

        bool left, right;
        string move;
        int score, lives;






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
            TmrPlanet.Enabled = false;
            

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 10; i++)
            {
                // generate a random number from 5 to 30 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 30);
                planet[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                planet[i].DrawPlanet(g);

                spaceship.DrawSpaceship(g);
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
                if (spaceship.spaceRec.IntersectsWith(planet[i].planetRec))
                {
                    //reset planet[i] back to top of panel
                    planet[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }


                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (planet[i].y >= PnlGame.Height)
                {
                    score += 1;//update the score
                    txtScore.Text = score.ToString();// display score
                    planet[i].y = 10;
                }


            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSpace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }

        }

        private void FrmSpace_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }

        }

        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                spaceship.MoveSpaceship(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                spaceship.MoveSpaceship(move);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmSpace_Load(object sender, EventArgs e)
        {
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            lblinstruct1.Visible = false;
            lblinstruct2.Visible = false;
            PnlGame.Visible = true;
            btncontinue.Visible = false;
            TmrPlanet.Enabled = true;
            





        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over");
                

            }
        }

    }
}
