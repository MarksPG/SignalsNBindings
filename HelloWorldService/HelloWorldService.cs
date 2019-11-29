using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorldService
{
    public class HelloWorldService : IHelloWorldService
    {
        public static AutoResetEvent elseReset = new AutoResetEvent(false);

        public void Ping()
        {
            elseReset.Set();
        }
    }
}
