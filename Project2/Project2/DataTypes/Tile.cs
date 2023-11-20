
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project2.Components;

namespace Project2.DataTypes
{
    internal class Tile : GameObject
    {
        public int TileID = 0;

        public Tile(int x, int y, Texture2D texture)
        {
            position = new Vector2(x, y);
            Texture = texture;
        }

        public override void init()
        {
            Rectangle = new Rectangle(0, 0, 50, 50);
        }
    }
}
