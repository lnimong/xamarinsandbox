using System;
using System.Linq;
using System.Collections.Generic;
using App.Domain.DomainService;
using App.Domain.Model;
using App.Common.ModelMVC;

namespace App.Common.ModelMVC
{
	public class CarListModelMVC
	{
		ICarSearchService carService;

		public CarListModelMVC ()
		{
			this.carService = new CarSearchService ();

			Init ();
		}

		public CarListModelMVC (ICarSearchService carService)
		{
			Init ();
		}

		public IEnumerable<CarModelMVC> Cars {
			get;
			private set;
		}

		public void Search (string request) {
			var cars = carService.Search (request);
			Cars = this.Map (cars);
		}

		IEnumerable<CarModelMVC> Map (IEnumerable<Car> cars)
		{
			return cars.Select(c => new CarModelMVC(c));
		}

		void Init () {
			var cars = carService.Search ();
			Cars = this.Map (cars);
		}

	}
}

