using DocnetCorePractice.Data.Entity;
using System.Linq;

namespace DocnetCorePractice.Data
{
    public interface IInitData
    {
        List<UserEntity> GetAllUser();
        bool AddUser(UserEntity entity);
    }
    public class InitData : IInitData
    {
        private static List<UserEntity> users = new List<UserEntity>()
        {
            new UserEntity()
            {
                Id = Guid.NewGuid().ToString("N"),
                FirstName = "huy",
                LastName = "nguyen",
                Sex = Enum.Sex.Male,
                Address = "Ho chi Minh",
                Balance = 100000,
                DateOfBirth = DateTime.Now,
                PhoneNumber = "0123456789",
                Roles = Enum.Roles.Basic,
                TotalProduct = 0,
                IsActive = true
            }
        };

        private static List<CaffeEntity> caffes = new List<CaffeEntity>()
        {
            new CaffeEntity()
            {
                Id = Guid.NewGuid().ToString("N"),
                Name = "Ca phe sua",
                Price = 20000,
                Discount = 10,
                Type = Enum.ProductType.A,
                IsActive = true
            }
        };

        private static List<OrderItemEntity> orderItems = new List<OrderItemEntity>();
        private static List<OrderEntity> orders = new List<OrderEntity>();

        public List<UserEntity> GetAllUser()
        {
            return users.Where(x => x.IsActive == true).ToList();
        }

        public bool AddUser(UserEntity entity)
        {
            users.Add(entity);
            return true;
        }
    }
}
