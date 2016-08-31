using EyeTrackingMouseV03Lib.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EyeTrackingMouseV03Lib.Helper
{
    public abstract class INotifyBase : INotifyPropertyChanged
    {

        private readonly Dictionary<string, Insert> _propertyValues = new Dictionary<string, Insert>();


        public event PropertyChangedEventHandler PropertyChanged;


        protected TValue GetValue<TValue>(EnumROI defaultInstanceName, TValue defaultValue = default(TValue),
            [CallerMemberName] string propertyName = null)
        {
            string key = $"{typeof(TValue)}:{defaultInstanceName}:{propertyName}";
            return _propertyValues.ContainsKey(key) ? (TValue)_propertyValues[key].value : defaultValue;
        }

        protected void SetValue<TValue, TInstanceOf>(TValue value, TInstanceOf instanceOfName, Action callback = null,
            [CallerMemberName] string propertyName = null)
        {

            string key = $"{typeof(TValue)}:{instanceOfName}:{propertyName}";
            if (_propertyValues.ContainsKey(key))
            {
                if (_propertyValues[key].classname != null && _propertyValues[key] != null && _propertyValues[key].value.Equals(value))
                    return;

                IComparable comparableValue = value as IComparable;
                IComparable comparableClassName = instanceOfName as IComparable;
                IComparable comparableDic = _propertyValues[key] as IComparable;

                if (comparableValue != null && comparableDic != null && comparableClassName != null)
                {
                    if (!Equals(_propertyValues[key].value, comparableValue))
                    {
                        _propertyValues[key].value = value;
                        _propertyValues[key].classname = instanceOfName.ToString();
                        OnPropertyChanged(propertyName);

                    }

                }
                else
                {
                    _propertyValues[key].value = value;
                    _propertyValues[key].classname = instanceOfName.ToString();
                    OnPropertyChanged(propertyName);
                }

            }
            else
            {
                _propertyValues.Add(key, new Insert());
                _propertyValues[key].value = value;
                _propertyValues[key].classname = instanceOfName.ToString();
                OnPropertyChanged(propertyName);
            }

            callback?.Invoke();
        }




        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class Insert
        {
            public object value { get; set; }
            public string classname { get; set; }
        }
    }
}
