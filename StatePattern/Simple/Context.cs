namespace StatePattern.Simple
{
    public class Context
    {
        public State CurrentState { get; private set; }

        public Context(State state)
        {
            this.CurrentState = state;
        }

        public void SetStatae(State state)
        {
            this.CurrentState = state;
        }

        public void Do()
        {
            this.CurrentState.Handle(this);
        }
    }
}