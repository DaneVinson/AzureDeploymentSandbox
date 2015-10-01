using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AlphaWebApi.Controllers
{
    public class AlphaController : ApiController
    {
        private static readonly Version ControllerVersion = new Version(1, 0, 0, 0);

        public string GetMessage()
        {
            return $"{this.GetType().Name} version {ControllerVersion}";
        }
    }
}
