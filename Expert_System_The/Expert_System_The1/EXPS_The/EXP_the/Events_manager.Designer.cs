namespace ExpertSystem_The
{
    partial class Events_manager
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
            this.datasukien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmask = new System.Windows.Forms.TextBox();
            this.txtmotask = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoaiSK = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datasukien)).BeginInit();
            this.SuspendLayout();
            // 
            // datasukien
            // 
            this.datasukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasukien.Location = new System.Drawing.Point(0, 0);
            this.datasukien.Name = "datasukien";
            this.datasukien.Size = new System.Drawing.Size(390, 402);
            this.datasukien.TabIndex = 0;
            this.datasukien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datasukien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(426, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "код события";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(426, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // txtmask
            // 
            this.txtmask.Location = new System.Drawing.Point(542, 126);
            this.txtmask.Name = "txtmask";
            this.txtmask.Size = new System.Drawing.Size(171, 20);
            this.txtmask.TabIndex = 3;
            // 
            // txtmotask
            // 
            this.txtmotask.Location = new System.Drawing.Point(542, 176);
            this.txtmotask.Margin = new System.Windows.Forms.Padding(4);
            this.txtmotask.Multiline = true;
            this.txtmotask.Name = "txtmotask";
            this.txtmotask.Size = new System.Drawing.Size(171, 64);
            this.txtmotask.TabIndex = 4;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(414, 321);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(90, 29);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Add";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Location = new System.Drawing.Point(524, 321);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 29);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Edit";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(634, 321);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(90, 29);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Delete";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(427, 40);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(166, 20);
            this.txttimkiem.TabIndex = 6;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.Location = new System.Drawing.Point(625, 40);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(100, 29);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Поиск";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(424, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Тип события";
            // 
            // cmbLoaiSK
            // 
            this.cmbLoaiSK.FormattingEnabled = true;
            this.cmbLoaiSK.Location = new System.Drawing.Point(542, 261);
            this.cmbLoaiSK.Name = "cmbLoaiSK";
            this.cmbLoaiSK.Size = new System.Drawing.Size(171, 21);
            this.cmbLoaiSK.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(741, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Events_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbLoaiSK);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmotask);
            this.Controls.Add(this.txtmask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datasukien);
            this.Name = "Events_manager";
            this.Text = "Event_management";
            this.Load += new System.EventHandler(this.quanlysukien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasukien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datasukien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmask;
        private System.Windows.Forms.TextBox txtmotask;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiSK;
        private System.Windows.Forms.Button button1;
    }
}