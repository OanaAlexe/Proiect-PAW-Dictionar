using System.Windows.Forms;

namespace REST_1049_ALEXE_OANA
{
    public partial class formIntroducereCuvant : Form
    {

        public Cuvant CuvantModificat { get; set; }
        public formIntroducereCuvant()
        {
            InitializeComponent();
            cmbLimba.Items.Add("Franceza");
            cmbLimba.Items.Add("Germana");
            cmbLimba.Items.Add("Latina");
        }

        private void btnSalveaza_Click(object sender, System.EventArgs e)
        {
            bool esteValid = ValideazaForm();
            if (esteValid == false)
            {
                return;
            }
            CuvantModificat = new Cuvant();
            CuvantModificat.Termen = txtTermen.Text;
            CuvantModificat.Definitie = txtDefinitie.Text;
            CuvantModificat.Traducere = txtTraducere.Text;
            CuvantModificat.Limba = cmbLimba.SelectedItem?.ToString();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            CuvantModificat = null;
        }

        private bool ValideazaForm()
        {
            epValidare.Clear();
            bool esteValid = true;
            if (string.IsNullOrEmpty(txtTermen.Text))
            {
                epValidare.SetError(txtTermen, "Introduceti termenul!");
                esteValid = false;
            }
            if (string.IsNullOrEmpty(txtDefinitie.Text))
            {
                epValidare.SetError(txtDefinitie, "Introduceti definitia!");
                esteValid = false;
            }
            if (string.IsNullOrEmpty(txtTraducere.Text))
            {
                epValidare.SetError(txtTraducere, "Introduceti traducerea!");
                esteValid = false;
            }
            if (string.IsNullOrEmpty(cmbLimba.Text))
            {
                epValidare.SetError(cmbLimba, "Introduceti limba in care vreti sa traduceti termenul!");
                esteValid = false;
            }
            return esteValid;
        }
    }
}
