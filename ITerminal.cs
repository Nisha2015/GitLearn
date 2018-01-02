using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLearn
{
    public interface ITerminal
    {
        Task<int> GetTerminalId();
        Task<string> GetTerminalName(); 
    }
}
