namespace Sino.IhuyiFlow
{
    /// <summary>
    /// 充值反馈
    /// </summary>
    public class RechargeResponse
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public ResultCode Code { get; set; }

        /// <summary>
        /// 消息描述
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 任务编号，提交失败则没有
        /// </summary>
        public string TaskId { get; set; }
    }
}
