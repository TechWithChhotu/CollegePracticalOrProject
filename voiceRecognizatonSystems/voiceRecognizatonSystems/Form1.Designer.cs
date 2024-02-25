namespace voiceRecognizatonSystems
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextToSpeech = new System.Windows.Forms.TextBox();
            this.SpeechToText = new System.Windows.Forms.TextBox();
            this.ClickToListen = new System.Windows.Forms.Button();
            this.ClickToSpeak = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text To Speech";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(670, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speech To Text";
            // 
            // TextToSpeech
            // 
            this.TextToSpeech.AccessibleName = "textToSpeachTxt";
            this.TextToSpeech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextToSpeech.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextToSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextToSpeech.Location = new System.Drawing.Point(12, 175);
            this.TextToSpeech.Multiline = true;
            this.TextToSpeech.Name = "TextToSpeech";
            this.TextToSpeech.Size = new System.Drawing.Size(870, 499);
            this.TextToSpeech.TabIndex = 3;
            // 
            // SpeechToText
            // 
            this.SpeechToText.AccessibleName = "TextBox2";
            this.SpeechToText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SpeechToText.BackColor = System.Drawing.Color.Silver;
            this.SpeechToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeechToText.ForeColor = System.Drawing.Color.Black;
            this.SpeechToText.Location = new System.Drawing.Point(150, 175);
            this.SpeechToText.Multiline = true;
            this.SpeechToText.Name = "SpeechToText";
            this.SpeechToText.Size = new System.Drawing.Size(879, 499);
            this.SpeechToText.TabIndex = 4;
            // 
            // ClickToListen
            // 
            this.ClickToListen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClickToListen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClickToListen.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickToListen.ForeColor = System.Drawing.Color.White;
            this.ClickToListen.Location = new System.Drawing.Point(-63, 704);
            this.ClickToListen.Name = "ClickToListen";
            this.ClickToListen.Size = new System.Drawing.Size(213, 69);
            this.ClickToListen.TabIndex = 5;
            this.ClickToListen.Text = "Click To Listen";
            this.ClickToListen.UseVisualStyleBackColor = false;
            this.ClickToListen.Click += new System.EventHandler(this.ClickToListen_Click);
            // 
            // ClickToSpeak
            // 
            this.ClickToSpeak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClickToSpeak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClickToSpeak.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickToSpeak.ForeColor = System.Drawing.Color.White;
            this.ClickToSpeak.Location = new System.Drawing.Point(787, 704);
            this.ClickToSpeak.Name = "ClickToSpeak";
            this.ClickToSpeak.Size = new System.Drawing.Size(213, 69);
            this.ClickToSpeak.TabIndex = 6;
            this.ClickToSpeak.Text = "Click To Speak";
            this.ClickToSpeak.UseVisualStyleBackColor = false;
            this.ClickToSpeak.Click += new System.EventHandler(this.ClickToSpeack_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar1.Location = new System.Drawing.Point(150, 704);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(195, 69);
            this.trackBar1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(753, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 116);
            this.label3.TabIndex = 8;
            this.label3.Text = "Text App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(26)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1041, 779);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ClickToSpeak);
            this.Controls.Add(this.ClickToListen);
            this.Controls.Add(this.SpeechToText);
            this.Controls.Add(this.TextToSpeech);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Text App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextToSpeech;
        private System.Windows.Forms.TextBox SpeechToText;
        private System.Windows.Forms.Button ClickToListen;
        private System.Windows.Forms.Button ClickToSpeak;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
    }
}

