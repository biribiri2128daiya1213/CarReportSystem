﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
	public partial class Form1 : Form {
		BindingList<CarReport> _carReports = new BindingList<CarReport>();
		public Form1() {
			InitializeComponent();
			//dgvCarReportData.DataSource = _carReports;
		}
		private void Form1_Load_1(object sender, EventArgs e) {
			//ロード
			tsslNowTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 500;
			Environment.CurrentDirectory = @"C:\Users\infosys\Pictures\";
			dgvCarReportData.Columns[0].Visible = false;
			timer1.Start();
		}

		private void btDataAdd_Click(object sender, EventArgs e) {
			/*//データの追加
			if (cbAuthor.Text != "" && cbCarName.Text != "") {
				CarReport car = new CarReport {
					CreatedDate = dtpCreateDate.Value.Date,
					Author = cbAuthor.Text,
					Maker = SelectedRadioButton(),
					CarName = cbCarName.Text,
					Report = tbReport.Text,
					Picture = pbCarPicture.Image
				};
				
				_carReports.Add(car);
				dgvCarReportData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
				setComboBoxMaker(cbAuthor.Text, cbCarName.Text);
				inputItemAllClear();
				dgvCarReportData.ClearSelection();
				btDataDelete.Enabled = false;
				btDataFix.Enabled = false;
			}
			else {
				MessageBox.Show("記録者と車名を入力してください", "エラー",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
			}*/
		}
		private void btDataFix_Click(object sender, EventArgs e) {
			//データを修正
			if (cbAuthor.Text != "" && cbCarName.Text != "") {
				dgvCarReportData.CurrentRow.Cells[1].Value = dtpCreateDate.Value;
				dgvCarReportData.CurrentRow.Cells[2].Value = cbAuthor.Text;
				dgvCarReportData.CurrentRow.Cells[3].Value = SelectedRadioButton();
				dgvCarReportData.CurrentRow.Cells[4].Value = cbCarName.Text;
				dgvCarReportData.CurrentRow.Cells[5].Value = tbReport.Text;
				dgvCarReportData.CurrentRow.Cells[6].Value = ImageToByteArray(pbCarPicture.Image);
				dgvCarReportData.Refresh();
			}
			else {
				MessageBox.Show("記録者と車名を入力してください", "エラー",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btDataDelete_Click(object sender, EventArgs e) {
			//データを削除
			_carReports.RemoveAt(dgvCarReportData.CurrentRow.Index);
			inputItemAllClear();
			dgvCarReportData.ClearSelection();
			btDataDelete.Enabled = false;
			btDataFix.Enabled = false;
		}

		private void btImageOpen_Click(object sender, EventArgs e) {
			//Imageのフォルダを開く
			ofdImageOpen.InitialDirectory = Path.GetFullPath(@"Saved Pictures\");

			if (ofdImageOpen.ShowDialog() == DialogResult.OK) {
				pbCarPicture.Image = Image.FromFile(ofdImageOpen.FileName);
			}

			ofdImageOpen.Dispose();
		}
		private void btImageDelete_Click(object sender, EventArgs e) {
			//写真の削除
			if (MessageBox.Show("本当に削除しますか？", "確認",
						MessageBoxButtons.YesNo) == DialogResult.Yes) {
				pbCarPicture.Image = null;
			}
			
		}

		private void btDataOpen_Click(object sender, EventArgs e) {
			this.carReportTableAdapter.Fill(this.infosys202028DataSetCarReport.CarReport);
			
		}

		private void btDataSave_Click(object sender, EventArgs e) {
			//フォルダを保存
			this.Validate();
			this.carReportBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.infosys202028DataSetCarReport);
		}

		private void btExit_Click(object sender, EventArgs e) {
			//終了
			Application.Exit();
		}

		private void inputItemAllClear() {
			//初期化のメソッド
			dtpCreateDate.Value = DateTime.Today;
			cbAuthor.Text = "";
			rbToyota.Checked = true;
			cbCarName.Text = "";
			tbReport.Text = "";
			pbCarPicture.Image = null;
		}

		private void setComboBoxMaker(string author, string carName) {
		//コンボボックスの履歴
		if (!cbAuthor.Items.Contains(author)) {
			cbAuthor.Items.Add(author);
		}
		if (!cbCarName.Items.Contains(carName)) {
			cbCarName.Items.Add(carName);
		}
		}

		private void dgvCarReportData_Click(object sender, EventArgs e) {

			dtpCreateDate.Value = (DateTime)dgvCarReportData.CurrentRow.Cells[1].Value;
			cbAuthor.Text = dgvCarReportData.CurrentRow.Cells[2].Value.ToString();
			RefreshRadioButton(dgvCarReportData.CurrentRow.Cells[3].Value.ToString());
			cbCarName.Text = dgvCarReportData.CurrentRow.Cells[4].Value.ToString();
			tbReport.Text = dgvCarReportData.CurrentRow.Cells[5].Value.ToString();
			//if (dgvCarReportData.CurrentRow.Cells[6].Value == null) {
				//pbCarPicture.Image = (Image)dgvCarReportData.CurrentRow.Cells[6].Value;
			//}
		}
		private string SelectedRadioButton() {
			foreach (RadioButton rb in makerGroup.Controls) {
				if (rb.Checked) {
					return rb.Text;
				}
			}
			return "その他";
		}

		private void RefreshRadioButton(string carMaker) {
			foreach (RadioButton item in makerGroup.Controls) {
				if (carMaker.ToString().Equals(item.Text)) {
					item.Checked = true;
				}
			}
		}

		private void msNew_Click(object sender, EventArgs e) {
			//新規作成
			inputItemAllClear();
			_carReports.Clear();
		}
		private void msOpen_Click(object sender, EventArgs e) {
			//メニューストリップの開く
			btDataOpen_Click(sender, e);
		}
		private void msSave_Click(object sender, EventArgs e) {
			//メニューストリップの保存
			BinaryFormatter formatter = new BinaryFormatter();
				using (FileStream fs = new FileStream(sfdSaveFile.FileName, FileMode.Create)) {
					try {
						formatter.Serialize(fs, _carReports);
					}
					catch (SerializationException er) {
						Console.WriteLine("エラー" + er.Message);
						throw;
					}
				}
		}
		private void msNamedSave_Click(object sender, EventArgs e) {
			//メニューストリップの名前つけて保存
			btDataSave_Click(sender, e);
		}
		private void timer1_Tick(object sender, EventArgs e) {
			tsslNowTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}

		// バイト配列をImageオブジェクトに変換
		public static Image ByteArrayToImage(byte[] byteData) {
			ImageConverter imgconv = new ImageConverter();
			Image img = (Image)imgconv.ConvertFrom(byteData);
			return img;
		}

		// Imageオブジェクトをバイト配列に変換
		public static byte[] ImageToByteArray(Image img) {
			ImageConverter imgconv = new ImageConverter();
			byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
			return byteData;
		}
	}
}
