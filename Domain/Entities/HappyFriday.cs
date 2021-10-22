﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HappyFriday : BaseEntity
    {
        public int CollaboratorId { get; set; }
        public Collaborator Collaborator { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public DateTime HappyFridayDate { get; set; }
    }
}
