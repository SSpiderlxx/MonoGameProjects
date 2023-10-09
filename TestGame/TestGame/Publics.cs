using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
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

    }
}
