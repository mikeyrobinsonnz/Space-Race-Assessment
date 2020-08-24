using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Race
{
    class Obstacle
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image obstacleImage;//variable for the planet's image

        public Rectangle obstacleRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Obstacle()
        {
            x = 10;
            y = 10;
            width = 20;
            height = 20;
            //obstalceImage contains the obstacle.png image
            obstacleImage = Properties.Resources.character1;
            obstacleRec = new Rectangle(x, y, width, height);
        }

    }
}
