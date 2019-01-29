using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        
        public int RestaurantID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Rating { get; set; }
    }

    public class RestaurantDBContext : DbContext
        {
            public DbSet<Restaurant> Restaurants { get; set; }
        }
}