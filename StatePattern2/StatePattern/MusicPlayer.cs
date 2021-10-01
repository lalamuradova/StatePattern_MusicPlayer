using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2.StatePattern
{
    class MusicPlayer
    {
        private State _state = null;

        public void ChangeState(State state)
        {
            _state = state;
        }
        public bool GetCanDrag()
        {
            return _state.CanDrag();
        }

        public bool GetCanPause()
        {
            return _state.CanPause();
        }

        public bool GetCanPlay()
        {
            return _state.CanPlay();
        }

        public bool GetCanStop()
        {
            return _state.CanStop();
        }

    }
}
