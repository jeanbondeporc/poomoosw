using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public interface IPlayer
    {
        ERace race
        {
            get;
            set;
        }
        List<Unit> units { get; set; }

        String name
        {
            get;
            set;
        }

        int getScore();
        void initUnits();
    }
}
