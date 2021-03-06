﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EstateManagement.IntegrationTests.Common
{
    using System.Threading.Tasks;
    using Ductus.FluentDocker.Executors;
    using Ductus.FluentDocker.Extensions;
    using Ductus.FluentDocker.Services;
    using Ductus.FluentDocker.Services.Extensions;
    using global::Shared.General;
    using global::Shared.Logger;
    using Microsoft.Extensions.Logging;
    using NLog;
    using NLog.Extensions.Logging;
    using TechTalk.SpecFlow;
    using Logger = global::Shared.Logger.Logger;
    [Binding]
    [Scope(Tag = "base")]
    public class GenericSteps
    {
        private readonly ScenarioContext ScenarioContext;

        private readonly TestingContext TestingContext;
        
        public GenericSteps(ScenarioContext scenarioContext,
                            TestingContext testingContext)
        {
            this.ScenarioContext = scenarioContext;
            this.TestingContext = testingContext;
        }

        [BeforeScenario()]
        public async Task StartSystem()
        {
            // Initialise a logger
            String scenarioName = this.ScenarioContext.ScenarioInfo.Title.Replace(" ", "");
            NlogLogger logger = new NlogLogger();
            logger.Initialise(LogManager.GetLogger(scenarioName),scenarioName);
            LogManager.AddHiddenAssembly(typeof(NlogLogger).Assembly);

            this.TestingContext.DockerHelper = new DockerHelper(logger, this.TestingContext);
            this.TestingContext.Logger = logger;
            this.TestingContext.Logger.LogInformation("About to Start Containers for Scenario Run");
            await this.TestingContext.DockerHelper.StartContainersForScenarioRun(scenarioName).ConfigureAwait(false);
            this.TestingContext.Logger.LogInformation("Containers for Scenario Run Started");
        }

        [AfterScenario()]
        public async Task StopSystem()
        {
            if (this.ScenarioContext.TestError != null)
            {
                //// The test has failed, grab the logs from all the containers
                //List<IContainerService> containers = new List<IContainerService>();
                //containers.Add(this.TestingContext.DockerHelper.SecurityServiceContainer);
                //containers.Add(this.TestingContext.DockerHelper.EstateManagementApiContainer);

                //foreach (IContainerService containerService in containers)
                //{
                //    ConsoleStream<String> logStream = containerService.Logs();
                //    IList<String> logData = logStream.ReadToEnd();

                //    foreach (String s in logData)
                //    {
                //        this.TestingContext.Logger.LogWarning(s);
                //    }
                //}
            }

            this.TestingContext.Logger.LogInformation("About to Stop Containers for Scenario Run");
            await this.TestingContext.DockerHelper.StopContainersForScenarioRun().ConfigureAwait(false);
            this.TestingContext.Logger.LogInformation("Containers for Scenario Run Stopped");
        }
    }
}
