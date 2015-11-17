using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public class TileFlyweightFactory
    {
        public static TileFlyweightFactory Instance
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Tile> tilePool
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Tile getTile(Position position)
        {
            throw new System.NotImplementedException();
        }
    }
}