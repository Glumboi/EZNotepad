using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;

namespace EZNotepad_redesign
{
    public partial class Form1 : MaterialForm
    {
        //Variables used front-end
        string text;
        bool darkmode;
        int fontsize_;
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        //Extern methods used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //Hotkeys
        private const int ACTION_HOTKEY_ID = 1;
        private const int ACTION_HOTKEY_ID2 = 2;
        private const int ACTION_HOTKEY_ID3 = 3;
        private const int ACTION_HOTKEY_ID4 = 4;
        private const int ACTION_HOTKEY_ID5 = 5;
        private const int ACTION_HOTKEY_ID6 = 6;

        public Form1()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Orange700, Primary.Orange700, Accent.Orange700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadContent_Settings();
            }
            catch
            {
                Slider_Font.Value = 11;
            }
        }

        private void LoadContent_Settings()
        {
            //This registers the hotkey presses
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID, 2, (int)Keys.S);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID2, 2, (int)Keys.O);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID3, 2, (int)Keys.N);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID4, 2, (int)Keys.G);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID5, 2, (int)Keys.K);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID6, 2, (int)Keys.E);

            getsettings();
        }

        //This method handles all the hotkey actions
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID)
            {
                savefile();
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID2)
            {
                openfile();
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID3)
            {
                newfile();
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID4)
            {
                Process.Start("https://github.com/Glumboi");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID5)
            {
                Process.Start("https://google.com");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID6)
            {
                if (string.IsNullOrWhiteSpace(edit.Text))
                {
                    edit.Text = addtocurrenttext($"EZTextEditor version: {getversionofapp()}");
                }
                else
                {
                    edit.Text = addtocurrenttext($" EZTextEditor version: {getversionofapp()}");
                }
            }
            base.WndProc(ref m);
        }

        private string addtocurrenttext(string stringtoadd)
        {
            string text_ = edit.Text + stringtoadd;
            return text_;
        }

        private string getversionofapp()
        {
            var os = RuntimeInformation.OSDescription;
            return Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\nOS version: " + os;
        }

        private void newfile()
        {
            edit.Clear();
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            loadfontsize_textlength();
            int fontsize = Slider_Font.Value;
            try
            {
                setfont(fontsize);
            }
            catch
            {
                fontsize = 1;
            }
        }

        private void loadfontsize_textlength()
        {
            string textlength = edit.Text.Length.ToString();
            Charcount.Text = $"Current document char count:  {textlength}";
        }

        private void setfont(int size)
        {
            //Properties.Settings.Default.FontSize = size;
            edit.Font = new Font(edit.Font.FontFamily, size, edit.Font.Style);
        }

        private void savefile()
        {
            text = edit.Text;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = ".txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                //---Old code kept for reference---//
                //File.WriteAllText(save.FileName, text);

                string savelocation = save.FileName;
                edit.SaveFile(savelocation, RichTextBoxStreamType.PlainText);
            }
        }

        //Creates a openfiedialog which will open the file on the selected path
        private void openfile()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = ".txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                edit.LoadFile(file.FileName, RichTextBoxStreamType.PlainText);
            }

            //The following two lines are used to update the GUI
            //--------------------------------------------------
            //This is old code kept for reference or if i revert
            //string output = File.ReadAllText(file.FileName);
            //edit.Text = output;
            //--------------------------------------------------   
        }

        private void Bn_Save_Click(object sender, EventArgs e)
        {
            savefile();
        }

        private void Bn_Open_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void Cb_Darkmode_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Darkmode.Checked)
            {
                darkmode = true;
                changetodark();
            }
            else if (darkmode)
            {
                darkmode = false;
                changetowhite();
            }
        }

        private void changetodark()
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Orange700, Primary.Orange700, Accent.Orange700, TextShade.WHITE);
        }

        private void changetowhite()
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Orange700, Primary.Orange700, Accent.Orange700, TextShade.WHITE);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            savesettings();
        }

        private void getsettings()
        {
            darkmode = Properties.Settings.Default.Darkmode;
            fontsize_ = Properties.Settings.Default.FontSize;
            Slider_Font.Value = fontsize_;
            setfont(fontsize_);
            if (darkmode)
            {
                Cb_Darkmode.Checked = true;
            }
            else
            {
                Cb_Darkmode.Checked = false;
            }
        }

        private void savesettings()
        {
            Properties.Settings.Default.Darkmode = darkmode;
            fontsize_ = getfontsize();
            Properties.Settings.Default.FontSize = fontsize_;
            Properties.Settings.Default.Save();
        }

        private int getfontsize()
        {
            return (int)edit.Font.Size;
        }

        private void BN_New_Click(object sender, EventArgs e)
        {
            edit.Clear();
        }

        //Method to load dragged files
        private void edit_dragdrop(object sender, DragEventArgs e)
        {
            object filename = e.Data.GetData("FileDrop");
            if (filename != null)
            {
                var list = filename as string[];

                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    edit.Clear();
                    edit.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void edit_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
