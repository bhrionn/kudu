﻿using System.Collections.Generic;
namespace Kudu.SiteManagement
{
    public class Site
    {
        public string ServiceUrl { get; set; }
        public string SiteUrl { get; set; }
        public List<string> SiteUrls { get; set; }
        public string DevSiteUrl { get; set; }
    }
}