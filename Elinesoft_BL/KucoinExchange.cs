using Kucoin.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinesoft_BL
{
    public sealed class KucoinExchange : Exchange
    {
        private KucoinClient _client = new();

        public override string Name => "Kucoin";

        public KucoinExchange(IResultPresenter resultPresenter) : base(resultPresenter)
        {
        }

        protected override async Task<decimal> Update()
        {
            try
            {
                var usdFuturesTradeHistoryData = await _client.FuturesApi.ExchangeData.GetTickerAsync("XBTUSDM");
                return usdFuturesTradeHistoryData.Data?.Price ?? 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
