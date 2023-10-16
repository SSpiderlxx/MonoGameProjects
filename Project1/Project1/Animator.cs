using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics;
using TestGame;

namespace Project1
{
    class Animator
    {

        public GameObject gameObject;

        public Rectangle Rectangle { get; set; }

        private int frame = 0;
        float timer = 0f;

        public Animation animation;

        public Animator(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }

        public Rectangle getFramePosition()
        {
            int textureWidth = animation.Texture.Width;
            int textureHeight = animation.Texture.Height;

            int rowCount = textureWidth / animation.resultion;
            int columnCount = textureHeight / animation.resultion;

            int y = frame / rowCount;
            int x = frame - (y * columnCount);



            Debug.Write(x.ToString());
            Debug.Write(y.ToString());
            return new Rectangle(x * animation.resultion, y * animation.resultion, animation.resultion, animation.resultion);

        }

        public void Animate(GameTime gameTime)
        {
            timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (timer >= animation.frameTime)
            {
                frame++;
                if(frame > animation.frames - 1)
                {
                    frame = 0;
                }
                timer = 0f;
                Rectangle = getFramePosition();
                gameObject.Rectangle = Rectangle;
            }
            
        }

    }
}
