using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace FrameworkDesign
{

    //数据类 此类型数据变化可直接委托中加入方法调用
    public class BindableProperty<T> where T : IEquatable<T>
    {
        private T mValue = default(T);
        public T Value
        {
            get => mValue;
            set
            {
                if (!value.Equals(mValue))
                {
                    mValue = value;
                    OnValueChanged?.Invoke(mValue);
                }
            }
        }
        public Action<T> OnValueChanged;

    }
}
