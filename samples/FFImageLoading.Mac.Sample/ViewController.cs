using System;

using AppKit;
using Foundation;

namespace FFImageLoading.Mac.Sample
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var imageView = new NSImageView
            {
                Frame = this.View.Bounds,
            };
            this.View.AddSubview(imageView);
            ImageService.Instance.LoadUrl("https://gastaticqn.gatime.cn/Landscape_3.jpg").Into(imageView);
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
