using FuelStation.Client.Pages;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase {
        private readonly IEntityRepo<TransactionLine> _repo;

        public TransactionLineController(IEntityRepo<TransactionLine> repo) {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionLineDto>> Get() {
            var linesList = _repo.GetAll();

            return linesList.Select(line => new TransactionLineDto(line.TransactionId, line.ItemId, line.Quantity));
        }

        [HttpGet("{Id}")]
        public async Task<TransactionLineDto?> GetById(int id) {
            var line = _repo.GetById(id);

            return new TransactionLineDto(line.TransactionId, line.ItemId, line.Quantity);

        }

        [HttpPost]
        public async Task Post(TransactionLineDto line) {
            var newLine = new TransactionLineDto(line.TransactionId, line.ItemId, line.Quantity);
            var returnLine = new TransactionLine() {
                Id = newLine.Id,
                TransactionId = newLine.TransactionId,
                ItemId = newLine.ItemId,
                Quantity = newLine.Quantity,
                ItemPrice = newLine.ItemPrice,
                NetValue = newLine.NetValue,
                DiscountPercent = newLine.DiscountPercent,
                DiscountValue = newLine.DiscountValue,
                TotalValue = newLine.TotalValue
            };

            _repo.Create(returnLine);
        }

        [HttpPut]
        public async Task Put(TransactionLineDto line) {
            var dbLine = await Task.Run(() => { return _repo.GetById(line.Id); });

            if (dbLine is null) {
                return;
            }

            dbLine.Id = line.Id;
            dbLine.TransactionId = line.TransactionId;
            dbLine.ItemId = line.ItemId;
            dbLine.Quantity = line.Quantity;
            dbLine.ItemPrice = line.ItemPrice;
            dbLine.NetValue = line.NetValue;
            dbLine.DiscountPercent = line.DiscountPercent;
            dbLine.DiscountValue = line.DiscountValue;
            dbLine.TotalValue = line.TotalValue;

            _repo.Update(line.Id, dbLine);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _repo.Delete(id);
        }

    }
}
