using System;
using System.ComponentModel.DataAnnotations;
namespace MyApplication.Data.Entites
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string RoleId { get; set; }
        public string ProjectName { get; set; }
        public string ManagerName { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public DateTime? DateOfJoining { get; set; } 
       
    
    }
}
