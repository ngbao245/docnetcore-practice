using DocnetCorePractice.Data;
using DocnetCorePractice.Data.Entity;
using DocnetCorePractice.Model;

namespace DocnetCorePractice.Service
{
    public interface IUserService
    {
        List<UserModel> GetAllUser();
        List<UserModel>? AddUser(UserModel userModel);
    }
    public class UserService : IUserService
    {
        private readonly IInitData _initData;

        public UserService(IInitData initData)
        {
            _initData = initData;
        }

        public List<UserModel>? GetAllUser()
        {
            var entity = _initData.GetAllUser();
            if (entity == null || !entity.Any())
            {
                return null;
            }
            var result = new List<UserModel>();
            entity.ForEach(x =>
            {
                var model = new UserModel
                {
                    Address = x.Address,
                    DateOfBirth = x.DateOfBirth,
                    Balance = x.Balance,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    PhoneNumber = x.PhoneNumber,
                    Sex = x.Sex,
                    TotalProduct = x.TotalProduct
                };
                result.Add(model);
            });
            return result;
        }

        public List<UserModel>? AddUser(UserModel userModel)
        {
            var entity = new UserEntity
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Address = userModel.Address,
                DateOfBirth = userModel.DateOfBirth,
                Balance = userModel.Balance,
                IsActive = true,
                PhoneNumber = userModel.PhoneNumber,
                Sex = userModel.Sex,
                TotalProduct = userModel.TotalProduct,
                Roles = Enum.Roles.Basic
            };
            _initData.AddUser(entity);
            return GetAllUser();
        }
    }
}
