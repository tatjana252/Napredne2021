using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class CreateStudentViewModel
    {
        [Required(ErrorMessage = "Obavezno polje")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public int EnrollmentYear { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public int EnrollmentNumber { get; set; }
        public int StudyProgramId { get; set; }
        public List<SelectListItem> StudyPrograms { get; set; }
    }
}
