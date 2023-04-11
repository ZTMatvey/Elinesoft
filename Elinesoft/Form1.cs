using Binance.Net.Clients;
using Binance.Net.Enums;
using Binance.Net.Interfaces.Clients;
using Elinesoft_BL;

namespace Elinesoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var binance = new BinanceExchange(new LabelResultPresenter(BinanceLabel));
            var bybit = new BybitExchange(new LabelResultPresenter(BybitLabel));
            var kucoin = new KucoinExchange(new LabelResultPresenter(KucoinLabel));
            binance.Start();
            bybit.Start();
            kucoin.Start();
        }
    }
}