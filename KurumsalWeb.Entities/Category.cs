﻿using KurumsalWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KurumsalWeb.Entities
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
