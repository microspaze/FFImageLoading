using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamvvm;
using System.Threading;
using System.IO;
using System.Threading.Tasks;

namespace FFImageLoading.Forms.Sample
{
    public class ByteArrayListPageModel : BasePageModel
    {
        public ByteArrayListPageModel()
        {
            ItemSelectedCommand = new BaseCommand<SelectedItemChangedEventArgs>((arg) =>
            {
                SelectedItem = null;
            });
        }

        public ListItem SelectedItem { get; set; }

        public ICommand ItemSelectedCommand { get; set; }

        public ObservableCollection<ListItem> Items { get; set; }

        public async void Reload()
        {
            var list = new List<ListItem>();

            string[] images = {
                "https://gastaticqn.gatime.cn/15806486058_7005d77438.jpg",
                "https://gastaticqn.gatime.cn/4308181244_5ac3f8239b.jpg",
                "https://gastaticqn.gatime.cn/8729135907_79599de8d8.jpg",
                "https://gastaticqn.gatime.cn/4058009019_ecf305f546.jpg",
                "https://gastaticqn.gatime.cn/14045101350_113edbe20b.jpg",
                "https://gastaticqn.gatime.cn/15620725287_3357e9db03.jpg",
                "https://gastaticqn.gatime.cn/8299022203_de0cb894b0.jpg",
                "https://gastaticqn.gatime.cn/10684479284_211f2a8b0f.jpg",
                "https://gastaticqn.gatime.cn/9308209014_ea8eac4387.jpg",
                "https://gastaticqn.gatime.cn/3096284216_8b2e8da102.jpg",
                "https://gastaticqn.gatime.cn/14949063062_a92fc5426f.jpg",
                "https://gastaticqn.gatime.cn/8349332314_e1ae376fd4.jpg",
                "https://gastaticqn.gatime.cn/2513217764_740fdd6afa.jpg",
                "https://gastaticqn.gatime.cn/5377978827_51d978d271.jpg",
                "https://gastaticqn.gatime.cn/3499605313_a9d43c1c83.jpg",
                "https://gastaticqn.gatime.cn/19438696_f103861437.jpg",
                "https://gastaticqn.gatime.cn/4963731276_a10e1bd520.jpg",
                "https://gastaticqn.gatime.cn/2814060518_6305796eb1.jpg",
                "https://gastaticqn.gatime.cn/14398989204_59f60a05c5.jpg",
                "https://gastaticqn.gatime.cn/3070391067_c80fb9e942.jpg"
            };

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < images.Length; i++)
                {
                    // Get your byte array here
                    byte[] byteArray;
                    var cacheStream = await ImageService.Instance.Config.DownloadCache.DownloadAndCacheIfNeededAsync(
                        images[i], ImageService.Instance.LoadUrl(images[i]), ImageService.Instance.Config, CancellationToken.None);

                    using (cacheStream.ImageStream)
                    using (var memoryStream = new MemoryStream())
                    {
                        await cacheStream.ImageStream.CopyToAsync(memoryStream);
                        byteArray = memoryStream.ToArray();
                    }

                    var item1 = new ListItem()
                    {
                        ImageSource = new CustomStreamImageSource() 
                        { 
                            Key = images[i], 
                            Stream = (token) => Task.FromResult<Stream>(new MemoryStream(byteArray)) 
                        },
                        FileName = string.Format("image{0}.jpeg", i + 1),
                    };
                    list.Add(item1);

                    var item2 = new ListItem()
                    {
                        ImageSource = new CustomStreamImageSource()
                        {
                            Key = images[i],
                            Stream = (token) => Task.FromResult<Stream>(new MemoryStream(byteArray))
                        },
                        FileName = string.Format("image{0}.jpeg", i + 1),
                    };
                    list.Add(item2);

                    var item3 = new ListItem()
                    {
                        ImageSource = new CustomStreamImageSource()
                        {
                            Key = images[i],
                            Stream = (token) => Task.FromResult<Stream>(new MemoryStream(byteArray))
                        },
                        FileName = string.Format("image{0}.jpeg", i + 1),
                    };
                    list.Add(item3);
                }
            }

            Items = new ObservableCollection<ListItem>(list);
        }

        public class CustomStreamImageSource : StreamImageSource
        {
            public string Key { get; set; }
        }

        public class ListItem : BaseModel
        {
            public ImageSource ImageSource { get; set; }

            public string FileName { get; set; }
        }
    }
}
