using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTest.Models;
internal class Output
{
    internal Input Input { get; set; }
#if HAVE_SETTERS
    internal ICollection<bool> OutValues { get; set; } = [];
#else
    internal ICollection<bool> OutValues { get; } = [];
#endif
}
