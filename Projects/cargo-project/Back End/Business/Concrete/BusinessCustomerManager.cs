using Business.Abstract;
using DataAccess.Abstract;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BusinessCustomerManager : IBusinessCustomerService
    {
        private readonly IBusinessCustomerDAL _context;

        public BusinessCustomerManager(IBusinessCustomerDAL context)
        {
            _context = context;
        }
        public void Add(BusinessCustomer data)
        {
            _context.Add(data);
        }

        public void Detele(int id)
        {
            _context.Delete(new BusinessCustomer { Id = id });
        }

        public List<BusinessCustomer> GetAll()
        {
            return _context.GetAll();
        }

        public BusinessCustomer GetWithNumber(int CompanyRegistrationNumber)
        {
            return _context.Get(c => c.CompanyRegistrationNumber == CompanyRegistrationNumber);
        }

        public BusinessCustomer GetWithName(string CompanyName)
        {
            return _context.Get(c => c.CompanyName == CompanyName);
        }
        public BusinessCustomer GetWithCamexId(int CamexId)
        {
            return _context.Get(c => c.CamexId == CamexId);
        }
        public void Update(BusinessCustomer data)
        {
            _context.Update(data);
        }
    }
}
