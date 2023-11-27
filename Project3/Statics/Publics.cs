using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project2.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame;

namespace Project2.Statics
{
    public class Publics
    {
        public Publics()
        {
            _instance = this;
        }

        private static Publics _instance;
        public static Publics Instance { get { return _instance; } }

        public Vector2 PlayerPos;

        public List<Bullet> bulletsToUpdate = new List<Bullet>();
        public List<Bullet> bulletsToRemove = new List<Bullet>();

        public InputManager inputManager = new();

        public SpriteFont font;

    }
}
