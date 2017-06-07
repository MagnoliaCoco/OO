using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class ActionNode : AbstractNode
    {
        private string action;

        public ActionNode(string action)
        {
            this.action = action;
        }

        public override string Interpret()
        {
            if ("move".Equals(action))
            {
                return " move ";
            }
            else if ("run".Equals(action))
            {
                return " run ";
            }
            else
            {
                return "invali operation";
            }
        }
    }
}
