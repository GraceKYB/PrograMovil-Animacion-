using System;
using System.Collections.Generic;
using System.Text;

namespace animacion
{
    public interface IAudioPlayer
    {
        void PlayAudio(string audioFileName);
        void PauseAudio();
        void ResumeAudio();
    }
}
