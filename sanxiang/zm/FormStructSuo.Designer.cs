namespace sanxiang
{
    partial class FormStructSuo
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
            this.btn_suo_cancel = new System.Windows.Forms.Button();
            this.btn_suo_add = new System.Windows.Forms.Button();
            this.txt_suo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_suo_cancel
            // 
            this.btn_suo_cancel.Location = new System.Drawing.Point(249, 113);
            this.btn_suo_cancel.Name = "btn_suo_cancel";
            this.btn_suo_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_suo_cancel.TabIndex = 21;
            this.btn_suo_cancel.Text = "取消";
            this.btn_suo_cancel.UseVisualStyleBackColor = true;
            this.btn_suo_cancel.Click += new System.EventHandler(this.btn_suo_cancel_Click);
            // 
            // btn_suo_add
            // 
            this.btn_suo_add.Location = new System.Drawing.Point(97, 114);
            this.btn_suo_add.Name = "btn_suo_add";
            this.btn_suo_add.Size = new System.Drawing.Size(75, 23);
            this.btn_suo_add.TabIndex = 20;
            this.btn_suo_add.Text = "添加";
            this.btn_suo_add.UseVisualStyleBackColor = true;
            this.btn_suo_add.Click += new System.EventHandler(this.btn_suo_add_Click);
            // 
            // txt_suo
            // 
            this.txt_suo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_suo.Location = new System.Drawing.Point(110, 48);
            this.txt_suo.Multiline = true;
            this.txt_suo.Name = "txt_suo";
            this.txt_suo.Size = new System.Drawing.Size(270, 25);
            this.txt_suo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label5.Location = new System.Drawing.Point(52, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "供电所";
            // 
            // FormStructSuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 179);
            this.Controls.Add(this.btn_suo_cancel);
            this.Controls.Add(this.btn_suo_add);
            this.Controls.Add(this.txt_suo);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStructSuo";
            this.Text = "添加节点";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_suo_cancel;
        private System.Windows.Forms.Button btn_suo_add;
        private System.Windows.Forms.TextBox txt_suo;
        private System.Windows.Forms.Label label5;
    }
}