using System;
using System.Collections.Generic;
using System.Text;
using TinyECS.Impls;
using TinyECS.Interfaces;
using Undine.Core;

namespace Undine.TinyECS
{
    public class TinyEcsContainer : EcsContainer
    {
        private IWorldContext _worldContext;
        private SystemManager _systemManager;

        public TinyEcsContainer()
        {
            _worldContext = new WorldContextFactory().CreateNewWorldInstance();

            _systemManager = new SystemManager(_worldContext);
        }

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            throw new NotImplementedException();
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            throw new NotImplementedException();
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            throw new NotImplementedException();
        }

        public override Core.ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            throw new NotImplementedException();
        }

        public override Core.ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            throw new NotImplementedException();
        }

        public override Core.ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            throw new NotImplementedException();
        }

        public override Core.ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}