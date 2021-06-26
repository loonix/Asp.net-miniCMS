using miniCMS.Models;
using System;
using System.Linq;

namespace miniCMS.Data
{
    public class DbInitializer
    {
        public static void Initialize(DbMiniCMSContext context)
        {
            context.Database.EnsureCreated();
            // Look for any conteudo.
            if (context.Conteudos.Any())
            {
                return; // DB has been seeded
            }
            Conteudo novoConteudo = new Conteudo
            {
                Pagina = "Home",
                Titulo = "<h1>Home</h1>",
                Texto = "<p>Bem vindo ao <b>Sistema miniCMS</b></p>" +
                        "<p>Todo o conteudo do site está numa <b>base de dados</b></p>" +
                        "<img src = '/cms/media/minicms.jpg' /> ",
                Autor = "miniCMS",
                Data = DateTime.Now
            };
            context.Conteudos.Add(novoConteudo);
            context.SaveChanges();

        }
    }
}
