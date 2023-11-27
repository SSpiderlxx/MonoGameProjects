using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project2.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class MouseManager : GameObject
    {

        public override void init()
        {
            Rectangle = new Rectangle(0, 0, 1, 1);
        }

        public override void Update(GameTime gameTime)
        {
            position = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}
