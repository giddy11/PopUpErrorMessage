using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CCSAWpfDemo.ViewModels
{
    public class ValidationViewModelBase : ViewModelBase, INotifyDataErrorInfo
    {
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public bool HasErrors => _propertyErrors.Any();

        public IEnumerable GetErrors(string? propertyName)
        {
            return propertyName is not null && _propertyErrors.ContainsKey(propertyName)
                ? _propertyErrors[propertyName]
                : Enumerable.Empty<string>();
        }

        //public IEnumerable GetErrors(string? propertyName)
        //{
        //    return propertyName is not null && _propertyErrors.ContainsKey(propertyName)
        //        ? _propertyErrors[propertyName]
        //        : Enumerable.Empty<string>();

        //    //if (propertyName is not null && _propertyErrors.ContainsKey(propertyName))
        //    //{
        //    //    return _propertyErrors[propertyName];
        //    //}
        //    //else
        //    //{
        //    //    return Enumerable.Empty<string>();
        //    //}
        //}

        private readonly Dictionary<string, List<string>> _propertyErrors = new();

        protected void AddError(string propertyName, string error)
        {
            if (!_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors[propertyName] = new List<string>();
            }
            if (!_propertyErrors[propertyName].Contains(error))
            {
                _propertyErrors[propertyName].Add(error);
                //RaiseErrorChanged(new DataErrorsChangedEventArgs(propertyName));
                //RaisePropertyChanged(nameof(HasErrors));
            }
        }

        protected void ClearErrors(string propertyName)
        {
            if (_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors.Remove(propertyName);
                //RaiseErrorChanged(new DataErrorsChangedEventArgs(propertyName));
                //RaisePropertyChanged(nameof(HasErrors));
            }
        }

        private void RaiseErrorChanged(DataErrorsChangedEventArgs e)
        {
            ErrorsChanged?.Invoke(this, e);
        }

    }
}
