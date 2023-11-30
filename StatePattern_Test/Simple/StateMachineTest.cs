using NUnit.Framework;
using StatePattern.Simple;

namespace StatePattern_Test.Simple
{
    [TestFixture]
    public class StateMachineTest
    {
        private StateMachine context;

        [SetUp]
        protected void SetUp()
        {
            this.context = new StateMachine();
        }

        [TearDown]
        protected void ClearUp()
        {
            this.context = null;
        }

        [Test]
        public void CreateStateMachine_Test()
        {
            Assert.AreEqual(this.context.IdleState, this.context.State);
        }

        [Test]
        public void SetState_Test()
        {
            this.context.SetState(this.context.IdleState);
            Assert.AreEqual(this.context.IdleState, this.context.State);

            this.context.SetState(this.context.RunState);
            Assert.AreEqual(this.context.RunState, this.context.State);

            this.context.SetState(this.context.AttackState);
            Assert.AreEqual(this.context.AttackState, this.context.State);

            this.context.SetState(this.context.RiseState);
            Assert.AreEqual(this.context.RiseState, this.context.State);

            this.context.SetState(this.context.FallState);
            Assert.AreEqual(this.context.FallState, this.context.State);
        }

        [Test]
        public void Do_Idle_InputAttackCommand_Test()
        {
            this.context.SetState(this.context.IdleState);
            this.context.State.InputAttackCommand();
            Assert.AreSame(this.context.AttackState, this.context.State);
        }

        [Test]
        public void Do_Idle_AttackActionComplete_Test()
        {
            this.context.SetState(this.context.IdleState);
            this.context.State.AttackActionComplete();
            Assert.AreSame(this.context.IdleState, this.context.State);
        }

        [Test]
        public void Do_Idle_InputXThanThresholdValue_Test()
        {
            this.context.SetState(this.context.IdleState);
            this.context.State.InputXThanThresholdValue();
            Assert.AreSame(this.context.RunState,this.context.State);
        }

        [Test]
        public void Do_Idle_InputXLessThresholdValue_Test()
        {
            this.context.SetState(this.context.IdleState);
            this.context.State.InputXLessThresholdValue();
            Assert.AreSame(this.context.IdleState,this.context.State);
        }

        [Test]
        public void Do_Idle_InputJumpCommand_Test()
        {
            this.context.SetState(this.context.IdleState);
            this.context.State.InputJumpCommand();
            Assert.AreSame(this.context.RiseState,this.context.State);
        }

        [Test]
        public void Do_Idle_YVelocityLessThresholdValue_Test()
        {
            this.context.SetState(this.context.IdleState);
            this.context.State.YVelocityLessThresholdValue();
            Assert.AreSame(this.context.FallState,this.context.State);
        }

        [Test]
        public void Do_Idle_CharacterTouchPlane_Test()
        {
            this.context.SetState(this.context.IdleState);
            this.context.State.CharacterTouchPlane();
            Assert.AreSame(this.context.IdleState,this.context.State);
        }
        
        [Test]
        public void Do_Run_InputAttackCommand_Test()
        {
            this.context.SetState(this.context.RunState);
            this.context.State.InputAttackCommand();
            Assert.AreSame(this.context.RunState, this.context.State);
        }

        [Test]
        public void Do_Run_AttackActionComplete_Test()
        {
            this.context.SetState(this.context.RunState);
            this.context.State.AttackActionComplete();
            Assert.AreSame(this.context.RunState, this.context.State);
        }

        [Test]
        public void Do_Run_InputXThanThresholdValue_Test()
        {
            this.context.SetState(this.context.RunState);
            this.context.State.InputXThanThresholdValue();
            Assert.AreSame(this.context.RunState,this.context.State);
        }

        [Test]
        public void Do_Run_InputXLessThresholdValue_Test()
        {
            this.context.SetState(this.context.RunState);
            this.context.State.InputXLessThresholdValue();
            Assert.AreSame(this.context.IdleState,this.context.State);
        }

        [Test]
        public void Do_Run_InputJumpCommand_Test()
        {
            this.context.SetState(this.context.RunState);
            this.context.State.InputJumpCommand();
            Assert.AreSame(this.context.RunState,this.context.State);
        }

        [Test]
        public void Do_Run_YVelocityLessThresholdValue_Test()
        {
            this.context.SetState(this.context.RunState);
            this.context.State.YVelocityLessThresholdValue();
            Assert.AreSame(this.context.RunState,this.context.State);
        }

        [Test]
        public void Do_Run_CharacterTouchPlane_Test()
        {
            this.context.SetState(this.context.RunState);
            this.context.State.CharacterTouchPlane();
            Assert.AreSame(this.context.RunState,this.context.State);
        }
        
                
        [Test]
        public void Do_Attack_InputAttackCommand_Test()
        {
            this.context.SetState(this.context.AttackState);
            this.context.State.InputAttackCommand();
            Assert.AreSame(this.context.AttackState, this.context.State);
        }

        [Test]
        public void Do_Attack_AttackActionComplete_Test()
        {
            this.context.SetState(this.context.AttackState);
            this.context.State.AttackActionComplete();
            Assert.AreSame(this.context.IdleState, this.context.State);
        }

        [Test]
        public void Do_Attack_InputXThanThresholdValue_Test()
        {
            this.context.SetState(this.context.AttackState);
            this.context.State.InputXThanThresholdValue();
            Assert.AreSame(this.context.AttackState,this.context.State);
        }

        [Test]
        public void Do_Attack_InputXLessThresholdValue_Test()
        {
            this.context.SetState(this.context.AttackState);
            this.context.State.InputXLessThresholdValue();
            Assert.AreSame(this.context.AttackState,this.context.State);
        }

        [Test]
        public void Do_Attack_InputJumpCommand_Test()
        {
            this.context.SetState(this.context.AttackState);
            this.context.State.InputJumpCommand();
            Assert.AreSame(this.context.AttackState,this.context.State);
        }

        [Test]
        public void Do_Attack_YVelocityLessThresholdValue_Test()
        {
            this.context.SetState(this.context.AttackState);
            this.context.State.YVelocityLessThresholdValue();
            Assert.AreSame(this.context.AttackState,this.context.State);
        }

        [Test]
        public void Do_Attack_CharacterTouchPlane_Test()
        {
            this.context.SetState(this.context.AttackState);
            this.context.State.CharacterTouchPlane();
            Assert.AreSame(this.context.AttackState,this.context.State);
        }
        
        [Test]
        public void Do_Rise_InputAttackCommand_Test()
        {
            this.context.SetState(this.context.RiseState);
            this.context.State.InputAttackCommand();
            Assert.AreSame(this.context.RiseState, this.context.State);
        }

        [Test]
        public void Do_Rise_AttackActionComplete_Test()
        {
            this.context.SetState(this.context.RiseState);
            this.context.State.AttackActionComplete();
            Assert.AreSame(this.context.RiseState, this.context.State);
        }

        [Test]
        public void Do_Rise_InputXThanThresholdValue_Test()
        {
            this.context.SetState(this.context.RiseState);
            this.context.State.InputXThanThresholdValue();
            Assert.AreSame(this.context.RiseState,this.context.State);
        }

        [Test]
        public void Do_Rise_InputXLessThresholdValue_Test()
        {
            this.context.SetState(this.context.RiseState);
            this.context.State.InputXLessThresholdValue();
            Assert.AreSame(this.context.RiseState,this.context.State);
        }

        [Test]
        public void Do_Rise_InputJumpCommand_Test()
        {
            this.context.SetState(this.context.RiseState);
            this.context.State.InputJumpCommand();
            Assert.AreSame(this.context.RiseState,this.context.State);
        }

        [Test]
        public void Do_Rise_YVelocityLessThresholdValue_Test()
        {
            this.context.SetState(this.context.RiseState);
            this.context.State.YVelocityLessThresholdValue();
            Assert.AreSame(this.context.FallState,this.context.State);
        }

        [Test]
        public void Do_Rise_CharacterTouchPlane_Test()
        {
            this.context.SetState(this.context.RiseState);
            this.context.State.CharacterTouchPlane();
            Assert.AreSame(this.context.RiseState,this.context.State);
        }
        
        [Test]
        public void Do_Fall_InputAttackCommand_Test()
        {
            this.context.SetState(this.context.FallState);
            this.context.State.InputAttackCommand();
            Assert.AreSame(this.context.FallState, this.context.State);
        }

        [Test]
        public void Do_Fall_AttackActionComplete_Test()
        {
            this.context.SetState(this.context.FallState);
            this.context.State.AttackActionComplete();
            Assert.AreSame(this.context.FallState, this.context.State);
        }

        [Test]
        public void Do_Fall_InputXThanThresholdValue_Test()
        {
            this.context.SetState(this.context.FallState);
            this.context.State.InputXThanThresholdValue();
            Assert.AreSame(this.context.FallState,this.context.State);
        }

        [Test]
        public void Do_Fall_InputXLessThresholdValue_Test()
        {
            this.context.SetState(this.context.FallState);
            this.context.State.InputXLessThresholdValue();
            Assert.AreSame(this.context.FallState,this.context.State);
        }

        [Test]
        public void Do_Fall_InputJumpCommand_Test()
        {
            this.context.SetState(this.context.FallState);
            this.context.State.InputJumpCommand();
            Assert.AreSame(this.context.FallState,this.context.State);
        }

        [Test]
        public void Do_Fall_YVelocityLessThresholdValue_Test()
        {
            this.context.SetState(this.context.FallState);
            this.context.State.YVelocityLessThresholdValue();
            Assert.AreSame(this.context.FallState,this.context.State);
        }

        [Test]
        public void Do_Fall_CharacterTouchPlane_Test()
        {
            this.context.SetState(this.context.FallState);
            this.context.State.CharacterTouchPlane();
            Assert.AreSame(this.context.IdleState,this.context.State);
        }
    }
}