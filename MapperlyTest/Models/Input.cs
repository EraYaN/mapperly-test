using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTest.Models;
internal class Input
{
#if HAVE_SETTERS
    internal ICollection<string> Names { get; set; } = [];
    internal ICollection<Sub> SubMessages { get; set; } = [];
    internal ICollection<int> Numbers { get; set; } = [];
#else
    internal ICollection<string> Names { get; } = [];
    internal ICollection<Sub> SubMessages { get; } = [];
    internal ICollection<int> Numbers { get; } = [];
#endif
}
