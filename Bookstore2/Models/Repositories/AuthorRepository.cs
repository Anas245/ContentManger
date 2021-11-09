using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore2.Models.Repositories
{
    public class AuthorRepository : IBookStoreRepository2<Author>
    {
        IList<Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>()
            { new Author { ID = 1 , FullName = " Anas Abdulbaset "},
                new Author { ID = 2 , FullName = " mohmaed saead "},
                new Author { ID = 3 , FullName = " mosa kosa  "}};
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(a => a.ID == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            author.FullName = newAuthor.FullName;
        }
    }
}
