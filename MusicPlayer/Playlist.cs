using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class PlaylistManager
    {
        //something new...


        public bool nothing;

        private List<MediaFile> playlist;

        public bool Random { get; set; }
        public bool Repeat { get; set; }

        public MediaFile GetNextFile()
        {
            throw new NotImplementedException();
        }
    }
}
