using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityframeworkDotnet.Context.metadata
{
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