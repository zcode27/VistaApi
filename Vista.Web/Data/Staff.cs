﻿using System.ComponentModel.DataAnnotations;

namespace Vista.Web.Data
{
    public class Staff
    {
        public Staff() { }
        public Staff(int staffId, string lastName, string firstName) 
        {
            StaffId = staffId;
            LastName = lastName;
            FirstName = firstName
        }
        public int StaffId { get; set; } = 0;

        [Required]
        public string LastName { get; set; } = null!;
        
        [Required] 
        public string FirstName { get; } = null!;

        //List of Workshops (many side of one-to-many)
        public List<WorkshopStaff> Workshop { get; set; }

    }
}
