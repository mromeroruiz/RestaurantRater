using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HumaneSociety.Models
{
    public class Pet
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string AnimalType { get; set; }
    }
    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}