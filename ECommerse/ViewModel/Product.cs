using System.Collections.Generic;

namespace ECommerse.ViewModel
{
	public class Product
	{
		public int Id { get; set; }

		public bool IsDiscounted { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }

		public int AvailableQuantity { get; set; }

		public double MarketPrice { get; set; }

		public double DiscountedPrice { get; set; }

		public string Images { get; set; }

		public List<string> AboutTheItem { get; set; }

		public bool ReturnReplacement { get; set; }

	}

	//public class ReturnReplacement
	//{
	//	public bool ReturnAvailable { get; set;}

	//	public bool ReplacementAvailable { get; set; }
	//}

	//public class Images
	//{
	//	public List<ThumbnailImages> Small { get; set; }

	//	public List<ThumbnailImages> Medium { get; set; }

	//	public List<ThumbnailImages> Large { get; set; }
	//}

	//public class ThumbnailImages
	//{
	//	public int Id { get; set; }

	//	public string URL { get; set; }

	//	public string Width { get; set; }

	//	public string Height { get; set; }

	//	public ImageSize ImageSize { get; set; }
	//}

	//public enum ImageSize
	//{
	//	Small,
	//	Medium,
	//	Large
	//}
}
