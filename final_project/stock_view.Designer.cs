using Pets;

namespace final_project
{
    partial class stock_view
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.Pets_stock = new System.Windows.Forms.ListBox();
            this.specie2_radio = new System.Windows.Forms.RadioButton();
            this.specie1_radio = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.count_species = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back to options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pets_stock
            // 
            this.Pets_stock.FormattingEnabled = true;
            this.Pets_stock.Location = new System.Drawing.Point(47, 95);
            this.Pets_stock.Name = "Pets_stock";
            this.Pets_stock.Size = new System.Drawing.Size(210, 316);
            this.Pets_stock.TabIndex = 13;
            // 
            // specie2_radio
            // 
            this.specie2_radio.AutoSize = true;
            this.specie2_radio.Location = new System.Drawing.Point(0, 84);
            this.specie2_radio.Name = "specie2_radio";
            this.specie2_radio.Size = new System.Drawing.Size(102, 17);
            this.specie2_radio.TabIndex = 12;
            this.specie2_radio.TabStop = true;
            this.specie2_radio.Text = "GoldenRetriever";
            this.specie2_radio.UseVisualStyleBackColor = true;
            this.specie2_radio.Click += new System.EventHandler(this.specie2_radio_Click);
            // 
            // specie1_radio
            // 
            this.specie1_radio.AutoSize = true;
            this.specie1_radio.Checked = true;
            this.specie1_radio.Location = new System.Drawing.Point(0, 41);
            this.specie1_radio.Name = "specie1_radio";
            this.specie1_radio.Size = new System.Drawing.Size(58, 17);
            this.specie1_radio.TabIndex = 11;
            this.specie1_radio.TabStop = true;
            this.specie1_radio.Text = "Poodle";
            this.specie1_radio.UseVisualStyleBackColor = true;
            this.specie1_radio.Click += new System.EventHandler(this.specie1_radio_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(0, 95);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Fish";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.type_fish_radio_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(0, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cat";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.type_cat_radio_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dog";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.type_dog_radio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "number of species:";
            // 
            // count_species
            // 
            this.count_species.AutoSize = true;
            this.count_species.Location = new System.Drawing.Point(146, 428);
            this.count_species.Name = "count_species";
            this.count_species.Size = new System.Drawing.Size(0, 13);
            this.count_species.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(584, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 118);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.specie2_radio);
            this.groupBox2.Controls.Add(this.specie1_radio);
            this.groupBox2.Location = new System.Drawing.Point(421, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Specie";
            // 
            // stock_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.count_species);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pets_stock);
            this.Controls.Add(this.button1);
            this.Name = "stock_view";
            this.Text = "stock_view";
            this.Load += new System.EventHandler(this.stock_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Pets_stock;
        private System.Windows.Forms.RadioButton specie2_radio;
        private System.Windows.Forms.RadioButton specie1_radio;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label count_species;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}