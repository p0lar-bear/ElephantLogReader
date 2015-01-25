using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using NLua;

namespace ElephantLogReader
{
    public partial class MainForm : Form
    {
        private Dictionary<object, object> _allLogs;

        public MainForm()
        {
            InitializeComponent();
        }

        //private Dictionary<object, object> 

        private void itmMainFileOpenManual_Click(object sender, EventArgs e)
        {
            if (dlgOpenSavedVars.ShowDialog() == DialogResult.OK)
            {
                NLua.Lua loadedVars = new NLua.Lua();
                try
                {
                    loadedVars.DoFile(dlgOpenSavedVars.FileName);

                    Dictionary<object, object> _elephantDB = loadedVars.GetTableDict(loadedVars.GetTable("ElephantDBPerChar"));
                    Dictionary<object, object> profileKeys = loadedVars.GetTableDict((NLua.LuaTable)_elephantDB["profileKeys"]);
                    //profileKeys[0] is null WHY?!?! how to get this value?
                    //Hey dummy, use profileKeys.ElementAt(0) instead!
                    MessageBox.Show(dlgOpenSavedVars.FileName + " loaded for " + profileKeys.First().Value + "!");
                }
                catch (NLua.Exceptions.LuaException ex)
                {
                    MessageBox.Show(ex.Message, "Error Parsing SavedVariables File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void itmMainFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
