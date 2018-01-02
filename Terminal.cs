using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLearn
{
    public class Terminal : ITerminal
    {
        public Task<int> GetTerminalId()
        {
            return Task.FromResult<int>(5);
        }

        public Task<string> GetTerminalName()
        {
            return Task.FromResult<string>("TestStr");
        }
    }
}
