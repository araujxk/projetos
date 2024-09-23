namespace Semáforo
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
            components = new System.ComponentModel.Container();
            buttonAMARELO = new Button();
            buttonVERDE = new Button();
            buttonVERMELHO = new Button();
            buttonAPAGADO = new Button();
            pictureBoxSemaforo = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSemaforo).BeginInit();
            SuspendLayout();
            // 
            // buttonAMARELO
            // 
            buttonAMARELO.Location = new Point(526, 146);
            buttonAMARELO.Name = "buttonAMARELO";
            buttonAMARELO.Size = new Size(88, 23);
            buttonAMARELO.TabIndex = 0;
            buttonAMARELO.Text = "AMARELO";
            buttonAMARELO.UseVisualStyleBackColor = true;
            buttonAMARELO.Click += buttonAMARELO_Click;
            // 
            // buttonVERDE
            // 
            buttonVERDE.Location = new Point(526, 77);
            buttonVERDE.Name = "buttonVERDE";
            buttonVERDE.Size = new Size(88, 23);
            buttonVERDE.TabIndex = 1;
            buttonVERDE.Text = "VERDE";
            buttonVERDE.UseVisualStyleBackColor = true;
            buttonVERDE.Click += buttonVERDE_Click;
            // 
            // buttonVERMELHO
            // 
            buttonVERMELHO.Location = new Point(526, 221);
            buttonVERMELHO.Name = "buttonVERMELHO";
            buttonVERMELHO.Size = new Size(88, 23);
            buttonVERMELHO.TabIndex = 2;
            buttonVERMELHO.Text = "VERMELHO";
            buttonVERMELHO.UseVisualStyleBackColor = true;
            buttonVERMELHO.Click += buttonVERMELHO_Click;
            // 
            // buttonAPAGADO
            // 
            buttonAPAGADO.Location = new Point(526, 292);
            buttonAPAGADO.Name = "buttonAPAGADO";
            buttonAPAGADO.Size = new Size(88, 23);
            buttonAPAGADO.TabIndex = 3;
            buttonAPAGADO.Text = "APAGADO";
            buttonAPAGADO.UseVisualStyleBackColor = true;
            buttonAPAGADO.Click += buttonAPAGADO_Click;
            // 
            // pictureBoxSemaforo
            // 
            pictureBoxSemaforo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxSemaforo.Location = new Point(261, 77);
            pictureBoxSemaforo.Name = "pictureBoxSemaforo";
            pictureBoxSemaforo.Size = new Size(214, 249);
            pictureBoxSemaforo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSemaforo.TabIndex = 4;
            pictureBoxSemaforo.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(56, 88);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Desligar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(56, 146);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Ligar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 44);
            textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBoxSemaforo);
            Controls.Add(buttonAPAGADO);
            Controls.Add(buttonVERMELHO);
            Controls.Add(buttonVERDE);
            Controls.Add(buttonAMARELO);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSemaforo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAMARELO;
        private Button buttonVERDE;
        private Button buttonVERMELHO;
        private Button buttonAPAGADO;
        private PictureBox pictureBoxSemaforo;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}
