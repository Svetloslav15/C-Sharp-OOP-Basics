using GrandPrix.Models.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models
{
    public class Track
    {
        private Weather weather;

        public Track(int lapsNumber, int trackLength)
        {
            this.LapsNumber = lapsNumber;
            this.TrackLength = trackLength;
            this.weather = Weather.Sunny;
            this.CurrentLap = 0;
        }
        public int LapsNumber { get; }
        public int TrackLength { get; }
        public Weather Weather { get; set; }
        public int CurrentLap { get; set; }
    }
}