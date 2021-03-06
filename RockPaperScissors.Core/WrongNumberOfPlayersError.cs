﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Core
{
    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError() : base("Wrong Number Of Players")
        {
        }

        public WrongNumberOfPlayersError(string message) : base(message)
        {
        }

        public WrongNumberOfPlayersError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongNumberOfPlayersError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
