using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mellow_Music_Player
{
    class Controller
    {

        public ArrayList parseSongFiles(String[] filepaths)
        {

            ArrayList names = new ArrayList();

            foreach(string filename in filepaths)
            {

                if(Path.GetExtension(filename).Equals(".mp3"))
                {

                    names.Add(Path.GetFileNameWithoutExtension(filename));
                    

                } 

            }

            return names;

        }

    }
}
