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
        BindingSource startingUnitsDataSource = new BindingSource(MeasurementUnitsDictionary.MeasurementUnits, null);
        BindingSource convertedUnitsDataSource = new BindingSource(MeasurementUnitsDictionary.MeasurementUnits, null);

        BindingSource PhysicalquantitiesDataSource = new BindingSource();
        
        // Variabili globali
        private double StartingValue;
        private Unit  StartingUnit;
        private Multiplier StartingMultiplier;
        private ObjectToConvert Selection;

        private Unit TargetUnit;
        private Multiplier TargetMultiplier;
        private double ConvertedValue;
        
        
        public MainForm()
        {
            InitializeComponent();
            
            _converter = new Converter();

            // Assegnazione fonti di dati
            startingUnitComboBox.DataSource = startingUnitsDataSource;
            startingUnitComboBox.DisplayMember = "Key";   // quello che vedi nel ComboBox
            startingUnitComboBox.ValueMember = "Value";   // quello che usi nel codice
            
            convertedUnitComboBox.DataSource = convertedUnitsDataSource;
            convertedUnitComboBox.DisplayMember = "Key";   // quello che vedi nel ComboBox
            convertedUnitComboBox.ValueMember = "Value";   // quello che usi nel codice

            PhysicalquantitiesDataSource.DataSource = Enum.GetValues(typeof(ObjectToConvert));
            physicalQuantityComboBox.DataSource = PhysicalquantitiesDataSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            TargetUnit = (Unit)convertedUnitComboBox.SelectedValue;
            TargetMultiplier = Multiplier.None;
            
            dynamic dyn = _converter.obj;
            dyn.ConvertTo(TargetUnit, TargetMultiplier);

            ConvertedValue = dyn.Value;
            convertedValueTextBox.Text = ConvertedValue.ToString();

        }

        // Evento di selezione di un nuovo elemento dal comboBox per il tipo di conversione
        private void physicalQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Selection = (ObjectToConvert)physicalQuantityComboBox.SelectedItem;
                StartingValue = Convert.ToDouble(startingValueTextBox.Text);
                StartingUnit = (Unit)startingUnitComboBox.SelectedValue;
                StartingMultiplier = Multiplier.None;
                
                //MessageBox.Show(startingUnitComboBox.SelectedValue?.ToString() ?? "NULL");

                
                _converter.InitializeObject(Selection, StartingValue, StartingUnit, StartingMultiplier);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
            Refresh();
        }
    }
}