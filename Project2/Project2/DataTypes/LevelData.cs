using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DataTypes
{
    [Serializable]
    internal class LevelData
    {

        public string LevelName = "";

        public Tile[,] map = new Tile[10, 10];
    }
}
