using DependencyInjectionDemo.Model;
using System.Collections.Generic;

namespace DependencyInjectionDemo.Repository
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> ListAll();
        int Add(Character character);
    }
}
