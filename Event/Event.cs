using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace FrameworkDesign
{

    //事件的基类 其余事件继承此类
    public class Event<T> where T : Event<T>
    {
        private static Action mOnEvent;

        public static void Register(Action onEvent)
        {
            mOnEvent += onEvent;
        }

        public static void UnRegister(Action onEvent)
        {
            mOnEvent -= onEvent;
        }
        public static void Trigger()
        {
            mOnEvent?.Invoke();
        }

    }
}
