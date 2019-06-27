using KurumsalWeb.Core.Entities;
using System;
using System.Collections.Generic;

namespace KurumsalWeb.Entities
{
    public partial class EmployeeTerritories: IEntity
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public virtual Employees Employee { get; set; }
        public virtual Territories Territory { get; set; }
    }
}
