﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRage.Library.Utils;
using VRage.Utils;

namespace VRage.Audio
{
    public interface IMySourceVoice
    {
        Action StoppedPlaying { get; set; }
        bool IsPlaying { get; }
        float FrequencyRatio { get; set; }
        bool IsLoopable { get; }
        MyStringId CueEnum { get; }

        void Start(bool skipIntro, bool skipToEnd = false);
        void Stop(bool force = false);

        void Pause();

        bool IsPaused { get; }

        void Resume();

        void SetVolume(float value);

        float Volume { get; }
    }
}
