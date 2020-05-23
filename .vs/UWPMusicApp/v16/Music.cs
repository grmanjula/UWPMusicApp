using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPMusicApp.Model
{
     public enum MusicCategory
        {
            Brunos,
            Demis,
            Drakes,
            Selenas
        }
    //
        public class Music
        {
            public string Name { get; set; }
            public MusicCategory Category { get; set; }
            public string AudioFile { get; set; }
            public string ImageFile { get; set; }
            public string Artist { get; set; }
            public string Album { get; set; }

        public Music(string name, MusicCategory category, string album, string artist)
            {
                Name = name;
                Category = category;
                AudioFile = $"/Assets/Music/{category}/{name}.mp3";
                ImageFile = $"/Assets/Images/{category}/{name}.png";
                Album = album;
                Artist = artist;
            }
        }
    }

    

