using System;
using System.ComponentModel.DataAnnotations;

namespace MyDairyApp.Models
{
    public class DairyEntry
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime Created { get; set; }
    }
}