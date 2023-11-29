namespace StatePattern.Simple
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}