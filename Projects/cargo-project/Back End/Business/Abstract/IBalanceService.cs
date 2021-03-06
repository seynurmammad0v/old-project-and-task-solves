using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBalanceService
    {
        Balance GetWithUserId(string id);
        List<Balance> GetAll();
        void Add(Balance data);
        void Update(Balance data);
        void Detele(int id);
    }
}
