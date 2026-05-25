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
        private MainProcess _process;
        
        // creazione oggetto converter
        private Converter _converter;
        
        // Fonti di dati per comboBox
        BindingSource _startingUnitsDataSource;
        BindingSource _convertedUnitsDataSource;
        BindingSource _startingMultiplierSource;
        BindingSource _convertedMultiplierSource;

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

            _process = new MainProcess(this);
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
                        
            _converter = new Converter();
            InitializeConverter();
            
            // Assegnazione fonti di dati
            startingUnitComboBox.DataSource = _startingUnitsDataSource;
            startingUnitComboBox.DisplayMember = "Key";   // quello che vedi nel ComboBox
            startingUnitComboBox.ValueMember = "Value";   // quello che usi nel codice
            
            convertedUnitComboBox.DataSource = _convertedUnitsDataSource;
            convertedUnitComboBox.DisplayMember = "Key";   // quello che vedi nel ComboBox
            convertedUnitComboBox.ValueMember = "Value";   // quello che usi nel codice
            
            PhysicalquantitiesDataSource.DataSource = Enum.GetValues(typeof(ObjectToConvert));
            physicalQuantityComboBox.DataSource = PhysicalquantitiesDataSource;
            
            RefreshAll();
            
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            RefreshAll();

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
            InitializeConverter();
            
            startingUnitComboBox.DataSource = _startingUnitsDataSource;
            convertedUnitComboBox.DataSource = _convertedUnitsDataSource;
            
            startingValueTextBox.Text = "0";
            convertedValueTextBox.Text = "0";
        }

        public void RefreshAll()
        {
            try
            {
                Selection = (ObjectToConvert)physicalQuantityComboBox.SelectedItem;
                StartingValue = Convert.ToDouble(startingValueTextBox.Text);
                StartingUnit = (Unit)startingUnitComboBox.SelectedValue;
                StartingMultiplier = Multiplier.None;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            Refresh();
        }

        public void InitializeConverter()
        {
            _converter.InitializeObject(Selection, StartingValue, StartingUnit, StartingMultiplier);
            dynamic dyn = _converter.Obj;
            
            _startingUnitsDataSource = new BindingSource(dyn.UnitsDictionary, null);
            _convertedUnitsDataSource = new BindingSource(dyn.UnitsDictionary, null);
        }


    }
}