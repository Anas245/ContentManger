﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string Desciption { get; set; }

        public Author Author  { get; set; }// حتى نستطيع ان نصل الى المؤلف الخاص بهذا الكتاب 



    }
}
