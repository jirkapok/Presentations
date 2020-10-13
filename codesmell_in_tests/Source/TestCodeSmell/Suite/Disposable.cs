using System;

namespace Suite
{
    public class Disposable: IDisposable
    {
        private bool isDisposed = false;

        public void Execute()
        {
            if (this.isDisposed)
                throw new ObjectDisposedException("Can be disposed only once");
        }

        public void Dispose()
        {
            if (this.isDisposed)
                throw new ObjectDisposedException("Can be disposed only once");

            this.isDisposed = true;
        }
    }
}