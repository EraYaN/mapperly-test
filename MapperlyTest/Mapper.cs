using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MapperlyTest.Models;
using MapperlyTest.Protos;

using Riok.Mapperly.Abstractions;

namespace MapperlyTest;


[Mapper]
internal static partial class Mapper
{
    internal static partial Input ToInternalInput(this InputModel input);

    internal static partial InputModel ToExternalInput(this Input input);

    internal static partial Output ToInternalOutput(this OutputModel input);

    internal static partial OutputModel ToExternalOutput(this Output input);

    internal static partial Sub ToInternalSub(this SubMessage input);

    internal static partial SubMessage ToExternalSub(this Sub input);
}
