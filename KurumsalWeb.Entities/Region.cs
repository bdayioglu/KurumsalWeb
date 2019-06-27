using KurumsalWeb.Core.Entities;
using System;
using System.Collections.Generic;

namespace KurumsalWeb.Entities
{
    public partial class Region : IEntity
    {
        public Region()
        {
            Territories = new HashSet<Territories>();
        }

        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<Territories> Territories { get; set; }
    }
}
