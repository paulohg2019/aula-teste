using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models
{
        public static class SeedData
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new MvcClienteContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<MvcClienteContext>>()))
                {
                    // Look for any movies.
                    if (context.Cliente.Any())
                    {
                        return;   // DB has been seeded
                    }

                    context.Cliente.AddRange(
                        new Cliente
                        {
                            UserName = "Gabriel",
                            Email = "gabriel@hotmail.com",
                            PhoneNumber = 123456789,
                            CPF = 987654321,
                            ReleaseDate = DateTime.Parse("1999-02-08"),
                            Endereco = "Terra do nunca",
                            Complemento = "Casa 0",
                            Coment = "Mandei bem"
                        }             
                    );
                    context.SaveChanges();
                }
            }
        }
    }
