﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModels
{
    public class DashboardViewModel
    {
        public int Workload { get; set; }

        public double Balance { get; set; }

        public IEnumerable<Schedules> Lasthours { get; set; }

        public int CollaboratorId { get; set; }

        public Collaborator Collaborator { get; set; }
    }
}
