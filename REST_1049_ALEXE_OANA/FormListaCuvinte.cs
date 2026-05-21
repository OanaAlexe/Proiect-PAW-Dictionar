using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace REST_1049_ALEXE_OANA
{
    public partial class FormPrincipal : Form
    {
        private BindingList<Cuvant> _cuvinte = new BindingList<Cuvant>();
        public FormPrincipal()
        {
            InitializeComponent();
            lvCuvinte.View = View.Details; //doar ii spun cum sa arate
            lvCuvinte.Columns.Add("Termen");
            lvCuvinte.Columns.Add("Definitie");
            lvCuvinte.Columns.Add("Traducere");
            lvCuvinte.Columns.Add("Limba");
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (var formIntroducereCuvant = new formIntroducereCuvant())
            {
                if (formIntroducereCuvant.ShowDialog() == DialogResult.OK)
                {
                    var cuvantNou = formIntroducereCuvant.CuvantModificat;
                    _cuvinte.Add(cuvantNou);
                    ListViewItem lvItem = new ListViewItem(cuvantNou.Termen);
                    lvItem.SubItems.Add(cuvantNou.Definitie);
                    lvItem.SubItems.Add(cuvantNou.Traducere);
                    lvItem.SubItems.Add(cuvantNou.Limba);

                    lvCuvinte.Items.Add(lvItem);

                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lvCuvinte.SelectedItems.Count > 0)
            {
                var index = lvCuvinte.SelectedItems[0].Index;
                var cuvant = _cuvinte[index];
                using (var formIntroducereCuvant = new formIntroducereCuvant())
                {
                    if (formIntroducereCuvant.ShowDialog() == DialogResult.OK)
                    {
                        var cuvantNou = formIntroducereCuvant.CuvantModificat;
                        _cuvinte[index] = cuvantNou;
                        AfiseazaCuvinte();
                    }
                }
            }
        }

        void AfiseazaCuvinte()
        {
            lvCuvinte.Items.Clear();
            foreach (Cuvant cuvant in _cuvinte)
            {
                ListViewItem item = new ListViewItem(cuvant.Termen);
                item.SubItems.Add(cuvant.Definitie);
                item.SubItems.Add(cuvant.Traducere);
                item.SubItems.Add(cuvant.Limba);
                lvCuvinte.Items.Add(item);
            }
        }
    }
}
