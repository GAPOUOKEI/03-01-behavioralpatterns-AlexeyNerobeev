using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class Track
    {
        private string _name;

        public string Name
        {
            get => _name; 
            set => _name = value;
        }

        private IState state;
        public void Play() =>
            state.Play();

        public void Pause() =>
            state.Pause();

        public void Stop() =>
            state.Stop();

        public void Rewind() =>
            state.Rewind();

        public Track(string name)
        {
            Name = name;
            state = new StopState();
        }

        public void ChangeState(IState state) => this.state = state;

        public override string ToString()
        {
            return $"трэк {Name} {state}";
        }
    }
}
