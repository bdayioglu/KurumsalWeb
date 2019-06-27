using KurumsalWeb.Core.Entities;
using System;
using System.Collections.Generic;

namespace KurumsalWeb.Entities
{
    public partial class CustomerDemographics : IEntity
    {
        public CustomerDemographics()
        {
            CustomerCustomerDemo = new HashSet<CustomerCustomerDemo>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
    }
}
