namespace EditorGrafos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarGrafo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirGrafo = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarAristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arboles = new System.Windows.Forms.ToolStripMenuItem();
            this.primToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kruskalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warshallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminoMasCortoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floydToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoGrafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isomorfismoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fuerzaBrutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminosCircuitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caminoMasCortoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.floydToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kruskalT = new System.Windows.Forms.ToolStripMenuItem();
            this.primT = new System.Windows.Forms.ToolStripMenuItem();
            this.warshallT = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "grafo";
            this.saveFileDialog1.Filter = "\"Archivos Grafo|*.grafo\"";
            this.saveFileDialog1.Title = "Guardar Grafo";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "grafo";
            this.openFileDialog1.Filter = "\"Archivos Grafo|*.grafo\"";
            this.openFileDialog1.Title = "Abrir Grafo";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.insertarToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.arboles,
            this.caminoMasCortoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivo
            // 
            this.archivo.AccessibleName = "archivo";
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarGrafo,
            this.abrirGrafo});
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(60, 20);
            this.archivo.Text = "Archivo";
            this.archivo.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.archivo_Click);
            // 
            // guardarGrafo
            // 
            this.guardarGrafo.AccessibleName = "guardarGrafo";
            this.guardarGrafo.Name = "guardarGrafo";
            this.guardarGrafo.Size = new System.Drawing.Size(148, 22);
            this.guardarGrafo.Text = "Guardar Grafo";
            // 
            // abrirGrafo
            // 
            this.abrirGrafo.AccessibleName = "abrirGrafo";
            this.abrirGrafo.Name = "abrirGrafo";
            this.abrirGrafo.Size = new System.Drawing.Size(148, 22);
            this.abrirGrafo.Text = "Abrir Grafo";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarNodoToolStripMenuItem,
            this.insertarAristaToolStripMenuItem});
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.insertarToolStripMenuItem.Text = "Insertar";
            this.insertarToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Insertar_Click);
            // 
            // insertarNodoToolStripMenuItem
            // 
            this.insertarNodoToolStripMenuItem.AccessibleName = "Nodo";
            this.insertarNodoToolStripMenuItem.Name = "insertarNodoToolStripMenuItem";
            this.insertarNodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertarNodoToolStripMenuItem.Text = "Insertar Nodo";
            // 
            // insertarAristaToolStripMenuItem
            // 
            this.insertarAristaToolStripMenuItem.AccessibleName = "Arista";
            this.insertarAristaToolStripMenuItem.Name = "insertarAristaToolStripMenuItem";
            this.insertarAristaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertarAristaToolStripMenuItem.Text = "Insertar Arista";
            this.insertarAristaToolStripMenuItem.Click += new System.EventHandler(this.insertarAristaToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarNodoToolStripMenuItem});
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.borrarToolStripMenuItem.Text = "Borrar";
            // 
            // borrarNodoToolStripMenuItem
            // 
            this.borrarNodoToolStripMenuItem.Name = "borrarNodoToolStripMenuItem";
            this.borrarNodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarNodoToolStripMenuItem.Text = "Borrar Nodo";
            // 
            // arboles
            // 
            this.arboles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primToolStripMenuItem,
            this.kruskalToolStripMenuItem,
            this.warshallToolStripMenuItem});
            this.arboles.Name = "arboles";
            this.arboles.Size = new System.Drawing.Size(59, 20);
            this.arboles.Text = "Arboles";
            this.arboles.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.arboles_click);
            // 
            // primToolStripMenuItem
            // 
            this.primToolStripMenuItem.AccessibleName = "Prim";
            this.primToolStripMenuItem.Name = "primToolStripMenuItem";
            this.primToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.primToolStripMenuItem.Text = "Prim";
            // 
            // kruskalToolStripMenuItem
            // 
            this.kruskalToolStripMenuItem.AccessibleName = "Kruskal";
            this.kruskalToolStripMenuItem.Name = "kruskalToolStripMenuItem";
            this.kruskalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kruskalToolStripMenuItem.Text = "Kruskal";
            // 
            // warshallToolStripMenuItem
            // 
            this.warshallToolStripMenuItem.AccessibleName = "Warshall";
            this.warshallToolStripMenuItem.Name = "warshallToolStripMenuItem";
            this.warshallToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.warshallToolStripMenuItem.Text = "Warshall";
            // 
            // caminoMasCortoToolStripMenuItem
            // 
            this.caminoMasCortoToolStripMenuItem.AccessibleName = "camMasCorto";
            this.caminoMasCortoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dijkstraToolStripMenuItem,
            this.floydToolStripMenuItem});
            this.caminoMasCortoToolStripMenuItem.Name = "caminoMasCortoToolStripMenuItem";
            this.caminoMasCortoToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.caminoMasCortoToolStripMenuItem.Text = "Ruta mas corta";
            this.caminoMasCortoToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.caminoMasCortoToolStripMenuItem_DropDownItemClicked);
            // 
            // dijkstraToolStripMenuItem
            // 
            this.dijkstraToolStripMenuItem.AccessibleName = "D";
            this.dijkstraToolStripMenuItem.Name = "dijkstraToolStripMenuItem";
            this.dijkstraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dijkstraToolStripMenuItem.Text = "Dijkstra";
            this.dijkstraToolStripMenuItem.Click += new System.EventHandler(this.dijkstraToolStripMenuItem_Click);
            // 
            // floydToolStripMenuItem
            // 
            this.floydToolStripMenuItem.AccessibleName = "F";
            this.floydToolStripMenuItem.Name = "floydToolStripMenuItem";
            this.floydToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.floydToolStripMenuItem.Text = "Floyd";
            this.floydToolStripMenuItem.Click += new System.EventHandler(this.floydToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Insertar Peso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Peso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Dirigido";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Iniciar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Finalizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.borrarToolStripMenuItem1,
            this.moverToolStripMenuItem,
            this.informaciónToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.nuevoGrafoToolStripMenuItem,
            this.isomorfismoToolStripMenuItem2,
            this.caminosCircuitosToolStripMenuItem,
            this.caminoMasCortoToolStripMenuItem1,
            this.arbolesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 246);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aristaToolStripMenuItem,
            this.nodoToolStripMenuItem});
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            // 
            // aristaToolStripMenuItem
            // 
            this.aristaToolStripMenuItem.Name = "aristaToolStripMenuItem";
            this.aristaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.aristaToolStripMenuItem.Text = "Arista";
            this.aristaToolStripMenuItem.Click += new System.EventHandler(this.aristaToolStripMenuItem_Click);
            // 
            // nodoToolStripMenuItem
            // 
            this.nodoToolStripMenuItem.Name = "nodoToolStripMenuItem";
            this.nodoToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.nodoToolStripMenuItem.Text = "Nodo";
            this.nodoToolStripMenuItem.Click += new System.EventHandler(this.nodoToolStripMenuItem_Click);
            // 
            // moverToolStripMenuItem
            // 
            this.moverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticeToolStripMenuItem,
            this.grafoToolStripMenuItem});
            this.moverToolStripMenuItem.Name = "moverToolStripMenuItem";
            this.moverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moverToolStripMenuItem.Text = "Mover";
            // 
            // verticeToolStripMenuItem
            // 
            this.verticeToolStripMenuItem.Name = "verticeToolStripMenuItem";
            this.verticeToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.verticeToolStripMenuItem.Text = "Vertice";
            this.verticeToolStripMenuItem.Click += new System.EventHandler(this.verticeToolStripMenuItem_Click);
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.grafoToolStripMenuItem.Text = "Grafo";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem,
            this.gradoToolStripMenuItem,
            this.contenidoToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // gradoToolStripMenuItem
            // 
            this.gradoToolStripMenuItem.Name = "gradoToolStripMenuItem";
            this.gradoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.gradoToolStripMenuItem.Text = "Grado";
            this.gradoToolStripMenuItem.Click += new System.EventHandler(this.gradoToolStripMenuItem_Click);
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.contenidoToolStripMenuItem.Text = "Contenido";
            this.contenidoToolStripMenuItem.Click += new System.EventHandler(this.contenidoToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formatoToolStripMenuItem.Text = "Formato";
            this.formatoToolStripMenuItem.Click += new System.EventHandler(this.formatoToolStripMenuItem_Click);
            // 
            // nuevoGrafoToolStripMenuItem
            // 
            this.nuevoGrafoToolStripMenuItem.Name = "nuevoGrafoToolStripMenuItem";
            this.nuevoGrafoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoGrafoToolStripMenuItem.Text = "Nuevo Grafo";
            this.nuevoGrafoToolStripMenuItem.Click += new System.EventHandler(this.nuevoGrafoToolStripMenuItem_Click);
            // 
            // isomorfismoToolStripMenuItem2
            // 
            this.isomorfismoToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuerzaBrutaToolStripMenuItem,
            this.pxToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.isomorfismoToolStripMenuItem2.Name = "isomorfismoToolStripMenuItem2";
            this.isomorfismoToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.isomorfismoToolStripMenuItem2.Text = "Isomorfismo";
            // 
            // fuerzaBrutaToolStripMenuItem
            // 
            this.fuerzaBrutaToolStripMenuItem.Name = "fuerzaBrutaToolStripMenuItem";
            this.fuerzaBrutaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fuerzaBrutaToolStripMenuItem.Text = "Fuerza Bruta";
            // 
            // pxToolStripMenuItem
            // 
            this.pxToolStripMenuItem.Name = "pxToolStripMenuItem";
            this.pxToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pxToolStripMenuItem.Text = "P*A*PT";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // caminosCircuitosToolStripMenuItem
            // 
            this.caminosCircuitosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.eulerToolStripMenuItem1});
            this.caminosCircuitosToolStripMenuItem.Name = "caminosCircuitosToolStripMenuItem";
            this.caminosCircuitosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caminosCircuitosToolStripMenuItem.Text = "Caminos/Circuitos";
            this.caminosCircuitosToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.caminosCircuitosToolStripMenuItem_DropDownItemClicked);
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simpleToolStripMenuItem.Text = "Simple";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // eulerToolStripMenuItem1
            // 
            this.eulerToolStripMenuItem1.Name = "eulerToolStripMenuItem1";
            this.eulerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eulerToolStripMenuItem1.Text = "Euler";
            this.eulerToolStripMenuItem1.Click += new System.EventHandler(this.eulerToolStripMenuItem1_Click);
            // 
            // caminoMasCortoToolStripMenuItem1
            // 
            this.caminoMasCortoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dijkstraToolStripMenuItem1,
            this.floydToolStripMenuItem1});
            this.caminoMasCortoToolStripMenuItem1.Name = "caminoMasCortoToolStripMenuItem1";
            this.caminoMasCortoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.caminoMasCortoToolStripMenuItem1.Text = "Camino mas Corto";
            this.caminoMasCortoToolStripMenuItem1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.caminoMasCortoToolStripMenuItem1_DropDownItemClicked);
            // 
            // dijkstraToolStripMenuItem1
            // 
            this.dijkstraToolStripMenuItem1.Name = "dijkstraToolStripMenuItem1";
            this.dijkstraToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dijkstraToolStripMenuItem1.Text = "Dijkstra";
            // 
            // floydToolStripMenuItem1
            // 
            this.floydToolStripMenuItem1.Name = "floydToolStripMenuItem1";
            this.floydToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.floydToolStripMenuItem1.Text = "Floyd";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kruskalT,
            this.primT,
            this.warshallT});
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.arbolesToolStripMenuItem_DropDownItemClicked);
            // 
            // kruskalT
            // 
            this.kruskalT.Name = "kruskalT";
            this.kruskalT.Size = new System.Drawing.Size(119, 22);
            this.kruskalT.Text = "Kruskal";
            // 
            // primT
            // 
            this.primT.Name = "primT";
            this.primT.Size = new System.Drawing.Size(119, 22);
            this.primT.Text = "Prim";
            // 
            // warshallT
            // 
            this.warshallT.Name = "warshallT";
            this.warshallT.Size = new System.Drawing.Size(119, 22);
            this.warshallT.Text = "Warshall";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 116);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Colorear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "Dirigido";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de Grafos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivo;
        private System.Windows.Forms.ToolStripMenuItem guardarGrafo;
        private System.Windows.Forms.ToolStripMenuItem abrirGrafo;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarAristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminoMasCortoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijkstraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floydToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arboles;
        private System.Windows.Forms.ToolStripMenuItem primToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kruskalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warshallToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoGrafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isomorfismoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fuerzaBrutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminosCircuitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminoMasCortoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dijkstraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem floydToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kruskalT;
        private System.Windows.Forms.ToolStripMenuItem primT;
        private System.Windows.Forms.ToolStripMenuItem warshallT;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem;
    }
}

