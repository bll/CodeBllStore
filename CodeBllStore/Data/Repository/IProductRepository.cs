using CodeBllStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBllStore.Data.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
