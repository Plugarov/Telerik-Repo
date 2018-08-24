﻿using Dealership.Engine;
using Ninject;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new DealershipModule());

            var engine = kernel.Get<DealershipEngine>();
            engine.Start();
        }
    }
}
