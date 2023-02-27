﻿using FuelStation.Client.Pages;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase {
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo) {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionDto>> Get() {
            var transactionList = _transactionRepo.GetAll();

            return transactionList.Select(transaction => new TransactionDto {
                Id = transaction.Id,
                Date = transaction.Date,
                EmployeeId = transaction.EmployeeId,
                CustomerId = transaction.CustomerId,
                PayMethod = transaction.PayMethod,
                TotalValue = transaction.TotalValue
            });
        }

        [HttpGet("{Id}")]
        public async Task<TransactionDto?> GetById(int id) {
            var result = _transactionRepo.GetById(id);

            return new TransactionDto {
                Id = result.Id,
                Date = result.Date,
                EmployeeId = result.EmployeeId,
                CustomerId = result.CustomerId,
                PayMethod = result.PayMethod,
                TotalValue = result.TotalValue
            };

        }

        [HttpPost]
        public async Task Post(TransactionDto transaction) {
            var newTransaction = new Transaction(transaction.EmployeeId, transaction.CustomerId, transaction.PayMethod, transaction.TotalValue);

            _transactionRepo.Create(newTransaction);
        }

        [HttpPut]
        public async Task Put(TransactionDto transaction) {
            var dbTransaction = await Task.Run(() => { return _transactionRepo.GetById(transaction.Id); });

            if (dbTransaction is null) {
                return;
            }

            dbTransaction.Date = transaction.Date;
            dbTransaction.TotalValue = transaction.TotalValue;
            dbTransaction.PayMethod = transaction.PayMethod;

            _transactionRepo.Update(transaction.Id, dbTransaction);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _transactionRepo.Delete(id);
        }

    }
}
