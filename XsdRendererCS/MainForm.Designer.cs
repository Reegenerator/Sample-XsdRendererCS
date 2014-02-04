namespace XsdRendererCS
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.parseXmlButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.xmlSourceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneListBox = new System.Windows.Forms.ListBox();
            this.phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.parseXmlButton);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.xmlSourceBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.phoneListBox);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.addressBox);
            this.splitContainer1.Panel2.Controls.Add(this.ageBox);
            this.splitContainer1.Panel2.Controls.Add(this.nameBox);
            this.splitContainer1.Size = new System.Drawing.Size(594, 420);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 1;
            // 
            // parseXmlButton
            // 
            this.parseXmlButton.Location = new System.Drawing.Point(112, 391);
            this.parseXmlButton.Name = "parseXmlButton";
            this.parseXmlButton.Size = new System.Drawing.Size(90, 32);
            this.parseXmlButton.TabIndex = 3;
            this.parseXmlButton.Text = "Parse";
            this.parseXmlButton.UseVisualStyleBackColor = true;
            this.parseXmlButton.Click += new System.EventHandler(this.parseXmlButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Xml Data";
            // 
            // xmlSourceBox
            // 
            this.xmlSourceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlSourceBox.Location = new System.Drawing.Point(0, 29);
            this.xmlSourceBox.Multiline = true;
            this.xmlSourceBox.Name = "xmlSourceBox";
            this.xmlSourceBox.Size = new System.Drawing.Size(318, 357);
            this.xmlSourceBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Numbers";
            // 
            // phoneListBox
            // 
            this.phoneListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneListBox.DataSource = this.phonesBindingSource;
            this.phoneListBox.FormattingEnabled = true;
            this.phoneListBox.Location = new System.Drawing.Point(27, 126);
            this.phoneListBox.Name = "phoneListBox";
            this.phoneListBox.Size = new System.Drawing.Size(223, 277);
            this.phoneListBox.TabIndex = 2;
            // 
            // phonesBindingSource
            // 
            this.phonesBindingSource.DataMember = "Phones";
            this.phonesBindingSource.DataSource = this.bindingSource;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(XsdRendererCS.Person);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // addressBox
            // 
            this.addressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Address", true));
            this.addressBox.Location = new System.Drawing.Point(68, 64);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(192, 20);
            this.addressBox.TabIndex = 0;
            // 
            // ageBox
            // 
            this.ageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Age", true));
            this.ageBox.Location = new System.Drawing.Point(68, 38);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(192, 20);
            this.ageBox.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Name", true));
            this.nameBox.Location = new System.Drawing.Point(68, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(192, 20);
            this.nameBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 420);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Xsd Renderer Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox xmlSourceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox phoneListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button parseXmlButton;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.BindingSource phonesBindingSource;
    }
}

