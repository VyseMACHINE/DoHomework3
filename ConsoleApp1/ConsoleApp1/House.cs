using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class House : IPart
    {
        string str;
        public string Do()
        {
            return "Дом построен!";
        }

        string IPart.basement()
        {
            throw new NotImplementedException();
        }

        string IPart.walls()
        {
            throw new NotImplementedException();
        }

        string IPart.door()
        {
            throw new NotImplementedException();
        }

        string IPart.window()
        {
            throw new NotImplementedException();
        }

        string IPart.roof()
        {
            throw new NotImplementedException();
        }

        public string house()
        {
            throw new NotImplementedException();
        }
    }
}
