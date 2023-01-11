namespace Assignment11_AlekseiVotintsev
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addinfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.ListBox();
            this.namePet = new System.Windows.Forms.TextBox();
            this.typePet = new System.Windows.Forms.TextBox();
            this.agePet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infocheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addinfo
            // 
            this.addinfo.Location = new System.Drawing.Point(317, 88);
            this.addinfo.Name = "addinfo";
            this.addinfo.Size = new System.Drawing.Size(104, 95);
            this.addinfo.TabIndex = 0;
            this.addinfo.Text = "Add info";
            this.addinfo.UseVisualStyleBackColor = true;
            this.addinfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // info
            // 
            this.info.FormattingEnabled = true;
            this.info.Location = new System.Drawing.Point(40, 274);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(156, 95);
            this.info.TabIndex = 2;
            // 
            // namePet
            // 
            this.namePet.Location = new System.Drawing.Point(118, 68);
            this.namePet.Name = "namePet";
            this.namePet.Size = new System.Drawing.Size(100, 20);
            this.namePet.TabIndex = 3;
            // 
            // typePet
            // 
            this.typePet.Location = new System.Drawing.Point(118, 122);
            this.typePet.Name = "typePet";
            this.typePet.Size = new System.Drawing.Size(100, 20);
            this.typePet.TabIndex = 4;
            // 
            // agePet
            // 
            this.agePet.Location = new System.Drawing.Point(118, 179);
            this.agePet.Name = "agePet";
            this.agePet.Size = new System.Drawing.Size(100, 20);
            this.agePet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // infocheck
            // 
            this.infocheck.Location = new System.Drawing.Point(271, 258);
            this.infocheck.Name = "infocheck";
            this.infocheck.Size = new System.Drawing.Size(124, 111);
            this.infocheck.TabIndex = 8;
            this.infocheck.Text = "Check info";
            this.infocheck.UseVisualStyleBackColor = true;
            this.infocheck.Click += new System.EventHandler(this.infocheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 381);
            this.Controls.Add(this.infocheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.agePet);
            this.Controls.Add(this.typePet);
            this.Controls.Add(this.namePet);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox info;
        private System.Windows.Forms.TextBox namePet;
        private System.Windows.Forms.TextBox typePet;
        private System.Windows.Forms.TextBox agePet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button infocheck;
    }
}

