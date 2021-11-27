using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestRadioDB.Helpers
{
    class BindingListsHelper
    {
        public static void AddRange<T>(BindingList<T> bindingList, List<T> addedRange)
        {
            var originalRaiseListChangedEvents = bindingList.RaiseListChangedEvents;
            try
            {
                bindingList.RaiseListChangedEvents = false;
                addedRange.ForEach(rangeItem => bindingList.Add(rangeItem));
            }
            finally
            {
                bindingList.RaiseListChangedEvents = originalRaiseListChangedEvents;
                if (bindingList.RaiseListChangedEvents)
                    bindingList.ResetBindings();
            }
        }

        public static void ReplaceRange<T>(BindingList<T> bindingList, List<T> newRange)
        {
            var originalRaiseListChangedEvents = bindingList.RaiseListChangedEvents;
            try
            {
                bindingList.RaiseListChangedEvents = false;
                bindingList.Clear();
                newRange.ForEach(rangeItem => bindingList.Add(rangeItem));
            }
            finally
            {
                bindingList.RaiseListChangedEvents = originalRaiseListChangedEvents;
                if (bindingList.RaiseListChangedEvents)
                    bindingList.ResetBindings();
            }
        }
    }
}
