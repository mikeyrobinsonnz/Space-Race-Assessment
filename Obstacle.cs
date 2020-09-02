using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


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

        public Planet()
        {
        }

        //Create a constructor (initialises the values of the fields)

        public Planet(int spacing)
        {
            x = spacing;
            y = 10;
            width = 30;
            height = 30;
            //obstalceImage contains the obstacle.png image
            planetImage = Image.FromFile("planet1.png");
            planetRec = new Rectangle(x, y, width, height);

        }


        public void DrawPlanet(Graphics g)
        {
            g.DrawImage(planetImage, planetRec);
        }

        public void MovePlanet()
        {
            y += 10;

            planetRec.Location = new Point(x, y);
        }



    }
}
