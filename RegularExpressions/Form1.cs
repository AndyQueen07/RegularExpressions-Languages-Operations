using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RegularExpressions
{
    /// <summary>
    /// 
    /// 
    /// </summary>

    public partial class frmRegularExpressions : Form
    {

        List<Entities.Alphabet> Alphabets;
        List<Entities.Language> Languages;

        int lastAlphabetIndex, lastLanguageIndex;

        bool unarySelected;

        String selectedOperation;

        /// <summary>
        /// Constructor
        /// </summary>
        public frmRegularExpressions()
        {
            InitializeComponent();
            InitComponents();
        }

        private void InitComponents()
        {
            Alphabets = new List<Entities.Alphabet>();
            Languages = new List<Entities.Language>();

            lastAlphabetIndex = 3;
            lastLanguageIndex = 3;

            unarySelected = false;

            selectedOperation = "";

            Entities.Language
                language1 = new Entities.Language("a,b,c,d,e,f,g,h,i,j,k".Split(',')),
                language2 = new Entities.Language("a,e,i,o,u".Split(',')),
                language3 = new Entities.Language("m,a,r,i,a".Split(','));

            Languages.Add(language1);
            Languages.Add(language2);
            Languages.Add(language3);

            txtLanguages.Text += "A: " + Languages[0].ToString(); // 1
            txtLanguages.Text += "\r\nB: " + Languages[1].ToString(); // 2
            txtLanguages.Text += "\r\nC: " + Languages[2].ToString(); // 3

            comboLanguageA.Items.Add("A");
            comboLanguageA.Items.Add("B");
            comboLanguageA.Items.Add("C");

            comboLanguageA.Text = comboLanguageA.Items[0].ToString();
            comboLanguageA.Text = comboLanguageA.Items[1].ToString();
            comboLanguageA.Text = comboLanguageA.Items[2].ToString();

            comboLanguageB.Items.Add("A");
            comboLanguageB.Items.Add("B");
            comboLanguageB.Items.Add("C");

            comboLanguageB.Text = comboLanguageB.Items[0].ToString();
            comboLanguageB.Text = comboLanguageB.Items[1].ToString();
            comboLanguageB.Text = comboLanguageB.Items[2].ToString();

        }

        private void txtAlphabet_MouseDown(object sender, MouseEventArgs e)
        {
            txtAlphabet.Text = "";
            txtAlphabet.ForeColor = Color.Black;
        }

        private void txtAlphabet_MouseLeave(object sender, EventArgs e)
        {

            if (String.Empty.Equals(txtAlphabet.Text))
            {
                txtAlphabet.Text = "Alfabeto";
                txtAlphabet.ForeColor = Color.FromArgb(224, 224, 224);
            }
            else
            {
                return;
            }

        }

        private void txtLanguage_MouseDown(object sender, MouseEventArgs e)
        {
            txtLanguage.Text = "";
            txtLanguage.ForeColor = Color.Black;
        }

        private void txtLanguage_MouseLeave(object sender, EventArgs e)
        {
            if (String.Empty.Equals(txtLanguage.Text))
            {
                txtLanguage.Text = "Leguaje";
                txtLanguage.ForeColor = Color.FromArgb(224, 224, 224);
            }
            else
            {
                return;
            }
        }

        private void frmRegularExpressions_MouseMove(object sender, MouseEventArgs e)
        {
            //Console.WriteLine(e.X + ", " + e.Y);
        }

        // Buttons Events

        /// <summary>
        /// This section will contain events of buttons :v
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAlphabet_Click(object sender, EventArgs e)
        {
            Alphabets.Add(new Entities.Alphabet(txtAlphabet.Text.Split(' ')));

            txtAlphabet.Text = " ";

            if (lastAlphabetIndex == 0)
            {
                txtAlphabets.Text += Alphabets[lastAlphabetIndex].ToString();
            }
            else
            {
                txtAlphabets.Text += "\n"  + Alphabets[lastAlphabetIndex].ToString();
            }

            lastAlphabetIndex++;
        }

        private void btnAddLanguage_Click(object sender, EventArgs e)
        {

            foreach (Entities.Language language in Languages)
            {
                Console.WriteLine(language.GetCharsets());
            }

            txtLanguage.Focus();

            Languages.Add(new Entities.Language(txtLanguage.Text.Split(',',' ')));

            txtLanguage.Text = " ";

            //65 = A

            string languageName = "" + (char)(lastLanguageIndex + 65);

            if (lastLanguageIndex == 0)
            {
                txtLanguages.Text +=  languageName + ": " + Languages[lastLanguageIndex].ToString();
            }
            else
            {
                txtLanguages.Text += "\r\n" + languageName + ": " + Languages[lastLanguageIndex].ToString();
            }

            comboLanguageA.Items.Add(languageName);
            comboLanguageA.Text = comboLanguageA.Items[lastLanguageIndex].ToString();

            comboLanguageB.Items.Add(languageName);
            comboLanguageB.Text = comboLanguageB.Items[lastLanguageIndex].ToString();


            lastLanguageIndex++;

        }
        
        public void ComboLanguageB_Enable(object sender, EventArgs e)
        {

            var radioChecked = sender as RadioButton;

            if (radioChecked.Checked)
            {
                unarySelected = true;
                comboLanguageB.Enabled = false;
            }
            else
            {
                unarySelected = false;
                comboLanguageB.Enabled = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            String result = IsLanguageSelected();
            if (result != "SELECCIONADOS")
            {
                statLbl.Text = result;
            }
            else
            {
                int languageAIndex = GetLanguageIndex(comboLanguageA.Text);
                int languageBIndex = -1;//that means, there's no language

                if (!unarySelected)
                {
                    languageBIndex = GetLanguageIndex(comboLanguageB.Text);
                }

                Entities.Language
                    languageA = Languages[languageAIndex],
                    languageB = languageBIndex != -1 ? Languages[languageBIndex] : null;

                txtResult.Text = Operate(selectedOperation, languageA, languageB);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //
        // RadioButtons Events
        //

        private void radioPower_CheckedChanged(object sender, EventArgs e)
        {

            ComboLanguageB_Enable(sender, e);
            if (radioPower.Checked)
            {
                numericPower.Enabled = true;
                selectedOperation = Entities.Language.POWER;
            }
            else
            {
                numericPower.Enabled = false;
            }
        }

        private void radioKleeneClosure_CheckedChanged(object sender, EventArgs e)
        {
            ComboLanguageB_Enable(sender, e);
            if (radioKleeneClosure.Checked)
            {
                selectedOperation = Entities.Language.KLEENE_CLOSURE;
            }
        }

        private void radioPositiveClosure_CheckedChanged(object sender, EventArgs e)
        {
            ComboLanguageB_Enable(sender, e);
            if (radioPositiveClosure.Checked)
            {
                selectedOperation = Entities.Language.POSITIVE_CLOSURE;
            }
        }

        private void radioComplement_CheckedChanged(object sender, EventArgs e)
        {
            ComboLanguageB_Enable(sender, e);
            if (radioComplement.Checked)
            {
                selectedOperation = Entities.Language.COMPLEMENT;
            }
        }


        private void radioUnion_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUnion.Checked)
            {
                selectedOperation = Entities.Language.UNION;
            }
        }

        private void radioIntersect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIntersect.Checked)
            {
                selectedOperation = Entities.Language.INTERSECTION;
            }
        }

        private void radioConcat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioConcat.Checked)
            {
                selectedOperation = Entities.Language.CONCATENATION;
            }
        }

        private void radioDifference_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDifference.Checked)
            {
                selectedOperation = Entities.Language.DIFFERENCE;
            }
        }

        private void radioSimetricDifference_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSimetricDifference.Checked)
            {
                selectedOperation = Entities.Language.SYM_DIFFERENCE;
            }
        }

        private void frmRegularExpressions_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Key: " + e.KeyValue + "Pressed");

            if (txtLanguage.Focused)
            {

                Console.WriteLine("Key: " + e.KeyValue + "Pressed while on txtLanguage");

            }

        }

        private void frmRegularExpressions_Load(object sender, EventArgs e)
        {

        }

        // IsLanguageSelected()
        public string IsLanguageSelected()
        {
            bool isSelected = !comboLanguageA.Text.Equals(String.Empty) ||
                                        !comboLanguageB.Text.Equals(String.Empty);

            if (!unarySelected)
            {
                if (!isSelected)
                {
                    return "Por favor seleccione ambos lenguajes";
                }
            }
            else
            {
                if (comboLanguageA.Text.Equals(String.Empty))
                {
                    return "Debe seleccionar algun lenguaje A";
                }
            }

            return "SELECCIONADOS";
        }

        // Auxiliar methdod: get index of Language by it's name
        public int GetLanguageIndex(string name)
        {
            for (int i = 0; i < Languages.Count; i++)
            {
                Console.WriteLine("Converted Value: " + Convert.ToInt32(name[0]));
                if ((i +  65) == Convert.ToInt32(name[0]))
                {
                    return i;
                }
            }
            return -1;
        }

        // Operations
        public String Operate(string operation, Entities.Language languageA, Entities.Language languageB)
        {
            String result = "";

            //Right now, we will guess that only 2 languages are on the array

            if (operation.Equals(Entities.Language.UNION))
            {
                result = (languageA + languageB).GetCharsets();
            }
            else if (operation.Equals(Entities.Language.INTERSECTION))
            {
                result = Entities.Language.Intersection(languageA, languageB).GetCharsets();
            }
            else if (operation.Equals(Entities.Language.CONCATENATION))
            {
                result = (Entities.Language.Concatenation(languageA, languageB)).GetCharsets();
            }
            else if (operation.Equals(Entities.Language.DIFFERENCE))
            {
                result = Entities.Language.Difference(languageA, languageB).GetCharsets();
            }
            else if (operation.Equals(Entities.Language.SYM_DIFFERENCE))
            {
                result = Entities.Language.SymetricDifference(languageA, languageB).GetCharsets();
            }
            else if (operation.Equals(Entities.Language.COMPLEMENT))
            {
                result = Entities.Language.Complement(languageA, Entities.Language.Universe(Languages, lastLanguageIndex)).GetCharsets();
            }
            else if (operation.Equals(Entities.Language.POWER))
            {
                result = Entities.Language.Power(languageA, (int)numericPower.Value).GetCharsets();
            }
            else if (operation.Equals(Entities.Language.KLEENE_CLOSURE))
            {
                result = Entities.Language.KleeneClosure(languageA, 3).GetCharsets();
            }       
            else
            {
                result = Entities.Language.PositiveKleeneClosure(languageA, 3).GetCharsets();
            }

            return result;
        }

    }
}
