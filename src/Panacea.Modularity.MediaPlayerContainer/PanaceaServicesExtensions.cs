using Panacea.Core;
using System.Linq;

namespace Panacea.Modularity.MediaPlayerContainer
{
    public static class PanaceaServicesExtensions
    {
        public static IMediaPlayerContainer GetMediaPlayerContainer(this PanaceaServices services)
        {
            return services.PluginLoader.GetPlugins<IMediaPlayerContainer>().FirstOrDefault();
        }

        public static bool TryGetMediaPlayerContainer(this PanaceaServices services, out IMediaPlayerContainer container)
        {
            container = null;
            var plugin = services.PluginLoader.GetPlugins<IMediaPlayerContainer>().FirstOrDefault();
            if(plugin == null)
            {
                return false;
            }
            container = plugin;
            return true;
        }
    }
}
