using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrchardCore.Modules;

namespace OrchardCore.Settings.ViewModels
{
    public class SiteSettingsViewModel
    {
        public string SiteName { get; set; }
        public string BaseUrl { get; set; }
        public string TimeZone { get; set; }
        public ITimeZone[] TimeZones { get; set; }
    }
}
