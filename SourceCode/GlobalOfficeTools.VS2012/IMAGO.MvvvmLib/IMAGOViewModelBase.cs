using System;
using System.Threading;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using IMAGO.MvvmLib.Messages;

namespace IMAGO.MvvmLib
{
    public class IMAGOViewModelBase : ViewModelBase
    {
        #region Private Fields 
        private bool _isBusy;
        private int _nBusyCount;
        #endregion

        #region Public Properties 
        public bool IsBusy 
        {
            get { return _isBusy; }
            set 
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }
        #endregion

        #region Constructor 
        public IMAGOViewModelBase()
        {
            _nBusyCount = 0;
        }
        #endregion

        #region Public Methods 
        public void SubscribeIsBusyAction(Action<Action> actionToRun) 
        {
            IncressBusy();
            if (actionToRun != null) actionToRun(() => { DecressBusy(); });   
        }
        public void NavigateView(string windowName, string windowTitle)
        {
            Messenger.Default.Send<ShowWindowMessage>(new ShowWindowMessage() { WindowName = windowName, WindowTitle = windowTitle });
        }
        #endregion

        #region Internal Methods 
        internal void IncressBusy() 
        {
            Interlocked.Increment(ref _nBusyCount);
            IsBusy = true;
        }
        internal void DecressBusy() 
        {
            Interlocked.Decrement(ref _nBusyCount);
            if (_nBusyCount <= 0)
            {
                _nBusyCount = 0;
                IsBusy = false;
            }
        }
        #endregion
    }
}
