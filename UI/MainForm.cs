using System;
using System.Windows.Forms;
using UnitConverter.Categories;
using UnitConverter.Categories.PhysicalQuantities;
using UnitConverter.Core;
using UnitConverter.Utils;

namespace UnitConverter.UI
{
    public partial class MainForm : Form
    {
        
        // creazione oggetto converter
        private Converter _converter;
        
        // Fonti di dati per comboBox
        BindingSource _startingUnitsDataSource;
        BindingSource _convertedUnitsDataSource;

        BindingSource PhysicalquantitiesDataSource = new BindingSource();
        
        // Variabili private
        private double StartingValue;
        private Unit  StartingUnit;

        private ObjectToConvert Selection;

        private Unit TargetUnit;
        private double ConvertedValue;
        
        
        public MainForm()
        {
            InitializeComponent();
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
            
            PhysicalquantitiesDataSource.DataSource = new BindingSource(ObjToConvertDict.CategoryDisplayNames, null);
            physicalQuantityComboBox.DataSource = PhysicalquantitiesDataSource;
            physicalQuantityComboBox.DisplayMember = "Key";   // quello che vedi nel ComboBox
            physicalQuantityComboBox.ValueMember = "Value";   // quello che usi nel codice
            
            
            RefreshAll();
            
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            RefreshAll();

            TargetUnit = (Unit)convertedUnitComboBox.SelectedValue;
            
            dynamic dyn = _converter.Obj;
            dyn.Value = StartingValue;
            dyn.Unit = StartingUnit;
            
            // conversione del dato in unità di misura voluta
            dyn.ConvertTo(TargetUnit);

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

        private void RefreshAll()
        {
            try
            {
                Selection = (ObjectToConvert)physicalQuantityComboBox.SelectedValue;
                StartingValue = Convert.ToDouble(startingValueTextBox.Text);
                StartingUnit = (Unit)startingUnitComboBox.SelectedValue;
            }
            catch (Exception exception)
            {
                //
            }
            
            Refresh();
        }

        public void InitializeConverter()
        {
            _converter.InitializeObject(Selection, StartingValue, StartingUnit);
            dynamic dyn = _converter.Obj;
            
            _startingUnitsDataSource = new BindingSource(dyn.UnitsDictionary, null);
            _convertedUnitsDataSource = new BindingSource(dyn.UnitsDictionary, null);
        }
        
    }
}

