using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotesSite.Models
{

    public class NoteModelDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must provide us your note's Title ")]
        [StringLength(255)]
        [Display(Name = "Title of your note")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You must provide us your note's Description")]
        [StringLength(1000, ErrorMessage = "Your note is too long")]
        [Display(Name = "Description of your note")]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "You must provide us your note's Description")]
        [Display(Name = "Priority of your note")]
        // TODO: create separate Table later
        // TODO: create dropdown list from values inside database
        public string Priority { get; set; }
    }
}
