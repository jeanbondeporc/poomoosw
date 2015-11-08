﻿using System;
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

        Position Position
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

        void attack(Tile tile);

        void move(Tile tile);
    }
}
