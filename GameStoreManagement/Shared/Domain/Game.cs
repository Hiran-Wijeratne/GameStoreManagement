using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreManagement.Shared.Domain
{
    public class Game : BaseDomainModel
    
    {
        public string? Name { get; set; }

        public string? Platform { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public double Price { get; set; }

    }
}
