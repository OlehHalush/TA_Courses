using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Testing.Steps
{
    [Binding]
    public class Steps
    {
        string name;
        [When(@"I write ""(.*)""")]
        public void WhenIWrite(string name)
        {
            this.name = name;
        }

        [Then(@"it is equal to ""(.*)""")]
        public void CheckName(string name)
        {
            Assert.That(this.name,Is.EqualTo(name));
        }
    }
}