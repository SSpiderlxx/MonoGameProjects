using Microsoft.Xna.Framework;

namespace TestGame
{
    public class Bullet : Projectile
    {

        public bool Destroy = false;

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (Destroy)
            {
                Publics.Instance.bulletsToRemove.Add(this);
            }
        }

    }
}
