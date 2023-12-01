using System;

namespace StatePattern.Simple
{
    public class RiseState : IState
    {
        private StateMachine context;

        public RiseState(StateMachine context)
        {
            this.context = context;
        }

        public void InputAttackCommand()
        {
            Console.WriteLine("不能在跳跃中攻击");
        }

        public void AttackActionComplete()
        {
            Console.WriteLine("当前不处于攻击中");
        }

        public void InputXThanThresholdValue()
        {
            Console.WriteLine("不能在跳跃时移动");
        }

        public void InputXLessThresholdValue()
        {
            Console.WriteLine("当前不在奔跑中");
        }

        public void InputJumpCommand()
        {
            Console.WriteLine("不能在跳跃中跳跃");
        }

        public void YVelocityLessThresholdValue()
        {
            Console.WriteLine("播放下落动画");
            this.context.SetState(this.context.FallState);
        }

        public void CharacterTouchPlane()
        {
            Console.WriteLine("当前不在下落中");
        }
    }
}