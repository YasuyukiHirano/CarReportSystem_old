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

            var RadioButtonChecked = groupBox1.Controls.OfType<RadioButton>()
                 .SingleOrDefault(rb => rb.Checked == true);

            switch(RadioButtonChecked.Text)
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
            return default;
            
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

        private void btdgvadd_Click(object sender, EventArgs e)
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
            _Cars.Insert(0, obj);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //入力項目を全クリア
        private void inputItemAllClear()
        {
            cbRecorder.Text = "";
            cbName.Text = "";
            tbReport.Text = "";
            pbImage.Image = null;
        }


        private void btDelete_Click(object sender, EventArgs e) //削除ボタン
        {
            _Cars.RemoveAt(dgvCarData.CurrentRow.Index);
            inputItemAllClear();
            dgvCarData.ClearSelection();
        }

        private void btClearImage_Click(object sender, EventArgs e) //クリアボタン
        {
            pbImage.Image = null;
        }


        private void btImageOpen_Click(object sender, EventArgs e)  //画像を開くボタン
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
            _Cars.RemoveAt(dgvCarData.CurrentRow.Index);
            inputItemAllClear();
            dgvCarData.ClearSelection();
        }

        private void btdvgOpen_Click(object sender, EventArgs e)    //データグリッドビューを開くボタン
        {
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdOpenData.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
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
    }
}
