using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public class Game
    {
        public Game(EGameType type)
        {
            throw new System.NotImplementedException();
        }

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

        public System.Collections.Generic.List<SmallWorld.Model.Turn> turns
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public static Game Instance
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void startNextTurn()
        {
            throw new System.NotImplementedException();
        }

        public void gameEnded(EEndGameType endType)
        {
            throw new System.NotImplementedException();
        }

        public void turnEnded()
        {
            throw new System.NotImplementedException();
        }
    }
}
