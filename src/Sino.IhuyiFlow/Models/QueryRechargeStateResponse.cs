using System.Collections.Generic;

namespace Sino.IhuyiFlow
{
    /// <summary>
    /// 充值状态回应
    /// </summary>
    public class QueryRechargeStateResponse
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
        /// 结果集
        /// </summary>
        public List<Report> Reports { get; set; }
    }

    public class Report
    {
        /// <summary>
        /// 任务ID
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 状态（0：失败，1：成功）
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }
    }
}
