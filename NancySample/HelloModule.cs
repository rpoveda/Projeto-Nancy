using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancySample
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/"] = parameters => "Hello World";
            Get["/About"] = parameters => "About test";
        }
    }
}