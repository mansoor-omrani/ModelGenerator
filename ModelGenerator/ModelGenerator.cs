using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelGenerator.Models;
using Newtonsoft.Json;
using RazorEngine;
using RazorEngine.Templating;

namespace ModelGenerator
{
    public class DefaultModelGenerator
    {
        public ModelGeneratorConfig Config { get; private set; }
        public void Load(string filename)
        {
            var content = File.ReadAllText(filename);

            Config = JsonConvert.DeserializeObject<ModelGeneratorConfig>(content);

            foreach (var model in Config.Models)
            {
                if (string.IsNullOrEmpty(model.Namespace))
                {
                    model.Namespace = Config.Namespace;
                }
            }
        }

        public void Generate(string dir)
        {
            if (Directory.Exists(dir))
            {
                var template = Util.GetTemplate("Templates.Model.cshtml");
                foreach (var model in Config.Models)
                {
                    var result = Engine.Razor.RunCompile(template, "templateKey", null, model);
                    var file = dir + "\\" + model.Name + ".cs";
                    File.WriteAllText(file, result);
                }
            }
        }
    }
}
