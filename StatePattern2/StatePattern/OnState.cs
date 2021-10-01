using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2.StatePattern
{
    public class OnState : State
    {
        public override bool CanDrag()
        {
            return true;
        }

        public override bool CanPause()
        {
            return true;
        }

        public override bool CanPlay()
        {
            return true;
        }

        public override bool CanStop()
        {
            return true;
        }
    }
}
