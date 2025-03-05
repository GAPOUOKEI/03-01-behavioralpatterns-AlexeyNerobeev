using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class PlayerContext
    {
        private IPlayerState _state;

        public PlayerContext(IPlayerState state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(IPlayerState state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play(this);
        }

        public void Pause()
        {
            _state.Pause(this);
        }

        public void Stop()
        {
            _state.Stop(this);
        }

        public void Rewind()
        {
            _state.Rewind(this);
        }
    }
}
