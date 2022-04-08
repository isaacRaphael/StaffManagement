using StaffManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Contracts
{
    public interface IStaffRepository
    {
        bool AddStaff(Staff staff);
        bool RemoveStaff(int id);
        Staff GetStaff(int id);
        IEnumerable<Staff> GetAllStaff();
    }
}
