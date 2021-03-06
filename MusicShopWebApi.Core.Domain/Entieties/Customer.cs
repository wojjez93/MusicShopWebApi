using MusicShopWebApi.Core.Domain.Common;

namespace MusicShopWebApi.Core.Domain.Entieties
{
    class Customer:AuditableEntity
    {
        public int Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string StreetAddress { get; set; }
        public string LocalAddress { get; set; }
    }
}
