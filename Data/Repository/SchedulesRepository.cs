﻿using Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class SchedulesRepository : BaseRepository<Schedules>, ISchedulesRepository
    {
        public SchedulesRepository(SqlContext context) : base(context)
        {
        }
        public IEnumerable<Schedules> GetAll()
        {
            var obj = CurrentSet
                       .Include(x => x.Collaborator).ToList();

            return obj;
        }
    }
}
