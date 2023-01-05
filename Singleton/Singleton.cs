using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace FrameworkDesign
{

    //单例类 继承可自己创建单例
    public class Singleton<T> where T : Singleton<T>
    {
        public static T mInstance;

        public static T Instance
        {
            get
            {
                if (mInstance == null)
                {
                    var type = typeof(T);
                    var ctors = type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
                    var ctor = Array.Find(ctors, c => c.GetParameters().Length == 0);

                    if (ctor == null)
                    {
                        throw new Exception("Non Public Constructor Not Found in" + type.Name);
                    }

                    mInstance = ctor.Invoke(null) as T;
                }
                return mInstance;
            }
        }
    }
}