using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PointEx.Entities;
using PointEx.Entities.Dto;
using PointEx.Security.Model;

namespace PointEx.Service
{
    public interface IUserService : IServive
    {
        Task Create(ApplicationUser applicationUser);
        void Edit(User user);
        void Delete(string userId);
        IQueryable<User> GetAll();
        List<UserDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal);
        List<UserDto> GetAllAdministrators(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal);
        User GetById(string id);
    }
}