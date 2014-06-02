using System;
using App.Domain.DomainService;
using App.Domain.Model;

namespace App.Common.ModelMVC
{
	public class CategoryModelMVC
	{
		ICategoryService service;
		Category c;

		public CategoryModelMVC (string categoryid) {
			service = new CategoryService (); 
			Init (service.Get(categoryid));
		}

		public CategoryModelMVC (App.Domain.Model.Category c)
		{
			service = new CategoryService (); 
			Init (c);
		}

		public CategoryModelMVC (string categoryid, ICategoryService service) {
			this.service = new CategoryService (); 
			Init (service.Get(categoryid));
		}

		public string Id {
			get {
				return c.Id;
			}
		}

		public string RentPage {
			get {
				return Tool.Box.Rent (Id);
			}
		}

		public string Name {
			get { 
				return c.Name;
			}
		}

		public string Description {
			get {
				return c.Description.Length > 25 
					? c.Description.Substring (0, 22) + "..."
						: c.Description;
			}
		}

		public string Explaination {
			get {
				return 
					@"Vous venez de sélectionner la location d'un{O} {1}, merci de compléter vos coordonnées afin";
			}
		}

		void Init (Category c)
		{
			this.c = c;
		}
	}
}

