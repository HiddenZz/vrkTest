using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.data;
using WpfApp1.models;

namespace WpfApp1.repository
{
    internal class dataSources
    {
        public List<ProductModel> getAllProducts()
        {
            return Entity.db.Product.Select(p => new ProductModel(
                p.ID, 
                p.Title,
                p.ProductTypeID,
                p.ArticleNumber,
                p.Description,
                p.Image, 
                p.ProductionPersonCount??0,
                p.ProductionWorkshopNumber??0, 
                decimal.ToDouble(p.MinCostForAgent)
                )).ToList();
                }

    }
}
