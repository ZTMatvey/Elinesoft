using Bybit.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinesoft_BL
{
    public sealed class BybitExchange : Exchange
    {
        private readonly BybitClient _client = new();

        public override string Name => "Bybit";

        public BybitExchange(IResultPresenter resultPresenter) : base(resultPresenter)
        {
        }

        protected override async Task<decimal> Update()
        {
            try
            {
                var usdFuturesTradeHistoryData = await _client.UsdPerpetualApi.ExchangeData.GetTickerAsync("BTCUSDT");
                return usdFuturesTradeHistoryData.Data.Last()?.LastPrice ?? 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
