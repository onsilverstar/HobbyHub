using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes.Models
{
    public class AddChef
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public DateTime dob;
        public DateTime DOB {
            get{
                return dob.Date;
            }
            set
            {
                if(value>DateTime.Today)
                dob=value.Date;
            }
        }
    
}
        
        
    
}