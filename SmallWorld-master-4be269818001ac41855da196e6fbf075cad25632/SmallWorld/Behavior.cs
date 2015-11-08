using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public interface Behavior
    {
        void moveTo(Tile tile);
        bool canMoveTo(Tile tile);
        /// <summary></summary>
        void attackUnit(Unit target);
        bool canAttackUnit(Unit target);
    }
}