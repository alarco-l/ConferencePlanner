using System.ComponentModel.DataAnnotations;

namespace ConferenceDTO
{
    public class Attendee
    {
        public int Id {get; set;}

        [Required, StringLength(100)]
        public virtual string FirstName {get; set;}

        [Required, StringLength(100)]
        public virtual string LastName {get; set;}

        [Required, StringLength(100)]
        public string UserName {get; set;}

        [Required, StringLength(256)]
        public virtual string EmailAddress {get; set;}
    }
}
