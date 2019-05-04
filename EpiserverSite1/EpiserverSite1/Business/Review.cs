using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Data.Dynamic;
using EPiServer.Data;
using EPiServer.Core;

namespace EpiserverSite1.Business
{
    public class Review: IDynamicData
    {
        public Identity Id { get; set; }

        public string PostedBy { get; set; }

        public string ReviewDescription { get; set; }

        public ContentReference RelatedReviewPage { get; set; }
    }
}