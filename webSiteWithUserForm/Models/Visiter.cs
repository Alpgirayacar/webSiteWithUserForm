using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webSiteWithUserForm.Models
{
    public class Visiter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Display(Name = " Adınız")]
        [StringLength(50)]
        [Required(ErrorMessage = " Ziyaretçi adı zorunlu bir alan.")]
        public string Name { get; set; }


        [StringLength(50)]
        [Required(ErrorMessage = " Ziyaretçi soyadı zorunlu bir alan.")]
        public string Surname { get; set; }


        [StringLength(50)]
        [Required(ErrorMessage = " Ziyaretçi email zorunlu bir alan.")]
   
        public string Email { get; set; }




        [StringLength(50)]
       
        [Required(ErrorMessage = " Ziyaretçi mesajı zorunlu bir alan.")]
        public string Message { get; set; }

    }
}
