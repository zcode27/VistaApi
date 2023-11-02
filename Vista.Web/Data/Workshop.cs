using System.ComponentModel.DataAnnotations;

namespace Vista.Web.Data
{
    public class Workshop
    {
        public Workshop() { }
        public Workshop(int workshopid, string name, DateTime dateAndTime) 
        {
            Workshopid = workshopid;
            Name = name;
            DateAndTime = dateAndTime;
        }

        public int Workshopid { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTime DateAndTime { get; set; }
        public string CategoryCode { get; set; } = null;
        public string BookingRef { get; set; } = null;

        //List of Staff (many side of one-to-many)
        public List<WorkshopStaff> Staff {get; set; }
    }
}
