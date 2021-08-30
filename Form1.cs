using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace TradesoftTestTask
{
  
    public partial class DirectoryAnalogsForm : Form
    {
        AnalogDbContext db;
        public DirectoryAnalogsForm()
        {
            InitializeComponent();
            db = new AnalogDbContext();
            db.Analogs.Load();
            dataGridView.DataSource = db.Analogs.Local.ToBindingList();
            this.dataGridView.Columns["id"].Visible = false;
        }

        void AddElem()
        {
            try
            {
                AddAnalogForm AdForm = new AddAnalogForm();
                DialogResult result = AdForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                Analog analog = new Analog();
                analog.articleOne = AdForm.Aricle1TextBox.Text;
                analog.articleTwo = AdForm.Article2TextBox.Text;
                analog.manufacturerOne = AdForm.Manufacturer1TextBox.Text;
                analog.manufacturerTwo = AdForm.Manufacturer2TextBox.Text;
                analog.confidence = (int)AdForm.ConfidenceNumericUpDown.Value;


                db.Analogs.Add(analog);
                db.SaveChanges();
                dataGridView.Refresh();
                MessageBox.Show("Новый объект добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DeletElem()
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;

                    Analog analog = db.Analogs.Find(id);
                    db.Analogs.Remove(analog);
                    db.SaveChanges();
                    dataGridView.Refresh();
                    MessageBox.Show("Объект удален");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ChangeElem()
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;

                    Analog analog = db.Analogs.Find(id);

                    AddAnalogForm AdForm = new AddAnalogForm();

                    AdForm.Aricle1TextBox.Text = analog.articleOne;
                    AdForm.Article2TextBox.Text = analog.articleTwo;
                    AdForm.Manufacturer1TextBox.Text = analog.manufacturerOne;
                    AdForm.Manufacturer2TextBox.Text = analog.manufacturerTwo;
                    AdForm.ConfidenceNumericUpDown.Value = analog.confidence;

                    DialogResult result = AdForm.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    analog.articleOne = AdForm.Aricle1TextBox.Text;
                    analog.articleTwo = AdForm.Article2TextBox.Text;
                    analog.manufacturerOne = AdForm.Manufacturer1TextBox.Text;
                    analog.manufacturerTwo = AdForm.Manufacturer2TextBox.Text;
                    analog.confidence = (int)AdForm.ConfidenceNumericUpDown.Value;

                    db.SaveChanges();
                    dataGridView.Refresh();
                    MessageBox.Show("Объект обновлен");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка при попытке обновить", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddElem();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            DeletElem();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeElem();
        }
        private void FindСonnectionButton_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm();
            PathForm pathForm = new PathForm();
            DialogResult result = findForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            FindRoutes findRoutes = new FindRoutes();
            findRoutes.Analogs = db.Analogs.ToArray();
            findRoutes.RecursionDepth = (int)findForm.depthsNumericUpDown.Value;
            findRoutes.pF = pathForm;
            findRoutes.RecursivePathfinding(findForm.sourceArtTextBox.Text,findForm.sourceManuftextBox.Text,findForm.targetArtTextBox.Text,findForm.targetManufTextBox.Text);
            if(findRoutes.chek)
                pathForm.ShowDialog();

        }

    }
}
