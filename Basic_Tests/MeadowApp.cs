﻿using Meadow;
using Meadow.Devices;
using System;
using System.Threading.Tasks;

#pragma warning disable 1998

namespace Basic_Tests
{ 
    public class Basic_Tests : App<F7FeatherV1>
    {
        public override Task Run()
        {
            string[] args = { "--verbose" };
            TestDriver.RunTests (typeof (BasicTests), null);
            TestDriver.RunTests(typeof(FloatTests), null);
            TestDriver.RunTests(typeof(LongTests), null);
            TestDriver.RunTests(typeof(MathsTests), null);
            TestDriver.RunTests(typeof(CallsTests), null);
            TestDriver.RunTests(typeof(ArrayTests), null);
            TestDriver.RunTests(typeof(GenericsTests), null);
            TestDriver.RunTests(typeof(ExceptionTests), null);
            TestDriver.RunTests(typeof(ObjectTests), null);
            TestDriver.RunTests(typeof(VectorTests), null);
            TestDriver.RunTests(typeof(RATests), null);
            TestDriver.RunTests(typeof(GSharedTests), null);
            TestDriver.RunTests(typeof(GCTests), null);
            TestDriver.RunTests(typeof(DevirtualizationTests), null);
            // TestDriver.RunTests(typeof(BenchTests), args);
            Console.WriteLine("**** Tests Complete ****");
	    return base.Run();
        }
    }
}
