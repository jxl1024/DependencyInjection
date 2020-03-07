using DependencyInjectionDemo.Context;
using DependencyInjectionDemo.Model;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionDemo.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        // 定义私有字段
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// 通过构造函数注入，并且给私有字段赋值
        /// </summary>
        /// <param name="dbContext"></param>
        public CharacterRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(Character character)
        {
            // 添加
            _dbContext.Characters.Add(character);
            // 保存
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Character> ListAll()
        {
            return _dbContext.Characters.AsEnumerable();
        }
    }
}
