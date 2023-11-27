using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project2.Components;
using Project2.Statics;
using SharpDX.Direct2D1;


namespace Project3.Components
{
    class Button : GameObject
    {
        
        public string Text = "";

        public bool isPressed = false;
        public bool isHovered = false;

        Publics publics = Publics.Instance;

        public override void Update(GameTime gameTime)
        {
            if(Collision.AABB(new Vector2(Mouse.GetState().X, Mouse.GetState().Y), this)){
                isHovered = true;
                if (publics.inputManager.OnMouseDown(1))
                {
                    isPressed = true;
                }
            }
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, position, Rectangle, Color.White, 0, new Vector2(0.5f, 0.5f), Scale, SpriteEffects.None, 1f);
            spriteBatch.DrawString(publics.font, Text, new Vector2(0, 0), Color.Black);
        }

    }
}
