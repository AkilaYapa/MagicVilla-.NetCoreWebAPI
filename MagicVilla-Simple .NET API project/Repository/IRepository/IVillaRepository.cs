﻿using MagicVilla_Simple_.NET_API_project.Models;
using System.Linq.Expressions;

namespace MagicVilla_Simple_.NET_API_project.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
