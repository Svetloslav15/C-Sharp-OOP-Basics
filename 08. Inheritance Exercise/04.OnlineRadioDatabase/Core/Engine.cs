using DefiningClasses.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses.Core
{
    public class Engine
    {
        private List<Song> songs;
        public Engine()
        {
            this.songs = new List<Song>();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 3)
                {
                    throw new InvalidSongException();
                }
                string artist = tokens[0];
                string songName = tokens[1];
                string[] length = tokens[2]
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);
                int minutes;
                int seconds;
                if (!int.TryParse(length[0], out minutes))
                {
                    throw new InvalidSongLengthException();
                }
                if (!int.TryParse(length[1], out seconds))
                {
                    throw new InvalidSongLengthException();

                }
                try
                {
                    Song song = new Song(artist, songName, minutes, seconds);
                    this.songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            int allSec = songs.Select(x => x.CalculateSec()).Sum();
            int hours = allSec / 3600;
            int min = allSec / 60 % 60;
            int sec = allSec % 3600 % 60;
            Console.WriteLine($"Songs added: {this.songs.Count()}");
            Console.WriteLine($"Playlist length: {hours}h {min}m {sec}s");
        }
    }
}
