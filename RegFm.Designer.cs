
namespace IS_SERYAKOV
{
    partial class RegFm
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
            this.bu_Reg = new System.Windows.Forms.Button();
            this.lb_regPass = new System.Windows.Forms.Label();
            this.lb_regLogin = new System.Windows.Forms.Label();
            this.tb_regLogin = new System.Windows.Forms.TextBox();
            this.tb_regLogDouble = new System.Windows.Forms.TextBox();
            this.tb_regPass = new System.Windows.Forms.TextBox();
            this.tb_regPassDouble = new System.Windows.Forms.TextBox();
            this.bt_backLoginFm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bu_Reg
            // 
            this.bu_Reg.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_Reg.Location = new System.Drawing.Point(189, 95);
            this.bu_Reg.Name = "bu_Reg";
            this.bu_Reg.Size = new System.Drawing.Size(209, 35);
            this.bu_Reg.TabIndex = 9;
            this.bu_Reg.Text = "Зарегистрироваться";
            this.bu_Reg.UseVisualStyleBackColor = true;
            this.bu_Reg.Click += new System.EventHandler(this.bu_Reg_Click);
            // 
            // lb_regPass
            // 
            this.lb_regPass.AutoSize = true;
            this.lb_regPass.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_regPass.Location = new System.Drawing.Point(310, 46);
            this.lb_regPass.Name = "lb_regPass";
            this.lb_regPass.Size = new System.Drawing.Size(69, 23);
            this.lb_regPass.TabIndex = 8;
            this.lb_regPass.Text = "Пароль";
            // 
            // lb_regLogin
            // 
            this.lb_regLogin.AutoSize = true;
            this.lb_regLogin.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_regLogin.Location = new System.Drawing.Point(310, 20);
            this.lb_regLogin.Name = "lb_regLogin";
            this.lb_regLogin.Size = new System.Drawing.Size(57, 23);
            this.lb_regLogin.TabIndex = 7;
            this.lb_regLogin.Text = "Логин";
            // 
            // tb_regLogin
            // 
            this.tb_regLogin.Location = new System.Drawing.Point(391, 24);
            this.tb_regLogin.Name = "tb_regLogin";
            this.tb_regLogin.Size = new System.Drawing.Size(163, 20);
            this.tb_regLogin.TabIndex = 5;
            this.tb_regLogin.Enter += new System.EventHandler(this.tb_regLogin_Enter);
            this.tb_regLogin.Leave += new System.EventHandler(this.tb_regLogin_Leave);
            // 
            // tb_regLogDouble
            // 
            this.tb_regLogDouble.Location = new System.Drawing.Point(100, 24);
            this.tb_regLogDouble.Name = "tb_regLogDouble";
            this.tb_regLogDouble.Size = new System.Drawing.Size(163, 20);
            this.tb_regLogDouble.TabIndex = 10;
            this.tb_regLogDouble.Enter += new System.EventHandler(this.tb_regLogDouble_Enter);
            this.tb_regLogDouble.Leave += new System.EventHandler(this.tb_regLogDouble_Leave);
            // 
            // tb_regPass
            // 
            this.tb_regPass.Location = new System.Drawing.Point(391, 50);
            this.tb_regPass.Name = "tb_regPass";
            this.tb_regPass.Size = new System.Drawing.Size(163, 20);
            this.tb_regPass.TabIndex = 6;
            this.tb_regPass.Enter += new System.EventHandler(this.tb_regPass_Enter);
            this.tb_regPass.Leave += new System.EventHandler(this.tb_regPass_Leave);
            // 
            // tb_regPassDouble
            // 
            this.tb_regPassDouble.Location = new System.Drawing.Point(100, 50);
            this.tb_regPassDouble.Name = "tb_regPassDouble";
            this.tb_regPassDouble.Size = new System.Drawing.Size(163, 20);
            this.tb_regPassDouble.TabIndex = 11;
            this.tb_regPassDouble.Enter += new System.EventHandler(this.tb_regPassDouble_Enter);
            this.tb_regPassDouble.Leave += new System.EventHandler(this.tb_regPassDouble_Leave);
            // 
            // bt_backLoginFm
            // 
            this.bt_backLoginFm.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_backLoginFm.Location = new System.Drawing.Point(419, 147);
            this.bt_backLoginFm.Name = "bt_backLoginFm";
            this.bt_backLoginFm.Size = new System.Drawing.Size(170, 55);
            this.bt_backLoginFm.TabIndex = 12;
            this.bt_backLoginFm.Text = "Вернуться на окно авторизации";
            this.bt_backLoginFm.UseVisualStyleBackColor = true;
            this.bt_backLoginFm.Click += new System.EventHandler(this.bt_backLoginFm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамилия";
            // 
            // RegFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_backLoginFm);
            this.Controls.Add(this.tb_regPassDouble);
            this.Controls.Add(this.tb_regLogDouble);
            this.Controls.Add(this.bu_Reg);
            this.Controls.Add(this.lb_regPass);
            this.Controls.Add(this.lb_regLogin);
            this.Controls.Add(this.tb_regPass);
            this.Controls.Add(this.tb_regLogin);
            this.Name = "RegFm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bu_Reg;
        private System.Windows.Forms.Label lb_regPass;
        private System.Windows.Forms.Label lb_regLogin;
        private System.Windows.Forms.TextBox tb_regLogin;
        private System.Windows.Forms.TextBox tb_regLogDouble;
        private System.Windows.Forms.TextBox tb_regPass;
        private System.Windows.Forms.TextBox tb_regPassDouble;
        private System.Windows.Forms.Button bt_backLoginFm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}