using System;

namespace ExplicitDependenciesPrinciple.Original
{
    public class Client
    {
        public string Login()
        {
            return $"用户:{Context.GetCurrentUser().Name} 已登陆!";
        }
    }
}