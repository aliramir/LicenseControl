using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.FluentDesignSystem;
using LicenseControl.Views.UserControls;

namespace LicenseControl.Views
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public static MainForm OwnForm;
        public MainForm()
        {
            InitializeComponent();
            OwnForm = this;
            UserControl(new Quickstart());
        }

        private void UserControl(Control userControl)
        {
            fluentDesignFormContainer1.Controls.Cast<Control>().ForEach(i => i.Dispose());
            fluentDesignFormContainer1.Controls.Clear();

            fluentDesignFormContainer1.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

       
        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, System.EventArgs e)
        {

        }

        private void ProduceListBtn_Click(object sender, System.EventArgs e)
        {
            UserControl(new ProducesList());
        }

        private void HomeBtn_Click(object sender, System.EventArgs e)
        {
            UserControl(new Quickstart());
        }

        private void CreateLicense_Click(object sender, System.EventArgs e)
        {
            UserControl(new CreateLicense());
        }

        private void aboutMeBtn_Click(object sender, System.EventArgs e)
        {
            UserControl(new AboutMe());
        }
    }
}
