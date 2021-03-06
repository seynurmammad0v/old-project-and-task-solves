using Entity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Concrete
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BJ9GPJO;Database=Camex;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
        public DbSet<BusinessCustomer> BusinessCustomers { get; set; }
        public DbSet<PrivateCustomer> PrivateCustomers { get; set; }
        public DbSet<Citizenship> Сitizenships { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<OfficeNameTranslate> OfficeNameTranslates { get; set; }
        public DbSet<CityNameTranslate> CityNameTranslates { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryAddressDescription> CountryAddressDescriptions { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductTranslate> ProductTranslate { get; set; }
        public DbSet<NoticeTranslate> NoticeTranslates { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopLink> ShopLinks { get; set; }
        public DbSet<ShopTranslate> ShopTranslates { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }
        public DbSet<CourierLocation> CourierLocations { get; set; }
        public DbSet<CourierTranslate> CourierTranslates { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<FAQTranslate> FAQTranslates { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceTranslate> ServiceTranslates { get; set; }
        public DbSet<MessageUser> MessageUsers { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsTranslate> NewsTranslates { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Bio> Bio { get; set; }
        public DbSet<ContactNotice> ContactNotice { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
