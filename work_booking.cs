using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WorkManagementSystem.Models.Entities

{
    public class work_booking
    {
        [Key]
        public int work_rowid { get; set; }
        public Guid work_Guid { get; set; } = Guid.NewGuid();
        public string work_fullname { get; set; }
        public string work_phonenumber { get; set; }
        public string work_whatsupmobile { get; set; }
        public string work_addressone { get; set; }
        public string work_addresstwo { get; set; }
        public string work_city { get; set; }
        public string work_province { get; set; }
        public string work_postalcode { get; set; }
        public string work_contectprefered { get; set; }
        public string work_services { get; set; }
        public string work_plumberissues { get; set; }
        public string work_otherplumber { get; set; }
        public string work_electricianissues { get; set; }
        public string work_otherelectrician { get; set; }
        public string work_carpenderissues { get; set; }
        public string work_othercarpender { get; set; }
        public string work_cleanerissues { get; set; }
        public string work_othercleaner { get; set; }

        public DateOnly work_date { get; set; }
        public string work_timeslot { get; set; }
        public string work_isurgent { get; set; }
        public string work_paymentmethod { get; set; }
        public string work_termsaccepted { get; set; }
        public DateTime work_CreatedOn { get; set; } = DateTime.Now;

    }

}
