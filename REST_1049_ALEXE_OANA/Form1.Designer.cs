namespace REST_1049_ALEXE_OANA
{
    partial class formIntroducereCuvant
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTermen = new System.Windows.Forms.TextBox();
            this.txtDefinitie = new System.Windows.Forms.TextBox();
            this.txtTraducere = new System.Windows.Forms.TextBox();
            this.labelTermen = new System.Windows.Forms.Label();
            this.labelDefinitie = new System.Windows.Forms.Label();
            this.labelTraducere = new System.Windows.Forms.Label();
            this.cmbLimba = new System.Windows.Forms.ComboBox();
            this.labelLimba = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTermen
            // 
            this.txtTermen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTermen.Location = new System.Drawing.Point(135, 72);
            this.txtTermen.Name = "txtTermen";
            this.txtTermen.Size = new System.Drawing.Size(322, 22);
            this.txtTermen.TabIndex = 1;
            // 
            // txtDefinitie
            // 
            this.txtDefinitie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDefinitie.Location = new System.Drawing.Point(135, 154);
            this.txtDefinitie.Name = "txtDefinitie";
            this.txtDefinitie.Size = new System.Drawing.Size(322, 22);
            this.txtDefinitie.TabIndex = 2;
            // 
            // txtTraducere
            // 
            this.txtTraducere.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTraducere.Location = new System.Drawing.Point(135, 225);
            this.txtTraducere.Name = "txtTraducere";
            this.txtTraducere.Size = new System.Drawing.Size(322, 22);
            this.txtTraducere.TabIndex = 3;
            // 
            // labelTermen
            // 
            this.labelTermen.AutoSize = true;
            this.labelTermen.Location = new System.Drawing.Point(555, 78);
            this.labelTermen.Name = "labelTermen";
            this.labelTermen.Size = new System.Drawing.Size(122, 16);
            this.labelTermen.TabIndex = 4;
            this.labelTermen.Text = "Introduceti termenul";
            // 
            // labelDefinitie
            // 
            this.labelDefinitie.AutoSize = true;
            this.labelDefinitie.Location = new System.Drawing.Point(555, 154);
            this.labelDefinitie.Name = "labelDefinitie";
            this.labelDefinitie.Size = new System.Drawing.Size(110, 16);
            this.labelDefinitie.TabIndex = 5;
            this.labelDefinitie.Text = "Introdceti definitie";
            // 
            // labelTraducere
            // 
            this.labelTraducere.AutoSize = true;
            this.labelTraducere.Location = new System.Drawing.Point(555, 231);
            this.labelTraducere.Name = "labelTraducere";
            this.labelTraducere.Size = new System.Drawing.Size(128, 16);
            this.labelTraducere.TabIndex = 6;
            this.labelTraducere.Text = "Introduceti traducere";
            // 
            // cmbLimba
            // 
            this.cmbLimba.FormattingEnabled = true;
            this.cmbLimba.Items.AddRange(new object[] {
            "Engleza",
            "Romana"});
            this.cmbLimba.Location = new System.Drawing.Point(135, 301);
            this.cmbLimba.Name = "cmbLimba";
            this.cmbLimba.Size = new System.Drawing.Size(322, 24);
            this.cmbLimba.TabIndex = 7;
            // 
            // labelLimba
            // 
            this.labelLimba.AutoSize = true;
            this.labelLimba.Location = new System.Drawing.Point(555, 304);
            this.labelLimba.Name = "labelLimba";
            this.labelLimba.Size = new System.Drawing.Size(104, 16);
            this.labelLimba.TabIndex = 8;
            this.labelLimba.Text = "Introduceti limba";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(254, 402);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(90, 23);
            this.btnSalveaza.TabIndex = 10;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(450, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Anuleaza";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(129, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ce cuvant vrei sa introduci?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formIntroducereCuvant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.labelLimba);
            this.Controls.Add(this.cmbLimba);
            this.Controls.Add(this.labelTraducere);
            this.Controls.Add(this.labelDefinitie);
            this.Controls.Add(this.labelTermen);
            this.Controls.Add(this.txtTraducere);
            this.Controls.Add(this.txtDefinitie);
            this.Controls.Add(this.txtTermen);
            this.Name = "formIntroducereCuvant";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTermen;
        private System.Windows.Forms.TextBox txtDefinitie;
        private System.Windows.Forms.TextBox txtTraducere;
        private System.Windows.Forms.Label labelTermen;
        private System.Windows.Forms.Label labelDefinitie;
        private System.Windows.Forms.Label labelTraducere;
        private System.Windows.Forms.ComboBox cmbLimba;
        private System.Windows.Forms.Label labelLimba;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

