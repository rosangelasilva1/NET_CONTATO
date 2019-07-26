﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleContato.Excecoes
{
    //Snippet de código Exception <TAB><TAB>

    [Serializable]
    public class ValidacaoException : Exception
    {
        public ValidacaoException() { }
        public ValidacaoException(string message) : base(message) { }
        public ValidacaoException(string message, Exception inner) : base(message, inner) { }
        protected ValidacaoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
