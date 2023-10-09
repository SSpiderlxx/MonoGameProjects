using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D background;
        private Rectangle Rectangle;

        private Player player;
        private Enemy enemy;

        Publics publics = new();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            background = Content.Load<Texture2D>("Assets/Enemy");
            player = new Player();
            player.Texture = Content.Load<Texture2D>("Assets/Player");

            enemy = new Enemy();
            enemy.position = new Vector2(200, 200);
            enemy.Texture = Content.Load<Texture2D>("Assets/Enemy");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            player.Update();
            enemy.Update();

            Rectangle = new Rectangle(100, 100, 50, 50);

            foreach (Bullet bullet in publics.bulletsToUpdate)
            {
                bullet.Texture = Content.Load<Texture2D>("Assets/Player");
                if (Collision.AABB(bullet.Rectangle, enemy.Rectangle))
                {
                    bullet.Destroy = true;
                }
                bullet.Update();
            }

            for(int i = 0; i < publics.bulletsToRemove.Count; i++)
            {

                Bullet bullet = publics.bulletsToRemove[i];
                publics.bulletsToUpdate.Remove(bullet);
            }

            if (Collision.AABB(player.Rectangle, Rectangle))
            {
                Rectangle = new Rectangle(200, 100, 50, 50);
            }
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(background, Rectangle, Color.White);

            _spriteBatch.Draw(player.Texture, player.Rectangle, Color.White) ;

            _spriteBatch.Draw(enemy.Texture, enemy.Rectangle, Color.White);

            foreach(Bullet bullet in publics.bulletsToUpdate)
            {
                if(!bullet.Destroy)
                    _spriteBatch.Draw(bullet.Texture, bullet.Rectangle, Color.White);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}