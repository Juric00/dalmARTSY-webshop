using System.ComponentModel.DataAnnotations;

namespace dalmARTSY_Test.Models;

public class User
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Email { get; set; }
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Password { get; set; }
}
