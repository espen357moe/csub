﻿using System.Drawing;

namespace csub
{
    //klasse for ferje, arver fra den abstrakte klassen Boat og interfacet IRenderable
    public class Ferry : Boat
    {
        public override float Speed { get; set; }
        public override MainGameForm.Direction Direction { get { return MainGameForm.Direction.Left; } }
        private readonly Image ferryImage = Image.FromFile("../../images/bast1.png");
        public override int Value { get { return 2; } }

        public override Image Image
        {
            get { return ferryImage; }
        }

        public new void Render(Graphics g)
        {
            g.DrawImage(ferryImage, 0, Position.Y);
        }
    }
}