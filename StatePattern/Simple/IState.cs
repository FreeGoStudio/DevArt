namespace StatePattern.Simple
{
    public interface IState
    {
        /// <summary>
        /// 动作：输入攻击指令
        /// </summary>
        void InputAttackCommand();
        
        /// <summary>
        /// 动作：攻击动作完成
        /// </summary>
        void AttackActionComplete();
        
        /// <summary>
        /// 动作：输入大于阈值的x值
        /// </summary>
        void InputXThanThresholdValue();
        
        /// <summary>
        /// 动作：输入小于阈值的x值
        /// </summary>
        void InputXLessThresholdValue();
        
        /// <summary>
        /// 动作：输入跳跃指令
        /// </summary>
        void InputJumpCommand();
        
        /// <summary>
        /// 动作：y轴速度小于阈值
        /// </summary>
        void YVelocityLessThresholdValue();
        
        /// <summary>
        /// 动作：角色接触地面
        /// </summary>
        void CharacterTouchPlane();
    }
}