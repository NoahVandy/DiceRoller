namespace DiceRoller
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
            this.btn_rollDice = new System.Windows.Forms.Button();
            this.lbl_d1Value = new System.Windows.Forms.Label();
            this.lbl_d2Value = new System.Windows.Forms.Label();
            this.numUpDown_sides = new System.Windows.Forms.NumericUpDown();
            this.lbl_numOfSides = new System.Windows.Forms.Label();
            this.lbl_numOfTries = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_sides)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rollDice
            // 
            this.btn_rollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rollDice.Location = new System.Drawing.Point(55, 109);
            this.btn_rollDice.Name = "btn_rollDice";
            this.btn_rollDice.Size = new System.Drawing.Size(313, 265);
            this.btn_rollDice.TabIndex = 0;
            this.btn_rollDice.Text = "Roll Dice";
            this.btn_rollDice.UseVisualStyleBackColor = true;
            this.btn_rollDice.Click += new System.EventHandler(this.btn_rollDice_Click);
            // 
            // lbl_d1Value
            // 
            this.lbl_d1Value.AutoSize = true;
            this.lbl_d1Value.BackColor = System.Drawing.Color.White;
            this.lbl_d1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_d1Value.ForeColor = System.Drawing.Color.Black;
            this.lbl_d1Value.Location = new System.Drawing.Point(427, 142);
            this.lbl_d1Value.Name = "lbl_d1Value";
            this.lbl_d1Value.Size = new System.Drawing.Size(166, 181);
            this.lbl_d1Value.TabIndex = 1;
            this.lbl_d1Value.Text = "0\r\n";
            // 
            // lbl_d2Value
            // 
            this.lbl_d2Value.AutoSize = true;
            this.lbl_d2Value.BackColor = System.Drawing.Color.White;
            this.lbl_d2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_d2Value.ForeColor = System.Drawing.Color.Black;
            this.lbl_d2Value.Location = new System.Drawing.Point(632, 142);
            this.lbl_d2Value.Name = "lbl_d2Value";
            this.lbl_d2Value.Size = new System.Drawing.Size(166, 181);
            this.lbl_d2Value.TabIndex = 2;
            this.lbl_d2Value.Text = "0\r\n";
            // 
            // numUpDown_sides
            // 
            this.numUpDown_sides.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_sides.Location = new System.Drawing.Point(73, 482);
            this.numUpDown_sides.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDown_sides.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDown_sides.Name = "numUpDown_sides";
            this.numUpDown_sides.Size = new System.Drawing.Size(120, 45);
            this.numUpDown_sides.TabIndex = 3;
            this.numUpDown_sides.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDown_sides.ValueChanged += new System.EventHandler(this.numUpDown_sides_ValueChanged);
            // 
            // lbl_numOfSides
            // 
            this.lbl_numOfSides.AutoSize = true;
            this.lbl_numOfSides.ForeColor = System.Drawing.Color.White;
            this.lbl_numOfSides.Location = new System.Drawing.Point(301, 489);
            this.lbl_numOfSides.Name = "lbl_numOfSides";
            this.lbl_numOfSides.Size = new System.Drawing.Size(251, 32);
            this.lbl_numOfSides.TabIndex = 4;
            this.lbl_numOfSides.Text = "Number of sides: 4";
            // 
            // lbl_numOfTries
            // 
            this.lbl_numOfTries.AutoSize = true;
            this.lbl_numOfTries.ForeColor = System.Drawing.Color.White;
            this.lbl_numOfTries.Location = new System.Drawing.Point(570, 489);
            this.lbl_numOfTries.Name = "lbl_numOfTries";
            this.lbl_numOfTries.Size = new System.Drawing.Size(222, 32);
            this.lbl_numOfTries.TabIndex = 5;
            this.lbl_numOfTries.Text = "Number of tries: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(922, 597);
            this.Controls.Add(this.lbl_numOfTries);
            this.Controls.Add(this.lbl_numOfSides);
            this.Controls.Add(this.numUpDown_sides);
            this.Controls.Add(this.lbl_d2Value);
            this.Controls.Add(this.lbl_d1Value);
            this.Controls.Add(this.btn_rollDice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_sides)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rollDice;
        private System.Windows.Forms.Label lbl_d1Value;
        private System.Windows.Forms.Label lbl_d2Value;
        private System.Windows.Forms.NumericUpDown numUpDown_sides;
        private System.Windows.Forms.Label lbl_numOfSides;
        private System.Windows.Forms.Label lbl_numOfTries;
    }
}

