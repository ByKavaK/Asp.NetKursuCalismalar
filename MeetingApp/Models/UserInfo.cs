using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Alanı Zorunlu")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon Alanı Zorunlu")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Email Alanı Zorunlu")]
        [EmailAddress(ErrorMessage ="Hatalı Email")]
        public string? Email { get; set; }
        
        [Required(ErrorMessage ="Katılım Durumunuzu Belirtiniz")]
        public bool? WillAttend { get; set; }


    }
}