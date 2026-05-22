using System;
using System.Windows.Forms;
using UnitConverter.Categories;
using UnitConverter.Categories.PhysicalQuantities;
using UnitConverter.Core;
using UnitConverter.Utils;

namespace UnitConverter
{
    public partial class MainForm : Form
    {
        // creazione oggetto converter
        private Converter _converter;
        
        // Fonti di dati per comboBox
        BindingSource UnitsDataSource = new BindingSource(MeasurementUnitsDictionary.MeasurementUnits, null);
        BindingSource PhysicalquantitiesDataSource = new BindingSource();
        
        public MainForm()
        {
            InitializeComponent();

            // Assegnazione fonti di dati
            startingUnitComboBox.DataSource = UnitsDataSource;
            startingUnitComboBox.DisplayMember = "Key";   // quello che vedi nel ComboBox
            startingUnitComboBox.ValueMember = "Value";   // quello che usi nel codice
            
            convertedUnitComboBox.DataSource = UnitsDataSource;
            convertedUnitComboBox.DisplayMember = "Key";   // quello che vedi nel ComboBox
            convertedUnitComboBox.ValueMember = "Value";   // quello che usi nel codice

            PhysicalquantitiesDataSource.DataSource = Enum.GetValues(typeof(ObjectToConvert));
            physicalQuantityComboBox.DataSource = PhysicalquantitiesDataSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        // Evento di selezione di un nuovo elemento dal comboBox per il tipo di conversione
        private void physicalQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = (ObjectToConvert)physicalQuantityComboBox.SelectedItem;
            //_converter.InitializeObject(selection, startingValueTextBox, );
            
            Refresh();
        }
    }
}