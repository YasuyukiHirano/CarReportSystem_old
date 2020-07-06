namespace CarReportSystem
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.cbRecorder = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.btdgvadd = new System.Windows.Forms.Button();
            this.btdgvFix = new System.Windows.Forms.Button();
            this.btdgvDelete = new System.Windows.Forms.Button();
            this.btdvgOpen = new System.Windows.Forms.Button();
            this.btDgvSave = new System.Windows.Forms.Button();
            this.btdgvClose = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dgvCarData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(119, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "トヨタ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(172, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "日産";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(225, 103);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ホンダ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(278, 103);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 16);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "スバル";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(340, 103);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "外車";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(393, 103);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 16);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "その他";
            this.radioButton6.UseVisualStyleBackColor = true;
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
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(569, 12);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 30);
            this.btImageOpen.TabIndex = 5;
            this.btImageOpen.Text = "開く";
            this.btImageOpen.UseVisualStyleBackColor = true;
            // 
            // btImageDelete
            // 
            this.btImageDelete.Location = new System.Drawing.Point(664, 11);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 30);
            this.btImageDelete.TabIndex = 6;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            // 
            // btdgvadd
            // 
            this.btdgvadd.Location = new System.Drawing.Point(362, 513);
            this.btdgvadd.Name = "btdgvadd";
            this.btdgvadd.Size = new System.Drawing.Size(85, 30);
            this.btdgvadd.TabIndex = 7;
            this.btdgvadd.Text = "追加";
            this.btdgvadd.UseVisualStyleBackColor = true;
            // 
            // btdgvFix
            // 
            this.btdgvFix.Location = new System.Drawing.Point(465, 513);
            this.btdgvFix.Name = "btdgvFix";
            this.btdgvFix.Size = new System.Drawing.Size(81, 30);
            this.btdgvFix.TabIndex = 8;
            this.btdgvFix.Text = "修正";
            this.btdgvFix.UseVisualStyleBackColor = true;
            // 
            // btdgvDelete
            // 
            this.btdgvDelete.Location = new System.Drawing.Point(565, 513);
            this.btdgvDelete.Name = "btdgvDelete";
            this.btdgvDelete.Size = new System.Drawing.Size(80, 30);
            this.btdgvDelete.TabIndex = 9;
            this.btdgvDelete.Text = "削除";
            this.btdgvDelete.UseVisualStyleBackColor = true;
            // 
            // btdvgOpen
            // 
            this.btdvgOpen.Location = new System.Drawing.Point(27, 356);
            this.btdvgOpen.Name = "btdvgOpen";
            this.btdvgOpen.Size = new System.Drawing.Size(75, 30);
            this.btdvgOpen.TabIndex = 10;
            this.btdvgOpen.Text = "開く";
            this.btdvgOpen.UseVisualStyleBackColor = true;
            // 
            // btDgvSave
            // 
            this.btDgvSave.Location = new System.Drawing.Point(27, 411);
            this.btDgvSave.Name = "btDgvSave";
            this.btDgvSave.Size = new System.Drawing.Size(75, 30);
            this.btDgvSave.TabIndex = 11;
            this.btDgvSave.Text = "保存";
            this.btDgvSave.UseVisualStyleBackColor = true;
            // 
            // btdgvClose
            // 
            this.btdgvClose.Location = new System.Drawing.Point(664, 513);
            this.btdgvClose.Name = "btdgvClose";
            this.btdgvClose.Size = new System.Drawing.Size(75, 30);
            this.btdgvClose.TabIndex = 12;
            this.btdgvClose.Text = "終了";
            this.btdgvClose.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(479, 47);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(260, 235);
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // dgvCarData
            // 
            this.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarData.Location = new System.Drawing.Point(119, 307);
            this.dgvCarData.Name = "dgvCarData";
            this.dgvCarData.RowTemplate.Height = 21;
            this.dgvCarData.Size = new System.Drawing.Size(620, 200);
            this.dgvCarData.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 555);
            this.Controls.Add(this.dgvCarData);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btdgvClose);
            this.Controls.Add(this.btDgvSave);
            this.Controls.Add(this.btdvgOpen);
            this.Controls.Add(this.btdgvDelete);
            this.Controls.Add(this.btdgvFix);
            this.Controls.Add(this.btdgvadd);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbRecorder);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.ComboBox cbRecorder;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.Button btdgvadd;
        private System.Windows.Forms.Button btdgvFix;
        private System.Windows.Forms.Button btdgvDelete;
        private System.Windows.Forms.Button btdvgOpen;
        private System.Windows.Forms.Button btDgvSave;
        private System.Windows.Forms.Button btdgvClose;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DataGridView dgvCarData;
    }
}

