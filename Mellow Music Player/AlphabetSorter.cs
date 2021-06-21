using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mellow_Music_Player
{
    class AlphabetSorter:IComparer<Song>
    {

        public int Compare(Song x, Song y)
        {

            return string.Compare(x.songName, y.songName, StringComparison.OrdinalIgnoreCase);
        }

    }
}
