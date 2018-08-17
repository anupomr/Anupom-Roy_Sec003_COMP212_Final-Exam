namespace Anupom_Roy_Sec003_Ex_01
{
    partial class BankAccountForm
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
            this.groupBoxBank = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAccNum = new System.Windows.Forms.TextBox();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxBanker = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxLinkedList = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.groupBoxBank.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBank
            // 
            this.groupBoxBank.Controls.Add(this.btnDisplay);
            this.groupBoxBank.Controls.Add(this.btnSearch);
            this.groupBoxBank.Controls.Add(this.btnDell);
            this.groupBoxBank.Controls.Add(this.btnInsert);
            this.groupBoxBank.Controls.Add(this.textBoxBanker);
            this.groupBoxBank.Controls.Add(this.textBoxBalance);
            this.groupBoxBank.Controls.Add(this.textBoxCustName);
            this.groupBoxBank.Controls.Add(this.textBoxAccNum);
            this.groupBoxBank.Controls.Add(this.label4);
            this.groupBoxBank.Controls.Add(this.label3);
            this.groupBoxBank.Controls.Add(this.label2);
            this.groupBoxBank.Controls.Add(this.label1);
            this.groupBoxBank.Location = new System.Drawing.Point(13, 13);
            this.groupBoxBank.Name = "groupBoxBank";
            this.groupBoxBank.Size = new System.Drawing.Size(344, 181);
            this.groupBoxBank.TabIndex = 0;
            this.groupBoxBank.TabStop = false;
            this.groupBoxBank.Text = "Bank Account Info- Sorted Dictionary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance (CAD): ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Banker Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAccNum
            // 
            this.textBoxAccNum.Location = new System.Drawing.Point(109, 27);
            this.textBoxAccNum.Name = "textBoxAccNum";
            this.textBoxAccNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccNum.TabIndex = 4;
            this.textBoxAccNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValivation);
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Location = new System.Drawing.Point(109, 56);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustName.TabIndex = 5;
            this.textBoxCustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValivation);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(109, 83);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.textBoxBalance.TabIndex = 6;
            this.textBoxBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValivation);
            // 
            // textBoxBanker
            // 
            this.textBoxBanker.Location = new System.Drawing.Point(109, 111);
            this.textBoxBanker.Name = "textBoxBanker";
            this.textBoxBanker.Size = new System.Drawing.Size(100, 20);
            this.textBoxBanker.TabIndex = 7;
            this.textBoxBanker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValivation);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(240, 25);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDell
            // 
            this.btnDell.Location = new System.Drawing.Point(240, 55);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(75, 23);
            this.btnDell.TabIndex = 9;
            this.btnDell.Text = "Delete";
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(240, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(240, 115);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.listBoxLinkedList);
            this.groupBox1.Location = new System.Drawing.Point(374, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linked List of Values";
            // 
            // listBoxLinkedList
            // 
            this.listBoxLinkedList.FormattingEnabled = true;
            this.listBoxLinkedList.Location = new System.Drawing.Point(6, 20);
            this.listBoxLinkedList.Name = "listBoxLinkedList";
            this.listBoxLinkedList.Size = new System.Drawing.Size(88, 147);
            this.listBoxLinkedList.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(152, 25);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(152, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add to Back";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(152, 84);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove from Font";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(152, 115);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(123, 23);
            this.btnMax.TabIndex = 4;
            this.btnMax.Text = "Maximum";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Output";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(13, 230);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(659, 95);
            this.listBoxOutput.TabIndex = 3;
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 341);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBank);
            this.Name = "BankAccountForm";
            this.Text = "TEST 02-COMP212-Sec003";
            this.groupBoxBank.ResumeLayout(false);
            this.groupBoxBank.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBank;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDell;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox textBoxBanker;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.TextBox textBoxAccNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listBoxLinkedList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxOutput;
    }
}

