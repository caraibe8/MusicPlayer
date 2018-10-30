using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicPlayer
{
    class MediaFile : IMediaFile
    {
        public string Path { get; }

        public string Name { get; }

        public MediaFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();
            Path = path;
            Name = path.Substring(path.LastIndexOf('/') + 1);
        }
    }
}
