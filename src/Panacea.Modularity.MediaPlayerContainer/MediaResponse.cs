using Panacea.Modularity.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.MediaPlayerContainer
{
    public interface IMediaResponse : IMediaPlayer
    {
        MediaRequest Request { get; }
    }
}
