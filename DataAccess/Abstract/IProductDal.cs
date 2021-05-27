using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{

    //interface methodları default olarak publictir. ama interface in kendisi internal olduğu için diğer katmanlardan bu interface e 
    //erişmek için interface önüne public yazılır.
    public interface IProductDal:IEntityRepository<Product>
    {
        

    }
}
