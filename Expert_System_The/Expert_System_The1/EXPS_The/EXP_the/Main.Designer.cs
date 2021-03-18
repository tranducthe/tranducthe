namespace ExpertSystem_The
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
            this.btnsukien = new System.Windows.Forms.Button();
            this.btnluat = new System.Windows.Forms.Button();
            this.btntuvan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsukien
            // 
            this.btnsukien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsukien.Location = new System.Drawing.Point(112, 381);
            this.btnsukien.Name = "btnsukien";
            this.btnsukien.Size = new System.Drawing.Size(123, 57);
            this.btnsukien.TabIndex = 0;
            this.btnsukien.Text = "событие";
            this.btnsukien.UseVisualStyleBackColor = true;
            this.btnsukien.Click += new System.EventHandler(this.btnsukien_Click);
            // 
            // btnluat
            // 
            this.btnluat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluat.Location = new System.Drawing.Point(264, 381);
            this.btnluat.Name = "btnluat";
            this.btnluat.Size = new System.Drawing.Size(123, 57);
            this.btnluat.TabIndex = 0;
            this.btnluat.Text = "закон";
            this.btnluat.UseVisualStyleBackColor = true;
            this.btnluat.Click += new System.EventHandler(this.btnluat_Click);
            // 
            // btntuvan
            // 
            this.btntuvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntuvan.Location = new System.Drawing.Point(415, 381);
            this.btntuvan.Name = "btntuvan";
            this.btntuvan.Size = new System.Drawing.Size(180, 57);
            this.btntuvan.TabIndex = 0;
            this.btntuvan.Text = "консультативный";
            this.btntuvan.UseVisualStyleBackColor = true;
            this.btntuvan.Click += new System.EventHandler(this.btntuvan_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(625, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExpertSystem_The.Properties.Resources.anhdep;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntuvan);
            this.Controls.Add(this.btnluat);
            this.Controls.Add(this.btnsukien);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Main";
            this.Text = "Expert_System_The";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsukien;
        private System.Windows.Forms.Button btnluat;
        private System.Windows.Forms.Button btntuvan;
        private System.Windows.Forms.Button button1;
    }
}

