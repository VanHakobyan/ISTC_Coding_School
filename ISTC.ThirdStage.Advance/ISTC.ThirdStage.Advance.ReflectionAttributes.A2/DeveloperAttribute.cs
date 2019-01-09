using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.ReflectionAttributes.A2
{
    [AttributeUsage(AttributeTargets.All)]
    public class DeveloperAttribute : Attribute
    {
        // Private fields.

        // This constructor defines two required parameters: name and level.

        public DeveloperAttribute(string name, string level)
        {
            this.Name = name;
            this.Level = level;
            this.Reviewed = false;
        }

        // Define Name property.
        // This is a read-only attribute.

        public string Name { get; }

        // Define Level property.
        // This is a read-only attribute.

        public string Level { get; }

        // Define Reviewed property.
        // This is a read/write attribute.

        public bool Reviewed { get; set; }
    }
}
