namespace LicenseControl.Views.UserControls
{
    partial class CreateLicense
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLicense));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.SelectMethod = new DevExpress.XtraEditors.LookUpEdit();
            this.SystemCode = new DevExpress.XtraEditors.TextEdit();
            this.Remark = new DevExpress.XtraEditors.MemoEdit();
            this.HashMethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Keywords = new DevExpress.XtraEditors.TextEdit();
            this.GenerateKey = new DevExpress.XtraEditors.SimpleButton();
            this.GenerateLicense = new DevExpress.XtraEditors.SimpleButton();
            this.LicensesCode = new DevExpress.XtraEditors.TextEdit();
            this.CopyLicense = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.GenerateLicenseCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.LicenseCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LicLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HashMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keywords.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicensesCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateLicenseCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicenseCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.SelectMethod);
            this.layoutControl1.Controls.Add(this.SystemCode);
            this.layoutControl1.Controls.Add(this.Remark);
            this.layoutControl1.Controls.Add(this.HashMethod);
            this.layoutControl1.Controls.Add(this.Keywords);
            this.layoutControl1.Controls.Add(this.GenerateKey);
            this.layoutControl1.Controls.Add(this.GenerateLicense);
            this.layoutControl1.Controls.Add(this.LicensesCode);
            this.layoutControl1.Controls.Add(this.CopyLicense);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(600, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // SelectMethod
            // 
            this.SelectMethod.Location = new System.Drawing.Point(120, 53);
            this.SelectMethod.Name = "SelectMethod";
            this.SelectMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectMethod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MethodName", "Method Name")});
            this.SelectMethod.Properties.NullText = "";
            this.SelectMethod.Size = new System.Drawing.Size(448, 28);
            this.SelectMethod.StyleController = this.layoutControl1;
            this.SelectMethod.TabIndex = 0;
            this.SelectMethod.EditValueChanged += new System.EventHandler(this.SelectMethod_EditValueChanged);
            // 
            // SystemCode
            // 
            this.SystemCode.Location = new System.Drawing.Point(120, 135);
            this.SystemCode.Name = "SystemCode";
            this.SystemCode.Size = new System.Drawing.Size(448, 28);
            this.SystemCode.StyleController = this.layoutControl1;
            this.SystemCode.TabIndex = 1;
            // 
            // Remark
            // 
            this.Remark.Location = new System.Drawing.Point(120, 87);
            this.Remark.Name = "Remark";
            this.Remark.Properties.ReadOnly = true;
            this.Remark.Size = new System.Drawing.Size(448, 42);
            this.Remark.StyleController = this.layoutControl1;
            this.Remark.TabIndex = 2;
            this.Remark.TabStop = false;
            // 
            // HashMethod
            // 
            this.HashMethod.EditValue = "SHA1";
            this.HashMethod.Location = new System.Drawing.Point(120, 222);
            this.HashMethod.Name = "HashMethod";
            this.HashMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HashMethod.Properties.Items.AddRange(new object[] {
            "MD5",
            "MD5H",
            "SHA1",
            "SHA256",
            "KeyedHash",
            "SHA384",
            "SHA512",
            "RIPEMD"});
            this.HashMethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.HashMethod.Size = new System.Drawing.Size(448, 28);
            this.HashMethod.StyleController = this.layoutControl1;
            this.HashMethod.TabIndex = 2;
            // 
            // Keywords
            // 
            this.Keywords.Location = new System.Drawing.Point(120, 256);
            this.Keywords.Name = "Keywords";
            this.Keywords.Properties.Appearance.FontSizeDelta = 2;
            this.Keywords.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Keywords.Properties.Appearance.Options.UseFont = true;
            this.Keywords.Size = new System.Drawing.Size(196, 32);
            this.Keywords.StyleController = this.layoutControl1;
            this.Keywords.TabIndex = 3;
            // 
            // GenerateKey
            // 
            this.GenerateKey.Location = new System.Drawing.Point(322, 256);
            this.GenerateKey.Name = "GenerateKey";
            this.GenerateKey.Size = new System.Drawing.Size(246, 32);
            this.GenerateKey.StyleController = this.layoutControl1;
            this.GenerateKey.TabIndex = 6;
            this.GenerateKey.TabStop = false;
            this.GenerateKey.Text = "Generate KeyWord";
            this.GenerateKey.Click += new System.EventHandler(this.GenerateKey_Click);
            // 
            // GenerateLicense
            // 
            this.GenerateLicense.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GenerateLicense.ImageOptions.SvgImage")));
            this.GenerateLicense.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.GenerateLicense.Location = new System.Drawing.Point(322, 294);
            this.GenerateLicense.Name = "GenerateLicense";
            this.GenerateLicense.Size = new System.Drawing.Size(143, 36);
            this.GenerateLicense.StyleController = this.layoutControl1;
            this.GenerateLicense.TabIndex = 8;
            this.GenerateLicense.TabStop = false;
            this.GenerateLicense.Text = "Generate License Code";
            this.GenerateLicense.Click += new System.EventHandler(this.GenerateLicense_Click);
            // 
            // LicensesCode
            // 
            this.LicensesCode.Location = new System.Drawing.Point(120, 294);
            this.LicensesCode.Name = "LicensesCode";
            this.LicensesCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LicensesCode.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.LicensesCode.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.LicensesCode.Properties.Appearance.Options.UseFont = true;
            this.LicensesCode.Properties.Appearance.Options.UseForeColor = true;
            this.LicensesCode.Properties.Appearance.Options.UseTextOptions = true;
            this.LicensesCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LicensesCode.Size = new System.Drawing.Size(196, 36);
            this.LicensesCode.StyleController = this.layoutControl1;
            this.LicensesCode.TabIndex = 4;
            // 
            // CopyLicense
            // 
            this.CopyLicense.Location = new System.Drawing.Point(471, 294);
            this.CopyLicense.Name = "CopyLicense";
            this.CopyLicense.Size = new System.Drawing.Size(97, 36);
            this.CopyLicense.StyleController = this.layoutControl1;
            this.CopyLicense.TabIndex = 9;
            this.CopyLicense.TabStop = false;
            this.CopyLicense.Text = "Copy To ClipBoard";
            this.CopyLicense.Click += new System.EventHandler(this.CopyLicense_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.LicLabel});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(600, 450);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 378);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(574, 46);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(574, 169);
            this.layoutControlGroup1.Text = "System Code";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.SelectMethod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(542, 34);
            this.layoutControlItem1.Text = "Select Method:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.SystemCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(542, 34);
            this.layoutControlItem2.Text = "System Code:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Remark;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 48);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(98, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(542, 48);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Remark:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.GenerateLicenseCode,
            this.LicenseCode,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 169);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(574, 167);
            this.layoutControlGroup2.Text = "Hash Encrypt";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.HashMethod;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(542, 34);
            this.layoutControlItem4.Text = "Hash Method:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Keywords;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(290, 38);
            this.layoutControlItem5.Text = "Key Word:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.GenerateKey;
            this.layoutControlItem6.Location = new System.Drawing.Point(290, 34);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(252, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(252, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(252, 38);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // GenerateLicenseCode
            // 
            this.GenerateLicenseCode.Control = this.GenerateLicense;
            this.GenerateLicenseCode.Location = new System.Drawing.Point(290, 72);
            this.GenerateLicenseCode.MaxSize = new System.Drawing.Size(149, 0);
            this.GenerateLicenseCode.MinSize = new System.Drawing.Size(149, 32);
            this.GenerateLicenseCode.Name = "GenerateLicenseCode";
            this.GenerateLicenseCode.Size = new System.Drawing.Size(149, 42);
            this.GenerateLicenseCode.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.GenerateLicenseCode.TextSize = new System.Drawing.Size(0, 0);
            this.GenerateLicenseCode.TextVisible = false;
            // 
            // LicenseCode
            // 
            this.LicenseCode.Control = this.LicensesCode;
            this.LicenseCode.Location = new System.Drawing.Point(0, 72);
            this.LicenseCode.Name = "LicenseCode";
            this.LicenseCode.Size = new System.Drawing.Size(290, 42);
            this.LicenseCode.Text = "License Code:";
            this.LicenseCode.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.CopyLicense;
            this.layoutControlItem7.Location = new System.Drawing.Point(439, 72);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(103, 0);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(103, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(103, 42);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // LicLabel
            // 
            this.LicLabel.AllowHotTrack = false;
            this.LicLabel.AppearanceItemCaption.FontSizeDelta = 5;
            this.LicLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.LicLabel.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.LicLabel.AppearanceItemCaption.Options.UseFont = true;
            this.LicLabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.LicLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.LicLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LicLabel.Location = new System.Drawing.Point(0, 336);
            this.LicLabel.Name = "LicLabel";
            this.LicLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.LicLabel.Size = new System.Drawing.Size(574, 42);
            this.LicLabel.Text = "License Code";
            this.LicLabel.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.LicLabel.TextSize = new System.Drawing.Size(118, 22);
            // 
            // CreateLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "CreateLicense";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.MainUc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HashMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keywords.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicensesCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateLicenseCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicenseCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LookUpEdit SelectMethod;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit SystemCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.MemoEdit Remark;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ComboBoxEdit HashMethod;
        private DevExpress.XtraEditors.TextEdit Keywords;
        private DevExpress.XtraEditors.SimpleButton GenerateKey;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton GenerateLicense;
        private DevExpress.XtraLayout.LayoutControlItem GenerateLicenseCode;
        private DevExpress.XtraEditors.TextEdit LicensesCode;
        private DevExpress.XtraLayout.LayoutControlItem LicenseCode;
        private DevExpress.XtraEditors.SimpleButton CopyLicense;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraLayout.SimpleLabelItem LicLabel;
    }
}
