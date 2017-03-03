namespace Sino.IhuyiFlow
{
    /// <summary>
    /// 返回码
    /// </summary>
    public enum ResultCode
    {
        /// <summary>
        /// 提交成功
        /// </summary>
        Success = 1,
        /// <summary>
        /// 无次操作类型（action为空或不存在）
        /// </summary>
        NoType = 1000,
        /// <summary>
        /// 用户名为空
        /// </summary>
        UserNameEmpty = 1001,
        /// <summary>
        /// 用户名错误
        /// </summary>
        UserNameError = 1002,
        /// <summary>
        /// 手机号为空
        /// </summary>
        PhoneNumberEmpty = 1003,
        /// <summary>
        /// 手机号错误
        /// </summary>
        PhoneNumberError = 1004,
        /// <summary>
        /// 套餐为空
        /// </summary>
        PackageEmpty = 1005,
        /// <summary>
        /// 时间戳为空
        /// </summary>
        TimeStampEmpty = 1006,
        /// <summary>
        /// 不存在的套餐
        /// </summary>
        PackageNoExisted = 1007,
        /// <summary>
        /// 签名为空
        /// </summary>
        SignEmpty = 1008,
        /// <summary>
        /// 签名错误
        /// </summary>
        SignError = 1009,
        /// <summary>
        /// 签名过期
        /// </summary>
        SignExpired = 1010,
        /// <summary>
        /// 账户被冻结
        /// </summary>
        AccountLocked = 1011,
        /// <summary>
        /// 余额不足
        /// </summary>
        BalanceNotEnough = 1012,
        /// <summary>
        /// 访问IP与备案IP不同
        /// </summary>
        IPNotInWhiteList = 1013,
        /// <summary>
        /// 订单ID不能为空
        /// </summary>
        OrderIdEmpty = 1014,
        /// <summary>
        /// 订单已存在
        /// </summary>
        OrderIdExisted = 1015,
        /// <summary>
        /// 不支持的手机号码
        /// </summary>
        NotSupportPhoneNumber = 2001,
        /// <summary>
        /// 手机号码已加入黑名单
        /// </summary>
        PhoneNumberInBlackWhite = 2002,
        /// <summary>
        /// 不支持的地区
        /// </summary>
        NotSupportArea = 2003,
        /// <summary>
        /// 扣费失败
        /// </summary>
        ChargebackFailure = 3001,
        /// <summary>
        /// 内部错误
        /// </summary>
        InternalError = 4001
    }
}
