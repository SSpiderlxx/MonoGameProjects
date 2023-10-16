using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project1;

namespace TestGame
{
    internal class Player : GameObject
    {

        public int Speed = 2;

        Publics publics = Publics.Instance;

        public Animator Animator { get; private set; }

        public override void init()
        {
            
            Animator = new Animator(this);

            

            Animation idle = new Animation();
            idle.Texture = Texture;
            idle.frames = 4;
            idle.resultion = 32;
            idle.frameTime = 1;

            Animator.animation = idle;

            Rectangle = Animator.getFramePosition();
        }

        public override void Update(GameTime gameTime)
        {
            Animator.Animate(gameTime);
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
                Bullet bullet = new();
                bullet.position = position;
                bullet.Direction = Functions.GetDirection(bullet.position, new Vector2(Mouse.GetState().Position.X, Mouse.GetState().Position.Y));
                bullet.Scale = new Vector2(1, 1);
                publics.bulletsToUpdate.Add(bullet);
                Speed = 4;

            }

            publics.PlayerPos = position;
            //Rectangle = new Rectangle((int)position.X, (int)position.Y, (int)Scale.X, (int)Scale.Y);
        }

    }
}
