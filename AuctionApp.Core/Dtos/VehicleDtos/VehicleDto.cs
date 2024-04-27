using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApp.Core.Dtos.VehicleDtos
{
	public class VehicleDto
	{
        public int Id { get; set; }
        public string BrandAndModel { get; set; }
		public int ManufacturingYear { get; set; }
		public string Color { get; set; }
		public decimal EngineCapacity { get; set; }
		public decimal Price { get; set; }

		public int Millage { get; set; }

		public string PlateNumber { get; set; }
		public double ActionPrice { get; set; }
		public string AdditionalInformation { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }

		public bool IsActive { get; set; }
		public string Image { get; set; }

		public string SellerId { get; set; }
	}
}
