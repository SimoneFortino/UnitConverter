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
        private ConversionEngine _engine = new ConversionEngine();
        
        // creazione oggetto converter
        private Converter _converter;
        
        // Fonti di dati per comboBox
        BindingSource _startingUnitsDataSource;
        BindingSource _convertedUnitsDataSource;
        
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
            try
            {
                physicalQuantityComboBox.DataSource = Enum.GetValues(typeof(ObjectToConvert));
             
                ReadValues(1);
                LoadSelection();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            

        }

        private void convertButton_Click(object sender, EventArgs e)
        {

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
            startingUnitComboBox.Text = "0";
            convertedUnitComboBox.Text = "0";
            
            ReadValues(0);
            LoadSelection();
        }

        private void LoadSelection()
        {
            _engine.StartingValue = StartingValue;
            _engine.StartingUnit = StartingUnit;
            
            var selection = (ObjectToConvert)physicalQuantityComboBox.SelectedItem;
            _engine.SetObject(selection);

            dynamic dyn = _engine.DynamicObject;
            
            startingUnitComboBox.DataSource = new BindingSource(dyn.UnitsDictionary, null);
            startingUnitComboBox.DisplayMember = "Key";   // quello che vedi nel ComboBox
            startingUnitComboBox.ValueMember = "Value";   // quello che usi nel codice
            
            convertedUnitComboBox.DataSource = new BindingSource(dyn.UnitsDictionary, null);
            convertedUnitComboBox.DisplayMember = "Key";   // quello che vedi nel ComboBox
            convertedUnitComboBox.ValueMember = "Value";   // quello che usi nel codice
        }

        public void ReadValues(int c)
        {
            if (c == 1)
            {
                StartingValue = 0;
                StartingUnit = Unit.Celsius;
            }
            else
            {
                try
                {
                    StartingValue = Convert.ToDouble(startingValueTextBox.Text);
                    StartingUnit = (Unit)startingUnitComboBox.SelectedValue;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e);
                }
 
            }
            

        }

    }
}