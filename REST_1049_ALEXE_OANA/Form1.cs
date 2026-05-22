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
    }
}
