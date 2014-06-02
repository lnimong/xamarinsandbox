using System;
using App.Domain.Model;
using App.Domain.DomainService;

namespace App.Common.ModelMVC
{
	public class CarModelMVC
	{
		string id;

		ICarSearchService carService;

		public CarModelMVC (Car car)
		{
			Init (car);		
		}

		public CarModelMVC (string code)
		{
			carService = new CarSearchService ();
			Init (carService.GetCar (code));
		}

		public override string ToString ()
		{
			return string.Format ("{0}|{1}|{2}|{3}",
				this.BrandName,
				this.ModelName,
				this.Year,
				this.Distance);
		}

		public string DetailPage {
			get {
				return Tool.Box.Details (id);
			}

		}

		public string RentPage {
			get {
				return Tool.Box.Rent (id);
			}
		}

		public string BuyPage {
			get {
				return Tool.Box.Buy (id);
			}
		}

		public string ModelName {
			get;
			private set;
		}

		public string BrandName {
			get;
			private set;
		}

		public int Year {
			get;
			private set;
		}

		public string Description {
			get;
			private set;
		}

		public int Distance {
			get;
			private set;
		}

		void Init (Car car)
		{
			this.id = car.Id;
			BrandName = car.Brand;
			ModelName = car.Model;
			Year = car.Year;
			Distance = car.Distance;
			Description = car.Description;
		}
	}
}

