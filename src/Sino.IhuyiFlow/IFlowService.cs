using System.Threading.Tasks;

namespace Sino.IhuyiFlow
{
    /// <summary>
    /// 充值接口
    /// </summary>
    public interface IFlowService
    {
        /// <summary>
        /// 单号码充值花费
        /// </summary>
        /// <param name="mobile">手机号</param>
        /// <param name="package">套餐数额</param>
        /// <param name="orderId">订单编号</param>
        Task<RechargeResponse> RechargeAsync(string mobile, string package, string orderId);

        /// <summary>
        /// 账户余额查询
        /// </summary>
        Task<CheckBalanceResponse> CheckBalanceAsync();

        /// <summary>
        /// 充值状态查询
        /// </summary>
        Task<QueryRechargeStateResponse> QueryRechargeStateAsync(int count);
    }
}
