using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLesson10
{
    public class WrongLoginException:Exception
    {
        private string _infoException;
        public WrongLoginException() { }
        public WrongLoginException(string infoException) :base(infoException)
        {
            _infoException = infoException;
        }
    }
}
