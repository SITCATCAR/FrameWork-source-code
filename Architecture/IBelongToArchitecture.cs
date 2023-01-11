namespace FrameworkDesign
{
    //解决注册不同模块功能
    public interface IBelongToArchitecture
    {
        IArchitecture Architecture { get; set; }

    }


}