using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Core
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError() : base("No Such Strategy")
        {
        }

        public NoSuchStrategyError(string message) : base(message)
        {
        }

        public NoSuchStrategyError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSuchStrategyError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
