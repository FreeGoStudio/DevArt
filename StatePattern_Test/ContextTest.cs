using System;
using NUnit.Framework;
using StatePattern.Simple;

namespace StatePattern_Test
{
    [TestFixture]
    public class ContextTest
    {
        [Test]
        public void InitState_Test()
        {
            var idleState = new IdleState();
            
            Context context = new Context(idleState);

            var current = context.CurrentState;
            Assert.AreSame(idleState,current);
        }

        [Test]
        public void SetAttackState_Test()
        {
            var idleState = new IdleState();
            
            var attackState = new AttackState();
            
            Context context = new Context(idleState);
            context.SetStatae(attackState);
            
            var current = context.CurrentState;
            
            Assert.AreSame(attackState,current);
        }

        [Test]
        public void DoState_Test()
        {
            var idleState = new IdleState();

            var context = new Context(idleState);

            context.Do();

            var current = context.CurrentState;
            
            current.Handle(context);
            
            
        }
    }
}