using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkerCRUD.Models
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 1)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Range(1, 2)]
        public int Gender { get; set; }
        [StringLength(150, MinimumLength = 1)]
        public string Specialization { get; set; }
        public DateTime Created { get; set; }
    }
}
