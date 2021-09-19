using System.Collections.Generic;
using Models;

namespace StoreDL
{
    public class ExampleRepo: IRepo
    {
        public List<StoreFront> GetAllStoreFronts()
        {
            //put your logic to get data here
            return new List<StoreFront>()
            {
                new StoreFront()
                {
                    Name = "Store One"
                }
            };
        }
    }
}