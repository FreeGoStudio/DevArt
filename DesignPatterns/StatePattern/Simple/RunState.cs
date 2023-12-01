using System;

namespace StatePattern.Simple
{
    public class RunState:IState
    {
        private StateMachine context;
        
        public RunState(StateMachine context)
        {
            this.context = context;
        }
        
        public void InputAttackCommand()
        {
            Console.WriteLine("不能在奔跑时攻击");
        }

        public void AttackActionComplete()
        {
            Console.WriteLine("当前不处于攻击中");
        }

        public void InputXThanThresholdValue()
        {
            Console.WriteLine("继续播放Run动画");
        }

        public void InputXLessThresholdValue()
        {
            Console.WriteLine("播放Idle动画");
            this.context.SetState(this.context.IdleState);
        }

        public void InputJumpCommand()
        {
            Console.WriteLine("不能在奔跑中跳跃");
        }

        public void YVelocityLessThresholdValue()
        {
            Console.WriteLine("不能在奔跑中下落");
        }

        public void CharacterTouchPlane()
        {
            Console.WriteLine("当前不在下落中");
        }
    }
}