using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    public class Brand : ICar
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; }
    }
}
