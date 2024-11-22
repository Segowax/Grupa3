using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Schedule
    {
        [Key]     
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Type { get; set; }
    }
}
