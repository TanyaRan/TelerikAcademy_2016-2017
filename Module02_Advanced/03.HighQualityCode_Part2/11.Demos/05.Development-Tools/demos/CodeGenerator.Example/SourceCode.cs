//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeGenerator.Example
{
    using System;
    using System.Collections.Generic;
    
    public partial class SourceCode
    {
        public int Id { get; set; }
        public string AuthorId { get; set; }
        public Nullable<int> ProblemId { get; set; }
        public byte[] Content { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Problem Problem { get; set; }
    }
}
