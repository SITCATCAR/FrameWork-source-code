namespace FrameworkDesign
{
    //解决注册不同模块功能
    public interface IModel : IBelongToArchitecture
    {

        void Init();
    }

}