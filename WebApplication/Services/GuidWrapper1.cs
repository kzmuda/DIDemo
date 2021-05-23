using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Services
{
    public class GuidWrapper1: IGuidWrapper1
    {
        private IGuidService service;

        public GuidWrapper1(IGuidService service)
        {
            this.service = service;
        }

        public string GetGuid()
        {
            return service.Get();
        }
    }
}
