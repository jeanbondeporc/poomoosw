using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public interface ITurn
    {

        void selectUnit(Unit unit);
        void moveUnit(Tile destinination);
        void attackTile(Tile targetedTile);
        void beginTurn();
    }
}