using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore2.Models.Repositories
{
    public class BookStoreRepository2 : IBookStoreRepository2<Book>
    {
        List<Book> books;// list of type Book and name it as books 
        //يجب ان نعمل انشاء للست داخل كونستراكتور 
        public BookStoreRepository2()
        {
            books = new List<Book>()// عند الانتهاء من كتابت الكتاب الاول اعمل كوبي ضع فاصلة في المكان الذي عليه علامة ! ثم انسخ النسخ بعد الفاصلة 
         {
             new Book// الكتاب الاول 
             {
                 ID = 1,Title = " C# programing ",Desciption = " No descrption"
             },//!
              new Book// الكتاب الثاني 
             {
                 ID = 2,Title = " Java programing ",Desciption = " Nothing"
             }, new Book//الكتاب الثالث 
             {
                 ID = 3,Title = " Python ",Desciption = " No Data"
             }
         };
                
        }

        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);//اعثر على الكتاب الذي يحقق الشرط التالي 
            books.Remove(book);//تزيل هذا العنصر هذا الكتاب 
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.ID == id);//SingleOrDefault معناه انه سيجلب عنصر واحد او العنصر الافتراضي 
            return book;
                                                              
        }

        public IList<Book> List()//تم تعريف هذه الميثود بنجاح عن طريق بناء الست التي بالاعلى  و كتابة امر return books ; بداخلها 
        {
            return books;
        }



        public void Update(int id, Book newBook)
        {
            var book = Find(id);//بسبب تكرار الكود 
            book.Title = newBook.Title;//الكتاب الموجود سابقا يحول عنوانه الى العنوان الجديد 
            book.Desciption = newBook.Desciption;//الكتاب الموجود سابقا حول النبذه الى النبذه الجديدة 
            book.Author = newBook.Author;//اسم الكاتب القديم حول اسمه الى اسم الكاتب الجديد 

        }
    }
}
