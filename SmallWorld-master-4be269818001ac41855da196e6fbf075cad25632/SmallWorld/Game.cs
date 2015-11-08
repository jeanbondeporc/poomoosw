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

        public void createGame(EGameType gameType)
        {
            throw new System.NotImplementedException();
        }

        public Player initOrder()
        {
            throw new System.NotImplementedException();
        }

        public void initPlayers()
        {
            throw new System.NotImplementedException();
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
