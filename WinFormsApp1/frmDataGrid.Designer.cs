namespace MiPrimerApp2025C
{
    partial class frmDataGrid
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
            saveFileDialogDataGrid = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            btnGuardar = new Button();
            dgvDatos = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // saveFileDialogDataGrid
            // 
            saveFileDialogDataGrid.Filter = "Archivo CSV|*.csv";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialogDataGrid";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|Excel (*.csv*)|*.csv*";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 500);
            button1.Name = "button1";
            button1.Size = new Size(1168, 40);
            button1.TabIndex = 2;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(3, 454);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(1168, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(3, 3);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.Size = new Size(1168, 439);
            dgvDatos.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvDatos, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Location = new Point(2, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.5372238F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4627762F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(1174, 543);
            tableLayoutPanel1.TabIndex = 1;
           
            // 
            // frmDataGrid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 567);
            Controls.Add(tableLayoutPanel1);
            Name = "frmDataGrid";
            Text = "DataGridView";
            
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SaveFileDialog saveFileDialogDataGrid;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button btnGuardar;
        private DataGridView dgvDatos;
        private TableLayoutPanel tableLayoutPanel1;
    }
}