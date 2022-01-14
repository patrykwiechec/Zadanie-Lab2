using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie.Models
{
    public class FormModel
    {
        [Display(Name = "Twoje imię")]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)] 
        [Display(Name = "Data urodzenia")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

    }
}
