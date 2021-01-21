using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EntityframeworkDotnet.Context.metadata;

namespace EntityframeworkDotnet.Context
{
    [MetadataType(typeof(FoodMetadata))]
    public partial class Food
    {

    }

    [MetadataType(typeof(categoryMetadata))]
    public partial class category
    {

    }

    [MetadataType(typeof(sizeMetadata))]
    public partial class size
    {

    }
}
