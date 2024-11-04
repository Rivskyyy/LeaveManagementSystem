using LeaveManagmentSystem.Web.Models.LeaveTypes;
using System.ComponentModel.DataAnnotations;

public class LeaveTypeEditVM : BaseLeaveTypeVM
{
    [Required]
    [Length(4, 150, ErrorMessage = "You have violated the length requirement")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(1, 90)]
    [Display(Name = "Maximum Allocation of Days")]
    public int NumberOfDays { get; set; }
}