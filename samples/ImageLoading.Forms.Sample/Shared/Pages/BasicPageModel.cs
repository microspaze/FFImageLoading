using System;
using Xamvvm;

namespace FFImageLoading.Forms.Sample
{
    
    public class BasicPageModel : BasePageModel
    {
        public void Reload()
        {
            // ImageUrl = Helpers.GetRandomImageUrl();
            ImageUrl = @"https://gastaticqn.gatime.cn/Landscape_3.jpg";
        }

        public string ImageUrl { get; set; }
    }
}
