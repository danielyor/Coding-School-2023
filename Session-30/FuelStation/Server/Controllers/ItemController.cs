using FuelStation.Client.Pages;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase {
        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> itemRepo) {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemDto>> Get() {
            var itemList = _itemRepo.GetAll();

            return itemList.Select(item => new ItemDto {
                Id = item.Id,
                Code = item.Code,
                Description = item.Description,
                Type = item.Type,
                Price = item.Price,
                Cost = item.Cost
            });
        }

        [HttpGet("{Id}")]
        public async Task<ItemDto?> GetById(int id) {
            var result = _itemRepo.GetById(id);

            return new ItemDto {
                Id = result.Id,
                Code = result.Code,
                Description = result.Description,
                Type = result.Type,
                Price = result.Price,
                Cost = result.Cost
            };

        }

        [HttpPost]
        public async Task Post(ItemDto item) {
            var newEmployee = new Item(item.Code, item.Description, item.Type, item.Price, item.Cost);

            _itemRepo.Create(newEmployee);
        }

        [HttpPut]
        public async Task Put(ItemDto item) {
            var dbItem = await Task.Run(() => { return _itemRepo.GetById(item.Id); });

            if (dbItem is null) {
                return;
            }

            dbItem.Code = item.Code;
            dbItem.Description = item.Description;
            dbItem.Type = item.Type;
            dbItem.Price = item.Price;
            dbItem.Cost = item.Cost;

            _itemRepo.Update(item.Id, dbItem);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _itemRepo.Delete(id);
        }

    }
}
