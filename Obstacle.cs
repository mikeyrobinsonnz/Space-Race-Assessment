using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Race
{
    class Planet
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image
        

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        private int spacing;
        //Create a constructor (initialises the values of the fields)

        public Planet()
        {
            x = spacing;
            x = 10;
            y = 10;
            width = 30;
            height = 30;
            //obstalceImage contains the obstacle.png image
            planetImage = Properties.Resources.planet1;
            planetRec = new Rectangle(x, y, width, height);

        }

        // Methods for the Asteroid class
        public void DrawAsteroid(Graphics g)
        {
            planetRec = new Rectangle(x, y, width, height);
            g.DrawImage(planetImage, planetRec);
        }


    }
}
