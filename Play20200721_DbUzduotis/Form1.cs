using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Play20200721_DbUzduotis
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arviu\Documents\GitHub\Play20200721\Play20200721_DbUzduotis\Play20200721_DbUzduotis\RobotDataBase.mdf;Integrated Security=True;Connect Timeout=30";



        public Form1()
        {
            InitializeComponent();
            Pasirinkimas.DataSource = new ComboItem[]
            {
                new ComboItem{ID=1, Text="Uzsakymo numeri"},
                new ComboItem{ID=2, Text="Gaminimo koda"},
                new ComboItem{ID=3, Text="Pagal pradzios ir pabaigos rezius"}
            };
        }

        private void uzsakymaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uzsakymaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.robotDataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'robotDataBaseDataSet.Sheet' table. You can move, or remove it, as needed.
          //  this.sheetTableAdapter.Fill(this.robotDataBaseDataSet.Sheet);
            // TODO: This line of code loads data into the 'robotDataBaseDataSet.DrawingInDB' table. You can move, or remove it, as needed.
            this.drawingInDBTableAdapter.Fill(this.robotDataBaseDataSet.DrawingInDB);
            // TODO: This line of code loads data into the 'robotDataBaseDataSet.Uzsakymai' table. You can move, or remove it, as needed.
            this.uzsakymaiTableAdapter.Fill(this.robotDataBaseDataSet.Uzsakymai);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uzsakymaiTableAdapter.FillBy(this.robotDataBaseDataSet.Uzsakymai);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uzsakymaiTableAdapter.FillBy1(this.robotDataBaseDataSet.Uzsakymai);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            DataContext db = new DataContext(ConnectionString);
            //var tableData =db.GetTable<Uzsakymai>();
            if ((int)Pasirinkimas.SelectedValue == 1) {
                var tableData = db.GetTable<DrawingInDB>().Where(X => X.Sheet.Uzsakymai.OrderNumber == PasrinkimoTB.Text);
                ShowDataInfo.DataSource = tableData.Select(x => new { x.Sheet.Amount, x.Code, x.Package, x.TrueName, x.Sheet.Uzsakymai.Name, x.Sheet.Uzsakymai.DeliveryDate });
            }
            else if ((int)Pasirinkimas.SelectedValue == 2)
            {
                var tableData = db.GetTable<DrawingInDB>().Where(X => X.Code == PasrinkimoTB.Text);
                ShowDataInfo.DataSource = tableData.Select(x => new { x.Sheet.Amount, x.Code, x.Package, x.TrueName, x.Sheet.Uzsakymai.Name, x.Sheet.Uzsakymai.DeliveryDate });
            }
            else if ((int)Pasirinkimas.SelectedValue == 3)
            {
                var tableData = db.GetTable<DrawingInDB>().Where(x => (x.Sheet.Uzsakymai.DeliveryDate >= PradziosDataDTP.Value && x.Sheet.Uzsakymai.DeliveryDate <= PabaigosDataDTP.Value));
                ShowDataInfo.DataSource = tableData.Select(x => new { x.Sheet.Amount, x.Code, x.Package, x.TrueName, x.Sheet.Uzsakymai.Name, x.Sheet.Uzsakymai.DeliveryDate });
            }




        }

        private void Pasirinkimas_SelectedValueChanged(object sender, EventArgs e)
        {
            switch ((int)Pasirinkimas.SelectedValue)
            {
                case 1:
                    PasrinkimoTB.Visible = true;
                    PradziosDataDTP.Visible = false;
                    PabaigosDataDTP.Visible = false;
                    PradziosDataLB.Visible = false;
                    PabaigosDataLB.Visible = false;
                    break;
                case 2:
                    PasrinkimoTB.Visible = true;
                    PradziosDataDTP.Visible = false;
                    PabaigosDataDTP.Visible = false;
                    PradziosDataLB.Visible = false;
                    PabaigosDataLB.Visible = false;
                    break;
                case 3:
                    PasrinkimoTB.Visible = false;
                    PradziosDataDTP.Visible = true;
                    PabaigosDataDTP.Visible = true;
                    PradziosDataLB.Visible = true;
                    PabaigosDataLB.Visible = true;
                    break;

            }
        }
    }
}
