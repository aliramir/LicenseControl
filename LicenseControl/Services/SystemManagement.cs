using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraPrinting.Export.Pdf;
using LicenseControl.Models.Dtos;

namespace LicenseControl.Services
{
    public interface ISystemManagement:IDisposable
    {
        public GetProcessorDto GetProcessor();
    }
    public class SystemManagement: ISystemManagement
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

        public SystemManagement(IntPtr handle)
        {
            this._handle = handle;
        }

        public SystemManagement()
        {

        }

        [DllImport("Kernel32")]
        private static extern bool CloseHandle(IntPtr handle);
        ~SystemManagement()
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
        public GetProcessorDto GetProcessor()
        {
            try
            {
                var searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                var result =new GetProcessorDto();
                foreach (var o in searcher.Get())
                {
                    var queryObj = (ManagementObject)o;
                    result.Architecture = (string)queryObj["Architecture"];
                    result.Caption = (string)queryObj["Caption"];
                    result.Family = (string)queryObj["Family"];
                    result.ProcessorId = (string)queryObj["ProcessorId"];
                }
                return result;
            }
            catch
            {
                return new GetProcessorDto
                {
                    Architecture = "null",
                    Caption = "null",
                    Family = "null",
                    ProcessorId = "null",
                };
            }
        }
    }
}
