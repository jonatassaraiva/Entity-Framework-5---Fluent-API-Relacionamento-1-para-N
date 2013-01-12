using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFramewor5CodeFristFluentAPI.Repositorio;
using EntityFramewor5CodeFristFluentAPI.Dominio;

namespace EntityFramewor5CodeFristFluentAPI.Testes
{
    [TestClass]
    public class BlogContextTestes
    {
        [TestMethod]
        public void CriarPost()
        {
            Blog blog = new Blog
            {
                Nome = "Blog Teste"
            };

            using (BlogContext banco = new BlogContext())
            {
                if (banco.Blogs.FirstOrDefault() == null)
                {
                    banco.Blogs.Add(blog);
                    banco.SaveChanges();
                }
                else
                    blog = banco.Blogs.First();
            }

            Post post = new Post
            {
                Titulo = "Titulo Blog",
                Conteudo = "Conteudo blog",
                Blog = blog
            };

            using (BlogContext banco = new BlogContext())
            {
                post.Blog = banco.Blogs.Find(post.Blog.Id);
                banco.Posts.Add(post);
                banco.SaveChanges();
            }

            Assert.IsTrue(post.Id != 0);
        }
    }
}
