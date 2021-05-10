using MusicShopWebApi.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopWebApi.Core.Domain.Entieties
{
    class Product:AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double PriceNet { get; set; }
        public string State { get; set; }
        public Picture Pictures { get; set; }
        public Category Category { get; set; }
        public Producer Producer { get; set; }
        public string Description { get; set; }
    }
}
