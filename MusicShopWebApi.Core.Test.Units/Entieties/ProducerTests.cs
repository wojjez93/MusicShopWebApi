using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using MusicShopWebApi.Core.Domain;
using MusicShopWebApi.Core.Domain.Entieties;

namespace MusicShopWebApi.Core.Test.Units.Entieties
{
    public class ProducerTests
    {
        private Producer producer;
        
        [TestCase("ddddd")]
        [TestCase("ola sndbajd")]        
        public void ChangeName_(string newName)
        {            
            producer.ChangeName(newName);

            var exception = producer.Name;

            exception.ShouldBe(newName);           
        }
        [Test]
        public void ChangeName_NameIsNotNullAndEmpty()
        {
            Assert.Throws<ArgumentNullException>(()=>producer.ChangeName(""));
        }
        [Test]
        public void ChangeName_NameIsTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => producer.ChangeName("udsghfgdhgdscghscghsddcgshcsdchsdcghdscdghssdgfjhsgchjdsgjhdscghjsgcjhdsgcjsgdhjsdghjdgfjsdgfjhdgfjdsgfjsdgfjsdgfhjfgsfgudsghfgdhgdscghscghsddcgshcsdchsdcghdscdghssdgfjhsgchjdsgjhdscghjsgcjhdsgcjsgdhjsdghjdgfjsdgfjhdgfjdsgfjsdgfjsdgfhjfgsfgdgfsdgfjhgfhdgfsdjgfjdsgfsdgcjhdsgfjdsgfjdsgfjgfjhsgfjsdgfjsdgfsdgfsdjgfdsjfgjsgfsjagfdgfdsjgfjdsgfdsjgfjsdgfjdsgf"));
        }
        public ProducerTests()
        {
            producer = new Producer(1, "Logo", "ABCD", "", "");
        }        
    }
}
