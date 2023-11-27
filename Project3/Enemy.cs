
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project2.Components;
using Project2.Statics;

namespace TestGame
{
    internal class Enemy : GameObject
    {

        public int Speed = 2;

        private Publics publics = Publics.Instance;

        public override void Update(GameTime gameTime)
        {
            Vector2 direction = publics.PlayerPos - position;
            direction.Normalize();
            Vector2 NewPos = position + direction * Speed;

            position = NewPos;

            //Rectangle = new Rectangle((int)position.X, (int)position.Y, (int)Scale.X, (int)Scale.Y);
        }
    }
}
