using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator
{
    public class Util
    {
        public static string GetTemplate(string name)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ModelGenerator." + name))
            {
                TextReader tr = new StreamReader(stream);
                return tr.ReadToEnd();
            }
        }
    }
}
