using System;
using System.Linq;
using System.Collections.Generic;
using App.Domain.DomainService;
using App.Domain.Model;
using App.Common.PhoneInfraServices;

namespace App.Common.ModelMVC
{
	public class BuyModelMVC
	{
		CarSearchService service;

		Car c;

		IPhoneService phone;

		public BuyModelMVC (string car, IPhoneService phone)
		{
			this.service = new CarSearchService ();
			this.phone = phone;

			Init (service.GetCar(car));
		}

		public string FirstName {
			get;
			set;
		}

		public string LastName {
			get;
			set;
		}

		public string ZipCode {
			get;
			set;
		}

		public string Phone {
			get;
			set;
		}

		public string Explain {
			get {
				return string.Format(@"Vous avez sélectionné la {0} {1}, cette voiture est à moteur {2} de {3} ayant déjà roulé {4} km environ. Merci de compléter le formulaire suivant afin de faciliter la prise en charge de votre demande",
					c.Brand,
					c.Model,
					"Essence",
					c.Year,
					c.Distance
				);
			}
		}

		public int? Budget {
			get;
			set;
		}


		void Init (Car car)
		{
			this.c = car;
			Phone = phone == null ? null : phone.Number;
		}
	}
}

