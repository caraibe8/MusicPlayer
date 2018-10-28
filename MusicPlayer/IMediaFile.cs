using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    interface IMediaFile
    {
        //Properties
        /// <summary>
        /// Full path of the file.
        /// </summary>
        string Path { get; }
        /// <summary>
        /// Name of the file as shown in it's folder
        /// </summary>
        string Name { get; }
    }
}
