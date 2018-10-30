using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Door : IPart
    {
        public string Do()
        {
            return "===\n|\t|\n===";
        }

        public string basement()
        {
            throw new NotImplementedException();
        }

        public string house()
        {
            throw new NotImplementedException();
        }

        public string roof()
        {
            throw new NotImplementedException();
        }

        public string walls()
        {
            throw new NotImplementedException();
        }

        public string window()
        {
            throw new NotImplementedException();
        }

        public string door()
        {
            throw new NotImplementedException();
        }
    }
}
