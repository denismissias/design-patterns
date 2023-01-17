using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class CloudManager
    {
        private Dictionary<string, CloudTemplate> clouds = new Dictionary<string, CloudTemplate>();

        public CloudTemplate this[string key]
        {
            get { return clouds[key]; }
            set { clouds[key] = value; }
        }
    }
}
