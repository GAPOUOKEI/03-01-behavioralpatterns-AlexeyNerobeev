﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal interface IState
    {
        void Play();
        void Stop();
        void Pause();
        void Rewind();
    }
}
