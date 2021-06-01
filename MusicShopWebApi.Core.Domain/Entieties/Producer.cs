using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopWebApi.Core.Domain.Entieties
{
    public class Producer
    {
        [Key]
        public int Id { get; private set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; private set; }
        public string Description { get; set; }
        [MaxLength(2100)]
        public string AddressUrl { get; set; }
        [MaxLength(2100)]
        public string ImageLogoUrl { get; set; }

        private Producer()
        {

        }
        public Producer(int id, string name, string description, string addressUrl, string imageLogoUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            AddressUrl = addressUrl;
            ImageLogoUrl = imageLogoUrl;
        }
        public void ChangeName(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new ArgumentNullException(newName);
            }
            if (newName.Length >= 50)
            {
                throw new ArgumentOutOfRangeException(newName);
            }
            Name = newName;
        }
    }
}
