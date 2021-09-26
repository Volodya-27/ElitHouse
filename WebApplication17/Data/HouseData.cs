using System.Collections.Generic;
using System.Linq;
using WebApplication17.Data.Models;
using WebApplication17.DataBase;
using WebApplication17.Interfaces;

namespace WebApplication17.Data
{
    public class HouseData : IHouseData
    {
        private readonly DataContext context;


        public HouseData(DataContext dataContext)
        {
            context = dataContext;

        }

        public void AddHouse(House house)
        {
            context.Houses.Add(house);
            context.SaveChanges();
        }


        public IEnumerable<House> GetHouse() => this.context.Houses;

        public void RemoveHouse(int houseId)
        {
            House house = context.Houses.FirstOrDefault(p => p.Id == houseId);

            context.Houses.Remove(house);
            context.SaveChanges();

        }
    }
}
