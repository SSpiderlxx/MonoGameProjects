﻿using System;
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
        public static bool AABB(GameObject A, GameObject B)
        {
            if(A.position.X <= B.position.X + B.Texture.Width && A.position.X + A.Texture.Width >= B.position.X &&
                A.position.Y <= B.position.Y + B.Texture.Height && A.position.Y + A.Texture.Height >= B.position.Y)
            {
                    return true;
            }
            
            return false;
        }
    }
}
