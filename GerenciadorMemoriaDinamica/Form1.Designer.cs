namespace GerenciadorMemoriaDinamica
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.l_bitmap = new System.Windows.Forms.Label();
            this.rb_best_fit = new System.Windows.Forms.RadioButton();
            this.rb_worst_fit = new System.Windows.Forms.RadioButton();
            this.rb_swapping = new System.Windows.Forms.RadioButton();
            this.rb_first_fit = new System.Windows.Forms.RadioButton();
            this.l_comandos = new System.Windows.Forms.Label();
            this.p_armazenamento = new System.Windows.Forms.ProgressBar();
            this.l_armazenamento = new System.Windows.Forms.Label();
            this.l_memoria = new System.Windows.Forms.Label();
            this.p_memoria = new System.Windows.Forms.ProgressBar();
            this.l_metodos = new System.Windows.Forms.Label();
            this.dg_processos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_processos = new System.Windows.Forms.Label();
            this.t_comandos = new System.Windows.Forms.TextBox();
            this.p_memo1 = new System.Windows.Forms.ProgressBar();
            this.p_memo2 = new System.Windows.Forms.ProgressBar();
            this.p_memo3 = new System.Windows.Forms.ProgressBar();
            this.l_memo1 = new System.Windows.Forms.Label();
            this.l_memo2 = new System.Windows.Forms.Label();
            this.l_memo3 = new System.Windows.Forms.Label();
            this.l_memo1Aloc = new System.Windows.Forms.Label();
            this.l_memo2Aloc = new System.Windows.Forms.Label();
            this.l_memo3Aloc = new System.Windows.Forms.Label();
            this.l_memoAloc = new System.Windows.Forms.Label();
            this.l_storageAloc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_processos)).BeginInit();
            this.SuspendLayout();
            // 
            // l_bitmap
            // 
            resources.ApplyResources(this.l_bitmap, "l_bitmap");
            this.l_bitmap.Name = "l_bitmap";
            // 
            // rb_best_fit
            // 
            resources.ApplyResources(this.rb_best_fit, "rb_best_fit");
            this.rb_best_fit.Name = "rb_best_fit";
            this.rb_best_fit.TabStop = true;
            this.rb_best_fit.UseVisualStyleBackColor = true;
            // 
            // rb_worst_fit
            // 
            resources.ApplyResources(this.rb_worst_fit, "rb_worst_fit");
            this.rb_worst_fit.Name = "rb_worst_fit";
            this.rb_worst_fit.TabStop = true;
            this.rb_worst_fit.UseVisualStyleBackColor = true;
            // 
            // rb_swapping
            // 
            resources.ApplyResources(this.rb_swapping, "rb_swapping");
            this.rb_swapping.Name = "rb_swapping";
            this.rb_swapping.TabStop = true;
            this.rb_swapping.UseVisualStyleBackColor = true;
            // 
            // rb_first_fit
            // 
            resources.ApplyResources(this.rb_first_fit, "rb_first_fit");
            this.rb_first_fit.Name = "rb_first_fit";
            this.rb_first_fit.TabStop = true;
            this.rb_first_fit.UseVisualStyleBackColor = true;
            // 
            // l_comandos
            // 
            resources.ApplyResources(this.l_comandos, "l_comandos");
            this.l_comandos.Name = "l_comandos";
            // 
            // p_armazenamento
            // 
            resources.ApplyResources(this.p_armazenamento, "p_armazenamento");
            this.p_armazenamento.Name = "p_armazenamento";
            // 
            // l_armazenamento
            // 
            resources.ApplyResources(this.l_armazenamento, "l_armazenamento");
            this.l_armazenamento.Name = "l_armazenamento";
            // 
            // l_memoria
            // 
            resources.ApplyResources(this.l_memoria, "l_memoria");
            this.l_memoria.Name = "l_memoria";
            // 
            // p_memoria
            // 
            resources.ApplyResources(this.p_memoria, "p_memoria");
            this.p_memoria.Maximum = 48;
            this.p_memoria.Name = "p_memoria";
            this.p_memoria.Step = 1;
            // 
            // l_metodos
            // 
            resources.ApplyResources(this.l_metodos, "l_metodos");
            this.l_metodos.Name = "l_metodos";
            // 
            // dg_processos
            // 
            this.dg_processos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg_processos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_processos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_processos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_processos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column6});
            this.dg_processos.GridColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.dg_processos, "dg_processos");
            this.dg_processos.Name = "dg_processos";
            this.dg_processos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_processos.RowHeadersVisible = false;
            this.dg_processos.ShowEditingIcon = false;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // l_processos
            // 
            resources.ApplyResources(this.l_processos, "l_processos");
            this.l_processos.Name = "l_processos";
            // 
            // t_comandos
            // 
            resources.ApplyResources(this.t_comandos, "t_comandos");
            this.t_comandos.Name = "t_comandos";
            this.t_comandos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_comandos_KeyDown);
            // 
            // p_memo1
            // 
            resources.ApplyResources(this.p_memo1, "p_memo1");
            this.p_memo1.Maximum = 8;
            this.p_memo1.Name = "p_memo1";
            this.p_memo1.Step = 1;
            this.p_memo1.Tag = "";
            // 
            // p_memo2
            // 
            resources.ApplyResources(this.p_memo2, "p_memo2");
            this.p_memo2.Maximum = 16;
            this.p_memo2.Name = "p_memo2";
            this.p_memo2.Step = 1;
            // 
            // p_memo3
            // 
            resources.ApplyResources(this.p_memo3, "p_memo3");
            this.p_memo3.Maximum = 24;
            this.p_memo3.Name = "p_memo3";
            this.p_memo3.Step = 1;
            // 
            // l_memo1
            // 
            resources.ApplyResources(this.l_memo1, "l_memo1");
            this.l_memo1.Name = "l_memo1";
            // 
            // l_memo2
            // 
            resources.ApplyResources(this.l_memo2, "l_memo2");
            this.l_memo2.Name = "l_memo2";
            // 
            // l_memo3
            // 
            resources.ApplyResources(this.l_memo3, "l_memo3");
            this.l_memo3.Name = "l_memo3";
            // 
            // l_memo1Aloc
            // 
            resources.ApplyResources(this.l_memo1Aloc, "l_memo1Aloc");
            this.l_memo1Aloc.Name = "l_memo1Aloc";
            // 
            // l_memo2Aloc
            // 
            resources.ApplyResources(this.l_memo2Aloc, "l_memo2Aloc");
            this.l_memo2Aloc.Name = "l_memo2Aloc";
            // 
            // l_memo3Aloc
            // 
            resources.ApplyResources(this.l_memo3Aloc, "l_memo3Aloc");
            this.l_memo3Aloc.Name = "l_memo3Aloc";
            // 
            // l_memoAloc
            // 
            resources.ApplyResources(this.l_memoAloc, "l_memoAloc");
            this.l_memoAloc.Name = "l_memoAloc";
            // 
            // l_storageAloc
            // 
            resources.ApplyResources(this.l_storageAloc, "l_storageAloc");
            this.l_storageAloc.Name = "l_storageAloc";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_storageAloc);
            this.Controls.Add(this.l_memoAloc);
            this.Controls.Add(this.l_memo3Aloc);
            this.Controls.Add(this.l_memo2Aloc);
            this.Controls.Add(this.l_memo1Aloc);
            this.Controls.Add(this.l_memo3);
            this.Controls.Add(this.l_memo2);
            this.Controls.Add(this.l_memo1);
            this.Controls.Add(this.p_memo3);
            this.Controls.Add(this.p_memo2);
            this.Controls.Add(this.p_memo1);
            this.Controls.Add(this.t_comandos);
            this.Controls.Add(this.l_processos);
            this.Controls.Add(this.dg_processos);
            this.Controls.Add(this.l_metodos);
            this.Controls.Add(this.l_memoria);
            this.Controls.Add(this.p_memoria);
            this.Controls.Add(this.l_armazenamento);
            this.Controls.Add(this.p_armazenamento);
            this.Controls.Add(this.l_comandos);
            this.Controls.Add(this.rb_swapping);
            this.Controls.Add(this.rb_first_fit);
            this.Controls.Add(this.rb_worst_fit);
            this.Controls.Add(this.rb_best_fit);
            this.Controls.Add(this.l_bitmap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dg_processos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_bitmap;
        private System.Windows.Forms.RadioButton rb_best_fit;
        private System.Windows.Forms.RadioButton rb_worst_fit;
        private System.Windows.Forms.RadioButton rb_swapping;
        private System.Windows.Forms.RadioButton rb_first_fit;
        private System.Windows.Forms.Label l_comandos;
        private System.Windows.Forms.ProgressBar p_armazenamento;
        private System.Windows.Forms.Label l_armazenamento;
        private System.Windows.Forms.Label l_memoria;
        private System.Windows.Forms.ProgressBar p_memoria;
        private System.Windows.Forms.Label l_metodos;
        private System.Windows.Forms.DataGridView dg_processos;
        private System.Windows.Forms.Label l_processos;
        private System.Windows.Forms.TextBox t_comandos;
        private System.Windows.Forms.ProgressBar p_memo1;
        private System.Windows.Forms.ProgressBar p_memo2;
        private System.Windows.Forms.ProgressBar p_memo3;
        private System.Windows.Forms.Label l_memo1;
        private System.Windows.Forms.Label l_memo2;
        private System.Windows.Forms.Label l_memo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label l_memo1Aloc;
        private System.Windows.Forms.Label l_memo2Aloc;
        private System.Windows.Forms.Label l_memo3Aloc;
        private System.Windows.Forms.Label l_memoAloc;
        private System.Windows.Forms.Label l_storageAloc;
        private System.Windows.Forms.Button button1;
    }
}

