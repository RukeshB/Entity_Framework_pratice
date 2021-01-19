using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EntityframeworkDotnet.Context
{
    using System;
    using System.Collections.Generic;

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

    public partial class sizeMetadata
    {
        public int id { get; set; }

        [Display(Name = "Food Id")]
        public int food_id { get; set; }

        [Display(Name = "Size")]
        public string size1 { get; set; }

        [Display(Name = "Price")]
        public int price { get; set; }
        public bool isDeleted { get; set; }

        public virtual Food Food { get; set; }
    }
}
