using System.Collections;
using System.Collections.Generic;
using vega.Persistence;

namespace vega.Controllers
{
    public class FeaturesController
    {
        private readonly VegaDbContext context;
        public FeaturesController(VegaDbContext context)
        {
            this.context = context;
        }

    }
}