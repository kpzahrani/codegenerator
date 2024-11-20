using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codegenerator_razor
{
    public class PropertyModel
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }

    public class YourModel
    {
        public string NamespaceName { get; set; }
        public string ClassName { get; set; }
        public List<PropertyModel> Properties { get; set; }
    }

}
