namespace EditorPoze
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioPolaroid = new System.Windows.Forms.RadioButton();
            this.ValoareSat = new System.Windows.Forms.Label();
            this.ValoareCon = new System.Windows.Forms.Label();
            this.ValoareLum = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.trackSaturatie = new System.Windows.Forms.TrackBar();
            this.trackContrast = new System.Windows.Forms.TrackBar();
            this.trackLuminozitate = new System.Windows.Forms.TrackBar();
            this.AplicaEfect = new System.Windows.Forms.Button();
            this.radioNegativ = new System.Windows.Forms.RadioButton();
            this.radioGrayscale = new System.Windows.Forms.RadioButton();
            this.radioSepia = new System.Windows.Forms.RadioButton();
            this.PictureEditor = new System.Windows.Forms.PictureBox();
            this.RestabilesteImagine = new System.Windows.Forms.Button();
            this.SalvareEditare = new System.Windows.Forms.Button();
            this.AnulareEditare = new System.Windows.Forms.Button();
            this.ButonADD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSaturatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLuminozitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButonADD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(374, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apasati aici pentru a aduga o fotografie noua.";
            // 
            // trackRed
            // 
            this.trackRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackRed.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackRed.Location = new System.Drawing.Point(54, 464);
            this.trackRed.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.trackRed.Maximum = 25;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(736, 45);
            this.trackRed.TabIndex = 5;
            this.trackRed.Scroll += new System.EventHandler(this.TrackRed_ValueChanged);
            // 
            // trackGreen
            // 
            this.trackGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackGreen.Location = new System.Drawing.Point(54, 512);
            this.trackGreen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.trackGreen.Maximum = 25;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(736, 45);
            this.trackGreen.TabIndex = 6;
            this.trackGreen.Scroll += new System.EventHandler(this.TrackGreen_ValueChanged);
            // 
            // trackBlue
            // 
            this.trackBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBlue.Location = new System.Drawing.Point(54, 560);
            this.trackBlue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.trackBlue.Maximum = 25;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(736, 45);
            this.trackBlue.TabIndex = 7;
            this.trackBlue.Scroll += new System.EventHandler(this.TrackBlue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(3, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Green:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(3, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Blue:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.radioPolaroid);
            this.panel1.Controls.Add(this.ValoareSat);
            this.panel1.Controls.Add(this.ValoareCon);
            this.panel1.Controls.Add(this.ValoareLum);
            this.panel1.Controls.Add(this.labelS);
            this.panel1.Controls.Add(this.labelC);
            this.panel1.Controls.Add(this.labelB);
            this.panel1.Controls.Add(this.trackSaturatie);
            this.panel1.Controls.Add(this.trackContrast);
            this.panel1.Controls.Add(this.trackLuminozitate);
            this.panel1.Controls.Add(this.AplicaEfect);
            this.panel1.Controls.Add(this.radioNegativ);
            this.panel1.Controls.Add(this.radioGrayscale);
            this.panel1.Controls.Add(this.radioSepia);
            this.panel1.Controls.Add(this.PictureEditor);
            this.panel1.Controls.Add(this.RestabilesteImagine);
            this.panel1.Controls.Add(this.SalvareEditare);
            this.panel1.Controls.Add(this.AnulareEditare);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.trackRed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.trackGreen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBlue);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 612);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // radioPolaroid
            // 
            this.radioPolaroid.AutoSize = true;
            this.radioPolaroid.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioPolaroid.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.radioPolaroid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.radioPolaroid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPolaroid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioPolaroid.Location = new System.Drawing.Point(811, 460);
            this.radioPolaroid.Name = "radioPolaroid";
            this.radioPolaroid.Size = new System.Drawing.Size(90, 19);
            this.radioPolaroid.TabIndex = 28;
            this.radioPolaroid.TabStop = true;
            this.radioPolaroid.Text = "Old image";
            this.radioPolaroid.UseVisualStyleBackColor = true;
            this.radioPolaroid.CheckedChanged += new System.EventHandler(this.radioPolaroid_CheckedChanged);
            // 
            // ValoareSat
            // 
            this.ValoareSat.AutoSize = true;
            this.ValoareSat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValoareSat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ValoareSat.Location = new System.Drawing.Point(884, 379);
            this.ValoareSat.Name = "ValoareSat";
            this.ValoareSat.Size = new System.Drawing.Size(15, 15);
            this.ValoareSat.TabIndex = 27;
            this.ValoareSat.Text = "0";
            // 
            // ValoareCon
            // 
            this.ValoareCon.AutoSize = true;
            this.ValoareCon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValoareCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ValoareCon.Location = new System.Drawing.Point(883, 313);
            this.ValoareCon.Name = "ValoareCon";
            this.ValoareCon.Size = new System.Drawing.Size(15, 15);
            this.ValoareCon.TabIndex = 26;
            this.ValoareCon.Text = "0";
            // 
            // ValoareLum
            // 
            this.ValoareLum.AutoSize = true;
            this.ValoareLum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValoareLum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ValoareLum.Location = new System.Drawing.Point(910, 241);
            this.ValoareLum.Name = "ValoareLum";
            this.ValoareLum.Size = new System.Drawing.Size(15, 15);
            this.ValoareLum.TabIndex = 25;
            this.ValoareLum.Text = "0";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelS.Location = new System.Drawing.Point(808, 379);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(72, 15);
            this.labelS.TabIndex = 24;
            this.labelS.Text = "Saturatie:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelC.Location = new System.Drawing.Point(808, 310);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(68, 15);
            this.labelC.TabIndex = 23;
            this.labelC.Text = "Contrast:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelB.Location = new System.Drawing.Point(808, 241);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(96, 15);
            this.labelB.TabIndex = 22;
            this.labelB.Text = "Luminozitate:";
            // 
            // trackSaturatie
            // 
            this.trackSaturatie.LargeChange = 2;
            this.trackSaturatie.Location = new System.Drawing.Point(802, 400);
            this.trackSaturatie.Maximum = 20;
            this.trackSaturatie.Name = "trackSaturatie";
            this.trackSaturatie.Size = new System.Drawing.Size(263, 45);
            this.trackSaturatie.TabIndex = 21;
            this.trackSaturatie.Value = 10;
            this.trackSaturatie.Scroll += new System.EventHandler(this.TrackSaturatie_Scroll);
            // 
            // trackContrast
            // 
            this.trackContrast.LargeChange = 2;
            this.trackContrast.Location = new System.Drawing.Point(802, 331);
            this.trackContrast.Maximum = 20;
            this.trackContrast.Name = "trackContrast";
            this.trackContrast.Size = new System.Drawing.Size(263, 45);
            this.trackContrast.TabIndex = 20;
            this.trackContrast.Value = 10;
            this.trackContrast.Scroll += new System.EventHandler(this.TrackContrast_Scroll);
            // 
            // trackLuminozitate
            // 
            this.trackLuminozitate.LargeChange = 2;
            this.trackLuminozitate.Location = new System.Drawing.Point(802, 262);
            this.trackLuminozitate.Minimum = -10;
            this.trackLuminozitate.Name = "trackLuminozitate";
            this.trackLuminozitate.Size = new System.Drawing.Size(263, 45);
            this.trackLuminozitate.TabIndex = 19;
            this.trackLuminozitate.Scroll += new System.EventHandler(this.TrackLuminozitate_Scroll);
            // 
            // AplicaEfect
            // 
            this.AplicaEfect.BackColor = System.Drawing.Color.Gray;
            this.AplicaEfect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AplicaEfect.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AplicaEfect.FlatAppearance.BorderSize = 0;
            this.AplicaEfect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.AplicaEfect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AplicaEfect.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AplicaEfect.ForeColor = System.Drawing.Color.White;
            this.AplicaEfect.Location = new System.Drawing.Point(811, 570);
            this.AplicaEfect.Name = "AplicaEfect";
            this.AplicaEfect.Size = new System.Drawing.Size(254, 35);
            this.AplicaEfect.TabIndex = 18;
            this.AplicaEfect.Text = "Aplica efectul";
            this.AplicaEfect.UseVisualStyleBackColor = false;
            this.AplicaEfect.Click += new System.EventHandler(this.AplicaEfect_Click);
            // 
            // radioNegativ
            // 
            this.radioNegativ.AutoSize = true;
            this.radioNegativ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioNegativ.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.radioNegativ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.radioNegativ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNegativ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioNegativ.Location = new System.Drawing.Point(811, 545);
            this.radioNegativ.Name = "radioNegativ";
            this.radioNegativ.Size = new System.Drawing.Size(75, 19);
            this.radioNegativ.TabIndex = 17;
            this.radioNegativ.TabStop = true;
            this.radioNegativ.Text = "Negativ";
            this.radioNegativ.UseVisualStyleBackColor = true;
            // 
            // radioGrayscale
            // 
            this.radioGrayscale.AutoSize = true;
            this.radioGrayscale.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioGrayscale.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.radioGrayscale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.radioGrayscale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGrayscale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioGrayscale.Location = new System.Drawing.Point(811, 517);
            this.radioGrayscale.Name = "radioGrayscale";
            this.radioGrayscale.Size = new System.Drawing.Size(91, 19);
            this.radioGrayscale.TabIndex = 16;
            this.radioGrayscale.TabStop = true;
            this.radioGrayscale.Text = "Grayscale";
            this.radioGrayscale.UseVisualStyleBackColor = true;
            // 
            // radioSepia
            // 
            this.radioSepia.AutoSize = true;
            this.radioSepia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioSepia.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.radioSepia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.radioSepia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSepia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioSepia.Location = new System.Drawing.Point(811, 489);
            this.radioSepia.Name = "radioSepia";
            this.radioSepia.Size = new System.Drawing.Size(62, 19);
            this.radioSepia.TabIndex = 15;
            this.radioSepia.TabStop = true;
            this.radioSepia.Text = "Sepia";
            this.radioSepia.UseVisualStyleBackColor = true;
            // 
            // PictureEditor
            // 
            this.PictureEditor.BackColor = System.Drawing.Color.White;
            this.PictureEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureEditor.Location = new System.Drawing.Point(6, 4);
            this.PictureEditor.Name = "PictureEditor";
            this.PictureEditor.Size = new System.Drawing.Size(784, 441);
            this.PictureEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureEditor.TabIndex = 14;
            this.PictureEditor.TabStop = false;
            // 
            // RestabilesteImagine
            // 
            this.RestabilesteImagine.BackColor = System.Drawing.Color.Gray;
            this.RestabilesteImagine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestabilesteImagine.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RestabilesteImagine.FlatAppearance.BorderSize = 0;
            this.RestabilesteImagine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.RestabilesteImagine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestabilesteImagine.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestabilesteImagine.ForeColor = System.Drawing.Color.White;
            this.RestabilesteImagine.Location = new System.Drawing.Point(811, 86);
            this.RestabilesteImagine.Name = "RestabilesteImagine";
            this.RestabilesteImagine.Size = new System.Drawing.Size(254, 35);
            this.RestabilesteImagine.TabIndex = 13;
            this.RestabilesteImagine.Text = "Restabileste imaginea";
            this.RestabilesteImagine.UseVisualStyleBackColor = false;
            this.RestabilesteImagine.Click += new System.EventHandler(this.RestabilireImagine_onClick);
            // 
            // SalvareEditare
            // 
            this.SalvareEditare.BackColor = System.Drawing.Color.Gray;
            this.SalvareEditare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvareEditare.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SalvareEditare.FlatAppearance.BorderSize = 0;
            this.SalvareEditare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.SalvareEditare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalvareEditare.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvareEditare.ForeColor = System.Drawing.Color.White;
            this.SalvareEditare.Location = new System.Drawing.Point(811, 45);
            this.SalvareEditare.Name = "SalvareEditare";
            this.SalvareEditare.Size = new System.Drawing.Size(254, 35);
            this.SalvareEditare.TabIndex = 12;
            this.SalvareEditare.Text = "Salveaza editarea";
            this.SalvareEditare.UseVisualStyleBackColor = false;
            this.SalvareEditare.Click += new System.EventHandler(this.SalveazaImaginea_onClick);
            // 
            // AnulareEditare
            // 
            this.AnulareEditare.BackColor = System.Drawing.Color.Gray;
            this.AnulareEditare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnulareEditare.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AnulareEditare.FlatAppearance.BorderSize = 0;
            this.AnulareEditare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.AnulareEditare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnulareEditare.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnulareEditare.ForeColor = System.Drawing.Color.White;
            this.AnulareEditare.Location = new System.Drawing.Point(811, 4);
            this.AnulareEditare.Name = "AnulareEditare";
            this.AnulareEditare.Size = new System.Drawing.Size(254, 35);
            this.AnulareEditare.TabIndex = 11;
            this.AnulareEditare.Text = "Anuleaza editarea";
            this.AnulareEditare.UseVisualStyleBackColor = false;
            this.AnulareEditare.Click += new System.EventHandler(this.AnuleazaEditarea_onClick);
            // 
            // ButonADD
            // 
            this.ButonADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButonADD.Image = global::EditorPoze.Properties.Resources.AddImage;
            this.ButonADD.Location = new System.Drawing.Point(447, 149);
            this.ButonADD.Name = "ButonADD";
            this.ButonADD.Size = new System.Drawing.Size(180, 180);
            this.ButonADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButonADD.TabIndex = 0;
            this.ButonADD.TabStop = false;
            this.ButonADD.Click += new System.EventHandler(this.ButonADD_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1100, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButonADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorPoze";
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSaturatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLuminozitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButonADD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ButonADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AnulareEditare;
        private System.Windows.Forms.Button RestabilesteImagine;
        private System.Windows.Forms.Button SalvareEditare;
        private System.Windows.Forms.PictureBox PictureEditor;
        private System.Windows.Forms.RadioButton radioNegativ;
        private System.Windows.Forms.RadioButton radioGrayscale;
        private System.Windows.Forms.RadioButton radioSepia;
        private System.Windows.Forms.Button AplicaEfect;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TrackBar trackSaturatie;
        private System.Windows.Forms.TrackBar trackContrast;
        private System.Windows.Forms.TrackBar trackLuminozitate;
        private System.Windows.Forms.Label ValoareSat;
        private System.Windows.Forms.Label ValoareCon;
        private System.Windows.Forms.Label ValoareLum;
        private System.Windows.Forms.RadioButton radioPolaroid;
    }
}

