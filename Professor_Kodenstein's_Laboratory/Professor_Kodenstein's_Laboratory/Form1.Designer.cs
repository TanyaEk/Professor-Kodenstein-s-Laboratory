namespace Professor_Kodenstein_s_Laboratory
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
            txt_Ingredient = new TextBox();
            btn_AddIngredient = new Button();
            list_BoxIngredients = new ListBox();
            btn_BrewPotion = new Button();
            lbl_Result = new Label();
            SuspendLayout();
            // 
            // txt_Ingredient
            // 
            txt_Ingredient.BackColor = Color.Honeydew;
            txt_Ingredient.Font = new Font("Comic Sans MS", 8.25F);
            txt_Ingredient.Location = new Point(20, 20);
            txt_Ingredient.Name = "txt_Ingredient";
            txt_Ingredient.Size = new Size(200, 23);
            txt_Ingredient.TabIndex = 0;
            // 
            // btn_AddIngredient
            // 
            btn_AddIngredient.BackColor = Color.PaleGreen;
            btn_AddIngredient.FlatStyle = FlatStyle.Flat;
            btn_AddIngredient.Font = new Font("Comic Sans MS", 8.25F);
            btn_AddIngredient.Location = new Point(20, 60);
            btn_AddIngredient.Name = "btn_AddIngredient";
            btn_AddIngredient.Size = new Size(200, 23);
            btn_AddIngredient.TabIndex = 1;
            btn_AddIngredient.Text = "Добави съставка";
            btn_AddIngredient.UseVisualStyleBackColor = false;
            btn_AddIngredient.Click += btn_AddIngredient_Click;
            // 
            // list_BoxIngredients
            // 
            list_BoxIngredients.BackColor = Color.Honeydew;
            list_BoxIngredients.Font = new Font("Comic Sans MS", 8.25F);
            list_BoxIngredients.FormattingEnabled = true;
            list_BoxIngredients.ItemHeight = 15;
            list_BoxIngredients.Location = new Point(250, 20);
            list_BoxIngredients.Name = "list_BoxIngredients";
            list_BoxIngredients.Size = new Size(200, 139);
            list_BoxIngredients.TabIndex = 2;
            // 
            // btn_BrewPotion
            // 
            btn_BrewPotion.BackColor = Color.PaleGreen;
            btn_BrewPotion.FlatStyle = FlatStyle.Flat;
            btn_BrewPotion.Font = new Font("Comic Sans MS", 8.25F);
            btn_BrewPotion.Location = new Point(250, 180);
            btn_BrewPotion.Name = "btn_BrewPotion";
            btn_BrewPotion.Size = new Size(200, 23);
            btn_BrewPotion.TabIndex = 3;
            btn_BrewPotion.Text = "Свари отварата!";
            btn_BrewPotion.UseVisualStyleBackColor = false;
            btn_BrewPotion.Click += btn_BrewPotion_Click;
            // 
            // lbl_Result
            // 
            lbl_Result.BackColor = Color.Honeydew;
            lbl_Result.BorderStyle = BorderStyle.FixedSingle;
            lbl_Result.Font = new Font("Comic Sans MS", 9F);
            lbl_Result.ForeColor = Color.DarkGreen;
            lbl_Result.Location = new Point(20, 250);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(430, 40);
            lbl_Result.TabIndex = 4;
            lbl_Result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.UDH;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 397);
            Controls.Add(lbl_Result);
            Controls.Add(btn_BrewPotion);
            Controls.Add(list_BoxIngredients);
            Controls.Add(btn_AddIngredient);
            Controls.Add(txt_Ingredient);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Ingredient;
        private Button btn_AddIngredient;
        private ListBox list_BoxIngredients;
        private Button btn_BrewPotion;
        private Label lbl_Result;
    }
}
