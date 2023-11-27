using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project2.Components;

namespace Project2.Statics
{
    static class Collision
    {
        public static bool AABB(GameObject A, GameObject B)
        {
            if (A.position.X <= B.position.X + B.Texture.Width && A.position.X + A.Texture.Width >= B.position.X &&
                A.position.Y <= B.position.Y + B.Texture.Height && A.position.Y + A.Texture.Height >= B.position.Y)
            {
                return true;
            }

            return false;
        }

        public static bool AABB(Vector2 A, GameObject B)
        {
            if (A.X <= B.position.X + B.Texture.Width && A.X >= B.position.X &&
                A.Y <= B.position.Y + B.Texture.Height && A.Y >= B.position.Y)
            {
                return true;
            }

            return false;
        }
    }
}
