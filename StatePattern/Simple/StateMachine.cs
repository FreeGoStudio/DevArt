namespace StatePattern.Simple
{
    public class StateMachine
    {
        public IState IdleState { get; private set; }
        public IState RunState { get; private set; }
        public IState AttackState { get; private set; }
        public IState RiseState { get; private set; }
        public IState FallState { get; private set; }

        public IState State;

        public StateMachine()
        {
            this.IdleState = new IdleState(this);
            this.RunState = new RunState(this);
            this.AttackState = new AttackState(this);
            this.RiseState = new RiseState(this);
            this.FallState = new FallState(this);

            this.State = this.IdleState;
        }

        public void SetState(IState state)
        {
            this.State = state;
        }
    }
}