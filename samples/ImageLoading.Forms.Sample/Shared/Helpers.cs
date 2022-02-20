﻿using System;
using System.Collections.Generic;

namespace FFImageLoading.Forms.Sample
{
    public static class Helpers
    {
		private static bool _useLorem = false;
		private static Random _random = new Random();

        public static string GetImageUrl(int key, int width = 600, int height = 600)
        {
			return _useLorem ? GetLoremImageUrl(key.ToString(), width, height) : GetStaticImageUrl(key);
        }

		public static string GetRandomImageUrl(int width = 600, int height = 600)
		{
			return _useLorem ? GetLoremImageUrl(Guid.NewGuid().ToString(), width, height) : GetStaticImageUrl(_random.Next(1000));
		}

		public static string GetLoremImageUrl(string key, int width = 600, int height = 600)
		{
			return $"https://loremflickr.com/{width}/{height}/nature?random={key}";
		}

		public static string GetStaticImageUrl(int key)
		{
			var index = key % Images.Count;
			return Images[index];
		}

		public static List<string> Images = new List<string>
		{
			"https://gastaticqn.gatime.cn/photo.jpg",
			"https://gastaticqn.gatime.cn/xh_DSC1193.jpg",
			"https://gastaticqn.gatime.cn/BARROCK.jpg",
			"https://gastaticqn.gatime.cn/photo.jpg",
			"https://gastaticqn.gatime.cn/4653925_xxl.jpg",
			"https://gastaticqn.gatime.cn/5844139_xxl.jpg",
			"https://gastaticqn.gatime.cn/2464798_xxl.jpg",
			"https://gastaticqn.gatime.cn/4372660_xl.jpg",
			"https://gastaticqn.gatime.cn/8519921_xxl.jpg",
			"https://gastaticqn.gatime.cn/3957599_xl.jpg",
			"https://gastaticqn.gatime.cn/glass skycraper.jpg",
			"https://gastaticqn.gatime.cn/5690707_xl.jpg",
			"https://gastaticqn.gatime.cn/6533324_xl.jpg",
			"https://gastaticqn.gatime.cn/7325232_l.jpg",
			"https://gastaticqn.gatime.cn/8159403_l.jpg",
			"https://gastaticqn.gatime.cn/3244738_xxl.jpg",
			"https://gastaticqn.gatime.cn/8534465_xxl.jpg",
			"https://gastaticqn.gatime.cn/7955764_xxl.jpg",
			"https://gastaticqn.gatime.cn/3244736_xxl.jpg",
			"https://gastaticqn.gatime.cn/1291207_xl.jpg",
			"https://gastaticqn.gatime.cn/6120392_xxl.jpg",
			"https://gastaticqn.gatime.cn/5914539_xl.jpg",
			"https://gastaticqn.gatime.cn/8026562_xl.jpg",
			"https://gastaticqn.gatime.cn/3919626_l.jpg",
			"https://gastaticqn.gatime.cn/10175099_xl.jpg",
			"https://gastaticqn.gatime.cn/4857011_xxl.jpg",
			"https://gastaticqn.gatime.cn/7593140_xxl.jpg",
			"https://gastaticqn.gatime.cn/4468492.jpg",
			"https://gastaticqn.gatime.cn/9586539_xxl.jpg",
			"https://gastaticqn.gatime.cn/6606763_xxl.jpg",
			"https://gastaticqn.gatime.cn/4431447_xl.jpg",
			"https://gastaticqn.gatime.cn/9566533_xl.jpg",
			"https://gastaticqn.gatime.cn/3340706_xxl.jpg",
			"https://gastaticqn.gatime.cn/9448558_xxl.jpg",
			"https://gastaticqn.gatime.cn/7638344_xl.jpg",
			"https://gastaticqn.gatime.cn/12997602_xl.jpg",
			"https://gastaticqn.gatime.cn/12803137_xxl.jpg",
			"https://gastaticqn.gatime.cn/9717604_xl.jpg",
			"https://gastaticqn.gatime.cn/4991384_xl.jpg",
			"https://gastaticqn.gatime.cn/6253346_xxl.jpg",
			"https://gastaticqn.gatime.cn/light.jpg",
			"https://gastaticqn.gatime.cn/13659470_xl.jpg",
			"https://gastaticqn.gatime.cn/4431443_xl.jpg",
			"https://gastaticqn.gatime.cn/4404867_xl.jpg",
			"https://gastaticqn.gatime.cn/6712892_l.jpg",
			"https://gastaticqn.gatime.cn/8165173_xl.jpg",
			"https://gastaticqn.gatime.cn/5990120_xl.jpg",
			"https://gastaticqn.gatime.cn/8784811_xl.jpg",
			"https://gastaticqn.gatime.cn/4431440_xl.jpg",
			"https://gastaticqn.gatime.cn/9266120_xl.jpg",
			"https://gastaticqn.gatime.cn/739501_xl.jpg",
			"https://gastaticqn.gatime.cn/8825603_xxl.jpg",
			"https://gastaticqn.gatime.cn/5881376_xl.jpg",
			"https://gastaticqn.gatime.cn/6410112_xl.jpg",
			"https://gastaticqn.gatime.cn/5913500_l.jpg",
			"https://gastaticqn.gatime.cn/5141027_xl.jpg",
			"https://gastaticqn.gatime.cn/8823717_xl.jpg",
			"https://gastaticqn.gatime.cn/Calendar_Icon.jpg",
			"https://gastaticqn.gatime.cn/5078256_xxl.jpg",
			"https://gastaticqn.gatime.cn/5288016_xxl.jpg",
			"https://gastaticqn.gatime.cn/7815172_xl.jpg",
			"https://gastaticqn.gatime.cn/7322971_xl.jpg",
			"https://gastaticqn.gatime.cn/7776812_xl.jpg",
			"https://gastaticqn.gatime.cn/7293022_xl.jpg",
			"https://gastaticqn.gatime.cn/7630040_xxl.jpg",
			"https://gastaticqn.gatime.cn/9109180_xl.jpg",
			"https://gastaticqn.gatime.cn/7772004_l.jpg",
			"https://gastaticqn.gatime.cn/13710590_xl.jpg",
			"https://gastaticqn.gatime.cn/4_ZHVibHlhMTAuanBn.jpg",
			"https://gastaticqn.gatime.cn/6516975_xl.jpg",
			"https://gastaticqn.gatime.cn/15180498_xxl.jpg",
			"https://gastaticqn.gatime.cn/4174831_l.jpg",
			"https://gastaticqn.gatime.cn/11653740_xl.jpg",
			"https://gastaticqn.gatime.cn/299011_xl.jpg",
			"https://gastaticqn.gatime.cn/2562812_xl.jpg",
			"https://gastaticqn.gatime.cn/6286346_xl.jpg",
			"https://gastaticqn.gatime.cn/13097271_xl.jpg",
			"https://gastaticqn.gatime.cn/6670302_xxl.jpg",
			"https://gastaticqn.gatime.cn/4864431_xxl.jpg",
			"https://gastaticqn.gatime.cn/8094101_xl.jpg",
			"https://gastaticqn.gatime.cn/5324611_xl.jpg",
			"https://gastaticqn.gatime.cn/glasses_icons_gray.jpg",
			"https://gastaticqn.gatime.cn/6851391_xl.jpg",
			"https://gastaticqn.gatime.cn/15901142_xl.jpg",
			"https://gastaticqn.gatime.cn/2472099_l.jpg",
			"https://gastaticqn.gatime.cn/2861579_xl.jpg",
			"https://gastaticqn.gatime.cn/6943958_xl.jpg",
			"https://gastaticqn.gatime.cn/7880789_xl.jpg",
			"https://gastaticqn.gatime.cn/7413213_xl.jpg",
			"https://gastaticqn.gatime.cn/6487553_xl.jpg",
			"https://gastaticqn.gatime.cn/8125235_xl.jpg",
			"https://gastaticqn.gatime.cn/7276936_xl.jpg",
			"https://gastaticqn.gatime.cn/7246508_xl.jpg",
			"https://gastaticqn.gatime.cn/7582562_xl.jpg",
			"https://gastaticqn.gatime.cn/5167230_xxl.jpg",
			"https://gastaticqn.gatime.cn/7796801_l.jpg",
			"https://gastaticqn.gatime.cn/6298740_xl.jpg",
			"https://gastaticqn.gatime.cn/5532389_xl.jpg",
			"https://gastaticqn.gatime.cn/Depositphotos_30311295_original.jpg",
			"https://gastaticqn.gatime.cn/7684832_xl.jpg",
			"https://gastaticqn.gatime.cn/9091556_xl.jpg",
			"https://gastaticqn.gatime.cn/3521693_xl.jpg",
			"https://gastaticqn.gatime.cn/8164556_xl.jpg",
			"https://gastaticqn.gatime.cn/9991943_xl.jpg",
			"https://gastaticqn.gatime.cn/5408120_xl.jpg",
			"https://gastaticqn.gatime.cn/7778069_xxl.jpg",
			"https://gastaticqn.gatime.cn/2455589_xxl.jpg",
			"https://gastaticqn.gatime.cn/5988751_l.jpg",
			"https://gastaticqn.gatime.cn/6070995_xxl.jpg",
			"https://gastaticqn.gatime.cn/6314231_xxl.jpg",
			"https://gastaticqn.gatime.cn/5315415_xl.jpg",
			"https://gastaticqn.gatime.cn/4627413_xl.jpg",
			"https://gastaticqn.gatime.cn/5191295_xl.jpg",
			"https://gastaticqn.gatime.cn/6444113_l.jpg",
			"https://gastaticqn.gatime.cn/6847780_xl.jpg",
			"https://gastaticqn.gatime.cn/8141536_xxl.jpg",
			"https://gastaticqn.gatime.cn/5128844_xl.jpg",
			"https://gastaticqn.gatime.cn/9034424_xl.jpg",
			"https://gastaticqn.gatime.cn/4431446_xl.jpg",
			"https://gastaticqn.gatime.cn/7262833_xl.jpg",
			"https://gastaticqn.gatime.cn/6110371_xl.jpg",
			"https://gastaticqn.gatime.cn/6233286_xl.jpg",
			"https://gastaticqn.gatime.cn/8084531_l.jpg",
			"https://gastaticqn.gatime.cn/7240772_xl.jpg",
			"https://gastaticqn.gatime.cn/7980818_xl.jpg",
			"https://gastaticqn.gatime.cn/6168959_xl.jpg",
			"https://gastaticqn.gatime.cn/7316848_l.jpg",
			"https://gastaticqn.gatime.cn/7651472_xl.jpg",
			"https://gastaticqn.gatime.cn/5718377_xl.jpg",
			"https://gastaticqn.gatime.cn/6811139_xl.jpg",
			"https://gastaticqn.gatime.cn/7220249_xl.jpg",
			"https://gastaticqn.gatime.cn/8169654_xl.jpg",
			"https://gastaticqn.gatime.cn/6480947_xl.jpg",
			"https://gastaticqn.gatime.cn/6666662_xl.jpg",
		};
	}
}
