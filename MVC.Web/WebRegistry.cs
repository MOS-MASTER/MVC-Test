using StructureMap.Configuration.DSL;
using CS.Data;
using CS.Services;

namespace CS.Web
{
    public class WebRegistry : Registry
    {
        protected override void configure()
        {
            ForRequestedType<ICategoryService>()
                .TheDefaultIsConcreteType<CategoryService>();

            ForRequestedType<IProductService>()
                .TheDefaultIsConcreteType<ProductService>();

            ForRequestedType<ICategoryRepository>()
                .TheDefaultIsConcreteType<SqlCategoryRepository>()
                .AsSingletons();

            ForRequestedType<IProductRepository>()
                .TheDefaultIsConcreteType<SqlProductRepository>()
                .AsSingletons();
        }
    }
}
