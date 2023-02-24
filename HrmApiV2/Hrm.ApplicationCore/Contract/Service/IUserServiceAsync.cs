using System;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;

namespace Hrm.ApplicationCore.Contract.Service
{
    public interface IUserServiceAsync
    {
        Task<int> AddUserAsync(UserRequestModel model);
        Task<int> UpdateUserAsync(UserRequestModel model);
        Task<int> DeleteUserAsync(int id);
        Task<UserResponseModel> GetUserByIdAsync(int id);
        Task<IEnumerable<UserResponseModel>> GetAllUsersAsync();

    }
}

