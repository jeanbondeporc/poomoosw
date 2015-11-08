using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public class Turn
    {
        public IPlayer IPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<Action> actionsHistory
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void attackTile(Tile targetedTile)
        {
            throw new System.NotImplementedException();
        }

        public void beginTurn()
        {
            throw new System.NotImplementedException();
        }

        public void moveUnit(Tile destinination)
        {
            throw new System.NotImplementedException();
        }

        public void selectUnit(Unit unit)
        {
            throw new System.NotImplementedException();
        }

        public bool canMoveOnTile(Tile tile)
        {
            throw new System.NotImplementedException();
        }

        public bool canAttackTile(Tile target)
        {
            throw new System.NotImplementedException();
        }

        public bool isEnemyPlayerHasMoreUnits()
        {
            throw new System.NotImplementedException();
        }
    }
}
