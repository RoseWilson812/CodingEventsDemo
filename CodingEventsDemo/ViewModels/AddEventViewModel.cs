using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage="Name is required.")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Name must be 3-50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description must be under 500 characters.")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }
    }
}
