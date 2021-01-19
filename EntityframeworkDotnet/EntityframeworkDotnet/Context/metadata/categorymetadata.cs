using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityframeworkDotnet.Context.metadata
{
    public partial class categoryMetadata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categoryMetadata()
        {
            this.Foods = new HashSet<Food>();
        }

        public int id { get; set; }

        [Display(Name = "Catagory Name")]
        [Required(ErrorMessage = "Catagory Name cannot be blank")]
        public string catagory_name { get; set; }

        public bool isDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Food> Foods { get; set; }
    }
}