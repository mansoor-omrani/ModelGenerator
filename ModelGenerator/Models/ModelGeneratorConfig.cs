using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.Models
{
    public class ModelGeneratorConfig
    {
        public string Namespace { get; set; }
        public List<ModelConfig> Models { get; set; }
    }
}
