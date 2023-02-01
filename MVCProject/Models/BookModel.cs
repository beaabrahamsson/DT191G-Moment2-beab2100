using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models {
    public class BookModel {
        //Properties
        [Required(ErrorMessage = "Ange ett namn")]
        [Display(Name= "Namn")]
        public string? Name {get; set;}

        [Required(ErrorMessage = "Ange en författare")]
        [Display(Name= "Författare")]
        public string? Author {get; set;}

        [Required(ErrorMessage = "Ange en genre")]
        [Display(Name= "Genre")]
        public string? Genre {get; set;}

        [Required(ErrorMessage = "Ange om läst")]
        [Display(Name= "Läst?")]
        public bool Read {get; set;}

    }
}