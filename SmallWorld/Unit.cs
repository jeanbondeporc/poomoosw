using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public interface Unit
    {
        int actionPoints
        {
            get;
            set;
        }
        Tile currentTile
        {
            get;
            set;
        }

        int healthPoints
        {
            get;
            set;
        }

        int attackPoints
        {
            get;
            set;
        }

        int defensePoints
        {
            get;
            set;
        }
        Behavior Behavior { get; set; }
        void resetActionPoints();
    }
}
