namespace WorkManagementSystem.Models
{
    public class workregisterviewmodel
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

        public string services { get; set; }
        public string plumberissues { get; set; }
        public string otherplumber { get; set; }
        public string electricianissues { get; set; }
        public string otherelectrician { get; set; }
        public string carpenderissues { get; set; }
        public string othercarpender { get; set; }
        public string cleanerissues { get; set; }
        public string othercleaner { get; set; }
        public DateOnly date { get; set; }
        public string timeslot { get; set; }
        public string surgent { get; set; }
        public string paymentmethod { get; set; }
        public string termsaccepted { get; set; }
        public DateTime work_CreatedOn { get; set; } = DateTime.Now;
    }
}
