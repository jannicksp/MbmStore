using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product {
        //Properties
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public static List<Track> Tracks { get; } = new List<Track>();

        //methods
        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
      
        //Constructors
        public MusicCD() { }
        public MusicCD(string artist, string title, decimal price, short released, string imageFileName) : base(title, price, imageFileName)
        {
            Artist = artist;
            Price = price;
            Released = released;
            ImageFileName = imageFileName;
        }

    }

}
