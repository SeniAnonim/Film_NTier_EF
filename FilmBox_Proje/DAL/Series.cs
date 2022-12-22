//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Series
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Series()
        {
            this.SeriesActorDetails = new HashSet<SeriesActorDetail>();
            this.SeriesCategoryDetails = new HashSet<SeriesCategoryDetail>();
            this.SeriesCustomerDetails = new HashSet<SeriesCustomerDetail>();
            this.SeriesDirectorDetails = new HashSet<SeriesDirectorDetail>();
        }
    
        public int SeriesId { get; set; }
        public string SeriesName { get; set; }
        public int Views { get; set; }
        public Nullable<int> Vote { get; set; }
        public decimal SeriesDuration { get; set; }
        public Nullable<System.DateTime> DateOfConstruction { get; set; }
        public string Language { get; set; }
        public Nullable<decimal> SeriesEndorsement { get; set; }
        public bool Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeriesActorDetail> SeriesActorDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeriesCategoryDetail> SeriesCategoryDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeriesCustomerDetail> SeriesCustomerDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeriesDirectorDetail> SeriesDirectorDetails { get; set; }
    }
}