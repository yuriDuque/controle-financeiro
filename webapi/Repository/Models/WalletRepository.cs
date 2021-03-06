﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System.Linq;

namespace Repository.Models
{
    public class WalletRepository : Repository<Wallet>
    {
        public WalletRepository(BaseContext ctx) : base(ctx) { }

        public IQueryable<Wallet> GetAllByUser(long idUser)
        {
            return GetAll()
                .Include(x => x.Incomes)
                .Include(x => x.Expenses)
                .Where(x => x.IdUser == idUser);
        }

        public Wallet GetById(long idUser, long id)
        {
            return GetAll()
                .Include(x => x.Incomes)
                .Include(x => x.Expenses)
                .FirstOrDefault(x => x.Id == id && x.IdUser == idUser);
        }
    }
}
