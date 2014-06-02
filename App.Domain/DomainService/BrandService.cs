using System;
using System.Collections.Generic;
using App.Domain.Model;

namespace App.Domain.DomainService
{

	public interface IBrandService
	{
		IEnumerable<Product> GetModels (Brand selectedBrand);

		IEnumerable<Brand> Brands ();
	}

	public class BrandService : IBrandService
	{
		public BrandService ()
		{
		}

		public IEnumerable<Brand> Brands () 
		{
			throw new NotImplementedException ();
		}

		public IEnumerable<Product> GetModels (Brand selectedBrand)
		{
			throw new NotImplementedException ();
		}


	}
}

