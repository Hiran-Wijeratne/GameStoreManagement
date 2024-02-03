using CarRentalManagement.Server.IRepository;
using GameStoreManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Game> Games { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Staff> Staffs { get; }
    }  
}