using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestGame
{
    static class Collision
    {
        public static bool AABB(Rectangle A, Rectangle B)
        {
            if(A.X <= B.X + B.Width && A.X + A.Width >= B.X &&
                A.Y <= B.Y + B.Height && A.Y + A.Height >= B.Y)
            {
                    return true;
            }
            
            return false;
        }
    }
}
