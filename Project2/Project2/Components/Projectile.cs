
using Microsoft.Xna.Framework;


namespace Project2.Components
{
    public abstract class Projectile : GameObject
    {
        public Vector2 Direction;

        float speed = 5f;


        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            position += Direction * speed;

            //Rectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)Scale.X, (int)Scale.Y);
        }
    }
}
