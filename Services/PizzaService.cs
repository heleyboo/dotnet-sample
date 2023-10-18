using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static List<Company> Companies { get; }
    static int nextId = 3;


    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
        };
    }

    public static List<Pizza> GetAll() => Pizzas;

    public static Pizza? Get(int id) 
    {
        using (var context = new BlogDataContext())
        {
            var john = new Company { name = "John T. Author", enterprise_gdt_code = "3495345345", valid = true };
            context.companies.Add(john);


            context.SaveChanges();
        }


        return Pizzas.FirstOrDefault(p => p.Id == id);
    } 

    public static async Task<List<Company>> GetAllCompany() {
        var context = new BlogDataContext();

        return await context.companies.Where(s => s.id > 300).ToListAsync<Company>();
    }

    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null)
            return;

        Pizzas.Remove(pizza);
    }

    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if(index == -1)
            return;

        Pizzas[index] = pizza;
    }
}