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
            _presenter = new GenerateLeaseAgreementPresenter(this);
        }

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.GeneratePdf();
        }
    }
}
