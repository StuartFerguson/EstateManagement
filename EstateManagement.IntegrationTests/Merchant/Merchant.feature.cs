// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EstateManagement.IntegrationTests.Merchant
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "base")]
    [Xunit.TraitAttribute("Category", "shared")]
    public partial class MerchantFeature : Xunit.IClassFixture<MerchantFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "base",
                "shared"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Merchant.feature"
#line hidden
        
        public MerchantFeature(MerchantFeature.FixtureData fixtureData, EstateManagement_IntegrationTests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Merchant", null, ProgrammingLanguage.CSharp, new string[] {
                        "base",
                        "shared"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "RoleName"});
            table18.AddRow(new string[] {
                        "Estate"});
            table18.AddRow(new string[] {
                        "Merchant"});
#line 6
 testRunner.Given("the following security roles exist", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "ResourceName",
                        "DisplayName",
                        "Secret",
                        "Scopes",
                        "UserClaims"});
            table19.AddRow(new string[] {
                        "estateManagement",
                        "Estate Managememt REST",
                        "Secret1",
                        "estateManagement",
                        "MerchantId, EstateId, role"});
#line 11
 testRunner.Given("the following api resources exist", ((string)(null)), table19, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "ClientId",
                        "ClientName",
                        "Secret",
                        "AllowedScopes",
                        "AllowedGrantTypes"});
            table20.AddRow(new string[] {
                        "serviceClient",
                        "Service Client",
                        "Secret1",
                        "estateManagement",
                        "client_credentials"});
            table20.AddRow(new string[] {
                        "estateClient",
                        "Estate Client",
                        "Secret1",
                        "estateManagement",
                        "password"});
#line 15
 testRunner.Given("the following clients exist", ((string)(null)), table20, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "ClientId"});
            table21.AddRow(new string[] {
                        "serviceClient"});
#line 20
 testRunner.Given("I have a token to access the estate management resource", ((string)(null)), table21, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "EstateName"});
            table22.AddRow(new string[] {
                        "Test Estate 1"});
#line 24
 testRunner.Given("I have created the following estates", ((string)(null)), table22, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "EstateName",
                        "OperatorName",
                        "RequireCustomMerchantNumber",
                        "RequireCustomTerminalNumber"});
            table23.AddRow(new string[] {
                        "Test Estate 1",
                        "Test Operator 1",
                        "True",
                        "True"});
#line 28
 testRunner.Given("I have created the following operators", ((string)(null)), table23, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "EmailAddress",
                        "Password",
                        "GivenName",
                        "FamilyName",
                        "EstateName"});
            table24.AddRow(new string[] {
                        "estateuser1@testestate1.co.uk",
                        "123456",
                        "TestEstate",
                        "User1",
                        "Test Estate 1"});
#line 32
 testRunner.Given("I have created the following security users", ((string)(null)), table24, "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create Merchant - System Login")]
        [Xunit.TraitAttribute("FeatureTitle", "Merchant")]
        [Xunit.TraitAttribute("Description", "Create Merchant - System Login")]
        public virtual void CreateMerchant_SystemLogin()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Merchant - System Login", null, ((string[])(null)));
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantName",
                            "AddressLine1",
                            "Town",
                            "Region",
                            "Country",
                            "ContactName",
                            "EmailAddress",
                            "EstateName"});
                table25.AddRow(new string[] {
                            "Test Merchant 1",
                            "Address Line 1",
                            "TestTown",
                            "Test Region",
                            "United Kingdom",
                            "Test Contact 1",
                            "testcontact1@merchant1.co.uk",
                            "Test Estate 1"});
#line 37
 testRunner.When("I create the following merchants", ((string)(null)), table25, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create Merchant - Estate User")]
        [Xunit.TraitAttribute("FeatureTitle", "Merchant")]
        [Xunit.TraitAttribute("Description", "Create Merchant - Estate User")]
        public virtual void CreateMerchant_EstateUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Merchant - Estate User", null, ((string[])(null)));
#line 41
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 42
 testRunner.Given("I am logged in as \"estateuser1@testestate1.co.uk\" with password \"123456\" for Esta" +
                        "te \"Test Estate 1\" with client \"estateClient\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantName",
                            "AddressLine1",
                            "Town",
                            "Region",
                            "Country",
                            "ContactName",
                            "EmailAddress",
                            "EstateName"});
                table26.AddRow(new string[] {
                            "Test Merchant 1",
                            "Address Line 1",
                            "TestTown",
                            "Test Region",
                            "United Kingdom",
                            "Test Contact 1",
                            "testcontact1@merchant1.co.uk",
                            "Test Estate 1"});
#line 43
 testRunner.When("I create the following merchants", ((string)(null)), table26, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Assign Operator To Merchant - System Login")]
        [Xunit.TraitAttribute("FeatureTitle", "Merchant")]
        [Xunit.TraitAttribute("Description", "Assign Operator To Merchant - System Login")]
        [Xunit.TraitAttribute("Category", "PRTest")]
        public virtual void AssignOperatorToMerchant_SystemLogin()
        {
            string[] tagsOfScenario = new string[] {
                    "PRTest"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign Operator To Merchant - System Login", null, new string[] {
                        "PRTest"});
#line 48
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantName",
                            "AddressLine1",
                            "Town",
                            "Region",
                            "Country",
                            "ContactName",
                            "EmailAddress",
                            "EstateName"});
                table27.AddRow(new string[] {
                            "Test Merchant 1",
                            "Address Line 1",
                            "TestTown",
                            "Test Region",
                            "United Kingdom",
                            "Test Contact 1",
                            "testcontact1@merchant1.co.uk",
                            "Test Estate 1"});
#line 49
 testRunner.Given("I create the following merchants", ((string)(null)), table27, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "OperatorName",
                            "MerchantName",
                            "MerchantNumber",
                            "TerminalNumber",
                            "EstateName"});
                table28.AddRow(new string[] {
                            "Test Operator 1",
                            "Test Merchant 1",
                            "00000001",
                            "10000001",
                            "Test Estate 1"});
#line 53
 testRunner.When("I assign the following  operator to the merchants", ((string)(null)), table28, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Assign Operator To Merchant - Estate User")]
        [Xunit.TraitAttribute("FeatureTitle", "Merchant")]
        [Xunit.TraitAttribute("Description", "Assign Operator To Merchant - Estate User")]
        public virtual void AssignOperatorToMerchant_EstateUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign Operator To Merchant - Estate User", null, ((string[])(null)));
#line 57
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 58
 testRunner.Given("I am logged in as \"estateuser1@testestate1.co.uk\" with password \"123456\" for Esta" +
                        "te \"Test Estate 1\" with client \"estateClient\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantName",
                            "AddressLine1",
                            "Town",
                            "Region",
                            "Country",
                            "ContactName",
                            "EmailAddress",
                            "EstateName"});
                table29.AddRow(new string[] {
                            "Test Merchant 1",
                            "Address Line 1",
                            "TestTown",
                            "Test Region",
                            "United Kingdom",
                            "Test Contact 1",
                            "testcontact1@merchant1.co.uk",
                            "Test Estate 1"});
#line 60
 testRunner.Given("I create the following merchants", ((string)(null)), table29, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "OperatorName",
                            "MerchantName",
                            "MerchantNumber",
                            "TerminalNumber",
                            "EstateName"});
                table30.AddRow(new string[] {
                            "Test Operator 1",
                            "Test Merchant 1",
                            "00000001",
                            "10000001",
                            "Test Estate 1"});
#line 64
 testRunner.When("I assign the following  operator to the merchants", ((string)(null)), table30, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create Security User - System Login")]
        [Xunit.TraitAttribute("FeatureTitle", "Merchant")]
        [Xunit.TraitAttribute("Description", "Create Security User - System Login")]
        [Xunit.TraitAttribute("Category", "PRTest")]
        public virtual void CreateSecurityUser_SystemLogin()
        {
            string[] tagsOfScenario = new string[] {
                    "PRTest"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Security User - System Login", null, new string[] {
                        "PRTest"});
#line 69
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantName",
                            "AddressLine1",
                            "Town",
                            "Region",
                            "Country",
                            "ContactName",
                            "EmailAddress",
                            "EstateName"});
                table31.AddRow(new string[] {
                            "Test Merchant 1",
                            "Address Line 1",
                            "TestTown",
                            "Test Region",
                            "United Kingdom",
                            "Test Contact 1",
                            "testcontact1@merchant1.co.uk",
                            "Test Estate 1"});
#line 70
 testRunner.Given("I create the following merchants", ((string)(null)), table31, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "EmailAddress",
                            "Password",
                            "GivenName",
                            "FamilyName",
                            "MerchantName",
                            "EstateName"});
                table32.AddRow(new string[] {
                            "merchantuser1@testmerchant1.co.uk",
                            "123456",
                            "TestMerchant",
                            "User1",
                            "Test Merchant 1",
                            "Test Estate 1"});
#line 74
 testRunner.When("I create the following security users", ((string)(null)), table32, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create Security User - Estate User")]
        [Xunit.TraitAttribute("FeatureTitle", "Merchant")]
        [Xunit.TraitAttribute("Description", "Create Security User - Estate User")]
        [Xunit.TraitAttribute("Category", "PRTest")]
        public virtual void CreateSecurityUser_EstateUser()
        {
            string[] tagsOfScenario = new string[] {
                    "PRTest"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Security User - Estate User", null, new string[] {
                        "PRTest"});
#line 79
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 80
 testRunner.Given("I am logged in as \"estateuser1@testestate1.co.uk\" with password \"123456\" for Esta" +
                        "te \"Test Estate 1\" with client \"estateClient\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantName",
                            "AddressLine1",
                            "Town",
                            "Region",
                            "Country",
                            "ContactName",
                            "EmailAddress",
                            "EstateName"});
                table33.AddRow(new string[] {
                            "Test Merchant 1",
                            "Address Line 1",
                            "TestTown",
                            "Test Region",
                            "United Kingdom",
                            "Test Contact 1",
                            "testcontact1@merchant1.co.uk",
                            "Test Estate 1"});
#line 82
 testRunner.Given("I create the following merchants", ((string)(null)), table33, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                            "EmailAddress",
                            "Password",
                            "GivenName",
                            "FamilyName",
                            "MerchantName",
                            "EstateName"});
                table34.AddRow(new string[] {
                            "merchantuser1@testmerchant1.co.uk",
                            "123456",
                            "TestMerchant",
                            "User1",
                            "Test Merchant 1",
                            "Test Estate 1"});
#line 86
 testRunner.When("I create the following security users", ((string)(null)), table34, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add Device To Merchant - Estate User")]
        [Xunit.TraitAttribute("FeatureTitle", "Merchant")]
        [Xunit.TraitAttribute("Description", "Add Device To Merchant - Estate User")]
        public virtual void AddDeviceToMerchant_EstateUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Device To Merchant - Estate User", null, ((string[])(null)));
#line 90
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 91
 testRunner.Given("I am logged in as \"estateuser1@testestate1.co.uk\" with password \"123456\" for Esta" +
                        "te \"Test Estate 1\" with client \"estateClient\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantName",
                            "AddressLine1",
                            "Town",
                            "Region",
                            "Country",
                            "ContactName",
                            "EmailAddress",
                            "EstateName"});
                table35.AddRow(new string[] {
                            "Test Merchant 1",
                            "Address Line 1",
                            "TestTown",
                            "Test Region",
                            "United Kingdom",
                            "Test Contact 1",
                            "testcontact1@merchant1.co.uk",
                            "Test Estate 1"});
#line 93
 testRunner.Given("I create the following merchants", ((string)(null)), table35, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                            "DeviceIdentifier",
                            "MerchantName",
                            "EstateName"});
                table36.AddRow(new string[] {
                            "TestDevice1",
                            "Test Merchant 1",
                            "Test Estate 1"});
#line 97
 testRunner.When("I add the following devices to the merchant", ((string)(null)), table36, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add Device To Merchant - System Login")]
        [Xunit.TraitAttribute("FeatureTitle", "Merchant")]
        [Xunit.TraitAttribute("Description", "Add Device To Merchant - System Login")]
        public virtual void AddDeviceToMerchant_SystemLogin()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Device To Merchant - System Login", null, ((string[])(null)));
#line 101
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                            "MerchantName",
                            "AddressLine1",
                            "Town",
                            "Region",
                            "Country",
                            "ContactName",
                            "EmailAddress",
                            "EstateName"});
                table37.AddRow(new string[] {
                            "Test Merchant 1",
                            "Address Line 1",
                            "TestTown",
                            "Test Region",
                            "United Kingdom",
                            "Test Contact 1",
                            "testcontact1@merchant1.co.uk",
                            "Test Estate 1"});
#line 102
 testRunner.Given("I create the following merchants", ((string)(null)), table37, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                            "DeviceIdentifier",
                            "MerchantName",
                            "EstateName"});
                table38.AddRow(new string[] {
                            "TestDevice1",
                            "Test Merchant 1",
                            "Test Estate 1"});
#line 106
 testRunner.When("I add the following devices to the merchant", ((string)(null)), table38, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                MerchantFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                MerchantFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
