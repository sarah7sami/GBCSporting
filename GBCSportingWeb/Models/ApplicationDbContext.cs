﻿using Microsoft.EntityFrameworkCore;

namespace GBCSportingWeb.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base( options )
        {
                      
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Incident> Incidents { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Technician> Technicians { get; set; }

        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "Afghanistan" },
                new Country { CountryId = 2, Name = "Albania" },
                new Country { CountryId = 3, Name = "Algeria" },
                new Country { CountryId = 4, Name = "Andorra" },
                new Country { CountryId = 5, Name = "Angola" },
                new Country { CountryId = 6, Name = "Antigua and Barbuda" },
                new Country { CountryId = 7, Name = "Argentina" },
                new Country { CountryId = 8, Name = "Armenia" },
                new Country { CountryId = 9, Name = "Australia" },
                new Country { CountryId = 10, Name = "Austria" },
                new Country { CountryId = 11, Name = "Azerbaijan" },
                new Country { CountryId = 12, Name = "Bahamas" },
                new Country { CountryId = 13, Name = "Bahrain" },
                new Country { CountryId = 14, Name = "Bangladesh" },
                new Country { CountryId = 15, Name = "Barbados" },
                new Country { CountryId = 16, Name = "Belarus" },
                new Country { CountryId = 17, Name = "Belgium" },
                new Country { CountryId = 18, Name = "Belize" },
                new Country { CountryId = 19, Name = "Benin" },
                new Country { CountryId = 20, Name = "Bhutan" },
                new Country { CountryId = 21, Name = "Bolivia" },
                new Country { CountryId = 22, Name = "Bosnia and Herzegovina" },
                new Country { CountryId = 23, Name = "Botswana" },
                new Country { CountryId = 24, Name = "Brazil" },
                new Country { CountryId = 25, Name = "Brunei" },
                new Country { CountryId = 26, Name = "Bulgaria" },
                new Country { CountryId = 27, Name = "Burkina Faso" },
                new Country { CountryId = 28, Name = "Burundi" },
                new Country { CountryId = 29, Name = "CÃ´te d'Ivoire" },
                new Country { CountryId = 30, Name = "Cabo Verde" },
                new Country { CountryId = 31, Name = "Cambodia" },
                new Country { CountryId = 32, Name = "Cameroon" },
                new Country { CountryId = 33, Name = "Canada" },
                new Country { CountryId = 34, Name = "Central African Republic" },
                new Country { CountryId = 35, Name = "Chad" },
                new Country { CountryId = 36, Name = "Chile" },
                new Country { CountryId = 37, Name = "China" },
                new Country { CountryId = 38, Name = "Colombia" },
                new Country { CountryId = 39, Name = "Comoros" },
                new Country { CountryId = 40, Name = "Congo (Congo-Brazzaville)" },
                new Country { CountryId = 41, Name = "Costa Rica" },
                new Country { CountryId = 42, Name = "Croatia" },
                new Country { CountryId = 43, Name = "Cuba" },
                new Country { CountryId = 44, Name = "Cyprus" },
                new Country { CountryId = 45, Name = "Czechia (Czech Republic)" },
                new Country { CountryId = 46, Name = "Democratic Republic of the Congo" },
                new Country { CountryId = 47, Name = "Denmark" },
                new Country { CountryId = 48, Name = "Djibouti" },
                new Country { CountryId = 49, Name = "Dominica" },
                new Country { CountryId = 50, Name = "Dominican Republic" },
                new Country { CountryId = 51, Name = "Ecuador" },
                new Country { CountryId = 52, Name = "Egypt" },
                new Country { CountryId = 53, Name = "El Salvador" },
                new Country { CountryId = 54, Name = "Equatorial Guinea" },
                new Country { CountryId = 55, Name = "Eritrea" },
                new Country { CountryId = 56, Name = "Estonia" },
                new Country { CountryId = 57, Name = "Eswatini" },
                new Country { CountryId = 58, Name = "Ethiopia" },
                new Country { CountryId = 59, Name = "Fiji" },
                new Country { CountryId = 60, Name = "Finland" },
                new Country { CountryId = 61, Name = "France" },
                new Country { CountryId = 62, Name = "Gabon" },
                new Country { CountryId = 63, Name = "Gambia" },
                new Country { CountryId = 64, Name = "Georgia" },
                new Country { CountryId = 65, Name = "Germany" },
                new Country { CountryId = 66, Name = "Ghana" },
                new Country { CountryId = 67, Name = "Greece" },
                new Country { CountryId = 68, Name = "Grenada" },
                new Country { CountryId = 69, Name = "Guatemala" },
                new Country { CountryId = 70, Name = "Guinea" },
                new Country { CountryId = 71, Name = "Guinea-Bissau" },
                new Country { CountryId = 72, Name = "Guyana" },
                new Country { CountryId = 73, Name = "Haiti" },
                new Country { CountryId = 74, Name = "Holy See" },
                new Country { CountryId = 75, Name = "Honduras" },
                new Country { CountryId = 76, Name = "Hungary" },
                new Country { CountryId = 77, Name = "Iceland" },
                new Country { CountryId = 78, Name = "India" },
                new Country { CountryId = 79, Name = "Indonesia" },
                new Country { CountryId = 80, Name = "Iran" },
                new Country { CountryId = 81, Name = "Iraq" },
                new Country { CountryId = 82, Name = "Ireland" },
                new Country { CountryId = 83, Name = "Israel" },
                new Country { CountryId = 84, Name = "Italy" },
                new Country { CountryId = 85, Name = "Jamaica" },
                new Country { CountryId = 86, Name = "Japan" },
                new Country { CountryId = 87, Name = "Jordan" },
                new Country { CountryId = 88, Name = "Kazakhstan" },
                new Country { CountryId = 89, Name = "Kenya" },
                new Country { CountryId = 90, Name = "Kiribati" },
                new Country { CountryId = 91, Name = "Kuwait" },
                new Country { CountryId = 92, Name = "Kyrgyzstan" },
                new Country { CountryId = 93, Name = "Laos" },
                new Country { CountryId = 94, Name = "Latvia" },
                new Country { CountryId = 95, Name = "Lebanon" },
                new Country { CountryId = 96, Name = "Lesotho" },
                new Country { CountryId = 97, Name = "Liberia" },
                new Country { CountryId = 98, Name = "Libya" },
                new Country { CountryId = 99, Name = "Liechtenstein" },
                new Country { CountryId = 100, Name = "Lithuania" },
                new Country { CountryId = 101, Name = "Luxembourg" },
                new Country { CountryId = 102, Name = "Madagascar" },
                new Country { CountryId = 103, Name = "Malawi" },
                new Country { CountryId = 104, Name = "Malaysia" },
                new Country { CountryId = 105, Name = "Maldives" },
                new Country { CountryId = 106, Name = "Mali" },
                new Country { CountryId = 107, Name = "Malta" },
                new Country { CountryId = 108, Name = "Marshall Islands" },
                new Country { CountryId = 109, Name = "Mauritania" },
                new Country { CountryId = 110, Name = "Mauritius" },
                new Country { CountryId = 111, Name = "Mexico" },
                new Country { CountryId = 112, Name = "Micronesia" },
                new Country { CountryId = 113, Name = "Moldova" },
                new Country { CountryId = 114, Name = "Monaco" },
                new Country { CountryId = 115, Name = "Mongolia" },
                new Country { CountryId = 116, Name = "Montenegro" },
                new Country { CountryId = 117, Name = "Morocco" },
                new Country { CountryId = 118, Name = "Mozambique" },
                new Country { CountryId = 119, Name = "Myanmar (formerly Burma)" },
                new Country { CountryId = 120, Name = "Namibia" },
                new Country { CountryId = 121, Name = "Nauru" },
                new Country { CountryId = 122, Name = "Nepal" },
                new Country { CountryId = 123, Name = "Netherlands" },
                new Country { CountryId = 124, Name = "New Zealand" },
                new Country { CountryId = 125, Name = "Nicaragua" },
                new Country { CountryId = 126, Name = "Niger" },
                new Country { CountryId = 127, Name = "Nigeria" },
                new Country { CountryId = 128, Name = "North Korea" },
                new Country { CountryId = 129, Name = "North Macedonia" },
                new Country { CountryId = 130, Name = "Norway" },
                new Country { CountryId = 131, Name = "Oman" },
                new Country { CountryId = 132, Name = "Pakistan" },
                new Country { CountryId = 133, Name = "Palau" },
                new Country { CountryId = 134, Name = "Palestine State" },
                new Country { CountryId = 135, Name = "Panama" },
                new Country { CountryId = 136, Name = "Papua New Guinea" },
                new Country { CountryId = 137, Name = "Paraguay" },
                new Country { CountryId = 138, Name = "Peru" },
                new Country { CountryId = 139, Name = "Philippines" },
                new Country { CountryId = 140, Name = "Poland" },
                new Country { CountryId = 141, Name = "Portugal" },
                new Country { CountryId = 142, Name = "Qatar" },
                new Country { CountryId = 143, Name = "Romania" },
                new Country { CountryId = 144, Name = "Russia" },
                new Country { CountryId = 145, Name = "Rwanda" },
                new Country { CountryId = 146, Name = "Saint Kitts and Nevis" },
                new Country { CountryId = 147, Name = "Saint Lucia" },
                new Country { CountryId = 148, Name = "Saint Vincent and the Grenadines" },
                new Country { CountryId = 149, Name = "Samoa" },
                new Country { CountryId = 150, Name = "San Marino" },
                new Country { CountryId = 151, Name = "Sao Tome and Principe" },
                new Country { CountryId = 152, Name = "Saudi Arabia" },
                new Country { CountryId = 153, Name = "Senegal" },
                new Country { CountryId = 154, Name = "Serbia" },
                new Country { CountryId = 155, Name = "Seychelles" },
                new Country { CountryId = 156, Name = "Sierra Leone" },
                new Country { CountryId = 157, Name = "Singapore" },
                new Country { CountryId = 158, Name = "Slovakia" },
                new Country { CountryId = 159, Name = "Slovenia" },
                new Country { CountryId = 160, Name = "Solomon Islands" },
                new Country { CountryId = 161, Name = "Somalia" },
                new Country { CountryId = 162, Name = "South Africa" },
                new Country { CountryId = 163, Name = "South Korea" },
                new Country { CountryId = 164, Name = "South Sudan" },
                new Country { CountryId = 165, Name = "Spain" },
                new Country { CountryId = 166, Name = "Sri Lanka" },
                new Country { CountryId = 167, Name = "Sudan" },
                new Country { CountryId = 168, Name = "Suriname" },
                new Country { CountryId = 169, Name = "Sweden" },
                new Country { CountryId = 170, Name = "Switzerland" },
                new Country { CountryId = 171, Name = "Syria" },
                new Country { CountryId = 172, Name = "Tajikistan" },
                new Country { CountryId = 173, Name = "Tanzania" },
                new Country { CountryId = 174, Name = "Thailand" },
                new Country { CountryId = 175, Name = "Timor-Leste" },
                new Country { CountryId = 176, Name = "Togo" },
                new Country { CountryId = 177, Name = "Tonga" },
                new Country { CountryId = 178, Name = "Trinidad and Tobago" },
                new Country { CountryId = 179, Name = "Tunisia" },
                new Country { CountryId = 180, Name = "Turkey" },
                new Country { CountryId = 181, Name = "Turkmenistan" },
                new Country { CountryId = 182, Name = "Tuvalu" },
                new Country { CountryId = 183, Name = "Uganda" },
                new Country { CountryId = 184, Name = "Ukraine" },
                new Country { CountryId = 185, Name = "United Arab Emirates" },
                new Country { CountryId = 186, Name = "United Kingdom" },
                new Country { CountryId = 187, Name = "United States of America" },
                new Country { CountryId = 188, Name = "Uruguay" },
                new Country { CountryId = 189, Name = "Uzbekistan" },
                new Country { CountryId = 190, Name = "Vanuatu" },
                new Country { CountryId = 191, Name = "Venezuela" },
                new Country { CountryId = 192, Name = "Vietnam" },
                new Country { CountryId = 193, Name = "Yemen" },
                new Country { CountryId = 194, Name = "Zambia" },
                new Country { CountryId = 195, Name = "Zimbabwe" });

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FirstName = "Thom", LastName = "Mundstock", Address="203 Avenua", City ="Toronto", State = "Ontario", PostalCode = "M2M 3U2", CountryId = 33, Email = "Thom.Mundstock@gmail.com" },
                new Customer { CustomerId = 2, FirstName = "Stanley", LastName = "Tsonev", Address = "4th Avenue", City = "NYC", State = "New York", PostalCode = "J1C 8Y1", CountryId = 187, Email="Stanley.Tsonev@gmail.com" },
                new Customer { CustomerId = 3, FirstName = "Farshad", LastName = "Jalali", Address = "7th Avenue", City = "Tehran", State = "Tehran", PostalCode = "k1C 9T1", CountryId = 80, Email = "Farshad.Jalali@gmail.com" });

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductCode = "TPYR1090", ProductName = "Tournament Master 1.0", YearlyPrice = 9.99, ReleaseDate = DateTime.Now},
                new Product { ProductId = 2, ProductCode = "WURE0115", ProductName = "League Scheduler 1.0", YearlyPrice = 50.98, ReleaseDate = DateTime.Now });

            modelBuilder.Entity<Technician>().HasData(
                new Technician { TechnicianId = 1, Name = "Sarah Sami", Email= "Sarah.Sami@georgebrown.ca", Phone = "4168290752"},
                new Technician { TechnicianId = 2, Name = "Tanja Jamie", Email= "Tanja.Jamie@georgebrown.ca", Phone = "4167620781" });

            modelBuilder.Entity<Incident>().HasData(
                new Incident { IncidentId = 1, CustomerId = 1, ProductId = 1, TechnicianId = 1, Title = "Problem!!", DateOpened = DateTime.Now, DateClosed = DateTime.Now },
                new Incident { IncidentId = 2, CustomerId = 2, ProductId = 2, TechnicianId = 2, Title = "Another one!!!", DateOpened = DateTime.Now, DateClosed = DateTime.Now });

            modelBuilder.Entity<Registration>()
            .HasOne(pd => pd.Product)
            .WithMany(r => r.Regstrations)
            .HasForeignKey(pd => pd.ProductId);

            modelBuilder.Entity<Registration>()
            .HasOne(cs => cs.Customer)
            .WithMany(r => r.Regstrations)
            .HasForeignKey(cs => cs.CustomerId);

            modelBuilder.Entity<Registration>().HasData(
                new Registration { Id = 1, CustomerId = 1, ProductId = 1 });
            modelBuilder.Entity<Registration>().HasData(
                new Registration { Id = 2, CustomerId = 2, ProductId = 1 });
            modelBuilder.Entity<Registration>().HasData(
                new Registration { Id = 3, CustomerId = 2, ProductId = 2 });
        }

    }
}
