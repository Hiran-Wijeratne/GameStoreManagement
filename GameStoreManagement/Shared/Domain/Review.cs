using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreManagement.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public int GameId { get; set; }
        public virtual Game? Game { get; set; }
        public double rating { get; set; }

    }
}
