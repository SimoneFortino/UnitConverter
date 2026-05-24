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
        readonly BindingSource startingUnitsDataSource = new BindingSource(MeasurementUnitsDictionary.MeasurementUnits, null);
        readonly BindingSource convertedUnitsDataSource = new BindingSource(MeasurementUnitsDictionary.MeasurementUnits, null);

        BindingSource PhysicalquantitiesDataSource = new BindingSource();
        
        // Variabili private
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
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
                        
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
            
            RefreshAll();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            TargetUnit = (Unit)convertedUnitComboBox.SelectedValue;
            TargetMultiplier = Multiplier.None;
            
            dynamic dyn = _converter.Obj;
            dyn.Value = StartingValue;
            dyn.Unit = StartingUnit;
            
            // conversione del dato in unità di misura voluta
            dyn.ConvertTo(TargetUnit, TargetMultiplier);

            ConvertedValue = dyn.Value;
            convertedValueTextBox.Text = ConvertedValue.ToString();

        }

        // Evento di selezione di un nuovo elemento dal comboBox per il tipo di conversione
        private void physicalQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
        }

        public void RefreshAll()
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
                MessageBox.Show(exception.Message);
            }
            
            Refresh();
        }


    }
}