﻿using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Repository
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {

        public LeaveTypeRepository(ApplicationDbContext db) : base(db)
        {

        }

    }
}
