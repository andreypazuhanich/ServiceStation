using System;
using Microsoft.EntityFrameworkCore;
using ServiceCatalog.Entities;

namespace ServiceCatalog.DbContexts
{
    public class ServiceCatalogDbContext : DbContext
    {
        public ServiceCatalogDbContext(DbContextOptions<ServiceCatalogDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var bodyGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA314}");
            var undercarriageGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA315}");
            var electronicsGuid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA316}");

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = bodyGuid,
                    Name = "Кузовные работы"
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = undercarriageGuid,
                    Name = "Ходовая часть"
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = electronicsGuid,
                    Name = "Электроника"
                });

            modelBuilder.Entity<ServiceItem>().HasData(
                new ServiceItem
                {
                    ServiceItemId = 8,
                    Name = "Полировка",
                    Price =1000M,
                    Description = "Полировка кузова",
                    CategoryId = bodyGuid
                });
            
            modelBuilder.Entity<ServiceItem>().HasData(
                new ServiceItem
                {
                    ServiceItemId = 1,
                    Name = "Покраска",
                    Price =50000M,
                    Description = "Покраска кузова",
                    CategoryId = bodyGuid
                });
            
            modelBuilder.Entity<ServiceItem>().HasData(
                new ServiceItem
                {
                    ServiceItemId = 2,
                    Name = "Диагностика",
                    Price =3000M,
                    Description = "Диагностика подвески",
                    CategoryId = undercarriageGuid
                });
            
            modelBuilder.Entity<ServiceItem>().HasData(
                new ServiceItem
                {
                    ServiceItemId = 3,
                    Name = "Замена сайлентблоков",
                    Price =1500M,
                    Description = "Замена сайлентблоков",
                    CategoryId = undercarriageGuid
                });
            
            modelBuilder.Entity<ServiceItem>().HasData(
                new ServiceItem
                {
                    ServiceItemId = 4,
                    Name = "Ремонт стоек стаблилизатора",
                    Price =5000M,
                    Description = "Ремонт стоек стабилизатора",
                    CategoryId = undercarriageGuid
                });
            
            modelBuilder.Entity<ServiceItem>().HasData(
                new ServiceItem
                {
                    ServiceItemId = 5,
                    Name = "Диагностика системы зажигания",
                    Price =500M,
                    Description = "Диагностика системы зажигания",
                    CategoryId = electronicsGuid
                });
            
            modelBuilder.Entity<ServiceItem>().HasData(
                new ServiceItem
                {
                    ServiceItemId = 6,
                    Name = "Ремонт генератора",
                    Price =3500M,
                    Description = "Ремонт генератора",
                    CategoryId = electronicsGuid
                });
            
            modelBuilder.Entity<ServiceItem>().HasData(
                new ServiceItem
                {
                    ServiceItemId = 7,
                    Name = "Установка парктроника",
                    Price =1000M,
                    Description = "Установка парктроника",
                    CategoryId = electronicsGuid
                });
        }
    }
}