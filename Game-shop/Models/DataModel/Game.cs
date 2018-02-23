using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_shop.Models.DataModel
{
    public class 
        Game
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}