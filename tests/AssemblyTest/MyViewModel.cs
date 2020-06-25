﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WPFLocalizeExtension.Providers;

namespace AssemblyTest
{
    public class MyViewModel : ViewModelBase
    {
        private ObservableCollection<Item> _items;

        public ObservableCollection<Item> Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new ObservableCollection<Item>();
                    _items.Add(new Item() { TranslationKey = "AssemblyTest:Strings:Tab1" });
                    _items.Add(new Item() { TranslationKey = "AssemblyTest:Strings:Tab2" });
                    _items.Add(new Item() { TranslationKey = "AssemblyTest:Strings:Tab3" });
                }
                return _items;
            }
        }

        private TestEnum enumValue = TestEnum.Processing;
        /// <summary>
        /// Gets or sets the enumValue.
        /// </summary>
        public TestEnum EnumValue
        {
            get { return enumValue; }
            set
            {
                if (enumValue != value)
                {
                    enumValue = value;
                    RaisePropertyChanged("EnumValue");
                }
            }
        }

        public MyViewModel()
        {
            ResxLocalizationProvider.Instance.UpdateCultureList("AssemblyTest", "Strings", null);
        }
    }
}
