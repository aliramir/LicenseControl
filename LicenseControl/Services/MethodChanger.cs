using LicenseControl.Models.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LicenseControl.Services
{
    public interface IMethodChanger:IDisposable
    {
        public List<MethodDto> MethodList();

    }
    public class MethodChanger: IMethodChanger
    {
        #region Dispose

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        private IntPtr _handle;
        private readonly Component _component = new();
        private bool _disposed = false;

        public MethodChanger(IntPtr handle)
        {
            this._handle = handle;
        }

        public MethodChanger()
        {
           
        }

        [DllImport("Kernel32")]
        private static extern bool CloseHandle(IntPtr handle);
        ~MethodChanger()
        {
            Dispose(disposing: false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this._disposed) return;
            if (disposing)
            {
                _component.Dispose();
            }

            CloseHandle(_handle);
            _handle = IntPtr.Zero;
            _disposed = true;
        }

        #endregion

        public List<MethodDto> MethodList()
        {
            var list = new List<MethodDto>
            {
                new()
                {
                    MethodName = "DeviceIdBuilderByToken",
                    Remark = "Here's a simple cross-platform one, using only the DeviceId package, which is valid for both version 5 and version 6 of the library"
                },
                new()
                {
                    MethodName = "DeviceIdWindowsMmi",
                    Remark = "Here's a more complex device ID, making use of some of the advanced components from the DeviceId.Windows.Wmi (or DeviceId.Windows.Mmi) package"
                },
                new()
                {
                    MethodName = "ComplexCrossPlatform",
                    Remark = "Here's a complex cross-platform device ID, using DeviceId.Windows.Wmi, DeviceId.Linux, and DeviceId.Mac"
                }
            };

            return list;
        }
    }
}
