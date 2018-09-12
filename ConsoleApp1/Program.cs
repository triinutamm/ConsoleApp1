using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // kasuta ainult seda

        static void Main(string[] args)
        {
            DeviceManager.Instance.SendData();
        }
    }
    public class DeviceManager
    {
        private static DeviceManager _managerInstance = new DeviceManager();
        private static Lazy<DeviceManager> _managerInstanceLazy = new Lazy<DeviceManager>();
        static DeviceManager()
        {
            _managerInstanceLazy = new Lazy<DeviceManager>(() =>
            {
                return new DeviceManager();
            });
        }
        private DeviceManager() 
        {

        }
        public static DeviceManager Instance
        {
            get
            {
                if(_managerInstance == null)
                {
                    _managerInstance = new DeviceManager();
                }
                return _managerInstance;
            }
        }
        public void SendData()
        {

        }

    }
}
