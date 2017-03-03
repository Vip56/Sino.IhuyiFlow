namespace Sino.IhuyiFlow
{
    public class CheckBalanceResponse
    {
        /// <summary>
        /// 代码
        /// </summary>
        public ResultCode Code { get; set; }

        /// <summary>
        /// 消息描述
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 剩余余额
        /// </summary>
        public float Balance { get; set; }
    }
}
