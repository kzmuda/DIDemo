using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Services
{
    public class GuidWrapper2: IGuidWrapper2
    {
        private IGuidService service;

        public GuidWrapper2(IGuidService service)
        {
            this.service = service;
        }

        public string GetGuid()
        {
            return service.Get();
        }
    }
}
