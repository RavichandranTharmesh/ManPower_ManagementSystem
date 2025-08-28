using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace WorkManagementSystem.Models.Entities
{
    public class info_user
    {
        [Key]

        public int info_rowid { get; set; }
        public Guid info_Guid { get; set; } = Guid.NewGuid();   
        public string info_firstname { get; set; }  
        public string info_lastname { get; set; }   
        public string info_nic {  get; set; }   
        public int info_gender { get; set; }    
        public string info_email { get; set; }  
        public string info_addressline1 { get; set; }
        public string info_addressline2 { get; set; }
        public string info_city { get; set; }   
        public string info_province { get; set; }   
        public string info_postalcode { get; set; } 
        public string info_telephone { get; set; }  
        public int info_privileges { get; set; }    

       public string info_username { get; set; }   
       public string info_password { get; set; }   
    }
}
