using System.Collections.Generic;
using vega.Models;

namespace vega.Controllers.Resources
{
    public class FeatureResources
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}