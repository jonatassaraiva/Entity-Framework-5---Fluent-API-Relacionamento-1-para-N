using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramewor5CodeFristFluentAPI.Dominio
{
    public class Post
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public Blog Blog { get; set; }
    }
}
