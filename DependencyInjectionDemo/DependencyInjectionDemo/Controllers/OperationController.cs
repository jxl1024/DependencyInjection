using DependencyInjectionDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemo.Controllers
{
    public class OperationController : Controller
    {
        // 定义私有字段
        private readonly IOperationTransientRepository _transientRepository;
        private readonly IOperationScopeRepository _scopeRepository;
        private readonly IOperationSingletonRepository _singletonRepository;

        /// <summary>
        /// 通过构造函数实现注入
        /// </summary>
        /// <param name="transientRepository"></param>
        /// <param name="scopeRepository"></param>
        /// <param name="singletonRepository"></param>
        public OperationController(IOperationTransientRepository transientRepository,
            IOperationScopeRepository scopeRepository,
            IOperationSingletonRepository singletonRepository)
        {
            _transientRepository = transientRepository;
            _scopeRepository = scopeRepository;
            _singletonRepository = singletonRepository;
        }


        public IActionResult Index()
        {
            // ViewBag赋值
            ViewBag.TransientGuid = _transientRepository.GetOperationId();
            ViewBag.ScopedGuid = _scopeRepository.GetOperationId();
            ViewBag.SingletonGuid = _singletonRepository.GetOperationId();
            return View();
        }
    }
}