using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
	[Serializable]
	class CarReport {
		public DateTime CreatedDate { get; set; }
		public string Author{ get; set; }
		public string Maker { get; set; }
		public string CarName { get; set; }
		public string Report { get; set; }
		public Image Picture { get; set; }
	}
}
