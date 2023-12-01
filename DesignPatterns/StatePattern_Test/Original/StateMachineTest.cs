using NUnit.Framework;
using StatePattern.Original;

namespace StatePattern_Test.Original
{
    [TestFixture]
    public class StateMachineTest
    {
        private StateMachine stateMachine;
        
        [SetUp]
        protected void SetUp()
        {
            this.stateMachine = new StateMachine();
        }

        [TearDown]
        protected void ClearUp()
        {
            this.stateMachine = null;
        }
        
        [Test]
        public void CreateStateMachine_Test()
        {
            Assert.AreEqual(StateMachine.Idle, stateMachine.State);
        }

        [Test]
        public void InputAttackCommand_Test()
        {
            stateMachine.State = StateMachine.Idle;
            stateMachine.InputAttackCommand();
            Assert.AreEqual(StateMachine.Attack, stateMachine.State);

            stateMachine.State = StateMachine.Run;
            stateMachine.InputAttackCommand();
            Assert.AreEqual(StateMachine.Run, stateMachine.State);

            stateMachine.State = StateMachine.Attack;
            stateMachine.InputAttackCommand();
            Assert.AreEqual(StateMachine.Attack, stateMachine.State);

            stateMachine.State = StateMachine.Rise;
            stateMachine.InputAttackCommand();
            Assert.AreEqual(StateMachine.Rise, stateMachine.State);

            stateMachine.State = StateMachine.Fall;
            stateMachine.InputAttackCommand();
            Assert.AreEqual(StateMachine.Fall, stateMachine.State);
        }

        [Test]
        public void AttackActionComplete_Test()
        {
            stateMachine.State = StateMachine.Idle;
            stateMachine.AttackActionComplete();
            Assert.AreEqual(StateMachine.Idle, stateMachine.State);

            stateMachine.State = StateMachine.Run;
            stateMachine.AttackActionComplete();
            Assert.AreEqual(StateMachine.Run, stateMachine.State);

            stateMachine.State = StateMachine.Attack;
            stateMachine.AttackActionComplete();
            Assert.AreEqual(StateMachine.Idle, stateMachine.State);

            stateMachine.State = StateMachine.Rise;
            stateMachine.AttackActionComplete();
            Assert.AreEqual(StateMachine.Rise, stateMachine.State);

            stateMachine.State = StateMachine.Fall;
            stateMachine.AttackActionComplete();
            Assert.AreEqual(StateMachine.Fall, stateMachine.State);
        }

        [Test]
        public void InputXThanThresholdValue_Test()
        {
            stateMachine.State = StateMachine.Idle;
            stateMachine.InputXThanThresholdValue();
            Assert.AreEqual(StateMachine.Run, stateMachine.State);

            stateMachine.State = StateMachine.Run;
            stateMachine.InputXThanThresholdValue();
            Assert.AreEqual(StateMachine.Run, stateMachine.State);

            stateMachine.State = StateMachine.Attack;
            stateMachine.InputXThanThresholdValue();
            Assert.AreEqual(StateMachine.Attack, stateMachine.State);

            stateMachine.State = StateMachine.Rise;
            stateMachine.InputXThanThresholdValue();
            Assert.AreEqual(StateMachine.Rise, stateMachine.State);

            stateMachine.State = StateMachine.Fall;
            stateMachine.InputXThanThresholdValue();
            Assert.AreEqual(StateMachine.Fall, stateMachine.State);
        }

        [Test]
        public void InputXLessThresholdValue_Test()
        {
            stateMachine.State = StateMachine.Idle;
            stateMachine.InputXLessThresholdValue();
            Assert.AreEqual(StateMachine.Idle, stateMachine.State);

            stateMachine.State = StateMachine.Run;
            stateMachine.InputXLessThresholdValue();
            Assert.AreEqual(StateMachine.Idle, stateMachine.State);

            stateMachine.State = StateMachine.Attack;
            stateMachine.InputXLessThresholdValue();
            Assert.AreEqual(StateMachine.Attack, stateMachine.State);

            stateMachine.State = StateMachine.Rise;
            stateMachine.InputXLessThresholdValue();
            Assert.AreEqual(StateMachine.Rise, stateMachine.State);

            stateMachine.State = StateMachine.Fall;
            stateMachine.InputXLessThresholdValue();
            Assert.AreEqual(StateMachine.Fall, stateMachine.State);
        }

        [Test]
        public void InputJumpCommand_Test()
        {
            stateMachine.State = StateMachine.Idle;
            stateMachine.InputJumpCommand();
            Assert.AreEqual(StateMachine.Rise, stateMachine.State);

            stateMachine.State = StateMachine.Run;
            stateMachine.InputJumpCommand();
            Assert.AreEqual(StateMachine.Run, stateMachine.State);

            stateMachine.State = StateMachine.Attack;
            stateMachine.InputJumpCommand();
            Assert.AreEqual(StateMachine.Attack, stateMachine.State);

            stateMachine.State = StateMachine.Rise;
            stateMachine.InputJumpCommand();
            Assert.AreEqual(StateMachine.Rise, stateMachine.State);

            stateMachine.State = StateMachine.Fall;
            stateMachine.InputJumpCommand();
            Assert.AreEqual(StateMachine.Fall, stateMachine.State);
        }

        [Test]
        public void YVelocityLessThresholdValue_Test()
        {
            stateMachine.State = StateMachine.Idle;
            stateMachine.YVelocityLessThresholdValue();
            Assert.AreEqual(StateMachine.Fall, stateMachine.State);

            stateMachine.State = StateMachine.Run;
            stateMachine.YVelocityLessThresholdValue();
            Assert.AreEqual(StateMachine.Run, stateMachine.State);

            stateMachine.State = StateMachine.Attack;
            stateMachine.YVelocityLessThresholdValue();
            Assert.AreEqual(StateMachine.Attack, stateMachine.State);

            stateMachine.State = StateMachine.Rise;
            stateMachine.YVelocityLessThresholdValue();
            Assert.AreEqual(StateMachine.Fall, stateMachine.State);

            stateMachine.State = StateMachine.Fall;
            stateMachine.YVelocityLessThresholdValue();
            Assert.AreEqual(StateMachine.Fall, stateMachine.State);
        }

        [Test]
        public void CharacterTouchPlane_Test()
        {
            stateMachine.State = StateMachine.Idle;
            stateMachine.CharacterTouchPlane();
            Assert.AreEqual(StateMachine.Idle, stateMachine.State);

            stateMachine.State = StateMachine.Run;
            stateMachine.CharacterTouchPlane();
            Assert.AreEqual(StateMachine.Run, stateMachine.State);

            stateMachine.State = StateMachine.Attack;
            stateMachine.CharacterTouchPlane();
            Assert.AreEqual(StateMachine.Attack, stateMachine.State);

            stateMachine.State = StateMachine.Rise;
            stateMachine.CharacterTouchPlane();
            Assert.AreEqual(StateMachine.Rise, stateMachine.State);

            stateMachine.State = StateMachine.Fall;
            stateMachine.CharacterTouchPlane();
            Assert.AreEqual(StateMachine.Idle, stateMachine.State);
        }
        
    }
}