using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinesoft_BL
{
    public abstract class Exchange
    {
        private bool _isRunning;
        private readonly IResultPresenter _resultPresenter;

        public abstract string Name { get; }

        protected abstract Task<decimal> Update();

        public Exchange(IResultPresenter resultPresenter)
        {
            _resultPresenter = resultPresenter;
        }

        public async Task Start()
        {
            await StartInternal();
        }

        private async Task StartInternal()
        {
            _isRunning = true;
            while (_isRunning)
            {
                var result = await Update();
                _resultPresenter.Update($"{Name}: {result}");
                await Task.Delay(5000);
            }
        }

        public void Stop()
        {
            _isRunning = false;
        }
    }
}
