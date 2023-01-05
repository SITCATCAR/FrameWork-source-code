
namespace FrameworkDesign
{

    //工具类 简化模块中注册功能 由添加的IOC类继承

    public abstract class Architecture<T> where T : Architecture<T>, new()
    {
        private static T mArchiteure;//mArchiteure 本质是一个字典
        static void MakeSureArchitecture()
        {
            if (mArchiteure == null)
            {
                mArchiteure = new T();
                mArchiteure.Init();
            }
        }

        protected abstract void Init();

        private IOCContainer mContainer = new IOCContainer();
        public static T Get<T>() where T : class
        {
            MakeSureArchitecture();

            return mArchiteure.mContainer.Get<T>();
        }

        public void Regester<T>(T instance)
        {
            MakeSureArchitecture();

            mArchiteure.mContainer.Register<T>(instance);
        }
    }
}