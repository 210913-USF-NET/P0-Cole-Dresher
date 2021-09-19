using Models;
using System.Collections.Generic;

namespace StoreBL
{
    public interface IBL
    {
         List<StoreFront> GetAllStoreFronts();
    }
}