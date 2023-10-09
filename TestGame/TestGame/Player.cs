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
    internal class Player
    {
        public Rectangle Rectangle { get; set; }
        public Texture2D Texture;

        public Vector2 position = new Vector2(0,0);
        public Vector2 Scale = new Vector2(50,50);

        public int Speed = 2;

        Publics publics = Publics.Instance;

        public void Update()
        {

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                position.X -= Speed;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                position.X += Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                position.Y -= Speed;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                position.Y += Speed;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                Bullet bullet = new Bullet(new Vector2(Mouse.GetState().Position.X, Mouse.GetState().Position.Y));
            }

            publics.PlayerPos = position;
            Rectangle = new Rectangle((int)position.X, (int)position.Y, (int)Scale.X, (int)Scale.Y);
        }

    }
}
