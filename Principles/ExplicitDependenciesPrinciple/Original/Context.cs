namespace ExplicitDependenciesPrinciple.Original
{
    public static class Context
    {
        public static User CurrentUser;

        public static User GetCurrentUser()
        {
            return CurrentUser;
        }
    }
}