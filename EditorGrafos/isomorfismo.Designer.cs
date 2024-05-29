namespace EditorGrafos
{
    partial class isomorfismo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(isomorfismo));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.archivo = new System.Windows.Forms.ToolStrip();
            this.abrirArchivo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.InsertarNodo = new System.Windows.Forms.ToolStripButton();
            this.InsertarArista = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.MoverNodoB = new System.Windows.Forms.ToolStripButton();
            this.BorrarNodoB = new System.Windows.Forms.ToolStripButton();
            this.BorrarAristaB = new System.Windows.Forms.ToolStripButton();
            this.archivo.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // archivo
            // 
            this.archivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivo,
            this.toolStripButton1});
            this.archivo.Location = new System.Drawing.Point(0, 0);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(800, 25);
            this.archivo.TabIndex = 0;
            this.archivo.Text = "toolStrip1";
            this.archivo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.archivo_Click);
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.AccessibleName = "abrirGrafo";
            this.abrirArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("abrirArchivo.Image")));
            this.abrirArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirArchivo.Name = "abrirArchivo";
            this.abrirArchivo.Size = new System.Drawing.Size(23, 22);
            this.abrirArchivo.Text = "toolStripButton1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AccessibleName = "guardarGrafo";
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertarNodo,
            this.InsertarArista});
            this.toolStrip2.Location = new System.Drawing.Point(58, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(58, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Insertar_Click);
            // 
            // InsertarNodo
            // 
            this.InsertarNodo.AccessibleName = "Nodo";
            this.InsertarNodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertarNodo.Image = ((System.Drawing.Image)(resources.GetObject("InsertarNodo.Image")));
            this.InsertarNodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertarNodo.Name = "InsertarNodo";
            this.InsertarNodo.Size = new System.Drawing.Size(23, 22);
            this.InsertarNodo.Text = "Insertar Nodo";
            // 
            // InsertarArista
            // 
            this.InsertarArista.AccessibleName = "Arista";
            this.InsertarArista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertarArista.Image = ((System.Drawing.Image)(resources.GetObject("InsertarArista.Image")));
            this.InsertarArista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertarArista.Name = "InsertarArista";
            this.InsertarArista.Size = new System.Drawing.Size(23, 22);
            this.InsertarArista.Text = "Insertar Arista";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoverNodoB,
            this.BorrarNodoB,
            this.BorrarAristaB});
            this.toolStrip3.Location = new System.Drawing.Point(116, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(81, 25);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Acciones_Click);
            // 
            // MoverNodoB
            // 
            this.MoverNodoB.AccessibleName = "MoverNodo";
            this.MoverNodoB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoverNodoB.Image = ((System.Drawing.Image)(resources.GetObject("MoverNodoB.Image")));
            this.MoverNodoB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoverNodoB.Name = "MoverNodoB";
            this.MoverNodoB.Size = new System.Drawing.Size(23, 22);
            this.MoverNodoB.Text = "Mover Nodo";
            // 
            // BorrarNodoB
            // 
            this.BorrarNodoB.AccessibleName = "BorrarNodo";
            this.BorrarNodoB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorrarNodoB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarNodoB.Name = "BorrarNodoB";
            this.BorrarNodoB.Size = new System.Drawing.Size(23, 22);
            this.BorrarNodoB.Text = "Borrar Nodo";
            // 
            // BorrarAristaB
            // 
            this.BorrarAristaB.AccessibleName = "BorrarArista";
            this.BorrarAristaB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorrarAristaB.Image = ((System.Drawing.Image)(resources.GetObject("BorrarAristaB.Image")));
            this.BorrarAristaB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarAristaB.Name = "BorrarAristaB";
            this.BorrarAristaB.Size = new System.Drawing.Size(23, 22);
            this.BorrarAristaB.Text = "toolStripButton1";
            this.BorrarAristaB.ToolTipText = "BorrarArista";
            // 
            // isomorfismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.archivo);
            this.Name = "isomorfismo";
            this.Text = "isomorfismo";
            this.Load += new System.EventHandler(this.isomorfismo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.isomorfismo_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.isomorfismo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.isomorfismo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.isomorfismo_MouseUp);
            this.archivo.ResumeLayout(false);
            this.archivo.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip archivo;
        private System.Windows.Forms.ToolStripButton abrirArchivo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton InsertarNodo;
        private System.Windows.Forms.ToolStripButton InsertarArista;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton MoverNodoB;
        private System.Windows.Forms.ToolStripButton BorrarNodoB;
        private System.Windows.Forms.ToolStripButton BorrarAristaB;
    }
}