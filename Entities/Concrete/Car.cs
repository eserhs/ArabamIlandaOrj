using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int BrandCategoryId { get; set; }
        public int ImageId { get; set; }
        public int ChassisTypeId { get; set; }
        public int FuelTypeId { get; set; }
        public int GearTypeId { get; set; }
        public int CustomerId { get; set; }
        public int CityId { get; set; }
        public int CityDetailId { get; set; }
        public string Description { get; set; }
        public string Mileage{ get; set; }
        public DateTime ListingDate { get; set; }
        public DateTime ModelYear { get; set; }







    }
}
