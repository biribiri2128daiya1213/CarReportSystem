using System;
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
			dgvCarReportData.DataSource = _carReports;
		}
		private void Form1_Load_1(object sender, EventArgs e) {
			//ロード
			initButton();
			SaveButton();
			tsslNowTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 500;
			Environment.CurrentDirectory = @"C:\Users\infosys\Pictures\";
			//timer1.Start();
		}

		private void btDataAdd_Click(object sender, EventArgs e) {
			//データの追加
			if (cbAuthor.Text != "" && cbCarName.Text != "") {
				CarReport car = new CarReport {
					CreatedDate = dtpCreateDate.Value.Date,
					Author = cbAuthor.Text,
					Maker = SelectedRadioButton(),
					CarName = cbCarName.Text,
					Report = tbReport.Text,
					Picture = pbCarPicture.Image
				};
				_carReports.Insert(0, car);
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
			}
		}
		private void btDataFix_Click(object sender, EventArgs e) {
			//データを修正
			if (cbAuthor.Text != "" && cbCarName.Text != "") {
				CarReport selectedCar = _carReports[dgvCarReportData.CurrentRow.Index];
				selectedCar.CreatedDate = dtpCreateDate.Value.Date;
				selectedCar.Author = cbAuthor.Text;
				selectedCar.Maker = SelectedRadioButton();
				selectedCar.CarName = cbCarName.Text;
				selectedCar.Report = tbReport.Text;
				selectedCar.Picture = pbCarPicture.Image;
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
			initButton();
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
			if (pbCarPicture.Image != null) {
				if (MessageBox.Show("本当に削除しますか？", "確認",
							MessageBoxButtons.YesNo) == DialogResult.Yes) {
					pbCarPicture.Image = null;
				}
			}
		}

		private void btDataOpen_Click(object sender, EventArgs e) {
			//フォルダを開く
			ofdOpenFile.InitialDirectory = @"C:\";
			if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
				using (FileStream fs = new FileStream(ofdOpenFile.FileName, FileMode.Open)) {
					try {
						BinaryFormatter formatter = new BinaryFormatter();

						_carReports = (BindingList<CarReport>)formatter.Deserialize(fs);
						dgvCarReportData.DataSource = _carReports;
						setComboBoxMaker(cbAuthor.Text, cbCarName.Text);
						inputItemAllClear();
						dgvCarReportData.ClearSelection();
						sfdSaveFile.FileName = ofdOpenFile.FileName;
						SaveButton();
						//dgvCarData_Click(sender,e);
					}
					catch (SerializationException er) {
						Console.WriteLine("エラー" + er.Message);
						throw;
					}
				}
			}
		}

		private void btDataSave_Click(object sender, EventArgs e) {
			//フォルダを保存
			sfdSaveFile.InitialDirectory = @"C:\";
			if (sfdSaveFile.ShowDialog() == DialogResult.OK) {
				BinaryFormatter formatter = new BinaryFormatter();
				using (FileStream fs = new FileStream(sfdSaveFile.FileName, FileMode.Create)) {
					try {
						formatter.Serialize(fs, _carReports);
						SaveButton();
					}
					catch (SerializationException er) {
						Console.WriteLine("エラー" + er.Message);
						throw;
					}
				}
			}
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
		private void initButton() {
			//ボタンの制御
			if (_carReports.Count <= 0) {
				btDataDelete.Enabled = false;
				btDataFix.Enabled = false;
			}
			else {
				btDataDelete.Enabled = true;
				btDataFix.Enabled = true;
			}
		}
		private void SaveButton() {
			if (sfdSaveFile.FileName == "") {
				msSave.Enabled = false;
			}
			else {
				msSave.Enabled = true;
			}
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
			if (dgvCarReportData.CurrentRow != null) {
				initButton();
				CarReport selectedCar = _carReports[dgvCarReportData.CurrentRow.Index];
				dtpCreateDate.Value = selectedCar.CreatedDate;
				cbAuthor.Text = selectedCar.Author;
				RefreshRadioButton(selectedCar.Maker);
				cbCarName.Text = selectedCar.CarName;
				tbReport.Text = selectedCar.Report;
				pbCarPicture.Image = selectedCar.Picture;
			}
		}
		private CarMaker SelectedRadioButton() {
			/*string maker = "";
			foreach (RadioButton rb in makerGroup.Controls) {
				if (rb.Checked) {
					maker = rb.Text;
				}
			}
			switch (maker) {
				case "トヨタ":
					return CarMaker.トヨタ;
				case "日産":
					return CarMaker.日産;
				case "ホンダ":
					return CarMaker.ホンダ;
				case "スバル":
					return CarMaker.スバル;
				case "外車":
					return CarMaker.外車;
				case "その他":
					return CarMaker.その他;
				default:
					return CarMaker.DEFAULT;
			}*/
			foreach (RadioButton rb in makerGroup.Controls) {
				if (rb.Checked) {
					return (CarMaker)int.Parse(rb.Tag.ToString());
				}
			}
			return CarMaker.トヨタ;
		}
		private void RefreshRadioButton(CarMaker carMaker) {
			/*switch (carMaker) {
				case CarMaker.トヨタ:
					rbToyota.Checked = true;
					break;
				case CarMaker.日産:
					rbNisan.Checked = true;
					break;
				case CarMaker.ホンダ:
					rbHonda.Checked = true;
					break;
				case CarMaker.スバル:
					rbSubaru.Checked = true;
					break;
				case CarMaker.外車:
					rbForeignCar.Checked = true;
					break;
				case CarMaker.その他:
					rbOther.Checked = true;
					break;
				default:
					rbToyota.Checked = true;
					break;
			}*/
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
			initButton();
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

		
	}
}
