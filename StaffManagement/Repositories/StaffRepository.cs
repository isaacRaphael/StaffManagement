﻿using StaffManagement.Contracts;
using StaffManagement.DataAccess;
using StaffManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StaffManagement.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        private readonly AppDbContext _db;

        public StaffRepository(AppDbContext db)
        {
            _db = db;
        }
        public bool AddStaff(Staff staff)
        {
            _db.Staffs.Add(staff);
            var changes = _db.SaveChanges();
            return changes > 0;
        }
        public IEnumerable<Staff> GetAllStaff()
        {
            return _db.Staffs.ToList();
        }

        public Staff GetStaff(Expression<Func<Staff, bool>> predicate)
        {
            return _db.Staffs.AsQueryable().FirstOrDefault(predicate);
        }

        public bool RemoveStaff(int id)
        {
            var staff = _db.Staffs.Find(id);
            if (staff == null)
            {
                return false;
            }

            _db.Staffs.Remove(staff);
            var changes = _db.SaveChanges();
            return changes > 0;
        }
    }
}
