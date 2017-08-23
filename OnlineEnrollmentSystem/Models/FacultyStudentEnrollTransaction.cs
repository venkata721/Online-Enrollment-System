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
    
    public partial class FacultyStudentEnrollTransaction
    {
        public int FS_ID { get; set; }
        public int FS_FACULTY_ID { get; set; }
        public int FS_STUDENT_ID { get; set; }
        public System.DateTime FS_ENROLLDATE { get; set; }
        public string FS_ENROLLBY { get; set; }
        public string FS_DESCRIPTION { get; set; }
        public string FS_AYN { get; set; }
        public string CDATE { get; set; }
        public string CUSER { get; set; }
        public string MDATE { get; set; }
        public string MUSER { get; set; }
        public string FS_STUDENT_NAME { get; set; }
        public string FS_FACULTY_NAME { get; set; }
    
        public virtual FacultyMaster FacultyMaster { get; set; }
        public virtual StudentMaster StudentMaster { get; set; }
    }
}