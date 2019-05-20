using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.MediaPlayerContainer
{
    public interface IMediaResponse
    {
        MediaRequest Request { get; }
        event EventHandler Playing;
        event EventHandler Stopped;
        event EventHandler Ended;
        event EventHandler Error;
    }
}
