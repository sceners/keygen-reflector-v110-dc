using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace KeygenReflector
{
	static public class ApiFuncs
	{
		static public string GetText(IntPtr hwnd)
		{
			try
			{
				StringBuilder str = new StringBuilder();
				str.Capacity = Api.SendMessage(hwnd, 14, 0, IntPtr.Zero) + 1;
				int len = Api.SendMessage(hwnd, 13, str.Capacity, str);
				return str.ToString().Substring(0, len);
			}
			catch
			{
				return "";
			}
		}
		static public Window[] EnumWindows()
		{
			List<Window> list = new List<Window>();
			Api.EnumWindows(new Api.EnumWindowsProc(delegate(int hWnd, int lParam)
			{
				StringBuilder title = new StringBuilder(256);
				Api.GetWindowText(hWnd, title, 256);
				lock (list)
				{
					list.Add(new Window((IntPtr)hWnd, title.ToString()));
				}
				return true;
			}), 0);
			return list.ToArray();
		}
		static public IntPtr[] GetChildWindows(IntPtr parent)
		{
			List<IntPtr> result = new List<IntPtr>();
			GCHandle safe = GCHandle.Alloc(result);

			Api.EnumChildWindows(parent, new Api.EnumWindowProc(delegate(IntPtr handle, IntPtr pointer)
			{
				lock (result) result.Add(handle);
				return true;
			}), GCHandle.ToIntPtr(safe));
			return result.ToArray();
		}
	}
	static public class Api
	{
		[DllImport("user32.dll", SetLastError = true)]
		static public extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
		[DllImport("user32.dll")]
		static public extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static public extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, StringBuilder lParam);
		[DllImport("user32.dll")]
		static public extern int SendMessage(IntPtr hWnd, int Msg, uint wParam, IntPtr lParam);
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static public extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static public extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr i);
		public delegate bool EnumWindowProc(IntPtr hWnd, IntPtr parameter);
		[DllImport("user32.dll")]
		static public extern int GetWindowText(int hWnd, StringBuilder title, int size);
		[DllImport("user32.dll")]
		static public extern int EnumWindows(EnumWindowsProc ewp, int lParam);
		public delegate bool EnumWindowsProc(int hWnd, int lParam);
		[DllImport("user32.dll")]
		static public extern bool IsWindowVisible(IntPtr hWnd);
		[DllImport("user32.dll", SetLastError = true)]
		static public extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
	}
	public struct Window
	{
		public IntPtr Handle;
		public string Title;
		public bool IsVisible
		{
			get
			{
				return Api.IsWindowVisible(Handle);
			}
		}

		public Window(IntPtr handle, string title)
		{
			Handle = handle;
			Title = title;
		}
	}
}