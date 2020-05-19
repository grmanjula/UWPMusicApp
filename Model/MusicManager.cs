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
            songs.Add(new Model.Music("Magic", MusicCategory.Brunos));
            songs.Add(new Model.Music("Uptown", MusicCategory.Brunos));
            songs.Add(new Model.Music("Confident", MusicCategory.Demis));
            songs.Add(new Model.Music("Sorry", MusicCategory.Demis));
            songs.Add(new Model.Music("Hotline", MusicCategory.Drakes));
            songs.Add(new Model.Music("Scorpion", MusicCategory.Drakes));
            songs.Add(new Model.Music("LoseU", MusicCategory.Selenas));
            songs.Add(new Model.Music("StarsDance", MusicCategory.Selenas));

            return songs;
        }
    }
}
