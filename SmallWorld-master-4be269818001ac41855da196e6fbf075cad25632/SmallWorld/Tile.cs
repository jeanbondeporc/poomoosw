using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallWorld.Model
{
    public abstract class Tile
    {
        public Position Position
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Unit> Units
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public static List<System.Drawing.Bitmap> bitmapsTiles
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public System.Drawing.Bitmap currentBitmap
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void unitEntered(Unit unit)
        {
            throw new System.NotImplementedException();
        }

        public void unitLeft(Unit unit)
        {
            throw new System.NotImplementedException();
        }
    }
}
