using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassSchedule.Models.DataLayer
{
    interface IClassScheduleUnitOfWork
    {
        public Repository<Class> classes { get; }
        public Repository<Teacher> teachers { get; }
        public Repository<Day> days{ get; }

        public void Save();

    }
}
