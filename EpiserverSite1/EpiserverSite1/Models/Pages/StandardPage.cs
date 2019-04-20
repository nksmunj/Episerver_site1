﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "eda7e835-8fd5-40be-ba0c-827d1fcc2ad1", Description = "")]
    public class StandardPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The Page Heading",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}