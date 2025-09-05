using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Threading;

namespace D.Diagram.DrawingBox
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public BindableBase()
        {
            Init();
        }

        protected virtual void Init()
        {

        }

        #region - MVVM -

        private bool _isRefreshing;

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value)) return false;

            storage = value;
            RaisePropertyChanged(propertyName);

            return true;
        }

        public virtual void DispatcherRaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            if (_isRefreshing)
                return;
            _isRefreshing = true;
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Input, new Action(() =>
            {
                _isRefreshing = false;
                OnDispatcherPropertyChanged();
            }));
        }

        protected virtual void OnDispatcherPropertyChanged()
        {

        }

        #endregion
    }
}
