using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTest.Models;
internal class Input
{
    internal ICollection<string> Names { get; } = [];
    internal ICollection<Sub> SubMessages { get; } = [];
    internal ICollection<int> Numbers { get; } = [];
}
