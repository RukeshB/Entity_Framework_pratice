using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EntityframeworkDotnet.Context.metadata
{
    public partial class FoodMetadata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodMetadata()
        {
            this.sizes = new HashSet<size>();
        }

        public int id { get; set; }

        [Display(Name = "Food Name")]
        [Required(ErrorMessage = "Food Name cannot be blank")]
        [MinLength(3)]
        public string name { get; set; }

        [Display(Name = "Catagory")]
        [Required(ErrorMessage = "Catagory cannot be blank")]
        public int catagory_id { get; set; }

        public bool isDeleted { get; set; }

        public virtual category category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<size> sizes { get; set; }
    }

    
}