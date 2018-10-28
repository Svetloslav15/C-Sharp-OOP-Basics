using DefiningClasses.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public string ArtistName
        {
            get => this.artistName;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                artistName = value;
            }
        }

        public string SongName
        {
            get => this.songName;
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                songName = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                seconds = value;
            }
        }

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public int CalculateSec()
        {
            return this.Minutes * 60 + this.Seconds;
        }
    }
}