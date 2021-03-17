using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Episode
    {
        public int EpisodeId { get; set; }
        public string Title { get; set; }
        public string GuestName { get; set; }
        public DateTime Date { get; set; }
        public string URL { get; set; }
    }
}
