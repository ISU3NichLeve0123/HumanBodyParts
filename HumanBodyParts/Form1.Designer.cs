namespace HumanBodyParts
{
    partial class medicalSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicalSale));
            this.eyeLabel = new System.Windows.Forms.Label();
            this.leglLabel = new System.Windows.Forms.Label();
            this.heartlabel = new System.Windows.Forms.Label();
            this.eyeTextBox = new System.Windows.Forms.TextBox();
            this.legTextBox = new System.Windows.Forms.TextBox();
            this.heartTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.printReciptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.cashLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eyeLabel
            // 
            this.eyeLabel.AutoSize = true;
            this.eyeLabel.Location = new System.Drawing.Point(12, 24);
            this.eyeLabel.Name = "eyeLabel";
            this.eyeLabel.Size = new System.Drawing.Size(25, 13);
            this.eyeLabel.TabIndex = 0;
            this.eyeLabel.Text = "Eye";
            // 
            // leglLabel
            // 
            this.leglLabel.Location = new System.Drawing.Point(12, 63);
            this.leglLabel.Name = "leglLabel";
            this.leglLabel.Size = new System.Drawing.Size(53, 17);
            this.leglLabel.TabIndex = 1;
            this.leglLabel.Text = "Leg";
            // 
            // heartlabel
            // 
            this.heartlabel.AutoSize = true;
            this.heartlabel.Location = new System.Drawing.Point(12, 93);
            this.heartlabel.Name = "heartlabel";
            this.heartlabel.Size = new System.Drawing.Size(33, 13);
            this.heartlabel.TabIndex = 2;
            this.heartlabel.Text = "Heart";
            // 
            // eyeTextBox
            // 
            this.eyeTextBox.Location = new System.Drawing.Point(73, 24);
            this.eyeTextBox.Name = "eyeTextBox";
            this.eyeTextBox.Size = new System.Drawing.Size(100, 20);
            this.eyeTextBox.TabIndex = 3;
            // 
            // legTextBox
            // 
            this.legTextBox.Location = new System.Drawing.Point(71, 60);
            this.legTextBox.Name = "legTextBox";
            this.legTextBox.Size = new System.Drawing.Size(100, 20);
            this.legTextBox.TabIndex = 4;
            // 
            // heartTextBox
            // 
            this.heartTextBox.Location = new System.Drawing.Point(71, 93);
            this.heartTextBox.Name = "heartTextBox";
            this.heartTextBox.Size = new System.Drawing.Size(100, 20);
            this.heartTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(73, 134);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(27, 166);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.subTotalLabel.TabIndex = 7;
            this.subTotalLabel.Text = "h";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.subTotalLabel.Visible = false;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(27, 194);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(13, 13);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "h";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.taxLabel.Visible = false;
            // 
            // printReciptButton
            // 
            this.printReciptButton.Location = new System.Drawing.Point(73, 364);
            this.printReciptButton.Name = "printReciptButton";
            this.printReciptButton.Size = new System.Drawing.Size(75, 23);
            this.printReciptButton.TabIndex = 9;
            this.printReciptButton.Text = "Print Recipt";
            this.printReciptButton.UseVisualStyleBackColor = true;
            this.printReciptButton.Visible = false;
            this.printReciptButton.Click += new System.EventHandler(this.printReciptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(316, 364);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(75, 23);
            this.newOrderButton.TabIndex = 10;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Visible = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButon_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(27, 217);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(10, 17);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "h";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.totalLabel.UseCompatibleTextRendering = true;
            this.totalLabel.Visible = false;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(71, 297);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Visible = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Location = new System.Drawing.Point(24, 260);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(31, 13);
            this.cashLabel.TabIndex = 13;
            this.cashLabel.Text = "Cash";
            this.cashLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cashLabel.Visible = false;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(24, 341);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.Text = "Change";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.changeLabel.Visible = false;
            // 
            // cashTextBox
            // 
            this.cashTextBox.Location = new System.Drawing.Point(73, 253);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashTextBox.TabIndex = 15;
            this.cashTextBox.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(179, 364);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 16;
            // 
            // medicalSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 399);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cashTextBox);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printReciptButton);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.heartTextBox);
            this.Controls.Add(this.legTextBox);
            this.Controls.Add(this.eyeTextBox);
            this.Controls.Add(this.heartlabel);
            this.Controls.Add(this.leglLabel);
            this.Controls.Add(this.eyeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "medicalSale";
            this.Text = "MedicalSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eyeLabel;
        private System.Windows.Forms.Label leglLabel;
        private System.Windows.Forms.Label heartlabel;
        private System.Windows.Forms.TextBox eyeTextBox;
        private System.Windows.Forms.TextBox legTextBox;
        private System.Windows.Forms.TextBox heartTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Button printReciptButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.Label errorLabel;
    }
}

