
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
    internal class Enemy
    {
        public Rectangle Rectangle { get; set; }
        public Texture2D Texture;

        public Vector2 position = new Vector2(0, 0);
        public Vector2 Scale = new Vector2(50, 50);

        public int Speed = 2;

        private Publics publics = Publics.Instance;

        public void Update()
        {

            Vector2 direction = publics.PlayerPos - position;
            direction.Normalize();
            Vector2 NewPos = position + direction * Speed;

            position = NewPos;

            Rectangle = new Rectangle((int)position.X, (int)position.Y, (int)Scale.X, (int)Scale.Y);
        }
    }
}
