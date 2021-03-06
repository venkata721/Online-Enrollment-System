//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineEnrollmentSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseMaster
    {
        public CourseMaster()
        {
            this.CourseFacultyEnrollTransactions = new HashSet<CourseFacultyEnrollTransaction>();
            this.StudentEnrollCourseTrans = new HashSet<StudentEnrollCourseTran>();
        }
    
        public int C_ID { get; set; }
        public string C_NAME { get; set; }
        public string C_DESCRIPTION { get; set; }
        public Nullable<System.DateTime> C_STARTDATE { get; set; }
        public Nullable<System.DateTime> C_ENDDATE { get; set; }
        public Nullable<int> C_FEE { get; set; }
        public string C_DURATION { get; set; }
        public string C_AYN { get; set; }
        public string CDATE { get; set; }
        public string CUSER { get; set; }
        public string MDATE { get; set; }
        public string MUSER { get; set; }
    
        public virtual ICollection<CourseFacultyEnrollTransaction> CourseFacultyEnrollTransactions { get; set; }
        public virtual ICollection<StudentEnrollCourseTran> StudentEnrollCourseTrans { get; set; }
    }
}
