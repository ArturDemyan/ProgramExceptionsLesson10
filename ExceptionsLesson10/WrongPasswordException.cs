using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLesson10
{
    public class WrongPasswordException: Exception
    {
        private string _infoPasswordException;
        public WrongPasswordException():base() { }
        public WrongPasswordException(string password)
        {
            _infoPasswordException = password;
        }
    }
}
