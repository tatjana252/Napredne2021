using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace WebApp.Models
{
    public class EnrollmentsViewModel
    {
        public List<SelectListItem> Courses { get; set; } = new List<SelectListItem>();
        public StudentViewModel Student { get; set; } = new StudentViewModel();
      
    }

    public class StudentViewModel : IValidatableObject
    {
        public string StudentName { get; set; }
        [IndexFormat]
        public string StudentIndex { get; set; }
        public List<CourseViewModel> Courses { get; set; } = new List<CourseViewModel>();
        public int StudentId { get; internal set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> result = new();
            if(Courses.Count == 0)
            {
                result.Add(new ValidationResult("Student must have more than one course!", new[] { "test "}));
            }
            if (Courses.Select(c => c.Id).Distinct().Count() != Courses.Count)
            {
                result.Add(new ValidationResult("Student must have distinct courses!", new[] { "Courses " }));
            }
            return result;
        }
    }

    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Espb { get; set; }
    }

    public class IndexFormatAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value is string val)
            {
               return Regex.IsMatch(val, @"[0-9]{0,4}/[0-9]{0,4}");
            }
            return false;

        }
    }
}
