using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicPlayer
{
    class MediaFile
    {
        public static string GetFileName(string path)
        {
            path = path.Substring(path.LastIndexOf('/') + 1);
            return path;
        }

        public string Path { get; }
        public string Name { get; }
        
        public MediaFile(string path)
        {
            if (!File.Exists(path))
                throw new ArgumentException("The path is not valid.");
            Path = path;
            Name = GetFileName(path);
        }
    }
}