using System.Linq;
using DependencyInjectionDemo.Model;
using DependencyInjectionDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemo.Controllers
{
    public class CharactersController : Controller
    {
        // 定义私有的只读字段
        private readonly ICharacterRepository _characterRepository;

        /// <summary>
        /// 通过构造函数注入并且给私有字段赋值
        /// </summary>
        /// <param name="characterRepository"></param>
        public CharactersController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        private void PopulateCharactersIfNoneExist()
        {
            // 如果不存在则添加
            if(!_characterRepository.ListAll().Any())
            {
                _characterRepository.Add(new Character("Tom"));
                _characterRepository.Add(new Character("Jack"));
                _characterRepository.Add(new Character("Kevin"));
            }
        }
    }
}