namespace sanxiang
{
    partial class FormStructZhan
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_zhan_name = new System.Windows.Forms.TextBox();
            this.btn_zhan_cancel = new System.Windows.Forms.Button();
            this.btn_zhan_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cob_suo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label5.Location = new System.Drawing.Point(46, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "供电站";
            // 
            // txt_zhan_name
            // 
            this.txt_zhan_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_zhan_name.Location = new System.Drawing.Point(108, 71);
            this.txt_zhan_name.Multiline = true;
            this.txt_zhan_name.Name = "txt_zhan_name";
            this.txt_zhan_name.Size = new System.Drawing.Size(270, 25);
            this.txt_zhan_name.TabIndex = 11;
            // 
            // btn_zhan_cancel
            // 
            this.btn_zhan_cancel.Location = new System.Drawing.Point(250, 128);
            this.btn_zhan_cancel.Name = "btn_zhan_cancel";
            this.btn_zhan_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_zhan_cancel.TabIndex = 17;
            this.btn_zhan_cancel.Text = "取消";
            this.btn_zhan_cancel.UseVisualStyleBackColor = true;
            this.btn_zhan_cancel.Click += new System.EventHandler(this.btn_zhan_cancel_Click);
            // 
            // btn_zhan_add
            // 
            this.btn_zhan_add.Location = new System.Drawing.Point(98, 129);
            this.btn_zhan_add.Name = "btn_zhan_add";
            this.btn_zhan_add.Size = new System.Drawing.Size(75, 23);
            this.btn_zhan_add.TabIndex = 16;
            this.btn_zhan_add.Text = "添加";
            this.btn_zhan_add.UseVisualStyleBackColor = true;
            this.btn_zhan_add.Click += new System.EventHandler(this.btn_zhan_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 18;
            // 
            // cob_suo
            // 
            this.cob_suo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_suo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cob_suo.FormattingEnabled = true;
            this.cob_suo.ItemHeight = 16;
            this.cob_suo.Location = new System.Drawing.Point(108, 30);
            this.cob_suo.Margin = new System.Windows.Forms.Padding(4);
            this.cob_suo.Name = "cob_suo";
            this.cob_suo.Size = new System.Drawing.Size(270, 24);
            this.cob_suo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label2.Location = new System.Drawing.Point(45, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "供电所";
            // 
            // FormStructZhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 179);
            this.Controls.Add(this.cob_suo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_zhan_cancel);
            this.Controls.Add(this.btn_zhan_add);
            this.Controls.Add(this.txt_zhan_name);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStructZhan";
            this.Text = "添加节点";
            this.Load += new System.EventHandler(this.FormStructZhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_zhan_name;
        private System.Windows.Forms.Button btn_zhan_cancel;
        private System.Windows.Forms.Button btn_zhan_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cob_suo;
        private System.Windows.Forms.Label label2;
    }
}