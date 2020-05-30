using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HW28_ASPNET_CORE_POSTMAN.Models
{
    public class Citata
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public  DateTime Date { get; set; }
        public string Author { get; set; }
    }
}
