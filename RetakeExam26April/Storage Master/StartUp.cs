using StorageMaster.Core;

namespace StorageMaster
{
    public class StartUp
    {
        public static void Main()
        {
            StorageMaster storageMaster = new StorageMaster();
            Engine engine = new Engine(storageMaster);
            engine.Run();
        }
    }
}