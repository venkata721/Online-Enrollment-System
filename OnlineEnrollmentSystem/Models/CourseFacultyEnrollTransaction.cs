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
    
    public partial class CourseFacultyEnrollTransaction
    {
        public int CF_ID { get; set; }
        public int CF_FACULTY_ID { get; set; }
        public int CF_COURSE_ID { get; set; }
        public System.DateTime CF_ENROLLDATE { get; set; }
        public string CF_ENROLLBY { get; set; }
        public string CF_DESCRIPTION { get; set; }
        public string CF_AYN { get; set; }
        public string CDATE { get; set; }
        public string CUSER { get; set; }
        public string MDATE { get; set; }
        public string MUSER { get; set; }
        public string CF_FACULTY_NAME { get; set; }
        public string CF_COURSE_NAME { get; set; }
    
        public virtual CourseMaster CourseMaster { get; set; }
        public virtual FacultyMaster FacultyMaster { get; set; }
    }
}
