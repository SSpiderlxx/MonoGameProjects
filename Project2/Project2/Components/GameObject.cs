using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project2.Components
{
    public abstract class GameObject
    {
        public Rectangle Rectangle { get; set; }
        public Texture2D Texture { get; set; }

        public Vector2 position = new Vector2(0, 0);
        public Vector2 Scale = new Vector2(1, 1);

        public virtual void init()
        {
            Rectangle = new Rectangle(0, 0, Texture.Width, Texture.Height);
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, position, Rectangle, Color.White, 0, new Vector2(0.5f, 0.5f), Scale, SpriteEffects.None, 1f);
        }

    }
}
