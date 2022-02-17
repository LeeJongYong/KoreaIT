using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCConf.Models
{
    public class Room
    {
        public int roomId { get; set; }
        public string name { get; set; }

        public virtual ICollection<Speaker> sperkers { get; set; }
    }

    public class Speaker
    {
        public int speakerId { get; set; }

        public string name { get; set; }
        public int roomId { get; set; }

        public virtual Room room { get; set; }
    }
}