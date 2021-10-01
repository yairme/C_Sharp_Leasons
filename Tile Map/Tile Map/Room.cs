using System;
using System.Collections.Generic;
using System.Text;

namespace Tile_Map
{
    class Room
    {
        public Room()
        {
            Tile[][] tile = new Tile[10][];
            for (int tileY = 0; tileY < tile.Length; tileY++)
            {
                Tile[] MoreTile = new Tile[10];
                for (int tileX = 0; tileX < tile[tileY].Length; tileX++)
                {
                    tile[tileY][tileX] = null;
                }
            }
        }
    }
}
