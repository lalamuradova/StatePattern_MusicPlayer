using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2.StatePattern
{
    class OffState : State
    {
        public override bool CanDrag()
        {
            return false;
        }

        public override bool CanPause()
        {
            return false;
        }

        public override bool CanPlay()
        {
            return false;
        }

        public override bool CanStop()
        {
            return false;
        }
    }
}
