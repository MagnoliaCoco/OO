using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    interface LFactory
    {
        Logger CreateLogger();
    }
}
