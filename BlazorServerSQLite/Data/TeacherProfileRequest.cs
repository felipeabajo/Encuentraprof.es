using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerSQLite.Data
{
    public class TeacherProfileRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string TypeOfField { get; set; }
        public string UnapprovedField { get; set; }
        public DateTime TeacherProfileRequestDate { get; set; }
        public string TeacherProfileRequestState { get; set; }

    }
}
