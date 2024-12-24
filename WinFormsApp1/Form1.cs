namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string PIN = "";
        const int limitePW = 5;
        int idAutoGenerato = 0;
        bool editPin=false; //seleziona modalità di modifica del pin
        string temp=""; //var temporanea per salvare cod. sblocco come argomento della funzione se in mod. modifica pin
        
        CassettaDiSicurezza cas1 = new CassettaDiSicurezza("0001", "Xiaomi", "12345", "01234", true, false);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            PIN = "";
            label1.Text = PIN;
            if (cas1.Vuoto)
            {
                labelObject.Text = "Vuota";
                labelAssicurazione.Visible = false;
                labelValue.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                labelObject.Text = cas1.getTipologia();
                labelAssicurazione.Text = cas1.getValoreAssicurato().ToString();
                labelValue.Text = cas1.OggettoContenuto.Valore.ToString();
                labelAssicurazione.Visible = true;
                labelValue.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
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
                if (editPin)
                {
                    if(temp=="") //significa che non è ancora stato inserito il codice di sblocco
                    {
                        temp = PIN;
                        MessageBox.Show("Ora immetti il nuovo PIN", "Modifica PIN");
                        UpdateForm();
                    } else //richiama la funzione per modificare il pin
                    {
                        if (cas1.ModificaPin(temp, PIN))
                            MessageBox.Show("PIN modificato con successo", "Modifica PIN");
                        else
                            MessageBox.Show("Il codice di sblocco non corrisponde", "Errore");
                        UpdateForm();
                        temp = "";
                        editPin = false;
                    }
                }
                else
                {
                    MessageBox.Show("PIN ricevuto, seleziona un comando");
                }
            }
            else
            {
                MessageBox.Show("Il PIN deve essere di " + limitePW + " cifre");
            }
        }

        //--- Controlli della cassetta ---

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
            if (cas1.Vuoto)
                MessageBox.Show("Nessun oggetto inserito");
            else
                cas1.Rimuovi(PIN);

            UpdateForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (PIN.Length < limitePW)
                MessageBox.Show("Il PIN deve essere di " + limitePW + " cifre");
            else if (!cas1.Vuoto)
                MessageBox.Show("Un oggetto è già contenuto");
            else
            {
                switch (comboBoxObj.SelectedIndex)
                {
                    case 0:
                        OggettoSegreto ObjGenerico = new OggettoSegreto(idAutoGenerato.ToString(), 50);
                        cas1.Apri(PIN);
                        cas1.Aggiungi(ObjGenerico, PIN);
                        break;
                    case 1:
                        OggettoSegreto Gioiello = new Gioielli(idAutoGenerato.ToString(), 100, textBoxType.Text);
                        cas1.Apri(PIN);
                        cas1.Aggiungi(Gioiello, PIN);
                        break;
                    case 2:
                        OggettoSegreto Doc = new Documenti(idAutoGenerato.ToString(), 30, textBoxType.Text);
                        cas1.Apri(PIN);
                        cas1.Aggiungi(Doc, PIN);
                        break;
                    case 3:
                        OggettoSegreto Chiave = new Chiavi(idAutoGenerato.ToString(), 1, GetKeyType());
                        cas1.Apri(PIN);
                        cas1.Aggiungi(Chiave, PIN);
                        break;
                }
                idAutoGenerato++;
            }

            UpdateForm();
        }

        private void comboBoxObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxObj.SelectedIndex == 3) //key
            {
                textBoxType.Visible = false;
                comboBoxKeyType.Visible = true;
            }
            else
            {
                textBoxType.Visible = true;
                comboBoxKeyType.Visible = false;
            }
        }

        private bool GetKeyType()
        {
            switch (comboBoxKeyType.SelectedIndex)
            {
                case 0: return true;
                case 1: return false;
                default: return false;
            }
        }

        private void buttoneditPIN_Click(object sender, EventArgs e)
        {
            editPin=true;
            UpdateForm();
            MessageBox.Show("Immetti il codice di sblocco (non è il PIN)", "Modifica PIN");

        }
    }
}
