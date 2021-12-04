using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProj.Models
{
    public class FavFood
    {
        public int Id { get; set; }
        public string FavoriteFood { get; set; }
        public string SecondFav { get; set; }
        public string LeastFav { get; set; }
        public string MealOfTheDay { get; set; }
    }
}
