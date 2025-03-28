﻿
using Orders.Shared.Entities;

namespace Orders.Backend.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public  async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckCategoriesAsync();
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Tecnología" });
                _context.Categories.Add(new Category { Name = "Mascotas" });
                _context.Categories.Add(new Category { Name = "Hogar" });
                _context.Categories.Add(new Category { Name = "Cosméticos" });
                _context.Categories.Add(new Category { Name = "Medicamentos" });
                _context.Categories.Add(new Category { Name = "Limpieza" });
                _context.Categories.Add(new Category { Name = "Pañales" });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCountriesAsync()
        {
            if(! _context.Countries.Any()) {
                _context.Countries.Add(new Country { Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Perú" });
                _context.Countries.Add(new Country { Name = "Argentina" });
                _context.Countries.Add(new Country { Name = "USA" });
                _context.Countries.Add(new Country { Name = "Italia" });
                _context.Countries.Add(new Country { Name = "Francia" });
                _context.Countries.Add(new Country { Name = "Uruguay" });

                await _context.SaveChangesAsync();
            }
        }


    }
}
