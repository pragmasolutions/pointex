//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointEx.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SliderImage
    {
        public SliderImage()
        {
            this.SectionItems = new HashSet<SectionItem>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int FileId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual File File { get; set; }
        public virtual ICollection<SectionItem> SectionItems { get; set; }
    }
}
