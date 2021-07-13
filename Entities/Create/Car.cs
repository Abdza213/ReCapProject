using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{       //  Id, BrandId, ColorId, ModelYear, DailyPrice, Description
    public class Car : ICar
    {
        public int CarId { get; set; }

        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public string ColorId { get; set; }

        public string ModelYear { get; set; }

        public decimal DailyPrice { get; set; }

        public string  Description { get; set; }
    }
}
