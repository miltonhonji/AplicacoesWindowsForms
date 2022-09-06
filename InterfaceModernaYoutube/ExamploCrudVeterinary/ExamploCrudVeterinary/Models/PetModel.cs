using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExamploCrudVeterinary.Models
{
    public class PetModel
    {
        [DisplayName("Pet ID")]
        private int Id { get; set; }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage ="Pet is name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Pet name must be between 3 and 50 characters")]
        private string Name { get; set; }

        [DisplayName("Pet Type")]
        [Required(ErrorMessage ="Pet is type is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Pet type must be between 3 and 50 characters")]
        private string Type { get; set; }

        [DisplayName("Pet Colour")]
        [Required(ErrorMessage ="Pet is colour is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Pet colour must be between 3 and 50 characters")]
        private string Colour { get; set; }
    }
}
