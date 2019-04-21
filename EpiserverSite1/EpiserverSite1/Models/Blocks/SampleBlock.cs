using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSite1.Models.Blocks
{
    [ContentType(DisplayName = "SampleBlock", GUID = "6649a891-08c5-49fe-bc2c-b86f83e5cc97", Description = "")]
    public class SampleBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Image",
            Description = "Add an image",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentReference Image { get; set; }

    }
}