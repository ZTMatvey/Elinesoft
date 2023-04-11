namespace Elinesoft
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
            BinanceLabel = new Label();
            BybitLabel = new Label();
            KucoinLabel = new Label();
            SuspendLayout();
            // 
            // BinanceLabel
            // 
            BinanceLabel.AutoSize = true;
            BinanceLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BinanceLabel.Location = new Point(18, 9);
            BinanceLabel.Margin = new Padding(9, 0, 9, 0);
            BinanceLabel.Name = "BinanceLabel";
            BinanceLabel.Size = new Size(161, 54);
            BinanceLabel.TabIndex = 0;
            BinanceLabel.Text = "Binance";
            // 
            // BybitLabel
            // 
            BybitLabel.AutoSize = true;
            BybitLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BybitLabel.Location = new Point(18, 63);
            BybitLabel.Margin = new Padding(9, 0, 9, 0);
            BybitLabel.Name = "BybitLabel";
            BybitLabel.Size = new Size(113, 54);
            BybitLabel.TabIndex = 1;
            BybitLabel.Text = "Bybit";
            // 
            // KucoinLabel
            // 
            KucoinLabel.AutoSize = true;
            KucoinLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            KucoinLabel.Location = new Point(18, 117);
            KucoinLabel.Margin = new Padding(9, 0, 9, 0);
            KucoinLabel.Name = "KucoinLabel";
            KucoinLabel.Size = new Size(143, 54);
            KucoinLabel.TabIndex = 2;
            KucoinLabel.Text = "Kucoin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(23F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 333);
            Controls.Add(KucoinLabel);
            Controls.Add(BybitLabel);
            Controls.Add(BinanceLabel);
            Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(9);
            Name = "Form1";
            Text = "Курс биткоина";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BinanceLabel;
        private Label BybitLabel;
        private Label KucoinLabel;
    }
}