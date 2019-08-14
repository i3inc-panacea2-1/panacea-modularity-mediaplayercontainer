using Panacea.Modularity.Media;
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

        bool IsPausable { get; }
        TimeSpan Duration { get; }
        bool HasPrevious { get; }
        bool HasNext { get; }
        bool IsPlaying { get; }
        float Position { get; set; }
        bool IsSeekable { get; }
        bool HasSubtitles { get; }

        event EventHandler<TimeSpan> DurationChanged;
        event EventHandler<bool> HasSubtitlesChanged;
        event EventHandler Opening;
        event EventHandler Playing;
        event EventHandler<string> NowPlaying;
        event EventHandler Stopped;
        event EventHandler<bool> HasPreviousChanged;
        event EventHandler Paused;
        event EventHandler<bool> IsPausableChanged;
        event EventHandler<bool> HasNextChanged;
        event EventHandler<Exception> Error;
        event EventHandler<bool> IsSeekableChanged;
        event EventHandler Ended;
        event EventHandler<float> PositionChanged;
        void Next();
        void Pause();
        void Play();
        void Previous();
        void SetSubtitles(bool on);
        void Stop();
    }
}
