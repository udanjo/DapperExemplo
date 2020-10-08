using Dapper;
using DapperTest.Context;
using DapperTest.Domain;
using DapperTest.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DapperTest.Service
{
    public class Bank : IBank
    {
        private readonly IConnectionFactory _conn;

        public Bank(IConnectionFactory conn)
        {
            _conn = conn;
        }


        public Task<BankInfo> GetBank(int id)
        {
            return Task.Run(() =>
            {
                using (var db = _conn.Connection())
                {
                    db.Open();

                    var info = db.QueryFirstOrDefaultAsync<BankInfo>(BankCommand._GetById, new
                    {
                        ID = id
                    });

                    return info.GetAwaiter().GetResult();
                }

            });
        }

        public Task<bool> Save(BankInfo bank)
        {
            bool success = false;

            return Task.Run(() =>
            {
                try
                {
                    using (var db = _conn.Connection())
                    {
                        db.Open();

                        db.Execute(BankCommand._Insert, new
                        {
                            CODIGO = bank.Codigo,
                            DESCRICAO = bank.Descricao
                        });

                        success = true;
                        return success;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }

        public Task<BankInfo> Update(BankInfo bank)
        {
            return Task.Run(() =>
            {
                try
                {
                    using (var db = _conn.Connection())
                    {
                        db.Open();

                        db.Execute(BankCommand._Update, new
                        {
                            CODIGO = bank.Codigo,
                            DESCRICAO = bank.Descricao,
                            ID = bank.Id
                        });

                        var info = db.QueryFirstOrDefaultAsync<BankInfo>(BankCommand._GetById, new
                        {
                            ID = bank.Id
                        });

                        return info.GetAwaiter().GetResult();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            });
        }
    }
}
