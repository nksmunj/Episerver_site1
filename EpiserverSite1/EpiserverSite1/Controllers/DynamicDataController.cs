using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpiserverSite1.Business;
using EPiServer.Data.Dynamic;
using EPiServer.Core;
using EPiServer.Data;

namespace EpiserverSite1.Controllers
{
    public class DynamicDataController : Controller
    {
        //This function creates a dynamic data store for reviews
        private DynamicDataStore _store
        {
            get { return DynamicDataStoreFactory.Instance.CreateStore(typeof(Review)); }
        }

        public static IEnumerable<Review> GetReview(ContentReference productPageReference)
        {
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Review));

            return store.Items<Review>().Where(x => x.RelatedReviewPage == productPageReference);
        }


        public Identity AddToStore(PageData page)
        {
            var propertyBag = new PropertyBag();

            propertyBag.Add("PageId", page.WorkPageID);
            propertyBag.Add("PageName", page.PageName);

            var store = DynamicDataStoreFactory.Instance.CreateStore("PageStore", propertyBag.GenerateTypeBag());

            return store.Save(propertyBag);
        }

        // GET: DynamicData
        public ActionResult Index()
        {
            Review reviewobj=new Review();
            reviewobj.PostedBy = "Admin";
            reviewobj.ReviewDescription = "Admin review";
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Review));
            store.Save(reviewobj);
            return View();
        }

        public void GetPageData(int pageID)
        {
            var store = (DynamicDataStore)DynamicDataStoreFactory.Instance.GetStore("PageStore");

            if (store != null)
            {
                var pageProperties = store.FindAsPropertyBag("PageId", pageID);

                if (pageProperties != null)
                {
                    foreach (var item in pageProperties)
                    {
                        var pageName = item["PageName"] as string ?? string.Empty;
                        var pageId = item["PageId"] as string ?? string.Empty;
                    }
                }
            }
        }
    }
}