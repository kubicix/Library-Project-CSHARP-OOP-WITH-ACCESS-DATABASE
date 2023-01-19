namespace LibraryProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookname = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioNew = new System.Windows.Forms.RadioButton();
            this.radioUsed = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(-5, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name:";
            // 
            // txtBookname
            // 
            this.txtBookname.Location = new System.Drawing.Point(115, 47);
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(193, 29);
            this.txtBookname.TabIndex = 2;
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(115, 85);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(193, 29);
            this.txtWriter.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Writer:";
            // 
            // txtpages
            // 
            this.txtpages.Location = new System.Drawing.Point(115, 120);
            this.txtpages.Name = "txtpages";
            this.txtpages.Size = new System.Drawing.Size(193, 29);
            this.txtpages.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pages:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(115, 155);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(193, 31);
            this.cmbType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(52, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type:";
            // 
            // radioNew
            // 
            this.radioNew.AutoSize = true;
            this.radioNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioNew.Location = new System.Drawing.Point(115, 189);
            this.radioNew.Name = "radioNew";
            this.radioNew.Size = new System.Drawing.Size(123, 27);
            this.radioNew.TabIndex = 9;
            this.radioNew.TabStop = true;
            this.radioNew.Text = "Brand New";
            this.radioNew.UseVisualStyleBackColor = false;
            // 
            // radioUsed
            // 
            this.radioUsed.AutoSize = true;
            this.radioUsed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioUsed.Location = new System.Drawing.Point(238, 189);
            this.radioUsed.Name = "radioUsed";
            this.radioUsed.Size = new System.Drawing.Size(70, 27);
            this.radioUsed.TabIndex = 10;
            this.radioUsed.TabStop = true;
            this.radioUsed.Text = "Used";
            this.radioUsed.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(9, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Condition:";
            // 
            // txtBookid
            // 
            this.txtBookid.Location = new System.Drawing.Point(115, 12);
            this.txtBookid.Name = "txtBookid";
            this.txtBookid.Size = new System.Drawing.Size(193, 29);
            this.txtBookid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(25, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Book ID:";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnList.Location = new System.Drawing.Point(333, 26);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(148, 42);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(333, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 42);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(333, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 42);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(333, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 42);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 486);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtBookid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioUsed);
            this.Controls.Add(this.radioNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtpages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookname;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioNew;
        private System.Windows.Forms.RadioButton radioUsed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

