namespace Editor_grafo
{
    partial class Form_Editor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lb_config = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.check_nodoDir = new System.Windows.Forms.CheckBox();
            this.tb_pesoArista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_datos = new System.Windows.Forms.RichTextBox();
            this.btn_EliminarNodo = new System.Windows.Forms.Button();
            this.btn_matrizAdy = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Abrir,
            this.btn_Nuevo,
            this.btn_Guardar});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.abrirToolStripMenuItem.Text = "Archivo";
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(116, 22);
            this.btn_Abrir.Text = "Abrir";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(116, 22);
            this.btn_Nuevo.Text = "Nuevo";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(116, 22);
            this.btn_Guardar.Text = "Guardar";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.nuevoToolStripMenuItem.Text = "Edición";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.guardarToolStripMenuItem.Text = "Formato";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_config
            // 
            this.lb_config.BackColor = System.Drawing.SystemColors.Menu;
            this.lb_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_config.FormattingEnabled = true;
            this.lb_config.ItemHeight = 16;
            this.lb_config.Location = new System.Drawing.Point(7, 67);
            this.lb_config.Name = "lb_config";
            this.lb_config.Size = new System.Drawing.Size(140, 68);
            this.lb_config.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos del Nodo";
            // 
            // check_nodoDir
            // 
            this.check_nodoDir.AutoSize = true;
            this.check_nodoDir.Location = new System.Drawing.Point(7, 152);
            this.check_nodoDir.Name = "check_nodoDir";
            this.check_nodoDir.Size = new System.Drawing.Size(90, 17);
            this.check_nodoDir.TabIndex = 3;
            this.check_nodoDir.Text = "Nodo Dirigido";
            this.check_nodoDir.UseVisualStyleBackColor = true;
            // 
            // tb_pesoArista
            // 
            this.tb_pesoArista.Location = new System.Drawing.Point(6, 174);
            this.tb_pesoArista.Name = "tb_pesoArista";
            this.tb_pesoArista.Size = new System.Drawing.Size(25, 20);
            this.tb_pesoArista.TabIndex = 5;
            this.tb_pesoArista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pesoArista_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peso Arista";
            // 
            // rtb_datos
            // 
            this.rtb_datos.Location = new System.Drawing.Point(7, 260);
            this.rtb_datos.Name = "rtb_datos";
            this.rtb_datos.Size = new System.Drawing.Size(258, 247);
            this.rtb_datos.TabIndex = 7;
            this.rtb_datos.Text = "";
            // 
            // btn_EliminarNodo
            // 
            this.btn_EliminarNodo.BackColor = System.Drawing.Color.Maroon;
            this.btn_EliminarNodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EliminarNodo.Location = new System.Drawing.Point(36, 202);
            this.btn_EliminarNodo.Name = "btn_EliminarNodo";
            this.btn_EliminarNodo.Size = new System.Drawing.Size(91, 23);
            this.btn_EliminarNodo.TabIndex = 8;
            this.btn_EliminarNodo.Text = "Eliminar Nodo";
            this.btn_EliminarNodo.UseVisualStyleBackColor = false;
            this.btn_EliminarNodo.Click += new System.EventHandler(this.btn_EliminarNodo_Click);
            // 
            // btn_matrizAdy
            // 
            this.btn_matrizAdy.Location = new System.Drawing.Point(6, 231);
            this.btn_matrizAdy.Name = "btn_matrizAdy";
            this.btn_matrizAdy.Size = new System.Drawing.Size(161, 23);
            this.btn_matrizAdy.TabIndex = 9;
            this.btn_matrizAdy.Text = "Generar matriz de adyacencia";
            this.btn_matrizAdy.UseVisualStyleBackColor = true;
            this.btn_matrizAdy.Click += new System.EventHandler(this.btn_matrizAdy_Click);
            // 
            // Form_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 551);
            this.Controls.Add(this.btn_matrizAdy);
            this.Controls.Add(this.btn_EliminarNodo);
            this.Controls.Add(this.rtb_datos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pesoArista);
            this.Controls.Add(this.check_nodoDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_config);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Editor";
            this.Text = "Editor de Grafos";
            this.Load += new System.EventHandler(this.Form_Editor_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Editor_Paint);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form_Editor_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Editor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Editor_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Editor_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_Abrir;
        private System.Windows.Forms.ToolStripMenuItem btn_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem btn_Guardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ListBox lb_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_nodoDir;
        private System.Windows.Forms.TextBox tb_pesoArista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_datos;
        private System.Windows.Forms.Button btn_EliminarNodo;
        private System.Windows.Forms.Button btn_matrizAdy;
    }
}

