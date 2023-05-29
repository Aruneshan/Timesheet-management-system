using System.ComponentModel.DataAnnotations;

namespace TimeMate.Models;

public class Feedback
{

    [Key]
    public int Id { get; set; }

    [Required]
    public string? emailid{get; set;}
    [Required]
    public int rating{get; set;}
    [Required]
    public string? feedback{get; set;}

}