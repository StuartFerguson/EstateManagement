﻿namespace EstateManagement.IntegrationTests.Common
{
    using System;
    using System.Collections.Generic;

    public class TestingContext
    {
        public TestingContext()
        {
            this.Estates = new Dictionary<String, Guid>();
        }

        public DockerHelper DockerHelper { get; set; }

        public Dictionary<String, Guid> Estates { get; set; }
    }
}