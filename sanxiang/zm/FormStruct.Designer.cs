namespace sanxiang
{
    partial class FormStruct
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
            this.cob_zhan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cob_suo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cob_xianlu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_taiqu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cob_zhan
            // 
            this.cob_zhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_zhan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cob_zhan.FormattingEnabled = true;
            this.cob_zhan.ItemHeight = 16;
            this.cob_zhan.Location = new System.Drawing.Point(116, 75);
            this.cob_zhan.Margin = new System.Windows.Forms.Padding(4);
            this.cob_zhan.Name = "cob_zhan";
            this.cob_zhan.Size = new System.Drawing.Size(269, 24);
            this.cob_zhan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "供电站";
            // 
            // cob_suo
            // 
            this.cob_suo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_suo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cob_suo.FormattingEnabled = true;
            this.cob_suo.ItemHeight = 16;
            this.cob_suo.Location = new System.Drawing.Point(115, 30);
            this.cob_suo.Margin = new System.Windows.Forms.Padding(4);
            this.cob_suo.Name = "cob_suo";
            this.cob_suo.Size = new System.Drawing.Size(269, 24);
            this.cob_suo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "供电所";
            // 
            // cob_xianlu
            // 
            this.cob_xianlu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_xianlu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cob_xianlu.FormattingEnabled = true;
            this.cob_xianlu.ItemHeight = 16;
            this.cob_xianlu.Location = new System.Drawing.Point(117, 118);
            this.cob_xianlu.Margin = new System.Windows.Forms.Padding(4);
            this.cob_xianlu.Name = "cob_xianlu";
            this.cob_xianlu.Size = new System.Drawing.Size(269, 24);
            this.cob_xianlu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "线路";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "台区";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(98, 219);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(250, 218);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_taiqu
            // 
            this.txt_taiqu.Location = new System.Drawing.Point(117, 157);
            this.txt_taiqu.Name = "txt_taiqu";
            this.txt_taiqu.Size = new System.Drawing.Size(267, 25);
            this.txt_taiqu.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_taiqu);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cob_xianlu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cob_suo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cob_zhan);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStruct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加节点";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cob_zhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cob_suo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cob_xianlu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_taiqu;
        private System.Windows.Forms.Button button1;

    }
}