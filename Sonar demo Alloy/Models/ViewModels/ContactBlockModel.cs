using System.Web;
using System.ComponentModel.DataAnnotations;
using Sonar_demo_Alloy.Models.Pages;
using EPiServer.Web;
using EPiServer.Core;

namespace Sonar_demo_Alloy.Models.ViewModels
{
    public class ContactBlockModel
    {
        [UIHint(UIHint.Image)]
        public ContentReference Image { get; set; }
        public string Heading { get; set; }
        public string LinkText { get; set; }
        public IHtmlString LinkUrl { get; set; }
        public bool ShowLink { get; set; }
        public ContactPage ContactPage { get; set; }
    }
}
