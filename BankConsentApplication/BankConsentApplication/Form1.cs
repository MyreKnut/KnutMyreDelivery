using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankConsentApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Bank consent editor";
        }

        private void bankBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bankBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataCenterDataSet);

            this.tableAdapterManager.BankTableAdapter.Update(this.dataCenterDataSet.Bank[bankBindingSource.Position]);
            this.tableAdapterManager.MessageQueueTableAdapter.Insert(
                this.dataCenterDataSet.Bank[bankBindingSource.Position].KUNDENR_ANONYMISERT,
                this.dataCenterDataSet.Bank[bankBindingSource.Position].VALID_FROM_DTTM,
                this.dataCenterDataSet.Bank[bankBindingSource.Position].KUNDE_POSTNR,
                this.dataCenterDataSet.Bank[bankBindingSource.Position].KUNDE_POSTSTED,
                this.dataCenterDataSet.Bank[bankBindingSource.Position].KUNDEANSVARLIG_ID,
                this.dataCenterDataSet.Bank[bankBindingSource.Position].BANK_ID,
                this.dataCenterDataSet.Bank[bankBindingSource.Position].SAMTYKKE_FORSIKRING,
                this.dataCenterDataSet.Bank[bankBindingSource.Position].SAMTYKKE_BANK
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataCenterDataSet.Bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.dataCenterDataSet.Bank);

        }
    }
}
