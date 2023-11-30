using System;

namespace StatePattern.Simple
{
    public class FallState : IState
    {
        private StateMachine context;

        public FallState(StateMachine context)
        {
            this.context = context;
        }

        public void InputAttackCommand()
        {
            Console.WriteLine("不能在下落中攻击");
        }

        public void AttackActionComplete()
        {
            Console.WriteLine("当前不处于攻击中");
        }

        public void InputXThanThresholdValue()
        {
            Console.WriteLine("不能在下落时移动");
        }

        public void InputXLessThresholdValue()
        {
            Console.WriteLine("当前不在奔跑中");
        }

        public void InputJumpCommand()
        {
            Console.WriteLine("不能在下落中跳跃");
        }

        public void YVelocityLessThresholdValue()
        {
            Console.WriteLine("不能在下落中下落");
        }

        public void CharacterTouchPlane()
        {
            Console.WriteLine("播放Idle动画");
            this.context.SetState(this.context.IdleState);
        }
    }
}