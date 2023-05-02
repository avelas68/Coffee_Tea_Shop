using System.Collections.Generic;
using System.Linq;
using ExampleOne.Models;

namespace ExampleOne.Services
{
    public interface IDrinksServices
    {
        List<MyDrinks> GetMyDrinks();

    }
    public class DrinksServices: IDrinksServices
    {
        private readonly AppDbContext db;
        public DrinksServices(AppDbContext db)
        {
            this.db = db;
        }
        public List<MyDrinks> GetMyDrinks()
        {

            return db.Drinkss.ToList();
        }
    }
}

