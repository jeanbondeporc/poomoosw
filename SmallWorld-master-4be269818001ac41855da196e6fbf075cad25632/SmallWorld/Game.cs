using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public class Game
    {
        public IPlayer Player2
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IPlayer Player1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public EGameType gameType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Map Map
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Player nextPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int turnsNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void createGame(EGameType gameType)
        {
            throw new System.NotImplementedException();
        }

        public void initUnits(IList<Unit> units)
        {
            throw new System.NotImplementedException();
        }

        public Player initOrder()
        {
            throw new System.NotImplementedException();
        }
    }
}
