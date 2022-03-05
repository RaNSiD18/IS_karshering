
namespace IS_SERYAKOV
{
    partial class LoginForm
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
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.bu_login = new System.Windows.Forms.Button();
            this.bt_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(136, 60);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(163, 20);
            this.tb_login.TabIndex = 0;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(136, 101);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(163, 20);
            this.tb_pass.TabIndex = 1;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(59, 56);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(57, 23);
            this.lb_login.TabIndex = 2;
            this.lb_login.Text = "Логин";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(59, 97);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(69, 23);
            this.lb_pass.TabIndex = 3;
            this.lb_pass.Text = "Пароль";
            // 
            // bu_login
            // 
            this.bu_login.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_login.Location = new System.Drawing.Point(126, 144);
            this.bu_login.Name = "bu_login";
            this.bu_login.Size = new System.Drawing.Size(131, 40);
            this.bu_login.TabIndex = 4;
            this.bu_login.Text = "Войти";
            this.bu_login.UseVisualStyleBackColor = true;
            this.bu_login.Click += new System.EventHandler(this.bu_login_Click);
            // 
            // bt_reg
            // 
            this.bt_reg.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reg.Location = new System.Drawing.Point(235, 12);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(128, 31);
            this.bt_reg.TabIndex = 5;
            this.bt_reg.Text = "Регистрация";
            this.bt_reg.UseVisualStyleBackColor = true;
            this.bt_reg.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 196);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.bu_login);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Button bu_login;
        private System.Windows.Forms.Button bt_reg;
    }
}

