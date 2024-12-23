namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string PIN = "";
        const int limitePW = 5;
        int idAutoGenerato = 0;
        CassettaDiSicurezza cas1 = new CassettaDiSicurezza("0001", "Xiaomi", "12345", "01234", true, false);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            UpdateForm();
        }

        private void UpdateForm()
        {
            PIN = "";
            label1.Text = PIN;
            if(!cas1.Vuoto)
                labelObject.Text = cas1.getTipologia();
            if (cas1.IsOpen)
            {
                labelState.Text = "Aperta";
            }
            else
            {
                labelState.Text = "Chiusa";
            }
        }

        //--- Selezione PIN al clic sul tastierino ---
        private void btn1_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 1;
                label1.Text = PIN;
            }

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 2;
                label1.Text = PIN;
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 3;
                label1.Text = PIN;
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 4;
                label1.Text = PIN;
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 5;
                label1.Text = PIN;
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 6;
                label1.Text = PIN;
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 7;
                label1.Text = PIN;
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 8;
                label1.Text = PIN;
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 9;
                label1.Text = PIN;
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
            {
                PIN += 0;
                label1.Text = PIN;
            }
        }

        private void confermabtn_Click(object sender, EventArgs e)
        {
            if (PIN.Length == limitePW)
            {
                MessageBox.Show("PIN ricevuto, seleziona un comando");
            }
            else
            {
                MessageBox.Show("Il PIN deve essere di " + limitePW + " cifre");
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
                MessageBox.Show("Il PIN deve essere di " + limitePW + " cifre");
            cas1.Apri(PIN);

            UpdateForm();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
                MessageBox.Show("Il PIN deve essere di " + limitePW + " cifre");
            cas1.Chiudi(PIN);

            UpdateForm();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
                MessageBox.Show("Il PIN deve essere di " + limitePW + " cifre");
            cas1.Rimuovi(PIN);

            UpdateForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (comboBoxObj.SelectedIndex)
            {
                case 0:
                    OggettoSegreto ObjGenerico = new OggettoSegreto(idAutoGenerato.ToString(), 100);
                    cas1.Apri(PIN);
                    cas1.Aggiungi(ObjGenerico, PIN);
                    break;
            }
            UpdateForm();
        }
    }
}
