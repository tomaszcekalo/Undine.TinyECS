using System;
using System.Collections.Generic;
using System.Text;
using TinyECS.Impls;
using TinyECS.Interfaces;
using Undine.Core;

namespace Undine.TinyECS
{
    public class TinyEcsSystem<T> : BaseReactiveSystem, Core.ISystem
        where T : struct, IComponent
    {
        public override bool Filter(IEntity entity)
        {
            return entity.HasComponent<T>();
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(List<IEntity> entities, float deltaTime)
        {
            throw new NotImplementedException();
        }
    }

    public class TinyEcsSystem<A, B> : BaseReactiveSystem, Core.ISystem
    {
        public override bool Filter(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(List<IEntity> entities, float deltaTime)
        {
            throw new NotImplementedException();
        }
    }

    public class TinyEcsSystem<A, B, C> : BaseReactiveSystem, Core.ISystem
    {
        public override bool Filter(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(List<IEntity> entities, float deltaTime)
        {
            throw new NotImplementedException();
        }
    }

    public class TinyEcsSystem<A, B, C, D> : BaseReactiveSystem, Core.ISystem
    {
        public override bool Filter(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(List<IEntity> entities, float deltaTime)
        {
            throw new NotImplementedException();
        }
    }
}