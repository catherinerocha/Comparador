using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparador
{
    public partial class Form1 : Form
    {
        string box1, box2, checkBoxOption;

        SortList sorting = new SortList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private List<string> Starting(string boxContent)
        {
            boxContent = CleaningString(boxContent);

            var listTextBoxes = sorting.SortString(sorting.SplitArray(boxContent).ToList());

            return listTextBoxes;
        }

        private string CleaningString(string box)
        {
            ContentCleaner cleanString = new ContentCleaner();
            box = cleanString.ReplaceCharacters(box, checkBoxOption);

            return box;
        }

        private void CompareButton(object sender, EventArgs e)
        {
            var listTextBoxes1 = Starting(textBox1.Text);

            var listTextBoxes2 = Starting(textBox2.Text);

            var listCompared = new List<string>();

            foreach (var index in listTextBoxes1)
            {
                if (!listTextBoxes2.Contains(index))
                {
                    listCompared.Add(index);
                }
            }

            // Salva em TXT se o conteúdo for longo
            if(listCompared.Count > 15)
            {
                TextWriter tw = new StreamWriter("SavedList.txt");

                foreach (String s in listCompared)
                    tw.WriteLine(s);

                tw.Close();
            }
            else MessageBox.Show(String.Join("\n", listCompared));
        }

        private void SortButton(object sender, EventArgs e)
        {

            textBox1.Text = String.Join(Environment.NewLine, Starting(textBox1.Text));
            textBox2.Text = String.Join(Environment.NewLine, Starting(textBox2.Text));
        }

        private void InverterButton(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = auxiliar;
        }

        private void RemoveDuplicates(object sender, EventArgs e)
        {
        }

        private void CleaningBoxes(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;

        }

        private void TXTGeneratorButton(object sender, EventArgs e)
        {

        }

        private void Separador_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxOption = "1";

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxOption = "2";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxOption = "3";
        }


        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxOption = "4";
        }
    }
}
