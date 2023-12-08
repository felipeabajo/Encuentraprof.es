using System.ComponentModel.DataAnnotations;

namespace BlazorServerSQLite.Data
{
    public class MailRequest
    {
        [Required (ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string ToEmail { get; set; }

        [Required (ErrorMessage = "Subject is required.")]
        public string Subject { get; set; }

        [Required (ErrorMessage = "Body is required.")]
        public string Body { get; set; }
    }
}
