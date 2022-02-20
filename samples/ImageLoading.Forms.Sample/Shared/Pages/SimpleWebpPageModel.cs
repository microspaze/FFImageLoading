using System;
using Xamvvm;

namespace FFImageLoading.Forms.Sample
{
    public class SimpleWebpPageModel : BasePageModel
    {
		public void Reload()
		{
			ImageUrl = "https://gastaticqn.gatime.cn/1.sm.webp";
		}

		public string ImageUrl { get; set; }
    }
}
