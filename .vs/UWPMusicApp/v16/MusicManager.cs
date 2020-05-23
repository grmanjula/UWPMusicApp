using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPMusicApp.Model
{
   public static class MusicManager
    {
        public static void GetAllSongs(ObservableCollection<Music> songs)
        {
            var allSongs = getSongs();
            songs.Clear();
            allSongs.ForEach(Music => songs.Add(Music)); //Lambda Expression

        }

        //
        public static void GetMusicByCategory(ObservableCollection<Music> Songs, MusicCategory category)
        {
            var allSongs = getSongs();
            var FilteredSounds = allSongs.Where(music => music.Category == category).ToList();
            Songs.Clear();
            FilteredSounds.ForEach(music => Songs.Add(music));
        }

        private static List<Music> getSongs()
        {
            var songs = new List<Music>();
            songs.Add(new Model.Music("Magic", MusicCategory.Brunos, "24K Magic", "Bruno Mars"));
            songs.Add(new Model.Music("Uptown", MusicCategory.Brunos, "UpTownFunk", "Mark Ronson"));
            songs.Add(new Model.Music("Confident", MusicCategory.Demis, "ConfidentR", "Demi Lovato"));
            songs.Add(new Model.Music("Sorry", MusicCategory.Demis,"Souveniers", "Demis Rousso"));
            songs.Add(new Model.Music("Hotline", MusicCategory.Drakes, "Hotline Bling","Drake Graham"));
            songs.Add(new Model.Music("Scorpion", MusicCategory.Drakes, "Scorpion 2018","Drake Graham"));
            songs.Add(new Model.Music("LoseU", MusicCategory.Selenas, "Lose You to Love Me" , "Selena Gomez"));
            songs.Add(new Model.Music("StarsDance", MusicCategory.Selenas, "Stars Dance 2013", "Selena Gomez"));

            return songs;
        }

    }
}
