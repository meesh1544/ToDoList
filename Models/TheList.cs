using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class TheList
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string? Description { get; set; }
        

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }
    }
}
