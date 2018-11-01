using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.IO.File;

namespace MusicPlayerLib
{
    public class PlaylistManager : IPlaylist
    {
        private Random randomizer;
        private List<IMediaFile> playlist;
        private List<int> notReadFiles;
        private bool random;

        public IMediaFile CurrentFile { get; private set; }
        public bool Random
        {
            get => random; set
            {
                random = value;
                if (value)
                    FillNotReadFile();
                else notReadFiles = null;
            }
        }
        public ReadMode ReadMode { get; set; }

        public PlaylistManager()
        {
            CurrentFile = null;
            Random = false;
            ReadMode = ReadMode.Normal;
            playlist = new List<IMediaFile>();
            randomizer = new Random();
        }

        public void AddToPlaylist(IMediaFile file)
        {
            if (file == null)
                throw new NullReferenceException();

            if (!Exists(file.Path))
                throw new FileNotFoundException();
            playlist.Add(file);
            if (Random)
                notReadFiles.Add(playlist.Count - 1);
        }

        public void AddToPlaylist(IEnumerable<IMediaFile> files)
        {
            if (files == null)
                throw new NullReferenceException();

            foreach (IMediaFile file in files)
            {
                if (!Exists(file.Path))
                    throw new FileNotFoundException();

            }
            playlist.AddRange(files);
        }

        public IMediaFile GetNextFile()
        {
            if (playlist == null)
                throw new InvalidOperationException();
            if (playlist.Count == 0)
                throw new InvalidOperationException();

            if (ReadMode == ReadMode.Repeat)
                return CurrentFile;

            if (ReadMode == ReadMode.Loop)
            {
                if (Random) return SetCurrentFile(GetRandomFile(true));
                else if (playlist.IndexOf(CurrentFile) + 1 == playlist.Count) return SetCurrentFile(playlist[0]);
                else return SetCurrentFile(playlist[playlist.IndexOf(CurrentFile) + 1]);
            }
            else
            {
                if (Random) return SetCurrentFile(GetRandomFile(false));
                else if (playlist.IndexOf(CurrentFile) + 1 == playlist.Count) return SetCurrentFile(null);
                else return SetCurrentFile(playlist[playlist.IndexOf(CurrentFile) + 1]);
            }
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

        private void FillNotReadFile()
        {
            notReadFiles = new List<int>();
            int i = 0;
            foreach (IMediaFile file in playlist)
                notReadFiles.Add(i++);
        }

        private IMediaFile GetRandomFile(bool repeatIfEmpty)
        {
            if (!repeatIfEmpty && notReadFiles.Count == 0)
                return null;
            for (; ; )
            {
                int fileIndex = randomizer.Next(playlist.Count - 1);
                /***/
                if (notReadFiles.Contains(fileIndex)) return playlist[fileIndex];
                /***/
            }
        }

        private IMediaFile SetCurrentFile(IMediaFile file)
        {
            CurrentFile = file;
            return CurrentFile;
        }
    }
}
