namespace sanxiang
{
    partial class FormStructXianlu
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
            this.cob_suo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xianlu_cancel = new System.Windows.Forms.Button();
            this.btn_xianlu_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_xianlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cob_zhan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cob_suo
            // 
            this.cob_suo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_suo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cob_suo.FormattingEnabled = true;
            this.cob_suo.ItemHeight = 16;
            this.cob_suo.Location = new System.Drawing.Point(106, 45);
            this.cob_suo.Margin = new System.Windows.Forms.Padding(4);
            this.cob_suo.Name = "cob_suo";
            this.cob_suo.Size = new System.Drawing.Size(270, 24);
            this.cob_suo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label2.Location = new System.Drawing.Point(43, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "供电所";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 25;
            // 
            // btn_xianlu_cancel
            // 
            this.btn_xianlu_cancel.Location = new System.Drawing.Point(248, 193);
            this.btn_xianlu_cancel.Name = "btn_xianlu_cancel";
            this.btn_xianlu_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_xianlu_cancel.TabIndex = 24;
            this.btn_xianlu_cancel.Text = "取消";
            this.btn_xianlu_cancel.UseVisualStyleBackColor = true;
            this.btn_xianlu_cancel.Click += new System.EventHandler(this.btn_xianlu_cancel_Click);
            // 
            // btn_xianlu_add
            // 
            this.btn_xianlu_add.Location = new System.Drawing.Point(96, 194);
            this.btn_xianlu_add.Name = "btn_xianlu_add";
            this.btn_xianlu_add.Size = new System.Drawing.Size(75, 23);
            this.btn_xianlu_add.TabIndex = 23;
            this.btn_xianlu_add.Text = "添加";
            this.btn_xianlu_add.UseVisualStyleBackColor = true;
            this.btn_xianlu_add.Click += new System.EventHandler(this.btn_xianlu_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label5.Location = new System.Drawing.Point(44, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "供电站";
            // 
            // txt_xianlu
            // 
            this.txt_xianlu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_xianlu.Location = new System.Drawing.Point(106, 138);
            this.txt_xianlu.Multiline = true;
            this.txt_xianlu.Name = "txt_xianlu";
            this.txt_xianlu.Size = new System.Drawing.Size(270, 25);
            this.txt_xianlu.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label3.Location = new System.Drawing.Point(45, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "线路";
            // 
            // cob_zhan
            // 
            this.cob_zhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_zhan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cob_zhan.FormattingEnabled = true;
            this.cob_zhan.ItemHeight = 16;
            this.cob_zhan.Location = new System.Drawing.Point(106, 91);
            this.cob_zhan.Margin = new System.Windows.Forms.Padding(4);
            this.cob_zhan.Name = "cob_zhan";
            this.cob_zhan.Size = new System.Drawing.Size(270, 24);
            this.cob_zhan.TabIndex = 30;
            // 
            // FormStructXianlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 245);
            this.Controls.Add(this.cob_zhan);
            this.Controls.Add(this.txt_xianlu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cob_suo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xianlu_cancel);
            this.Controls.Add(this.btn_xianlu_add);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStructXianlu";
            this.Text = "添加节点";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cob_suo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xianlu_cancel;
        private System.Windows.Forms.Button btn_xianlu_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_xianlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cob_zhan;
    }
}