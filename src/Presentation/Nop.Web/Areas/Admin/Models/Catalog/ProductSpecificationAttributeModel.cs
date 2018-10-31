using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product specification attribute model
    /// </summary>
    public partial class ProductSpecificationAttributeModel : BaseNopEntityModel
    {
        #region Properties

        public int AttributeTypeId { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AttributeType")]
        public string AttributeTypeName { get; set; }

        public int AttributeId { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttribute")]
        public string AttributeName { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.CustomValue")]
        public string ValueRaw { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AllowFiltering")]
        public bool AllowFiltering { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.ShowOnProductPage")]
        public bool ShowOnProductPage { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttributeOption")]
        public int SpecificationAttributeOptionId { get; set; }

        #endregion
    }
}