﻿namespace ECommerse.ViewModel
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }

		public int AvailableQuantity { get; set; }

		public double Price { get; set; }
	}
}
