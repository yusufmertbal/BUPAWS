using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter
{
    public class PawUser
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string UserName { get; set; }
        [Required]
        [StringLength(256)]
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
