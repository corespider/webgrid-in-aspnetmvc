using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using XML_WebGrid_aspnetmvc.Models;
namespace XML_WebGrid_aspnetmvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>();

            //Load the XML file in XmlDocument.
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("~/customer.xml"));

            //Loop through the selected Nodes.
            foreach (XmlNode node in doc.SelectNodes("/CustomerDetails/customer"))
            {
                //Fetch the Node values and assign it to Model.
                customers.Add(new Customer
                {
                    customerId = int.Parse(node["customer_id"].InnerText),
                    firstName = node["first_name"].InnerText,
                    lastName = node["last_name"].InnerText,
                    email = node["email"].InnerText,
                    street = node["street"].InnerText,
                    city = node["city"].InnerText,
                    state = node["state"].InnerText,
                    zipCode = node["zip_code"].InnerText,
                });
            }
            return View(customers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}