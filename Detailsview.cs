namespace WorkManagementSystem.Models
{
    public class Detailsview
    {

        public int rowid { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string nic { get; set; }
        public int gender { get; set; }
        public string email { get; set; }
        public string addressline1 { get; set; }
        public string addressline2 { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postalcode { get; set; }
        public string telephone { get; set; }
        public int privileges { get; set; }


        public string username { get; set; }
        public string password { get; set; }
    }
}
