﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Twingly.Gearman.Tests
{
    [TestFixture]
    public class GearmanClientTests
    {
        [Test]
        public void can_submit_backgroundjob()
        {
            var client = new GearmanClient();
            client.AddServer("127.0.0.1");
            var handle = client.SubmitBackgroundJob("reverse", Encoding.ASCII.GetBytes("Hello World"));

            Assert.IsNotNull(handle);
        }
    }
}