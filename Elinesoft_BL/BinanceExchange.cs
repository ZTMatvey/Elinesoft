using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binance;
using Binance.Net.Clients;
using Binance.Net.Enums;
using Binance.Net.Interfaces.Clients;
using Binance.Net.Objects;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.CommonObjects;

namespace Elinesoft_BL
{
    public sealed class BinanceExchange : Exchange
    {
        private readonly BinanceClient _client = new();

        public override string Name => "Binance";

        public BinanceExchange(IResultPresenter resultPresenter) : base(resultPresenter)
        {
        }

        protected override async Task<decimal> Update()
        {
            try
            {
                var usdFuturesTradeHistoryData = await _client.UsdFuturesApi.ExchangeData.GetTickerAsync("BTCUSDT");
                return usdFuturesTradeHistoryData.Data?.LastPrice ?? 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}