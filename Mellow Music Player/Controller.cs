﻿using System;
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
        private string currentSongDuration;

        public Controller()
        {

            songDatabase = new SongDatabase();

        }

        public void parseSongFiles(String[] filepaths)
        {

            foreach(string filename in filepaths)
            {

                if(Path.GetExtension(filename).Equals(".mp3"))
                {
                    String songName = Path.GetFileNameWithoutExtension(filename);
                    Song song = new Song(filename, songName);
                    songDatabase.addSong(song);
                   

                } 

            }

        }

        public List<Song> getList()
        {

            return songDatabase.getSongs();

        }

        public void setCurrentSongDuration(String currentSongDuration)
        {

            this.currentSongDuration = currentSongDuration;

        }

        public string getCurrentSongDuration()
        {

            return currentSongDuration;
            

        }

        public string parseTime(int seconds)
        {

            TimeSpan span = TimeSpan.FromSeconds(seconds);
            return span.ToString(@"mm\:ss");

        }

    }
}
