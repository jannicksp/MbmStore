using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Track {
        //Properties
        public string Title { get; set; }
        public string Composer { get; set;}
        public TimeSpan Length { get; set; }

        //Constructor
        public Track(string title, TimeSpan length)
        {
            Title = title;
            Length = length;
            Composer = "";
        }

        //Constructor
        public Track(string title, TimeSpan length, string composer)
        {
            Title = title;
            Length = length;
            Composer = composer;
        }

    }
}
