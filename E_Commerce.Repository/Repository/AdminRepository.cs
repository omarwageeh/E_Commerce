﻿using E_Commerce.Data.Context;
using E_Commerce.Model;
using E_Commerce.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Repository.Repository
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(DataContext context) : base(context)
        {
        }
    }
}
