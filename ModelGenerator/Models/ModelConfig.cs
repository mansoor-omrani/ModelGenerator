using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.Models
{
    public class ModelConfig
    {
        public string Namespace { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
        public List<ModelPropertyConfig> Properties { get; set; }
    }
}
