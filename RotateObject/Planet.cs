﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RotateObject
{
    class Planet
    {
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Planet(int spacing)
        {
            x = spacing;
            y = 10;
            width = 30;
            height = 30;
            //planetImage contains the plane1.png image
            planetImage = Properties.Resources.planet1;
            planetRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawPlanet(Graphics g)
        {
            g.DrawImage(planetImage, planetRec);
        }

        public void MovePlanet()
        {
            planetRec.Location = new Point(x, y);
        }

    }
}
