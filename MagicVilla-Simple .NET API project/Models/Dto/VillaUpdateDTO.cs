﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Simple_.NET_API_project.Models.Dto
{
    public class VillaUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int Occupancy { get; set; }
        [Required]
        public int Sqft { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public string ImageURL { get; set; }
        public string Amenity { get; set; }
    }
}
