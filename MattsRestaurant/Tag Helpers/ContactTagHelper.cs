using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.Tag_Helpers
{
    public class ContactTagHelper : TagHelper 
    {
        public string Address { get; set; }
        public string Content { get; set; }
        public int phoneNumber { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var tagStyle = new TagHelperAttribute("class", "contact");
            output.TagName = "a";
            output.Attributes.Add(tagStyle);
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            output.Content.SetContent(Content);
            
        }
    }
}
