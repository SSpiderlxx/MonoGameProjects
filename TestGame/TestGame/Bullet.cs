using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestGame
{
    public class Bullet
    {
        public Rectangle Rectangle;
        public Texture2D Texture;

        public Vector2 Position;
        public Vector2 Direction;
        public Vector2 Scale;

        public Bullet(Vector2 MousePositon)
        {
            Direction = Functions.GetDirection(Position, MousePositon);
        }

        public void Update()
        {

            Position += Direction;

            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)Scale.X, (int)Scale.Y);
        }
    }
}
