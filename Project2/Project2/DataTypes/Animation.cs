using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DataTypes
{
    public class Animation
    {
        public int resultion = 0;
        public int frames = 0;
        public float frameTime = 0.1f;
        public Texture2D Texture { get; set; }
    }
}
