namespace BankConsentApplication
{
    partial class Form1
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
            System.Windows.Forms.Label kUNDENR_ANONYMISERTLabel;
            System.Windows.Forms.Label vALID_FROM_DTTMLabel;
            System.Windows.Forms.Label kUNDE_POSTNRLabel;
            System.Windows.Forms.Label kUNDE_POSTSTEDLabel;
            System.Windows.Forms.Label kUNDEANSVARLIG_IDLabel;
            System.Windows.Forms.Label bANK_IDLabel;
            System.Windows.Forms.Label sAMTYKKE_FORSIKRINGLabel;
            System.Windows.Forms.Label sAMTYKKE_BANKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataCenterDataSet = new BankConsentApplication.DataCenterDataSet();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankTableAdapter = new BankConsentApplication.DataCenterDataSetTableAdapters.BankTableAdapter();
            this.tableAdapterManager = new BankConsentApplication.DataCenterDataSetTableAdapters.TableAdapterManager();
            this.bankBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bankBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kUNDENR_ANONYMISERTTextBox = new System.Windows.Forms.TextBox();
            this.vALID_FROM_DTTMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kUNDE_POSTNRTextBox = new System.Windows.Forms.TextBox();
            this.kUNDE_POSTSTEDTextBox = new System.Windows.Forms.TextBox();
            this.kUNDEANSVARLIG_IDTextBox = new System.Windows.Forms.TextBox();
            this.bANK_IDTextBox = new System.Windows.Forms.TextBox();
            this.sAMTYKKE_FORSIKRINGTextBox = new System.Windows.Forms.TextBox();
            this.sAMTYKKE_BANKTextBox = new System.Windows.Forms.TextBox();
            kUNDENR_ANONYMISERTLabel = new System.Windows.Forms.Label();
            vALID_FROM_DTTMLabel = new System.Windows.Forms.Label();
            kUNDE_POSTNRLabel = new System.Windows.Forms.Label();
            kUNDE_POSTSTEDLabel = new System.Windows.Forms.Label();
            kUNDEANSVARLIG_IDLabel = new System.Windows.Forms.Label();
            bANK_IDLabel = new System.Windows.Forms.Label();
            sAMTYKKE_FORSIKRINGLabel = new System.Windows.Forms.Label();
            sAMTYKKE_BANKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingNavigator)).BeginInit();
            this.bankBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kUNDENR_ANONYMISERTLabel
            // 
            kUNDENR_ANONYMISERTLabel.AutoSize = true;
            kUNDENR_ANONYMISERTLabel.Location = new System.Drawing.Point(293, 134);
            kUNDENR_ANONYMISERTLabel.Name = "kUNDENR_ANONYMISERTLabel";
            kUNDENR_ANONYMISERTLabel.Size = new System.Drawing.Size(213, 20);
            kUNDENR_ANONYMISERTLabel.TabIndex = 1;
            kUNDENR_ANONYMISERTLabel.Text = "KUNDENR ANONYMISERT:";
            // 
            // vALID_FROM_DTTMLabel
            // 
            vALID_FROM_DTTMLabel.AutoSize = true;
            vALID_FROM_DTTMLabel.Location = new System.Drawing.Point(293, 167);
            vALID_FROM_DTTMLabel.Name = "vALID_FROM_DTTMLabel";
            vALID_FROM_DTTMLabel.Size = new System.Drawing.Size(159, 20);
            vALID_FROM_DTTMLabel.TabIndex = 3;
            vALID_FROM_DTTMLabel.Text = "VALID FROM DTTM:";
            // 
            // kUNDE_POSTNRLabel
            // 
            kUNDE_POSTNRLabel.AutoSize = true;
            kUNDE_POSTNRLabel.Location = new System.Drawing.Point(293, 198);
            kUNDE_POSTNRLabel.Name = "kUNDE_POSTNRLabel";
            kUNDE_POSTNRLabel.Size = new System.Drawing.Size(138, 20);
            kUNDE_POSTNRLabel.TabIndex = 5;
            kUNDE_POSTNRLabel.Text = "KUNDE POSTNR:";
            // 
            // kUNDE_POSTSTEDLabel
            // 
            kUNDE_POSTSTEDLabel.AutoSize = true;
            kUNDE_POSTSTEDLabel.Location = new System.Drawing.Point(293, 230);
            kUNDE_POSTSTEDLabel.Name = "kUNDE_POSTSTEDLabel";
            kUNDE_POSTSTEDLabel.Size = new System.Drawing.Size(158, 20);
            kUNDE_POSTSTEDLabel.TabIndex = 7;
            kUNDE_POSTSTEDLabel.Text = "KUNDE POSTSTED:";
            // 
            // kUNDEANSVARLIG_IDLabel
            // 
            kUNDEANSVARLIG_IDLabel.AutoSize = true;
            kUNDEANSVARLIG_IDLabel.Location = new System.Drawing.Point(293, 262);
            kUNDEANSVARLIG_IDLabel.Name = "kUNDEANSVARLIG_IDLabel";
            kUNDEANSVARLIG_IDLabel.Size = new System.Drawing.Size(184, 20);
            kUNDEANSVARLIG_IDLabel.TabIndex = 9;
            kUNDEANSVARLIG_IDLabel.Text = "KUNDEANSVARLIG ID:";
            // 
            // bANK_IDLabel
            // 
            bANK_IDLabel.AutoSize = true;
            bANK_IDLabel.Location = new System.Drawing.Point(293, 294);
            bANK_IDLabel.Name = "bANK_IDLabel";
            bANK_IDLabel.Size = new System.Drawing.Size(77, 20);
            bANK_IDLabel.TabIndex = 11;
            bANK_IDLabel.Text = "BANK ID:";
            // 
            // sAMTYKKE_FORSIKRINGLabel
            // 
            sAMTYKKE_FORSIKRINGLabel.AutoSize = true;
            sAMTYKKE_FORSIKRINGLabel.Location = new System.Drawing.Point(293, 326);
            sAMTYKKE_FORSIKRINGLabel.Name = "sAMTYKKE_FORSIKRINGLabel";
            sAMTYKKE_FORSIKRINGLabel.Size = new System.Drawing.Size(204, 20);
            sAMTYKKE_FORSIKRINGLabel.TabIndex = 13;
            sAMTYKKE_FORSIKRINGLabel.Text = "SAMTYKKE FORSIKRING:";
            // 
            // sAMTYKKE_BANKLabel
            // 
            sAMTYKKE_BANKLabel.AutoSize = true;
            sAMTYKKE_BANKLabel.Location = new System.Drawing.Point(293, 358);
            sAMTYKKE_BANKLabel.Name = "sAMTYKKE_BANKLabel";
            sAMTYKKE_BANKLabel.Size = new System.Drawing.Size(146, 20);
            sAMTYKKE_BANKLabel.TabIndex = 15;
            sAMTYKKE_BANKLabel.Text = "SAMTYKKE BANK:";
            // 
            // dataCenterDataSet
            // 
            this.dataCenterDataSet.DataSetName = "DataCenterDataSet";
            this.dataCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataMember = "Bank";
            this.bankBindingSource.DataSource = this.dataCenterDataSet;
            // 
            // bankTableAdapter
            // 
            this.bankTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = this.bankTableAdapter;
            this.tableAdapterManager.MessageQueueTableAdapter = new DataCenterDataSetTableAdapters.MessageQueueTableAdapter();
            this.tableAdapterManager.UpdateOrder = BankConsentApplication.DataCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bankBindingNavigator
            // 
            this.bankBindingNavigator.AddNewItem = null;
            this.bankBindingNavigator.BindingSource = this.bankBindingSource;
            this.bankBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bankBindingNavigator.DeleteItem = null;
            this.bankBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bankBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bankBindingNavigatorSaveItem});
            this.bankBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bankBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bankBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bankBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bankBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bankBindingNavigator.Name = "bankBindingNavigator";
            this.bankBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bankBindingNavigator.Size = new System.Drawing.Size(919, 31);
            this.bankBindingNavigator.TabIndex = 0;
            this.bankBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bankBindingNavigatorSaveItem
            // 
            this.bankBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bankBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bankBindingNavigatorSaveItem.Image")));
            this.bankBindingNavigatorSaveItem.Name = "bankBindingNavigatorSaveItem";
            this.bankBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.bankBindingNavigatorSaveItem.Text = "Save Data";
            this.bankBindingNavigatorSaveItem.Click += new System.EventHandler(this.bankBindingNavigatorSaveItem_Click);
            // 
            // kUNDENR_ANONYMISERTTextBox
            // 
            this.kUNDENR_ANONYMISERTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "KUNDENR_ANONYMISERT", true));
            this.kUNDENR_ANONYMISERTTextBox.Location = new System.Drawing.Point(512, 131);
            this.kUNDENR_ANONYMISERTTextBox.Name = "kUNDENR_ANONYMISERTTextBox";
            this.kUNDENR_ANONYMISERTTextBox.Size = new System.Drawing.Size(200, 26);
            this.kUNDENR_ANONYMISERTTextBox.TabIndex = 2;
            this.kUNDENR_ANONYMISERTTextBox.ReadOnly = true;
            // 
            // vALID_FROM_DTTMDateTimePicker
            // 
            this.vALID_FROM_DTTMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bankBindingSource, "VALID_FROM_DTTM", true));
            this.vALID_FROM_DTTMDateTimePicker.Location = new System.Drawing.Point(512, 163);
            this.vALID_FROM_DTTMDateTimePicker.Name = "vALID_FROM_DTTMDateTimePicker";
            this.vALID_FROM_DTTMDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.vALID_FROM_DTTMDateTimePicker.TabIndex = 4;
            this.vALID_FROM_DTTMDateTimePicker.Enabled = false;
            // 
            // kUNDE_POSTNRTextBox
            // 
            this.kUNDE_POSTNRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "KUNDE_POSTNR", true));
            this.kUNDE_POSTNRTextBox.Location = new System.Drawing.Point(512, 195);
            this.kUNDE_POSTNRTextBox.Name = "kUNDE_POSTNRTextBox";
            this.kUNDE_POSTNRTextBox.Size = new System.Drawing.Size(200, 26);
            this.kUNDE_POSTNRTextBox.TabIndex = 6;
            this.kUNDE_POSTNRTextBox.ReadOnly = true;
            // 
            // kUNDE_POSTSTEDTextBox
            // 
            this.kUNDE_POSTSTEDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "KUNDE_POSTSTED", true));
            this.kUNDE_POSTSTEDTextBox.Location = new System.Drawing.Point(512, 227);
            this.kUNDE_POSTSTEDTextBox.Name = "kUNDE_POSTSTEDTextBox";
            this.kUNDE_POSTSTEDTextBox.Size = new System.Drawing.Size(200, 26);
            this.kUNDE_POSTSTEDTextBox.TabIndex = 8;
            this.kUNDE_POSTSTEDTextBox.ReadOnly = true;
            // 
            // kUNDEANSVARLIG_IDTextBox
            // 
            this.kUNDEANSVARLIG_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "KUNDEANSVARLIG_ID", true));
            this.kUNDEANSVARLIG_IDTextBox.Location = new System.Drawing.Point(512, 259);
            this.kUNDEANSVARLIG_IDTextBox.Name = "kUNDEANSVARLIG_IDTextBox";
            this.kUNDEANSVARLIG_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.kUNDEANSVARLIG_IDTextBox.TabIndex = 10;
            this.kUNDEANSVARLIG_IDTextBox.ReadOnly = true;
            // 
            // bANK_IDTextBox
            // 
            this.bANK_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "BANK_ID", true));
            this.bANK_IDTextBox.Location = new System.Drawing.Point(512, 291);
            this.bANK_IDTextBox.Name = "bANK_IDTextBox";
            this.bANK_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.bANK_IDTextBox.TabIndex = 12;
            this.bANK_IDTextBox.ReadOnly = true;
            // 
            // sAMTYKKE_FORSIKRINGTextBox
            // 
            this.sAMTYKKE_FORSIKRINGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "SAMTYKKE_FORSIKRING", true));
            this.sAMTYKKE_FORSIKRINGTextBox.Location = new System.Drawing.Point(512, 323);
            this.sAMTYKKE_FORSIKRINGTextBox.Name = "sAMTYKKE_FORSIKRINGTextBox";
            this.sAMTYKKE_FORSIKRINGTextBox.Size = new System.Drawing.Size(200, 26);
            this.sAMTYKKE_FORSIKRINGTextBox.TabIndex = 14;
            this.sAMTYKKE_FORSIKRINGTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // sAMTYKKE_BANKTextBox
            // 
            this.sAMTYKKE_BANKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "SAMTYKKE_BANK", true));
            this.sAMTYKKE_BANKTextBox.Location = new System.Drawing.Point(512, 355);
            this.sAMTYKKE_BANKTextBox.Name = "sAMTYKKE_BANKTextBox";
            this.sAMTYKKE_BANKTextBox.Size = new System.Drawing.Size(200, 26);
            this.sAMTYKKE_BANKTextBox.TabIndex = 16;
            this.sAMTYKKE_BANKTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 548);
            this.Controls.Add(kUNDENR_ANONYMISERTLabel);
            this.Controls.Add(this.kUNDENR_ANONYMISERTTextBox);
            this.Controls.Add(vALID_FROM_DTTMLabel);
            this.Controls.Add(this.vALID_FROM_DTTMDateTimePicker);
            this.Controls.Add(kUNDE_POSTNRLabel);
            this.Controls.Add(this.kUNDE_POSTNRTextBox);
            this.Controls.Add(kUNDE_POSTSTEDLabel);
            this.Controls.Add(this.kUNDE_POSTSTEDTextBox);
            this.Controls.Add(kUNDEANSVARLIG_IDLabel);
            this.Controls.Add(this.kUNDEANSVARLIG_IDTextBox);
            this.Controls.Add(bANK_IDLabel);
            this.Controls.Add(this.bANK_IDTextBox);
            this.Controls.Add(sAMTYKKE_FORSIKRINGLabel);
            this.Controls.Add(this.sAMTYKKE_FORSIKRINGTextBox);
            this.Controls.Add(sAMTYKKE_BANKLabel);
            this.Controls.Add(this.sAMTYKKE_BANKTextBox);
            this.Controls.Add(this.bankBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingNavigator)).EndInit();
            this.bankBindingNavigator.ResumeLayout(false);
            this.bankBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataCenterDataSet dataCenterDataSet;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private DataCenterDataSetTableAdapters.BankTableAdapter bankTableAdapter;
        private DataCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bankBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bankBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kUNDENR_ANONYMISERTTextBox;
        private System.Windows.Forms.DateTimePicker vALID_FROM_DTTMDateTimePicker;
        private System.Windows.Forms.TextBox kUNDE_POSTNRTextBox;
        private System.Windows.Forms.TextBox kUNDE_POSTSTEDTextBox;
        private System.Windows.Forms.TextBox kUNDEANSVARLIG_IDTextBox;
        private System.Windows.Forms.TextBox bANK_IDTextBox;
        private System.Windows.Forms.TextBox sAMTYKKE_FORSIKRINGTextBox;
        private System.Windows.Forms.TextBox sAMTYKKE_BANKTextBox;
    }
}

