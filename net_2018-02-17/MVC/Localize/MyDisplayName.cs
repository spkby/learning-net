﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MVC.Localize
{
    public class MyDisplayName : DisplayNameAttribute
    {

        private PropertyInfo _nameProperty;
        private Type _resourceType;

        public MyDisplayName(string displayNameKey) : base(displayNameKey) { }

        public Type NameResourceType
        {
            get
            {
                return _resourceType;
            }
            set
            {
                _resourceType = value;
                _nameProperty = _resourceType.GetProperty(base.DisplayName, BindingFlags.Static | BindingFlags.Public);
            }
        }

        public override string DisplayName
        {
            get
            {
                if(_nameProperty == null)
                {
                    return base.DisplayName;
                }
                return (string)_nameProperty.GetValue(_nameProperty.DeclaringType, null);
            }
        }
    }
}