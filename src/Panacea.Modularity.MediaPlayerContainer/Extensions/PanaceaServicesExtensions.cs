using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.MediaPlayerContainer.Extensions
{
    public static class PanaceaServicesExtensions
    {
        public static IMediaPlayerContainer GetMediaPlayerContainer(this PanaceaServices services)
        {
            return services.PluginLoader.GetPlugins<IMediaPlayerContainer>().FirstOrDefault();
        }
    }
}
