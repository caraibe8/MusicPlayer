using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public enum ReadMode
    {
        Loop, Repeat, Normal
    }

    interface IPlaylist
    {
        //Properties
        /// <summary>
        /// The file that is currently being read.
        /// </summary>
        IMediaFile CurrentFile { get; }
        /// <summary>
        /// If the Playlist should always read the same file.
        /// </summary>
        bool Random { get; set; }
        /// <summary>
        /// The way the files are picked depends on this property.
        /// </summary>
        ReadMode ReadMode { get; set; }

        /// <summary>
        /// Returns the next file to play in function of the current read settings.
        /// </summary>
        /// <returns>File to read</returns>
        IMediaFile GetNextFile();
        /// <summary>
        /// Returns the previous file according to the current read settings (cannot be the same one).
        /// </summary>
        /// <returns>File to read</returns>
        IMediaFile JumpToPreviousFile();
        /// <summary>
        /// Returns the next file according to the current read settings (cannot be the same one).
        /// </summary>
        /// <returns>File to read</returns>
        IMediaFile JumpToNextFile();
        /// <summary>
        /// Returns the current playlist.
        /// </summary>
        /// <returns>Current playlist</returns>
        IEnumerable<IMediaFile> GetPlaylist();
        /// <summary>
        /// Adds the given file to the playlist if it is valid.
        /// </summary>
        /// <param name="file">File to add</param>
        /// <returns>If the file was successfully added</returns>
        /// <exception cref="ArgumentException"></exception>
        void AddToPlaylist(IMediaFile file);
        /// <summary>
        /// Adds the given files to the playlist if they are valid
        /// </summary>
        /// <param name="files">Files to add</param>
        /// <exception cref="ArgumentException"></exception>
        void AddToPlaylist(IEnumerable<IMediaFile> files);
        /// <summary>
        /// Removes the given file from the playlist if it is par of it.
        /// </summary>
        /// <param name="file">File to remove</param>
        /// <returns>If the file was successfully removed</returns>
        bool RemoveFromPlaylist(IMediaFile file);
        /// <summary>
        /// Removes all files from the playlist and replace them with the given files.
        /// </summary>
        /// <param name="files">Files to add to the playlist</param>
        /// <exception cref="ArgumentException"></exception>
        void ResetPlaylist(IEnumerable<IMediaFile> files = null);
    }
}
