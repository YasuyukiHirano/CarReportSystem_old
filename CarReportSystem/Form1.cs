using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarReportSystem.CarReport;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> _Cars = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            dgvCarData.DataSource = _Cars;
        }

        private CarReport.CarMeker RadioButtonChecked()
        {
            
            var RadioButtonChecked_InGroup = groupBox1.Controls.OfType<RadioButton>()
                 .SingleOrDefault(rb => rb.Checked == true);

            if(RadioButtonChecked_InGroup == null)
            {
                return CarReportSystem.CarReport.CarMeker.DEFAULT;
            }


            switch(RadioButtonChecked_InGroup.Text)
            {
                case "トヨタ":
                    return CarReport.CarMeker.トヨタ;
                case "日産":
                    return CarReport.CarMeker.日産;
                case "ホンダ":
                    return CarReport.CarMeker.ホンダ;
                case "スバル":
                    return CarReport.CarMeker.スバル;
                case "外車":
                    return CarReport.CarMeker.外車;
                case "その他":
                    return CarReport.CarMeker.その他;
            }
            return 0;
            
            /*foreach (RadioButton item in groupBox1.Controls)
            {
                if (rbToyota.Checked == true)
                {
                    CarReport.CarMeker.トヨタ.ToString();
                }
                else if (rbNissan.Checked == true)
                {
                    CarReport.CarMeker.日産.ToString();
                }
                else if (rbHonda.Checked == true)
                {
                    CarReport.CarMeker.ホンダ.ToString();
                }
                else if (rbSubaru.Checked == true)
                {
                    CarReport.CarMeker.スバル.ToString();
                }
                else if (rbForeigncar.Checked == true)
                {
                    CarReport.CarMeker.外車.ToString();
                }
                else
                {
                    CarReport.CarMeker.その他.ToString();
                }
            }*/
        }

        private void btdgvadd_Click(object sender, EventArgs e) //登録ボタン
        {

            //Carオブジェクトの作成
            CarReport obj = new CarReport
            {
                CreateDate = dateTimePicker1.Value,
                Author = cbRecorder.Text,
                Maker = RadioButtonChecked(),
                Name = cbName.Text,
                Report = tbReport.Text,
                image = pbImage.Image
            };

            //リストの先頭(インデックス0)への追加
            _Cars.Insert(0, obj);

            //追加時にcomboBoxに追加する
            cbRecorder.Items.Add(cbRecorder.Text);
            cbName.Items.Add(cbName.Text);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            initButtons();
        }

        //入力項目を全クリア
        private void inputItemAllClear()
        {
            cbRecorder.Text = "";
            cbName.Text = "";
            tbReport.Text = "";
            pbImage.Image = null;
        }


        private void btDelete_Click(object sender, EventArgs e) //データグリッドビュー削除ボタン
        {
            if (pbImage.Image == null)
                return;
            //メッセージボックスを表示する
            MessageBox.Show("削除してよいですか？",
                "確認",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            {
                pbImage.Image = null;
            }
            _Cars.RemoveAt(dgvCarData.CurrentRow.Index);
            inputItemAllClear();
            dgvCarData.ClearSelection();
        }

        private void btClearImage_Click(object sender, EventArgs e) //画像クリアボタン
        {
            pbImage.Image = null;
        }


        private void btOpenImage_Click(object sender, EventArgs e)  //画像開くボタン
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btImageDelete_Click(object sender, EventArgs e)    //画像削除ボタン
        {
            if (pbImage.Image == null)
                return;
            //メッセージボックスを表示する
            MessageBox.Show("削除してよいですか？",
                "確認",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            {
                pbImage.Image = null;
            }
            _Cars.RemoveAt(dgvCarData.CurrentRow.Index);
            inputItemAllClear();
            dgvCarData.ClearSelection();
        }

        private void dgvCarData_Click(object sender, EventArgs e)
        {
            if (dgvCarData.CurrentRow == null)
                return;

            //選択したレコードを取り出す
            //データグリッドビューで選択した行のインデックスを元に
            //BindingListのデータを取得する
            CarReport selectedCar = _Cars[dgvCarData.CurrentRow.Index];
            selectedCar.CreateDate = dateTimePicker1.Value;
            selectedCar.Maker = RadioButtonChecked();
            selectedCar.Name = cbName.Text;
            selectedCar.Report = tbReport.Text;
            selectedCar.image = pbImage.Image;

        }

        private void btdvgOpen_Click(object sender, EventArgs e)    //データグリッドビューを開くボタン
        {
               //オープンファイルダイアログを表示
             if (ofdOpenData.ShowDialog() == DialogResult.OK)
                {

                   using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                    {
                        try
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            //逆シリアル化して読み込む
                            _Cars = (BindingList<CarReport>)formatter.Deserialize(fs);
                            //データグリッドビューに再設定
                            dgvCarData.DataSource = _Cars;
                            //選択されている箇所を各コントロールへ表示
                            dgvCarData_Click(sender, e);

                        }
                        catch (SerializationException se)
                        {
                            Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                            throw;
                        }
                   }
             }
        }

        private void btDgvSave_Click(object sender, EventArgs e)    //データグリッドビュー保存ボタン
        {
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                //セーブファイルダイアログを表示
                BinaryFormatter formatter = new BinaryFormatter();

                //ファイルストリームを生成
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))　//ファイルを占有
                {                                          //↑保存先
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _Cars);
                    }
                    catch (SerializationException emo)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + emo.Message);
                        throw;
                    }
                }
            }
        }

        private void initButtons()
        {
            if (_Cars.Count > 0)
            {
                btdgvFix.Enabled = true;
                btdgvDelete.Enabled = true;
            }
            else
            {
                btdgvFix.Enabled = false;
                btdgvDelete.Enabled = false;
            }
        }

        private void btdgvDelete_Click(object sender, EventArgs e)　//データグリッドビュー削除ボタン
        {
            _Cars.RemoveAt(dgvCarData.CurrentRow.Index);
            initButtons();
            inputItemAllClear();
            dgvCarData.ClearSelection();
        }

        private void btdgvFix_Click(object sender, EventArgs e) //データグリッドビュー変更ボタン
        {
            //変更対象のレコード（オブジェクト）
            CarReport selectedCar = _Cars[dgvCarData.CurrentRow.Index];
            selectedCar.CreateDate = dateTimePicker1.Value;
            selectedCar.Maker = RadioButtonChecked();
            selectedCar.Name = cbName.Text;
            selectedCar.Report = tbReport.Text;
            selectedCar.image = pbImage.Image;

            dgvCarData.Refresh();       //データグリッドビューの再描
        }

        private void btdgvClose_Click(object sender, EventArgs e)   //終了ボタン
        {
            this.Close();
        }
    }
}