using System;
using System.Linq;
using System.Collections.Generic;
using App.Domain.DomainService;

namespace App.Common.ModelMVC
{
	public class CategoryListModelMVC
	{
		ICategoryService categoryService;

		public CategoryListModelMVC ()
		{
			categoryService = new CategoryService ();
			Init ();
		}

		public CategoryListModelMVC (ICategoryService service)
		{
			categoryService = service;
			Init ();
		}

		public IEnumerable<CategoryModelMVC> Categories {
			get;
			private set;
		}

		void Init ()
		{
			Categories = Map(categoryService.All ());
		}

		IEnumerable<CategoryModelMVC> Map (IEnumerable<App.Domain.Model.Category> categories)
		{
			return categories.Select (c => new CategoryModelMVC (c));
		}
	}
}

