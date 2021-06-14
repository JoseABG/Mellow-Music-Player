using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Mellow_Music_Player
{
    class Controller
    {
        private SongDatabase songDatabase;

        public Controller()
        {

            songDatabase = new SongDatabase();

        }

        public ArrayList parseSongFiles(String[] filepaths)
        {

            ArrayList names = new ArrayList();

            foreach(string filename in filepaths)
            {

                if(Path.GetExtension(filename).Equals(".mp3"))
                {
                    String songName = Path.GetFileNameWithoutExtension(filename);
                    names.Add(songName);
                    Song song = new Song(filename, songName);
                    songDatabase.addSong(song);
                    

                } 

            }

            return names;

        }

        public ArrayList getList()
        {

            return songDatabase.getSongs();

        }

    }
}
