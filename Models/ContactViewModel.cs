using System.ComponentModel.DataAnnotations;

namespace jasper_portfolio.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Your name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Your email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter a subject.")]
        public string? Subject { get; set; }

        [Required(ErrorMessage = "Please enter your message.")]
        public string? Message { get; set; }
    }
}
