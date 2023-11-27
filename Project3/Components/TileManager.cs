using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.DataTypes;

using System.IO.IsolatedStorage;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Diagnostics;
using Microsoft.Xna.Framework.Input;

namespace Project2.Components
{
    internal class TileManager
    {
        string savePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "");

        bool EditMode = false;

        LevelData level;

        public void SaveLevelData()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(savePath + level.LevelName + ".map", FileMode.Create);
            formatter.Serialize(stream, level);
            stream.Close();
        }

        public void LoadLevelData()
        {
            string loadPath = savePath + level.LevelName + ".map";

            if (File.Exists(loadPath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(loadPath, FileMode.Open);
                level = formatter.Deserialize(stream) as LevelData;
                stream.Close();
            }

        }

        public Tile getTileMouseOver()
        {
            int x = Mouse.GetState().Position.X / level.map.GetLength(0);
            int y = Mouse.GetState().Position.Y / level.map.GetLength(1);

            return level.map[x, y];
        }

        public void setTileID(int x, int y, int ID)
        {
            level.map[x, y].TileID = ID;
        }

        public void UpdateTiles()
        {
            foreach (Tile tile in level.map)
            {
                switch (tile.TileID){
                    case 0:

                        // Set Texture

                        break;
                }
            }
        }

        public void UpdateTile(Tile tile)
        {
            switch (tile.TileID)
            {
                case 0:

                    // Set Texture

                    break;
            }
        }

    }
}
