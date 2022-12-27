using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Data
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Date Created")]
        public Nullable<DateTime> Datecreated { get; set; }
    }
}
