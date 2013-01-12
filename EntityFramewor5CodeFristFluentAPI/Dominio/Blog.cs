using System.Collections.Generic;

namespace EntityFramewor5CodeFristFluentAPI.Dominio
{
    public class Blog
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
