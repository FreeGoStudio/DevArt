using System;

namespace StatePattern.Simple
{
    public class AttackState : IState
    {
        private StateMachine context;

        public AttackState(StateMachine context)
        {
            this.context = context;
        }

        public void InputAttackCommand()
        {
            Console.WriteLine("不能在攻击时攻击");
        }

        public void AttackActionComplete()
        {
            Console.WriteLine("完成Idle动画");
            this.context.SetState(this.context.IdleState);
        }

        public void InputXThanThresholdValue()
        {
            Console.WriteLine("不能在攻击时移动");
        }

        public void InputXLessThresholdValue()
        {
            Console.WriteLine("当前不在奔跑中");
        }

        public void InputJumpCommand()
        {
            Console.WriteLine("不能在攻击中跳跃");
        }

        public void YVelocityLessThresholdValue()
        {
            Console.WriteLine("不能在攻击中下落");
        }

        public void CharacterTouchPlane()
        {
            Console.WriteLine("当前不在下落中");
        }
    }
}