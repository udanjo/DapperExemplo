using System.Threading.Tasks;

namespace DapperTest.Service.Interfaces
{
    public interface IBank
    {
        Task<BankInfo> GetBank(int id);
        Task<bool> Save(BankInfo info);
        Task<BankInfo> Update(BankInfo bank);
    }
}
