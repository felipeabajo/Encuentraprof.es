using BlazorServerSQLite.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerSQLite.Data
{
    public class TeacherContact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string TeacherId { get; set; }
        public ApplicationUser Teacher { get; set; }
        public DateTime UnblockingDate { get; set; }
    }
}