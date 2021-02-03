using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        
        //brand-marka
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        //dailyprice- günlük fiyatı
        public double DailyPrice { get; set; }
        public string Description { get; set; }


    }
}
