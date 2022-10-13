using System;
using System.Collections.Generic;
using System.Text;
using TinyECS.Interfaces;

namespace Undine.TinyECS
{
    public struct TinyEcsComponentWrapper<T>
        where T : struct, IComponent
    {
    }
}