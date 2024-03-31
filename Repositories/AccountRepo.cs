using System;
using System.Data.Entity;
using System.Threading.Tasks;
using UModule.Database.EF;

namespace UModule.Database.Repositories
{
    public class AccountRepo
    {
        crm_dbEntities _dbContext = new crm_dbEntities();

        public async Task<CrmUser> LoginAsync(string email = "", string password = "")
        {
            try
            {
                var clnt = await _dbContext.CrmUsers.FirstOrDefaultAsync(x => x.Email.Equals(email) && x.Password.Equals(password));
                return clnt;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<UserRole> GetRoleById(int? Id)
        {
            try
            {
                var clnt = await _dbContext.UserRoles.FirstOrDefaultAsync(x => x.Id == Id);
                return clnt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
