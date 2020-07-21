namespace Play20200721_DbUzduotis
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.uzsakymaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.robotDataBaseDataSet = new Play20200721_DbUzduotis.RobotDataBaseDataSet();
            this.uzsakymaiTableAdapter = new Play20200721_DbUzduotis.RobotDataBaseDataSetTableAdapters.UzsakymaiTableAdapter();
            this.tableAdapterManager = new Play20200721_DbUzduotis.RobotDataBaseDataSetTableAdapters.TableAdapterManager();
            this.drawingInDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drawingInDBTableAdapter = new Play20200721_DbUzduotis.RobotDataBaseDataSetTableAdapters.DrawingInDBTableAdapter();
            this.PasrinkimoTB = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowDataInfo = new System.Windows.Forms.DataGridView();
            this.Pasirinkimas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PabaigosDataDTP = new System.Windows.Forms.DateTimePicker();
            this.PradziosDataDTP = new System.Windows.Forms.DateTimePicker();
            this.PradziosDataLB = new System.Windows.Forms.Label();
            this.PabaigosDataLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingInDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // uzsakymaiBindingSource
            // 
            this.uzsakymaiBindingSource.DataMember = "Uzsakymai";
            this.uzsakymaiBindingSource.DataSource = this.robotDataBaseDataSet;
            // 
            // robotDataBaseDataSet
            // 
            this.robotDataBaseDataSet.DataSetName = "RobotDataBaseDataSet";
            this.robotDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uzsakymaiTableAdapter
            // 
            this.uzsakymaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvariniaiPranesimaiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DrawingInDBTableAdapter = null;
            this.tableAdapterManager.LINESQLTableAdapter = null;
            this.tableAdapterManager.SheetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Play20200721_DbUzduotis.RobotDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UzsakymaiTableAdapter = this.uzsakymaiTableAdapter;
            // 
            // drawingInDBBindingSource
            // 
            this.drawingInDBBindingSource.DataMember = "DrawingInDB";
            this.drawingInDBBindingSource.DataSource = this.robotDataBaseDataSet;
            // 
            // drawingInDBTableAdapter
            // 
            this.drawingInDBTableAdapter.ClearBeforeFill = true;
            // 
            // PasrinkimoTB
            // 
            this.PasrinkimoTB.Location = new System.Drawing.Point(13, 57);
            this.PasrinkimoTB.Name = "PasrinkimoTB";
            this.PasrinkimoTB.Size = new System.Drawing.Size(121, 20);
            this.PasrinkimoTB.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(140, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 41);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowDataInfo
            // 
            this.ShowDataInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataInfo.Location = new System.Drawing.Point(12, 119);
            this.ShowDataInfo.Name = "ShowDataInfo";
            this.ShowDataInfo.Size = new System.Drawing.Size(736, 308);
            this.ShowDataInfo.TabIndex = 2;
            // 
            // Pasirinkimas
            // 
            this.Pasirinkimas.DisplayMember = "Text";
            this.Pasirinkimas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pasirinkimas.FormattingEnabled = true;
            this.Pasirinkimas.Location = new System.Drawing.Point(13, 30);
            this.Pasirinkimas.Name = "Pasirinkimas";
            this.Pasirinkimas.Size = new System.Drawing.Size(121, 21);
            this.Pasirinkimas.TabIndex = 3;
            this.Pasirinkimas.ValueMember = "ID";
            this.Pasirinkimas.SelectedValueChanged += new System.EventHandler(this.Pasirinkimas_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ieskoti Pagal";
            // 
            // PabaigosDataDTP
            // 
            this.PabaigosDataDTP.Location = new System.Drawing.Point(91, 83);
            this.PabaigosDataDTP.Name = "PabaigosDataDTP";
            this.PabaigosDataDTP.Size = new System.Drawing.Size(125, 20);
            this.PabaigosDataDTP.TabIndex = 5;
            // 
            // PradziosDataDTP
            // 
            this.PradziosDataDTP.Location = new System.Drawing.Point(91, 57);
            this.PradziosDataDTP.Name = "PradziosDataDTP";
            this.PradziosDataDTP.Size = new System.Drawing.Size(125, 20);
            this.PradziosDataDTP.TabIndex = 6;
            // 
            // PradziosDataLB
            // 
            this.PradziosDataLB.AutoSize = true;
            this.PradziosDataLB.Location = new System.Drawing.Point(12, 60);
            this.PradziosDataLB.Name = "PradziosDataLB";
            this.PradziosDataLB.Size = new System.Drawing.Size(73, 13);
            this.PradziosDataLB.TabIndex = 7;
            this.PradziosDataLB.Text = "Pradzios Data";
            // 
            // PabaigosDataLB
            // 
            this.PabaigosDataLB.AutoSize = true;
            this.PabaigosDataLB.Location = new System.Drawing.Point(12, 83);
            this.PabaigosDataLB.Name = "PabaigosDataLB";
            this.PabaigosDataLB.Size = new System.Drawing.Size(77, 13);
            this.PabaigosDataLB.TabIndex = 8;
            this.PabaigosDataLB.Text = "Pabaigos Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 439);
            this.Controls.Add(this.PabaigosDataLB);
            this.Controls.Add(this.PradziosDataLB);
            this.Controls.Add(this.PradziosDataDTP);
            this.Controls.Add(this.PabaigosDataDTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pasirinkimas);
            this.Controls.Add(this.ShowDataInfo);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PasrinkimoTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingInDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RobotDataBaseDataSet robotDataBaseDataSet;
        private System.Windows.Forms.BindingSource uzsakymaiBindingSource;
        private RobotDataBaseDataSetTableAdapters.UzsakymaiTableAdapter uzsakymaiTableAdapter;
        private RobotDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource drawingInDBBindingSource;
        private RobotDataBaseDataSetTableAdapters.DrawingInDBTableAdapter drawingInDBTableAdapter;
        private System.Windows.Forms.TextBox PasrinkimoTB;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ShowDataInfo;
        private System.Windows.Forms.ComboBox Pasirinkimas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker PabaigosDataDTP;
        private System.Windows.Forms.DateTimePicker PradziosDataDTP;
        private System.Windows.Forms.Label PradziosDataLB;
        private System.Windows.Forms.Label PabaigosDataLB;
    }
}

