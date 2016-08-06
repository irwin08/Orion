using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orion
{
    public class MapCell
    {
        public List<int> BaseTiles = new List<int>();

        public int TileID
        {
            get
            {
                return BaseTiles.Count > 0 ? BaseTiles[0] : 0;
            }    
            set
            {
                if (BaseTiles.Count > 0)
                    BaseTiles[0] = value;
                else
                    AddBaseTile(value);
            }
        }

        public MapCell()
        {
            
        }

        public void AddBaseTile(int tileID)
        {
            BaseTiles.Add(tileID);
        }
    }
}
