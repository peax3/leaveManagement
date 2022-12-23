using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class DetailsLeaveTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Datecreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
    }

    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }
    }
}