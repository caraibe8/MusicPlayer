using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class PlaylistManager : IPlaylist
    {
        public IMediaFile CurrentFile => throw new NotImplementedException();

        public bool Random { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ReadMode ReadMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddToPlaylist(IMediaFile file)
        {
            throw new NotImplementedException();
        }

        public void AddToPlaylist(IEnumerable<IMediaFile> files)
        {
            throw new NotImplementedException();
        }

        public IMediaFile GetNextFile()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMediaFile> GetPlaylist()
        {
            throw new NotImplementedException();
        }

        public IMediaFile JumpToNextFile()
        {
            throw new NotImplementedException();
        }

        public IMediaFile JumpToPreviousFile()
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromPlaylist(IMediaFile file)
        {
            throw new NotImplementedException();
        }

        public void ResetPlaylist(IEnumerable<IMediaFile> files = null)
        {
            throw new NotImplementedException();
        }
    }
}
