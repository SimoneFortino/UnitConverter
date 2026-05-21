using System;
using System.Windows.Forms;
using UnitConverter.Categories;
using UnitConverter.Categories.PhysicalQuantities;
using UnitConverter.Utils;

namespace UnitConverter
{
    public partial class MainForm : Form
    {
        // Fonti di dati per comboBox
        BindingSource UnitsDataSource = new BindingSource(MeasurementUnitsDictionary.MeasurementUnits, null);
        BindingSource PhysicalquantitiesDataSource = new BindingSource(MeasurementUnitsDictionary.MeasurementUnits, null);
        public MainForm()
        {
            InitializeComponent();

            // Assegnazione fonti di dati
            startingUnitComboBox.DataSource = UnitsDataSource;
            convertedUnitComboBox.DataSource = UnitsDataSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(startingValueTextBox.Text);
            Unit unit = MeasurementUnitsDictionary.MeasurementUnits[(string)physicalQuantityComboBox.SelectedItem];
            Unit targetUnit = MeasurementUnitsDictionary.MeasurementUnits[(string)convertedUnitComboBox.SelectedItem];

            Temperature temp = new Temperature(val, unit, Multiplier.None);
            
            temp.ConvertTo(targetUnit);

            convertedValueTextBox.Text = temp.Value.ToString();
        }
    }
}