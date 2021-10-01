using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2.StatePattern
{
   public abstract class State
    {
        public abstract bool CanPlay();
        public abstract bool CanPause();
        public abstract bool CanStop();
        public abstract bool CanDrag();
    }
}
