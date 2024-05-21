using System.ComponentModel.DataAnnotations;

namespace LearningBlazor.Models;

public class Counters
{
    [Required]
    [RegularExpression(@"^[^\p{P}\p{Sm}]*$", ErrorMessage = "Please use only numbers")]
    [NotZero(ErrorMessage = "ID of 0 is invalid")]
    public int Id { get; set; }
    public int CurrantCount { get; set; }
}

public class NotZeroAttribute : ValidationAttribute
{
    public override bool IsValid(object? value) => (int)(value ?? 1) != 0;
}