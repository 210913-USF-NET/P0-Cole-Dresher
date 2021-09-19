using System.Collections.Generic;
using Models;

namespace StoreDL

{
    public interface IRepo
    {
         List<StoreFront> GetAllStoreFronts();
    }
}