namespace ExplicitDependenciesPrinciple.Improve
{
    public class Client
    {
        public string Login(User user)
        {
            return $"用户:{user.Name} 已登陆!";
        }
    }
}