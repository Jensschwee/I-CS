using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Foundation
{
   public class CreateAdd
    {
       public void createAddress(Address adr)
       {
           using (var db = new CardealerEF())
           {
               // Create and save a new Blog 

               db.Address.Add(adr);
               db.SaveChanges();
           }
       }
    }
}
