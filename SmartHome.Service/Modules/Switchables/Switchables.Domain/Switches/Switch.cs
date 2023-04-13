using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchables.Domain.Switches
{
    public class Switch
    {
        public Guid Id { get; protected set; }

        public bool On { get; protected set; }

        protected Switch(bool onState) 
        {
            On = onState;
        }

        // TODO: Wrap Create methods in some Result/Maybe type
        public static Switch Create(bool onState) {
            return new Switch(onState);
        }
    }
}
