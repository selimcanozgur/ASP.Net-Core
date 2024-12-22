using System.ComponentModel.DataAnnotations;

// Student Model
namespace efcoreApp.Data{
    public class Student {
        [Key]
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}