using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace AnimalShelter.Data
{
    public class PawAnimal
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string AnimalName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Species { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string AnimalArea { get; set; }
        [Required]
        [StringLength(256)]
        public string Vaccine { get; set; }
        [Required]
        [StringLength(256)]
        public string Health { get; set; }
        [Required]
        [StringLength(256)]
        public DateTime CreatedDate { get; set; }
    }
}
