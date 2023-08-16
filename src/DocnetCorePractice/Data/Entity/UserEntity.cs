using DocnetCorePractice.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocnetCorePractice.Data.Entity
{
    [Table("User")]
    public class UserEntity : Entity
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        [Column(TypeName = "Money")]
        [Range(0, int.MaxValue)]
        public decimal Balance { get; set; }
        public int TotalProduct { get; set; }
        [DefaultValue("true")]
        public bool IsActive { get; set; }
        public Roles Roles { get; set; }

        public virtual ICollection<OrderEntity>?  Orders { get; set; }
    }
}
