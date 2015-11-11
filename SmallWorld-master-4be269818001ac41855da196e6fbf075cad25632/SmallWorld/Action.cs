using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public abstract class Action : IUndo
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public void Undo()
        {

        }
    }
}