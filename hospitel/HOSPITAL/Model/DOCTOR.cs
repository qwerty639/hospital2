//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOSPITAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DOCTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCTOR()
        {
            this.THERAPY = new HashSet<THERAPY>();
        }
    
        public int Id { get; set; }
        public string Doctorname { get; set; }
        public string Post { get; set; }
        public int Idskill { get; set; }
        public int Idspecialization { get; set; }
    
        public virtual SKILLTABLE SKILLTABLE { get; set; }
        public virtual SPECIALIZATIONTABLE SPECIALIZATIONTABLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THERAPY> THERAPY { get; set; }
    }
}
