using DeviceId;
using LicenseControl.Models.Dtos;
using LicenseControl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LicenseControl.Views.UserControls
{
    public partial class CreateLicense : DevExpress.XtraEditors.XtraUserControl
    {
        public CreateLicense()
        {
            InitializeComponent();
            LicLabel.Text = "";
            FillMethods();
        }

        private void MainUc_Load(object sender, EventArgs e)
        {
            GenerateSystemCode();
        }
        private static List<MethodDto> GetListMethods()
        {
            using IMethodChanger method = new MethodChanger();
            return method.MethodList();
        }

        private void FillMethods()
        {
            var method = GetListMethods();
            SelectMethod.Properties.DataSource = method;
            SelectMethod.Properties.DisplayMember = "MethodName";
            SelectMethod.Properties.ValueMember = "MethodName";
            SelectMethod.EditValue = @"DeviceIdWindowsMmi";
        }

        private void GenerateSystemCode()
        {
            var method = GetListMethods();
            var val = SelectMethod.EditValue;
            var deviceId = val switch
            {
                "DeviceIdBuilderByToken" => new DeviceIdBuilder().AddMachineName()
                    .AddOsVersion()
                    .AddFileToken(Application.StartupPath + @"\token.txt")
                    .ToString(),
                "DeviceIdWindowsMmi" => new DeviceIdBuilder().AddMachineName()
                    .AddOsVersion()
                    .OnWindows(windows => windows
                        .AddProcessorId()
                        .AddMotherboardSerialNumber()
                        .AddSystemDriveSerialNumber())
                    .ToString(),
                "ComplexCrossPlatform" => new DeviceIdBuilder().AddMachineName()
                    .AddOsVersion()
                    .OnWindows(windows => windows
                        .AddProcessorId()
                        .AddMotherboardSerialNumber()
                        .AddSystemDriveSerialNumber())
                    //.OnLinux(linux => linux
                    //    .AddMotherboardSerialNumber()
                    //    .AddSystemDriveSerialNumber())
                    //.OnMac(mac => mac
                    //    .AddSystemDriveSerialNumber()
                    //    .AddPlatformSerialNumber())
                    .ToString(),
                _ => "No Any Code Found."
            };
            SystemCode.Text = deviceId;
            Remark.Text = method.SingleOrDefault(x => x.MethodName == val)?.Remark.ToString();
        }
        private void SelectMethod_EditValueChanged(object sender, EventArgs e)
        {
            GenerateSystemCode();
        }

        private void GenerateKey_Click(object sender, EventArgs e)
        {
            var id = Guid.NewGuid();
            Keywords.Text = id.ToString();
        }

        private void CopyLicense_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LicensesCode.Text);
            alertControl1.Show(MainForm.OwnForm, "Copy", "The Code Has Benn Copy On ClipBoard");
        }

        private void GenerateLicense_Click(object sender, EventArgs e)
        {
            var method = HashMethod.Text.ToLower();
            var sysCode = SystemCode.Text;
            var key = Keywords.Text;
            var input = key + sysCode;
            var lic = method switch
            {
                "md5" => input.Md5(),
                "md5h" => input.Md5H(),
                "sha1" => input.Sha1(),
                "sha2" => input.Sha2(),
                _ => "Null"
            };

            LicensesCode.Text = lic;
            LicLabel.Text = lic;
        }
    }
}
