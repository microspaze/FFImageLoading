using System;
using Xamvvm;
using System.Windows.Input;

namespace FFImageLoading.Forms.Sample
{
	public class PlaceholdersPageModel : BasePageModel
	{
		public PlaceholdersPageModel()
		{
			LoadingPlaceholderCommand = new BaseCommand((arg) =>
			{
				ImageUrl = Helpers.GetRandomImageUrl();
			});

			ErrorPlaceholderCommand = new BaseCommand((arg) =>
			{
				ImageUrl = "https://gastaticqn.gatime.cn/notexisting2.jpg";
			});
		}

		public ICommand LoadingPlaceholderCommand { get; set; }

		public ICommand ErrorPlaceholderCommand { get; set; }

		public string ImageUrl { get; set; } = Helpers.GetRandomImageUrl();
	}
}
