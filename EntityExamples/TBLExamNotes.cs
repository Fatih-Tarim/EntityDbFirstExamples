//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityExamples
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLExamNotes
    {
        public int LessonId { get; set; }
        public Nullable<int> Student { get; set; }
        public Nullable<int> Lesson { get; set; }
        public Nullable<short> exam1 { get; set; }
        public Nullable<short> exam2 { get; set; }
        public Nullable<short> exam3 { get; set; }
        public Nullable<decimal> exam_averages { get; set; }
        public Nullable<bool> situation { get; set; }
    
        public virtual TBLLessons TBLLessons { get; set; }
        public virtual TBLStudent TBLStudent { get; set; }
    }
}