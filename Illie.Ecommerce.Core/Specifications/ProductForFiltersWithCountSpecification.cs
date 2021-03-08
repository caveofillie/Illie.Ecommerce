using Illie.Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Illie.Ecommerce.Core.Specifications
{
    public class ProductForFiltersWithCountSpecification : BaseSpecification<Product>
    {
        public ProductForFiltersWithCountSpecification(ProductSpecParams productParams)
            : base(x =>
                (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower()
                .Contains(productParams.Search)) &&
                (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
                (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
            )
        {

        }
    }
}
