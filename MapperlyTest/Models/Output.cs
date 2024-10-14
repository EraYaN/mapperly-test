using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTest.Models;
internal class Output
{
    internal Input Input { get; set; }
    internal ICollection<bool> OutValues { get; } = [];
}
