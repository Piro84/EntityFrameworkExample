using EntityFrameworkExample.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Repository
{
    public class BarellRepository
    {
        private DataContext dbContext;

        public BarellRepository()
        {
            dbContext = new DataContext();
        }


    }
}