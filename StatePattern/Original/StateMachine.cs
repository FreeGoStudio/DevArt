using System;

namespace StatePattern.Original
{
    /// <summary>
    /// 使用普通方法创建的状态机
    /// </summary>
    public class StateMachine
    {
        public const int Idle = 0;
        public const int Run = 1;
        public const int Attack = 2;
        public const int Rise = 3;
        public const int Fall = 4;

        public int State = Idle;

        public StateMachine()
        {
            
        }

        /// <summary>
        /// 动作：输入攻击指令
        /// </summary>
        public void InputAttackCommand()
        {
            if (State == Idle)
            {
                Console.WriteLine("播放Attack动画");
                State = Attack;
            }
            else if (State == Run)
            {
                Console.WriteLine("不能在奔跑时攻击");
            }
            else if (State == Attack)
            {
                Console.WriteLine("不能在攻击时攻击");
            }
            else if (State == Rise)
            {
                Console.WriteLine("不能在跳跃中攻击");
            }
            else if (State == Fall)
            {
                Console.WriteLine("不能在下落中攻击");
            }
        }

        /// <summary>
        /// 动作：攻击动作完成
        /// </summary>
        public void AttackActionComplete()
        {
            if (State == Idle)
            {
                Console.WriteLine("当前不处于攻击中");
            }
            else if (State == Run)
            {
                Console.WriteLine("当前不处于攻击中");
            }
            else if (State == Attack)
            {
                Console.WriteLine("完成Idle动画");
                State = Idle;
            }
            else if (State == Rise)
            {
                Console.WriteLine("当前不处于攻击中");
            }
            else if (State == Fall)
            {
                Console.WriteLine("当前不处于攻击中");
            }
        }

        /// <summary>
        /// 动作：输入大于阈值的x值
        /// </summary>
        public void InputXThanThresholdValue()
        {
            if (State == Idle)
            {
                Console.WriteLine("播放Run动画");
                State = Run;
            }
            else if (State == Run)
            {
                Console.WriteLine("继续播放Run动画");
            }
            else if (State == Attack)
            {
                Console.WriteLine("不能在攻击时移动");
            }
            else if (State == Rise)
            {
                Console.WriteLine("不能在跳跃时移动");
            }
            else if (State == Fall)
            {
                Console.WriteLine("不能在下落时移动");
            }
        }

        /// <summary>
        /// 动作：输入小于阈值的x值
        /// </summary>
        public void InputXLessThresholdValue()
        {
            if (State == Idle)
            {
                Console.WriteLine("当前不在奔跑中");
            }
            else if (State == Run)
            {
                Console.WriteLine("播放Idle动画");
                State = Idle;
            }
            else if (State == Attack)
            {
                Console.WriteLine("当前不在奔跑中");
            }
            else if (State == Rise)
            {
                Console.WriteLine("当前不在奔跑中");
            }
            else if (State == Fall)
            {
                Console.WriteLine("当前不在奔跑中");
            }
        }

        /// <summary>
        /// 动作：输入跳跃指令
        /// </summary>
        public void InputJumpCommand()
        {
            if (State == Idle)
            {
                Console.WriteLine("播放跳跃动画");
                State = Rise;
            }
            else if (State == Run)
            {
                Console.WriteLine("不能在奔跑中跳跃");
            }
            else if (State == Attack)
            {
                Console.WriteLine("不能在攻击中跳跃");
            }
            else if (State == Rise)
            {
                Console.WriteLine("不能在跳跃中跳跃");
            }
            else if (State == Fall)
            {
                Console.WriteLine("不能在下落中跳跃");
            }
        }

        /// <summary>
        /// 动作：y轴速度小于阈值
        /// </summary>
        public void YVelocityLessThresholdValue()
        {
            if (State == Idle)
            {
                Console.WriteLine("播放下落动画");
                State = Fall;
            }
            else if (State == Run)
            {
                Console.WriteLine("不能在奔跑中下落");
            }
            else if (State == Attack)
            {
                Console.WriteLine("不能在攻击中下落");
            }
            else if (State == Rise)
            {
                Console.WriteLine("播放下落动画");
                State = Fall;
            }
            else if (State == Fall)
            {
                Console.WriteLine("不能在下落中下落");
            }
        }

        /// <summary>
        /// 动作：角色接触地面
        /// </summary>
        public void CharacterTouchPlane()
        {
            if (State == Idle)
            {
                Console.WriteLine("当前不在下落中");
            }
            else if (State == Run)
            {
                Console.WriteLine("当前不在下落中");
            }
            else if (State == Attack)
            {
                Console.WriteLine("当前不在下落中");
            }
            else if (State == Rise)
            {
                Console.WriteLine("当前不在下落中");
            }
            else if (State == Fall)
            {
                Console.WriteLine("播放Idle动画");
                State = Idle;
            }
        }
    }
}