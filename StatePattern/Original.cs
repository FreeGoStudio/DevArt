using System;

namespace StatePattern
{
    public class Original
    {
        public InputData InputData;

        /// <summary>
        /// 攻击触发器
        /// </summary>
        public bool isAttackTrigger;

        /// <summary>
        /// 水平方向输入值
        /// </summary>
        public float horizontalInputValue;

        /// <summary>
        /// 垂直方向速度
        /// </summary>
        public float veritalVelocity;


        public Original()
        {
            InputData = new InputData();
        }


        public void Execute()
        {
            var output = $"{DateTime.Now:mm:ss} ";

            if (isAttackTrigger)
            {
                output += "播放攻击动画";
            }
            else if (Math.Abs(horizontalInputValue) > 0.1f)
            {
                output += "播放跑动画";
            }
            else if (veritalVelocity > 0.1f)
            {
                output += "播放跳跃动画";
            }
            else if (veritalVelocity < -0.1f)
            {
                output += "播放下落动画";
            }
            else
            {
                output += "播放闲置动画";
            }

            Console.WriteLine(output);
        }
    }

    public class InputData
    {
        /// <summary>
        /// 水平方向输入值
        /// </summary>
        public float Horizontal;

        /// <summary>
        /// 攻击触发器
        /// </summary>
        public bool IsAttackTrigger;

        public bool IsJumpTrigger;

        public void Input()
        {
            var input = Console.ReadLine();
            if (input == null)
            {
                return;
            }

            input = input.Trim().ToLower();
            if (input == "a" || input == "d")
            {
                Horizontal = 1;
            }
            else
            {
                Horizontal = 0;
            }

            switch (input)
            {
                case "j":
                    IsAttackTrigger = true;
                    break;
                case "k":
                    IsJumpTrigger = true;
                    break;
            }
        }
    }
}