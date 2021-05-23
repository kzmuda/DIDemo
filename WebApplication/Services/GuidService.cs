using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Services
{
    public class GuidService: IGuidService
    {
        private string guid;

        public GuidService()
        {
            this.guid = Guid.NewGuid().ToString();
        }

        public string Get()
        {
            return this.guid;
        }
    }
}
