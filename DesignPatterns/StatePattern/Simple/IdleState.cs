using System;

namespace StatePattern.Simple
{
    public class IdleState : IState
    {
        private readonly StateMachine context;

        public IdleState(StateMachine context)
        {
            this.context = context;
        }

        public void InputAttackCommand()
        {
            Console.WriteLine("播放Attack动画");
            this.context.SetState(context.AttackState);
        }

        public void AttackActionComplete()
        {
            Console.WriteLine("当前不处于攻击中");
        }

        public void InputXThanThresholdValue()
        {
            Console.WriteLine("播放Run动画");
            this.context.SetState(this.context.RunState);
        }

        public void InputXLessThresholdValue()
        {
            Console.WriteLine("当前不在奔跑中");
        }

        public void InputJumpCommand()
        {
            Console.WriteLine("播放跳跃动画");
            this.context.SetState(this.context.RiseState);
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