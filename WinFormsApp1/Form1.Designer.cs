namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            label1 = new Label();
            confermabtn = new Button();
            groupBox1 = new GroupBox();
            buttonClear = new Button();
            groupBox2 = new GroupBox();
            buttoneditPIN = new Button();
            buttonClose = new Button();
            buttonOpen = new Button();
            labelState = new Label();
            groupBox3 = new GroupBox();
            textBoxType = new TextBox();
            comboBoxObj = new ComboBox();
            buttonRemove = new Button();
            buttonAdd = new Button();
            labelObject = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(13, 66);
            btn1.Name = "btn1";
            btn1.Size = new Size(46, 45);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(65, 66);
            btn2.Name = "btn2";
            btn2.Size = new Size(46, 45);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(13, 117);
            btn4.Name = "btn4";
            btn4.Size = new Size(46, 45);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(117, 66);
            btn3.Name = "btn3";
            btn3.Size = new Size(46, 45);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(117, 117);
            btn6.Name = "btn6";
            btn6.Size = new Size(46, 45);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(65, 117);
            btn5.Name = "btn5";
            btn5.Size = new Size(46, 45);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(65, 219);
            btn0.Name = "btn0";
            btn0.Size = new Size(46, 45);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(117, 168);
            btn9.Name = "btn9";
            btn9.Size = new Size(46, 45);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(65, 168);
            btn8.Name = "btn8";
            btn8.Size = new Size(46, 45);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(13, 168);
            btn7.Name = "btn7";
            btn7.Size = new Size(46, 45);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 32);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // confermabtn
            // 
            confermabtn.Location = new Point(117, 219);
            confermabtn.Name = "confermabtn";
            confermabtn.Size = new Size(46, 45);
            confermabtn.TabIndex = 12;
            confermabtn.Text = "ok";
            confermabtn.UseVisualStyleBackColor = true;
            confermabtn.Click += confermabtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(confermabtn);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(btn0);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn9);
            groupBox1.Controls.Add(btn1);
            groupBox1.Controls.Add(btn8);
            groupBox1.Controls.Add(btn2);
            groupBox1.Controls.Add(btn7);
            groupBox1.Controls.Add(btn3);
            groupBox1.Controls.Add(btn6);
            groupBox1.Controls.Add(btn4);
            groupBox1.Controls.Add(btn5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 275);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tastierino";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(13, 219);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(46, 45);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "-";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttoneditPIN);
            groupBox2.Controls.Add(buttonClose);
            groupBox2.Controls.Add(buttonOpen);
            groupBox2.Location = new Point(250, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 62);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controlli Cassetta";
            // 
            // buttoneditPIN
            // 
            buttoneditPIN.Location = new Point(248, 22);
            buttoneditPIN.Name = "buttoneditPIN";
            buttoneditPIN.Size = new Size(98, 23);
            buttoneditPIN.TabIndex = 2;
            buttoneditPIN.Text = "modifica PIN";
            buttoneditPIN.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(125, 22);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(98, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Chiudi";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(6, 22);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(98, 23);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Apri";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            labelState.Location = new Point(305, 247);
            labelState.Name = "labelState";
            labelState.Size = new Size(115, 86);
            labelState.TabIndex = 17;
            labelState.Text = "---";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxType);
            groupBox3.Controls.Add(comboBoxObj);
            groupBox3.Controls.Add(buttonRemove);
            groupBox3.Controls.Add(buttonAdd);
            groupBox3.Location = new Point(256, 112);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(352, 132);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controlli Cassetta";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(182, 29);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(158, 23);
            textBoxType.TabIndex = 3;
            // 
            // comboBoxObj
            // 
            comboBoxObj.FormattingEnabled = true;
            comboBoxObj.Items.AddRange(new object[] { "Generico", "Gioiello", "Documento", "Chiave" });
            comboBoxObj.Location = new Point(6, 28);
            comboBoxObj.Name = "comboBoxObj";
            comboBoxObj.Size = new Size(132, 23);
            comboBoxObj.TabIndex = 2;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(6, 103);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(98, 23);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Rimuovi";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(242, 103);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(98, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Aggiungi";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelObject
            // 
            labelObject.AutoSize = true;
            labelObject.Location = new Point(574, 291);
            labelObject.Name = "labelObject";
            labelObject.Size = new Size(22, 15);
            labelObject.TabIndex = 18;
            labelObject.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 378);
            Controls.Add(labelObject);
            Controls.Add(groupBox3);
            Controls.Add(labelState);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "cassettaDiSicurezza";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn4;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Label label1;
        private Button confermabtn;
        private GroupBox groupBox1;
        private Button buttonClear;
        private GroupBox groupBox2;
        private Button buttonClose;
        private Button buttonOpen;
        private Button buttoneditPIN;
        private Label labelState;
        private GroupBox groupBox3;
        private TextBox textBoxType;
        private ComboBox comboBoxObj;
        private Button buttonRemove;
        private Button buttonAdd;
        private Label labelObject;
    }
}
