
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{

    public class UserInfo
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Isim Girmeniz Zorunludur!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon Girmeniz Zorunludur!")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email Girmeniz Zorunludur!")]
        [EmailAddress(ErrorMessage = "Lutfen Email Formatinda giriniz!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lutfen Katiliminizi Belirtin!")]
        public bool? WillAttend { get; set; }

    }

}