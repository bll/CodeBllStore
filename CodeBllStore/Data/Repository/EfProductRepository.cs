using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBllStore.Models;
using CodeBllStore.Data.Context;

namespace CodeBllStore.Data.Repository
{
    public class EFProductRepository : IProductRepository
    {
        private CodeBllContext context;
        public EFProductRepository(CodeBllContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Product> Products => context.Products;

    }
}
