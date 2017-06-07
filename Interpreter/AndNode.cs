using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class AndNode : AbstractNode
    {
        private AbstractNode left;
        private AbstractNode right;

        public AndNode(AbstractNode left, AbstractNode right)
        {
            this.left = left;
            this.right = right;
        }

        public override string Interpret()
        {
            return left.Interpret() + " then " + right.Interpret();
        }
    }
}
