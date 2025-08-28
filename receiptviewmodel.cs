namespace WorkManagementSystem.Models
{
    public class receiptviewmodel
    {

        public int rowid { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string fullname { get; set; }
        public string phonenumber { get; set; }
        public string whatsupmobile { get; set; }
        public string addressone { get; set; }
        public string addresstwo { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postalcode { get; set; }
        public string contectprefered { get; set; }
        public DateOnly date { get; set; }
        public string timeslot { get; set; }
        public string surgent { get; set; }
        public string paymentmethod { get; set; }
    }
}
