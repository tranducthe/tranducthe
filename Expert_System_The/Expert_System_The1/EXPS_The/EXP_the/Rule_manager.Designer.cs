namespace ExpertSystem_The
{
    partial class Rule_manager
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
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.txtmaluat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataluat = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataluat)).BeginInit();
            this.SuspendLayout();
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.Location = new System.Drawing.Point(603, 22);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(100, 29);
            this.btntimkiem.TabIndex = 17;
            this.btntimkiem.Text = "Поиск";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(405, 22);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(166, 20);
            this.txttimkiem.TabIndex = 16;
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(632, 305);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(90, 29);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Delete";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Location = new System.Drawing.Point(516, 305);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 29);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Edit";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(401, 305);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(90, 29);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Add";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(551, 196);
            this.txtnoidung.Margin = new System.Windows.Forms.Padding(4);
            this.txtnoidung.Multiline = true;
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(171, 64);
            this.txtnoidung.TabIndex = 12;
            // 
            // txtmaluat
            // 
            this.txtmaluat.Location = new System.Drawing.Point(551, 144);
            this.txtmaluat.Name = "txtmaluat";
            this.txtmaluat.Size = new System.Drawing.Size(171, 20);
            this.txtmaluat.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(402, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "содержание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(402, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Кодекс закона";
            // 
            // dataluat
            // 
            this.dataluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataluat.Location = new System.Drawing.Point(2, 2);
            this.dataluat.Name = "dataluat";
            this.dataluat.Size = new System.Drawing.Size(351, 402);
            this.dataluat.TabIndex = 8;
            this.dataluat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataluat_CellClick);
            this.dataluat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataluat_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(742, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rule_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtnoidung);
            this.Controls.Add(this.txtmaluat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataluat);
            this.Name = "Rule_manager";
            this.Text = "Rule_management";
            this.Load += new System.EventHandler(this.quanlyluat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataluat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.TextBox txtmaluat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataluat;
        private System.Windows.Forms.Button button1;
    }
}