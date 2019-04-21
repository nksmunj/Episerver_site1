using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiserverSite1.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "5bf87c54-4f05-4aa8-ac94-6afd86a2ffaa", Description = "")]    
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData
    {
        //// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        public virtual string Copyright { get; set; }

        public virtual String Description { get; set; }
    }
}