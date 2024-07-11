using System;
using System.Windows.Forms;

namespace YourProply.PDF
{
    public partial class GenerateLeaseAgreementForm : Form, IGenerateLeaseAgreementView
    {
        private readonly GenerateLeaseAgreementPresenter _presenter;

        public GenerateLeaseAgreementForm()
        {
            InitializeComponent();
            btnBack.Click += (s, e) => BackToMenuClick?.Invoke(this, EventArgs.Empty);
            btnSave.Click += (s, e) => GeneratePDF?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler BackToMenuClick;
        public event EventHandler GeneratePDF;

        public string LandlordFirstName => txtLandlordFirstName.Text;
        public string LandlordLastName => txtLandlordLastName.Text;
        public string LandlordDOB => txtLandlordBirtdate.Text;
        public string LandlordID => txtIdNumber.Text;

        public string TenantFirstName => txtTenantFirstName.Text;
        public string TenantLastName => txtTenantLastName.Text;
        public string TenantDOB => txtTenantBirthdate.Text;
        public string TenantID => txtTenantIdNumber.Text;

        public string PropertyName => txtPropertyName.Text;
        public string PropertyAddress => txtPropertyAdres.Text;
        public string PropertyType => txtPropertyType.Text;

        public string RentalAmount => txtRentalAmount.Text;
        public string RentalStartDate => txtStartDate.Text;
        public string RentalEndDate => txtEndDate.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public new void Show()
        {
            base.Show();
        }

        public new void Hide()
        {
            base.Hide();
        }
    }
}
