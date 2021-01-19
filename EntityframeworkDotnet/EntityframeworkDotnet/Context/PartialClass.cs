using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EntityframeworkDotnet.Context
{
    public class PartialClass
    {
        [MetadataType(typeof(FoodMetadata))]
        public partial class Food
        {

        }

        [MetadataType(typeof(categoryMetadata))]
        public partial class cacategory
        {

        }

        [MetadataType(typeof(sizeMetadata))]
        public partial class size
        {

        }
    }
}
