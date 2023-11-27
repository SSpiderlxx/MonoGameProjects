using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Statics
{
    static class Functions
    {
        public static Vector2 MoveTo(Vector2 Position1, Vector2 Position2, int Speed)
        {
            Vector2 direction = Position2 - Position1;
            direction.Normalize();
            Vector2 NewPos = Position1 + direction * Speed;
            return NewPos;
        }

        public static Vector2 GetDirection(Vector2 Position, Vector2 Desination)
        {
            Vector2 direction = Desination - Position;
            direction.Normalize();
            return direction;
        }
    }
}
