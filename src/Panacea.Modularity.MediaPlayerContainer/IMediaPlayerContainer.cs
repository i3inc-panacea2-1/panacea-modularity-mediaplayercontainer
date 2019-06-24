using Panacea.Modularity.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.MediaPlayerContainer
{
    public interface IMediaPlayerContainer : IPlugin
    {
        MediaRequest CurrentRequest { get; }
        object CurrentOwner { get; }
        IMediaPlayerPlugin CurrentMediaPlayer { get; }
        IMediaResponse Play(MediaRequest request);
        void GoFullscreen();
    }
}
