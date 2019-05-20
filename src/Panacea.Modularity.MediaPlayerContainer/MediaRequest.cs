using Panacea.Modularity.Media;
using System;
using System.Windows.Controls;

namespace Panacea.Modularity.MediaPlayerContainer
{
    public class MediaRequest
    {
        public MediaRequest(MediaItem channel)
        {
            Media = channel;
            FullscreenMode = FullscreenMode.User;
            ShowVideo = true;
            ShowControls = true;
            MediaPlayerPosition = MediaPlayerPosition.Standalone;
            ContinuePreviousMedia = false;
            IsInPip = false;
        }

        public ContentControl MediaPlayerHost { get; set; }

        public MediaItem Media { get; set; }
        public FullscreenMode FullscreenMode { get; set; }
        public MediaPlayerPosition MediaPlayerPosition { get; set; }
        public float Position { get; set; }
        public bool ShowVideo { get; set; }
        public bool AllowPip { get; set; }
        public bool ShowControls { get; set; }
        public bool ContinuePreviousMedia { get; set; }
        public bool IsInPip { get; set; }

        public IMediaTraverser MediaTraverser { get; set; }

        public MediaRequest Copy()
        {
            var ret = new MediaRequest(Media);
            foreach (var prop in this.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                prop.SetValue(ret, prop.GetValue(this));
            }
            return ret;
        }


    }


    

   
}
