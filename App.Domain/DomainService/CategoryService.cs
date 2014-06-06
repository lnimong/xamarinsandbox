using System;
using System.Linq;
using System.Collections.Generic;
using App.Domain.Model;

namespace App.Domain.DomainService
{
	public interface ICategoryService
	{
		IEnumerable<Category> All();
		Category Get(string code);
	}

	public class CategoryService : ICategoryService
	{
		Category[] all;

		public CategoryService ()
		{
			this.all = new Category[] {
				new Category() {
					Id = "001",
					Name = "Citadine",
					Description = "de type Renault Clio Business  | Opel Corsa Business Connect | Kia Rio"
				},
				new Category() {
					Id = "002",
					Name = "Berline Compacte",
					Description = "de type Renault Captur Intens | Renault Megane berline | BMW Série 1 Business | Mercedes Classe A  Business"
				},
				new Category() {
					Id = "003",
					Name = "Berline Familiale",
					Description = "de type Citroen DS4  Executive | Ford Mondéo berline et break  Business Nav | Volvo V40 Momentum Business "
				},
				new Category() {
					Id = "004",
					Name = "Monospace 5/7 places",
					Description = "de type Ford GD C-max Business Nav | Toyota Verso Business | Mercedes GLA Business"
				},
				new Category() {
					Id = "005",
					Name = "Premium",
					Description = "de type Mercedes Classe C et CLA Business | BMW série 3 | BMW X1 Business"
				},
				new Category() {
					Id = "006",
					Name = "Premium superieur",
					Description = "de type Mercedes Classe E Avantgarde | BMW Série 5 | BMW X3 Business | Volvo XC60 Momentum Business "
				}
			};
		}

		public IEnumerable<Category> All()
		{
			return all;
		}

		public Category Get(string code) 
		{
			return all.FirstOrDefault (c => c.Id == code);
		}
	}
}

