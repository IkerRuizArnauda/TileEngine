using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileEngine
{
    class MapCell
    {
        public int TileID
        {
            get { return BaseTiles.Count > 0 ? BaseTiles[0] : 0; }
            set
            {
                if (BaseTiles.Count > 0)
                    BaseTiles[0] = value;
                else
                    AddBaseTile(value);
            }
        }

        //By storing a line of tile IDs, we can stack any number of tile images on the same space
        public List<int> BaseTiles = new List<int>();
        //Elevated Terrain
        public List<int> HeightTiles = new List<int>();
        //Top Overlay
        public List<int> TopperTiles = new List<int>();
        //Walkeable
        public bool Walkable { get; set; }
        //identify the Slope Map associated with a map cell
        public int SlopeMap { get; set; }

        public MapCell(int tileID)
        {
            SlopeMap = -1;
            Walkable = true;
            TileID = tileID;
        }

        //Transition Layer
        public void AddBaseTile(int tileID)
        {
            BaseTiles.Add(tileID);
        }

        //Elevated Terrain
        public void AddHeightTile(int tileID)
        {
            HeightTiles.Add(tileID);
        }

        public void AddTopperTile(int tileID)
        {
            TopperTiles.Add(tileID);
        }
    }
}
