using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.models
{
    internal class ProductModel
    {

        public ProductModel(int id, string title,  int? productTypeID, string articleNumber
            , string description, string image, int productPersonCount, int productWorkshopNumber, double minCostForAgent
            )
        {
            this.id = id;
            this.title = title;
            this.productTypeID = productTypeID??0;
                this.articleNumber = articleNumber;
            this.description = description;
            this.image = image;
            this.productPersonCount = productPersonCount;
            this.productWorkshopNumber = productWorkshopNumber;
            this.minCostForAgent = minCostForAgent;
        }

  
        private int id { get; set; }

        private string title  { get; set; }

        private int productTypeID { get; set; }

        private string articleNumber { get; set; }


        private string description { get; set; }


        private string image { get; set; }

        private int productPersonCount { get; set; }



        private int productWorkshopNumber { get; set; }

        private double minCostForAgent { get; set; }

        
    }
}
