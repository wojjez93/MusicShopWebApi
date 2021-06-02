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

        #region ChangeNameTests
        [TestCase("ddddd")]
        [TestCase("ola sndbajd")]
        public void ChangeName_NameIsChanged(string newName)
        {
            producer.ChangeName(newName);

            var exception = producer.Name;

            exception.ShouldBe(newName);
        }
        [Test]
        public void ChangeName_NameIsNotNullAndEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => producer.ChangeName(""));
        }
        [Test]
        public void ChangeName_NameIsTooLong_LessThen50Characters()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => producer.ChangeName(Builder(50)));
        }
        #endregion

        #region AddDescriptionTests
        [TestCase("hdgfdshv")]
        public void AddDescription_DescriptionIsChanged(string newDescription)
        {
            producer.AddDescription(newDescription);

            var excpection = producer.Description;

            excpection.ShouldBe(newDescription);
        }
        #endregion

        #region AddAddressUrlTests
        [Test]
        public void AddAddressUrl_UrlIsTooLong_LessThen2100Characters()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => producer.AddAddressUrl(Builder(2100)));

        }
        #endregion

        #region AddImageLogoUrlTests
        [Test]
        public void AddImageLogoUrl_UrlIsTooLong_LessThen2100Characters()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => producer.AddImageLogoUrl(Builder(2100)));
        } 
        #endregion

        private string Builder(int maxLengthOfCharacters)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < maxLengthOfCharacters; i++)
            {
                builder.Append("a");
            }
            return builder.ToString();
        }
        public ProducerTests()
        {
            producer = new Producer(1, "Logo", "ABCD", "", "");
        }
    }
}
