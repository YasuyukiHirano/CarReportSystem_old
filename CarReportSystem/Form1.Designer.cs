﻿namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbForeigncar = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.cbRecorder = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.btdgvadd = new System.Windows.Forms.Button();
            this.btdgvFix = new System.Windows.Forms.Button();
            this.btdgvDelete = new System.Windows.Forms.Button();
            this.btdvgOpen = new System.Windows.Forms.Button();
            this.btDgvSave = new System.Windows.Forms.Button();
            this.btdgvClose = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dgvCarData = new System.Windows.Forms.DataGridView();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.btOpenImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 19);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "日付:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "記録者:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "メーカー:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(27, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "車名:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(27, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "レポート:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(27, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "記事一覧:";
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(0, 18);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 2;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(53, 18);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 2;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(106, 18);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 2;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(163, 18);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 2;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbForeigncar
            // 
            this.rbForeigncar.AutoSize = true;
            this.rbForeigncar.Location = new System.Drawing.Point(221, 17);
            this.rbForeigncar.Name = "rbForeigncar";
            this.rbForeigncar.Size = new System.Drawing.Size(47, 16);
            this.rbForeigncar.TabIndex = 2;
            this.rbForeigncar.TabStop = true;
            this.rbForeigncar.Text = "外車";
            this.rbForeigncar.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(274, 17);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 2;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // cbRecorder
            // 
            this.cbRecorder.FormattingEnabled = true;
            this.cbRecorder.Location = new System.Drawing.Point(119, 62);
            this.cbRecorder.Name = "cbRecorder";
            this.cbRecorder.Size = new System.Drawing.Size(328, 20);
            this.cbRecorder.TabIndex = 3;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(119, 141);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(328, 20);
            this.cbName.TabIndex = 3;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(119, 182);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(328, 100);
            this.tbReport.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(476, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "画像:";
            // 
            // btImageDelete
            // 
            this.btImageDelete.Location = new System.Drawing.Point(664, 11);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 30);
            this.btImageDelete.TabIndex = 6;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // btdgvadd
            // 
            this.btdgvadd.Location = new System.Drawing.Point(362, 513);
            this.btdgvadd.Name = "btdgvadd";
            this.btdgvadd.Size = new System.Drawing.Size(85, 30);
            this.btdgvadd.TabIndex = 7;
            this.btdgvadd.Text = "追加";
            this.btdgvadd.UseVisualStyleBackColor = true;
            this.btdgvadd.Click += new System.EventHandler(this.btdgvadd_Click);
            // 
            // btdgvFix
            // 
            this.btdgvFix.Location = new System.Drawing.Point(465, 513);
            this.btdgvFix.Name = "btdgvFix";
            this.btdgvFix.Size = new System.Drawing.Size(81, 30);
            this.btdgvFix.TabIndex = 8;
            this.btdgvFix.Text = "修正";
            this.btdgvFix.UseVisualStyleBackColor = true;
            this.btdgvFix.Click += new System.EventHandler(this.btdgvFix_Click);
            // 
            // btdgvDelete
            // 
            this.btdgvDelete.Location = new System.Drawing.Point(565, 513);
            this.btdgvDelete.Name = "btdgvDelete";
            this.btdgvDelete.Size = new System.Drawing.Size(80, 30);
            this.btdgvDelete.TabIndex = 9;
            this.btdgvDelete.Text = "削除";
            this.btdgvDelete.UseVisualStyleBackColor = true;
            this.btdgvDelete.Click += new System.EventHandler(this.btdgvDelete_Click);
            // 
            // btdvgOpen
            // 
            this.btdvgOpen.Location = new System.Drawing.Point(27, 356);
            this.btdvgOpen.Name = "btdvgOpen";
            this.btdvgOpen.Size = new System.Drawing.Size(75, 30);
            this.btdvgOpen.TabIndex = 10;
            this.btdvgOpen.Text = "開く";
            this.btdvgOpen.UseVisualStyleBackColor = true;
            this.btdvgOpen.Click += new System.EventHandler(this.btdvgOpen_Click);
            // 
            // btDgvSave
            // 
            this.btDgvSave.Location = new System.Drawing.Point(27, 411);
            this.btDgvSave.Name = "btDgvSave";
            this.btDgvSave.Size = new System.Drawing.Size(75, 30);
            this.btDgvSave.TabIndex = 11;
            this.btDgvSave.Text = "保存";
            this.btDgvSave.UseVisualStyleBackColor = true;
            this.btDgvSave.Click += new System.EventHandler(this.btDgvSave_Click);
            // 
            // btdgvClose
            // 
            this.btdgvClose.Location = new System.Drawing.Point(664, 513);
            this.btdgvClose.Name = "btdgvClose";
            this.btdgvClose.Size = new System.Drawing.Size(75, 30);
            this.btdgvClose.TabIndex = 12;
            this.btdgvClose.Text = "終了";
            this.btdgvClose.UseVisualStyleBackColor = true;
            this.btdgvClose.Click += new System.EventHandler(this.btdgvClose_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbImage.Location = new System.Drawing.Point(479, 47);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(260, 235);
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // dgvCarData
            // 
            this.dgvCarData.AllowUserToAddRows = false;
            this.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarData.Location = new System.Drawing.Point(119, 307);
            this.dgvCarData.MultiSelect = false;
            this.dgvCarData.Name = "dgvCarData";
            this.dgvCarData.RowTemplate.Height = 21;
            this.dgvCarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarData.Size = new System.Drawing.Size(620, 200);
            this.dgvCarData.TabIndex = 14;
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbForeigncar);
            this.groupBox1.Controls.Add(this.rbSubaru);
            this.groupBox1.Controls.Add(this.rbToyota);
            this.groupBox1.Controls.Add(this.rbNissan);
            this.groupBox1.Controls.Add(this.rbHonda);
            this.groupBox1.Location = new System.Drawing.Point(119, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 47);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // btOpenImage
            // 
            this.btOpenImage.Location = new System.Drawing.Point(570, 11);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(75, 30);
            this.btOpenImage.TabIndex = 0;
            this.btOpenImage.Text = "開く";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 555);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCarData);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btdgvClose);
            this.Controls.Add(this.btDgvSave);
            this.Controls.Add(this.btdvgOpen);
            this.Controls.Add(this.btdgvDelete);
            this.Controls.Add(this.btdgvFix);
            this.Controls.Add(this.btdgvadd);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbRecorder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbForeigncar;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.ComboBox cbRecorder;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.Button btdgvadd;
        private System.Windows.Forms.Button btdgvFix;
        private System.Windows.Forms.Button btdgvDelete;
        private System.Windows.Forms.Button btdvgOpen;
        private System.Windows.Forms.Button btDgvSave;
        private System.Windows.Forms.Button btdgvClose;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DataGridView dgvCarData;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.Button btOpenImage;
    }
}

