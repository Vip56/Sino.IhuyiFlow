using Sino.IhuyiFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FlowServiceUnitTest
{
    public class Test
    {
        private IFlowService _client;

        public Test()
        {
            _client = new FlowService("http://f.ihuyi.com/phone", "", "");
        }

        [Fact]
        public async Task TestCheckBalance()
        {
            var response = await _client.CheckBalanceAsync();
            Assert.NotNull(response);
            Assert.Equal(response.Code, ResultCode.Success);
        }

        [Fact]
        public async Task TestRecharge()
        {
            var response = await _client.RechargeAsync("", "1", DateTime.Now.Ticks.ToString());
            Assert.NotNull(response);
            Assert.Equal(response.Code, ResultCode.Success);
        }

        [Fact]
        public async Task TestQueryRechargeState()
        {
            var response = await _client.QueryRechargeStateAsync(10);
            Assert.NotNull(response);
            Assert.Equal(response.Code, ResultCode.Success);
        }
    }
}
