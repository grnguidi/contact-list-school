using System.Windows.Forms;
using System;

namespace Contact_list
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contactlst = new System.Windows.Forms.ListBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.numbertxt = new System.Windows.Forms.TextBox();
            this.addcontactbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< Updated upstream
            this.label1.Location = new System.Drawing.Point(12, 14);
=======
            this.label1.Location = new System.Drawing.Point(12, 48);
>>>>>>> Stashed changes
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< Updated upstream
            this.label2.Location = new System.Drawing.Point(12, 51);
=======
            this.label2.Location = new System.Drawing.Point(12, 85);
>>>>>>> Stashed changes
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< Updated upstream
            this.label3.Location = new System.Drawing.Point(12, 90);
=======
            this.label3.Location = new System.Drawing.Point(12, 124);
>>>>>>> Stashed changes
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contactlst
            // 
            this.contactlst.FormattingEnabled = true;
<<<<<<< Updated upstream
            this.contactlst.Location = new System.Drawing.Point(192, 12);
=======
            this.contactlst.Location = new System.Drawing.Point(192, 46);
>>>>>>> Stashed changes
            this.contactlst.Name = "contactlst";
            this.contactlst.Size = new System.Drawing.Size(227, 160);
            this.contactlst.TabIndex = 3;
            // 
            // nametxt
            // 
<<<<<<< Updated upstream
            this.nametxt.Location = new System.Drawing.Point(74, 14);
=======
            this.nametxt.Location = new System.Drawing.Point(74, 48);
>>>>>>> Stashed changes
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(69, 20);
            this.nametxt.TabIndex = 4;
            // 
            // lastnametxt
            // 
<<<<<<< Updated upstream
            this.lastnametxt.Location = new System.Drawing.Point(76, 51);
=======
            this.lastnametxt.Location = new System.Drawing.Point(76, 85);
>>>>>>> Stashed changes
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(67, 20);
            this.lastnametxt.TabIndex = 5;
            // 
            // numbertxt
            // 
<<<<<<< Updated upstream
            this.numbertxt.Location = new System.Drawing.Point(77, 91);
=======
            this.numbertxt.Location = new System.Drawing.Point(77, 125);
>>>>>>> Stashed changes
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(66, 20);
            this.numbertxt.TabIndex = 6;
            // 
            // addcontactbtn
            // 
<<<<<<< Updated upstream
            this.addcontactbtn.Location = new System.Drawing.Point(15, 117);
=======
            this.addcontactbtn.Location = new System.Drawing.Point(15, 151);
>>>>>>> Stashed changes
            this.addcontactbtn.Name = "addcontactbtn";
            this.addcontactbtn.Size = new System.Drawing.Size(128, 55);
            this.addcontactbtn.TabIndex = 7;
            this.addcontactbtn.Text = "Add Contact";
            this.addcontactbtn.UseVisualStyleBackColor = true;
            this.addcontactbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 471);
            this.Controls.Add(this.addcontactbtn);
            this.Controls.Add(this.numbertxt);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.contactlst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox contactlst;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.TextBox numbertxt;
        private System.Windows.Forms.Button addcontactbtn;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addcontactbtn_click(object sender, EventArgs e)
        {
            Contact objcontact = new Contact();
            contactlst.Items.Add(objcontact.ToString());
        }
    }


}



