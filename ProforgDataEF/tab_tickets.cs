//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProforgDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tab_tickets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tab_tickets()
        {
            this.tab_order = new HashSet<tab_order>();
        }
    
        public int ticket_ID { get; set; }
        public int ticket_prise { get; set; }
        public int ticket_type_ID { get; set; }
        public int ticket_count { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tab_order> tab_order { get; set; }
        public virtual tab_tickets tab_tickets1 { get; set; }
        public virtual tab_tickets tab_tickets2 { get; set; }
        public virtual ticket_type ticket_type { get; set; }
    }
}
