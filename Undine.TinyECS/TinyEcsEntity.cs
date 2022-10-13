using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.TinyECS
{
    internal class TinyEcsEntity : IUnifiedEntity
    {
        public void AddComponent<A>(in A component) where A : struct
        {
            throw new NotImplementedException();
        }

        public ref A GetComponent<A>() where A : struct
        {
            throw new NotImplementedException();
        }
    }
}