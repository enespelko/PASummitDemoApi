using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;

namespace PASummitDemoApi.Controllers
{
    public class ConfigurationController : ApiController
    {
        // GET: api/Configuration
        public IEnumerable<string> Get()
        {
			return new string[] {
				$"App Conifg Value: {ConfigurationManager.AppSettings["AppValue"]}",
				$"Slot Config Value: {ConfigurationManager.AppSettings["SlotValue"]}",
				$"Version v1"
			};
		}        
    }
}
