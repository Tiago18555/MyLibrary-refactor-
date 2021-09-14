
namespace My_Library
{
    partial class F_Configs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_funcBoundary = new System.Windows.Forms.TextBox();
            this.tb_profBoundary = new System.Windows.Forms.TextBox();
            this.tb_allowence = new System.Windows.Forms.TextBox();
            this.cb_theme = new System.Windows.Forms.ComboBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_default = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.mtb_value = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONFIGURAÇÕES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limite de empréstimos (FUNCIONÁRIO)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Limite de empréstimos (PROFESSOR)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor da multa diária";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Período de tolerância (ALUNOS)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "TEMA: ";
            // 
            // tb_funcBoundary
            // 
            this.tb_funcBoundary.Location = new System.Drawing.Point(57, 140);
            this.tb_funcBoundary.Name = "tb_funcBoundary";
            this.tb_funcBoundary.Size = new System.Drawing.Size(202, 23);
            this.tb_funcBoundary.TabIndex = 6;
            this.tb_funcBoundary.TextChanged += new System.EventHandler(this.tb_funcBoundary_TextChanged);
            this.tb_funcBoundary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_funcBoundary_KeyPress);
            // 
            // tb_profBoundary
            // 
            this.tb_profBoundary.Location = new System.Drawing.Point(57, 199);
            this.tb_profBoundary.Name = "tb_profBoundary";
            this.tb_profBoundary.Size = new System.Drawing.Size(202, 23);
            this.tb_profBoundary.TabIndex = 7;
            this.tb_profBoundary.TextChanged += new System.EventHandler(this.tb_profBoundary_TextChanged);
            this.tb_profBoundary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_profBoundary_KeyPress);
            // 
            // tb_allowence
            // 
            this.tb_allowence.Location = new System.Drawing.Point(57, 336);
            this.tb_allowence.Name = "tb_allowence";
            this.tb_allowence.Size = new System.Drawing.Size(202, 23);
            this.tb_allowence.TabIndex = 9;
            this.tb_allowence.TextChanged += new System.EventHandler(this.tb_allowence_TextChanged);
            this.tb_allowence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_allowence_KeyPress);
            // 
            // cb_theme
            // 
            this.cb_theme.FormattingEnabled = true;
            this.cb_theme.Location = new System.Drawing.Point(57, 406);
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.Size = new System.Drawing.Size(202, 23);
            this.cb_theme.TabIndex = 10;
            // 
            // btn_apply
            // 
            this.btn_apply.Enabled = false;
            this.btn_apply.Location = new System.Drawing.Point(231, 480);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 11;
            this.btn_apply.Text = "Aplicar";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_default
            // 
            this.btn_default.Location = new System.Drawing.Point(128, 480);
            this.btn_default.Name = "btn_default";
            this.btn_default.Size = new System.Drawing.Size(75, 23);
            this.btn_default.TabIndex = 11;
            this.btn_default.Text = "Padrão";
            this.btn_default.UseVisualStyleBackColor = true;
            this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(26, 480);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // mtb_value
            // 
            this.mtb_value.Location = new System.Drawing.Point(57, 274);
            this.mtb_value.Mask = "$ 99,99";
            this.mtb_value.Name = "mtb_value";
            this.mtb_value.Size = new System.Drawing.Size(202, 23);
            this.mtb_value.TabIndex = 12;
            this.mtb_value.TextChanged += new System.EventHandler(this.mtb_value_TextChanged);
            // 
            // F_Configs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 515);
            this.Controls.Add(this.mtb_value);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_default);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cb_theme);
            this.Controls.Add(this.tb_allowence);
            this.Controls.Add(this.tb_profBoundary);
            this.Controls.Add(this.tb_funcBoundary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_Configs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Configs";
            this.Load += new System.EventHandler(this.F_Configs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_funcBoundary;
        private System.Windows.Forms.TextBox tb_profBoundary;
        private System.Windows.Forms.TextBox tb_allowence;
        private System.Windows.Forms.ComboBox cb_theme;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_default;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.MaskedTextBox mtb_value;
    }
}