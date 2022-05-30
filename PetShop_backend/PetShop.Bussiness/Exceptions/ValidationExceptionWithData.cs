using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop_backend.PetShop.Bussiness.Exceptions
{
      public class ValidationExceptionWithData<T>: Exception
    {
        private T _data;

        public ValidationExceptionWithData(string message, T data): base(message)
        {
            _data = data;
        }

        public T GetData()
        {
            return _data;
        }
    }
}