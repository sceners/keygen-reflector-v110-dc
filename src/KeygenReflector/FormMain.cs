using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using KeygenReflector.Properties;

namespace KeygenReflector
{
	public partial class FormMain : Form
	{
		private IntPtr WindowHandle
		{
			get
			{
				try
				{
					return (IntPtr)long.Parse(cmbWindow.Text.Split(':')[0], NumberStyles.HexNumber);
				}
				catch
				{
					return IntPtr.Zero;
				}
			}
		}
		private IntPtr GenerateHandle
		{
			get
			{
				try
				{
					return (IntPtr)long.Parse(cmbGenerate.Text.Split(':')[0], NumberStyles.HexNumber);
				}
				catch
				{
					return IntPtr.Zero;
				}
			}
		}
		private IntPtr SerialHandle
		{
			get
			{
				try
				{
					return (IntPtr)long.Parse(cmbSerial.Text.Split(':')[0], NumberStyles.HexNumber);
				}
				catch
				{
					return IntPtr.Zero;
				}
			}
		}
		private string WindowTitle
		{
			get
			{
				string title = cmbWindow.Text.Substring(cmbWindow.Text.IndexOf(":") + 1).Trim();
				foreach (char ch in Path.GetInvalidFileNameChars())
				{
					title = title.Replace(ch.ToString(), "");
				}
				return title;
			}
		}
		private List<IntPtr> OtherSerials = new List<IntPtr>();
		private bool Stopped;

		public FormMain()
		{
			InitializeComponent();
			new ToolTip().SetToolTip(btnAddSerial, "If the Keygen uses more than one text field for the serial,\r\nclick here to add another.");
		}
		private void FormMain_Load(object sender, EventArgs e)
		{
			cmbWindow_DropDown(null, null);
			string[] search = new string[] { "keygen", "keymaker", "key gen", "key maker" };
			for (int i = 0; i < cmbWindow.Items.Count; i++)
			{
				bool found = false;
				foreach (string sear in search)
				{
					if (Convert.ToString(cmbWindow.Items[i]).ToLower().Contains(sear))
					{
						cmbWindow.SelectedIndex = i;
						found = true;
					}
				}
				if (found) break;
			}
		}
		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Environment.Exit(0);
		}

		private void cmbWindow_DropDown(object sender, EventArgs e)
		{
			cmbWindow.Items.Clear();
			cmbGenerate.Items.Clear();
			cmbSerial.Items.Clear();
			foreach (Window win in ApiFuncs.EnumWindows())
			{
				if (win.Handle != Handle && win.IsVisible)
				{
					bool ok = true;
					try
					{
						uint pid = 0;
						Api.GetWindowThreadProcessId(win.Handle, out pid);
						Process proc = Process.GetProcessById((int)pid);
						List<string> donot = new List<string>(new string[]
						{
							"explorer", "firefox", "iexplore", "notepad", "calc",
							"cmd", "icq"
						});
						if (donot.Contains(proc.ProcessName.ToLower())) ok = false;
					}
					catch { }
					if (ok)
					{
						cmbWindow.Items.Add(win.Handle.ToString("x8") + ": " + win.Title);
					}
				}
			}
			OtherSerials.Clear();
			CheckStartEnabled();
		}
		private void cmbGenerate_DropDown(object sender, EventArgs e)
		{
			cmbGenerate.Items.Clear();
			IntPtr window = WindowHandle;
			if (window != IntPtr.Zero)
			{
				foreach (IntPtr control in ApiFuncs.GetChildWindows(window))
				{
					cmbGenerate.Items.Add(control.ToString("x8") + ": " + ApiFuncs.GetText(control));
				}
			}
			CheckStartEnabled();
		}
		private void cmbSerial_DropDown(object sender, EventArgs e)
		{
			cmbSerial.Items.Clear();
			IntPtr window = WindowHandle;
			if (window != IntPtr.Zero)
			{
				foreach (IntPtr control in ApiFuncs.GetChildWindows(window))
				{
					cmbSerial.Items.Add(control.ToString("x8") + ": " + ApiFuncs.GetText(control));
				}
			}
			CheckStartEnabled();
		}
		private void cmbWindow_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				uint pid = 0;
				Api.GetWindowThreadProcessId(WindowHandle, out pid);
				Process proc = Process.GetProcessById((int)pid);
				lblProcess.Text = proc.ProcessName;
				try
				{
					PerformanceCounter pc = new PerformanceCounter("Process", "Creating Process ID", proc.ProcessName);
					Process parent = Process.GetProcessById((int)pc.NextValue());
					lblParentProcess.Text = parent.ProcessName;
					lblParentProcess.ForeColor = lblParentProcess.Text == "explorer" ? Color.Green : Color.DarkRed;
				}
				catch
				{
					lblParentProcess.Text = "Error";
					lblParentProcess.ForeColor = Color.DarkRed;
				}
				try
				{
					lblExecPath.Text = proc.MainModule.FileName;
					lblExecPath.ForeColor = Path.GetTempPath().StartsWith(Path.GetDirectoryName(lblExecPath.Text)) ? Color.DarkRed : Color.Black;
				}
				catch
				{
					lblExecPath.Text = "";
				}
				try
				{
					byte[] md5 = MD5.Create().ComputeHash(File.ReadAllBytes(lblExecPath.Text));
					string hash = "";
					for (int i = 0; i < 16; i++) hash += md5[i].ToString("x2");
					lblMD5.Text = hash;
				}
				catch
				{
					lblMD5.Text = "";
				}
			}
			catch
			{
				lblProcess.Text = "";
				lblParentProcess.Text = "";
				lblExecPath.Text = "";
				lblMD5.Text = "";
			}
			try
			{
				cmbGenerate_DropDown(null, null);
				string[] search = new string[] { "gen", "ok" };
				for (int i = 0; i < cmbGenerate.Items.Count; i++)
				{
					bool found = false;
					foreach (string sear in search)
					{
						if (Convert.ToString(cmbGenerate.Items[i]).ToLower().Contains(sear))
						{
							cmbGenerate.SelectedIndex = i;
							found = true;
						}
					}
					if (found) break;
				}
			}
			catch { }
			CheckStartEnabled();
		}
		private void cmbGenerate_SelectedIndexChanged(object sender, EventArgs e)
		{
			CheckStartEnabled();
		}
		private void cmbSerial_SelectedIndexChanged(object sender, EventArgs e)
		{
			CheckStartEnabled();
		}
		private void btnAddSerial_Click(object sender, EventArgs e)
		{
			if (SerialHandle != IntPtr.Zero) OtherSerials.Add(SerialHandle);
			cmbSerial_DropDown(null, null);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (btnStart.Text == "Start")
			{
				btnStart.Text = "Stop";
				btnStart.Image = Resources.Stop;
				Stopped = false;
				Start();
			}
			else
			{
				btnStart.Text = "Start";
				btnStart.Image = Resources.Start;
				Stopped = true;
			}
		}
		private void Start()
		{
			List<IntPtr> serials = new List<IntPtr>(OtherSerials.ToArray());
			serials.Add(SerialHandle);

			IntPtr hWindow = WindowHandle;
			DialogSave.FileName = WindowTitle;
			if (DialogSave.ShowDialog() == DialogResult.OK)
			{
				IntPtr hButton = GenerateHandle;

				string last = "???", text = "???", text2 = "???";
				lblDuplicates.Text = "0";
				List<string> result = new List<string>();

				int count = Convert.ToInt32(edtCount.Value), duplicates = 0;
				for (int i = 0; i < count; i++)
				{
					if (Stopped) break;
					if (chkWait.Checked) Thread.Sleep(10);
					Api.SendMessage(hButton, 0xf5, 0, IntPtr.Zero);
					while (text2 == last || text == "")
					{
						if (Stopped) break;
						text = "";
						for (int a = 0; a < serials.Count; a++)
						{
							string current = ApiFuncs.GetText(serials[a]);
							if (a == 0) text2 = current;
							text += current;
							if (a < serials.Count - 1) text += "-";
						}
						Thread.Sleep(10);
						Application.DoEvents();
					}
					last = text2;
					if (result.Contains(text))
					{
						duplicates++;
						lblDuplicates.Text = Convert.ToString(duplicates);
						i--;
					}
					else
					{
						result.Add(text);
						edtCurrent.Text = text;
					}

					prgProgress.Value = (i + 1) * 100 / count;
				}
				if (!Stopped || MessageBox.Show("Do you still want the keys that have been generated so far?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					File.WriteAllLines(DialogSave.FileName, result.ToArray());
				}
			}
			btnStart.Text = "Start";
			btnStart.Image = Resources.Start;
		}
		private void CheckStartEnabled()
		{
			btnStart.Enabled = WindowHandle != IntPtr.Zero && GenerateHandle != IntPtr.Zero && (SerialHandle != IntPtr.Zero || OtherSerials.Count > 0);
		}
	}
}