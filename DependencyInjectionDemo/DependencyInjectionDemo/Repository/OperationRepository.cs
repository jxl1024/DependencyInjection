using System;

namespace DependencyInjectionDemo.Repository
{
    public class OperationRepository : IOperationRepository
    {
        private readonly Guid _guid;

        public OperationRepository()
        {
            _guid = Guid.NewGuid();
        }

        public  Guid GetOperationId()
        {
            return _guid;
        }
    }

    public class OperationTransientRepository : OperationRepository, IOperationTransientRepository
    {

    }

    public class OperationScopeRepository : OperationRepository, IOperationScopeRepository
    {

    }

    public class OperationSingletonRepository : OperationRepository, IOperationSingletonRepository
    {

    }
}
