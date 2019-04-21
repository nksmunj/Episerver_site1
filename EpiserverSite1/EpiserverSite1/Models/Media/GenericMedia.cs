using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiserverSite1.Models.Media
{
    [ContentType(DisplayName = "GenericMedia", GUID = "6a9d4bf2-22ca-4c8b-9f99-bcf72891a3c3", Description = "")]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx,png,jpeg,jpg")]
    public class GenericMedia : MediaData
    {

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "Description field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }

    }
}