using System;
using System.Linq;
using System.Collections.Generic;
using App.Domain.DomainService;
using App.Domain.Model;
using App.Common.PhoneInfraServices;

namespace App.Common.ModelMVC
{
	public class RentModelMVC
	{
		ICategoryService service;

		IPhoneService phone;

		Category c;

		public RentModelMVC (string category, IPhoneService phone)
		{
			this.service = new CategoryService ();
			this.phone = phone;

			Init (service.Get(category));
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
				var feminin = new string [] { "001", "002", "003" }.Contains (c.Id);
				return string.Format(@"Vous avez sélectionné la location d'un{0} {1}, merci de compléter le formulaire suivant afin de faciliter la prise en charge de votre demande",
					feminin ? "e":" véhicule",
					c.Name
					);
			}
		}

		public int? Budget {
			get;
			set;
		}

		public DateTime Begin {
			get;
			set;
		}

		public DateTime End {
			get;
			set;
		}

		void Init (Category category)
		{
			this.c = category;
			Phone = phone == null ? null : phone.Number;
		}
	}
}

