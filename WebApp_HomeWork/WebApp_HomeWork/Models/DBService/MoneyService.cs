using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_HomeWork.Models;
using WebApp_HomeWork.Repositories;

namespace WebApp_HomeWork.Service
{
    public class MoneyService
    {
        private readonly IRepository<AccountBook> _accountBookRep;
        private readonly IUnitOfWork _unitOfWork;
        public MoneyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _accountBookRep = new Repository<AccountBook>(unitOfWork);
        }

        public IEnumerable<MoneyClass> Lookup()
        {
            var source = _accountBookRep.LookupAll();
            var result = source.Select(s => new MoneyClass()
            {
                category = (CategoryType)s.Categoryyy,
                money = s.Amounttt,
                date = s.Dateee,
                description = s.Remarkkk
            }).ToList();

            return result;
        }

        public void Add(MoneyClass money)
        {
            var account = new AccountBook()
            {
                Id = Guid.NewGuid(),
                Categoryyy = (int)money.category,
                Dateee = money.date,
                Amounttt = Convert.ToInt32(money.money),
                Remarkkk = money.description
            };
            _accountBookRep.Create(account);
        }

        public void Save()
        {
            _unitOfWork.Save();
        }
    }
}