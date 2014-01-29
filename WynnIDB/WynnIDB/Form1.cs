using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet.WinFormsUtilities;
using GemBox.Spreadsheet;

namespace WynnIDB
{
    public partial class wynnidb : Form
    {
        #region Initialize
        public wynnidb()
        {
            InitializeComponent();
            click();
            itemClass.SelectedIndex = 0;
            pictureBox2.Visible = false; em.Visible = false; pictureBox1.Visible = false; ebl.Visible = false; pictureBox3.Visible = false; lel.Visible = false;
        }
        DataTable dt = new DataTable();
        string bClass = String.Empty;
        string sheetName = String.Empty;
        bool mccolors = false;
        #endregion
        #region itemNames
        private void itemNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            getExcelData();
            dispData(dt);
            getImg();
        }
        #endregion
        #region itemClass
        private void itemClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllB.Checked = false; BasicB.Checked = false; UniqueB.Checked = false; RareB.Checked = false; LegendaryB.Checked = false;
            itemNames.Items.Clear();
            switch (itemClass.SelectedItem.ToString().ToLower())
            {
                case "spears": sheetName = "Spears"; AllB.Enabled = true; BasicB.Enabled = true; UniqueB.Enabled = true; RareB.Enabled = true; LegendaryB.Enabled = true; 
                    break;
                case "wands": sheetName = "Wands"; AllB.Enabled = true; BasicB.Enabled = true; UniqueB.Enabled = true; RareB.Enabled = true; LegendaryB.Enabled = true; 
                    break;
                case "bows": sheetName = "Bows"; AllB.Enabled = true; BasicB.Enabled = true; UniqueB.Enabled = true; RareB.Enabled = true; LegendaryB.Enabled = true; 
                    break;
                case "daggers":  sheetName = "Daggers"; AllB.Enabled = true; BasicB.Enabled = true; UniqueB.Enabled = true; RareB.Enabled = true; LegendaryB.Enabled = true; 
                    break;
                case "leather armour": sheetName = "ArmourLeather"; AllB.Enabled = true; BasicB.Enabled = true; UniqueB.Enabled = true; RareB.Enabled = true; LegendaryB.Enabled = true; 
                    break;
                case "gold armour": sheetName = "ArmourGold"; AllB.Enabled = true; BasicB.Enabled = true; UniqueB.Enabled = true; RareB.Enabled = true; LegendaryB.Enabled = true; 
                    break;
                case "chain armour": sheetName = "ArmourChain"; AllB.Enabled = true; BasicB.Enabled = true; UniqueB.Enabled = true; RareB.Enabled = true; LegendaryB.Enabled = true; 
                    break;
                case "iron armour": sheetName = "ArmourIron"; AllB.Enabled = true; BasicB.Enabled = true; UniqueB.Enabled = true; RareB.Enabled = true; ; LegendaryB.Enabled = true; 
                    break;
                case "diamond armour": sheetName = "ArmourDiamond"; AllB.Enabled = true; BasicB.Enabled = true; UniqueB.Enabled = true; RareB.Enabled = true; LegendaryB.Enabled = true; 
                    break;
                case "special armour": sheetName = "ArmourSpecial"; AllB.Enabled = true; BasicB.Enabled = false; UniqueB.Enabled = false; RareB.Enabled = false; LegendaryB.Enabled = false; 
                    break;
                case "quest armour": sheetName = "ArmourQuest"; AllB.Enabled = true; BasicB.Enabled = false; UniqueB.Enabled = false; RareB.Enabled = false; LegendaryB.Enabled = false; 
                    break;
            }
        }
        #endregion
        #region getExcelData
        public void getExcelData()
        {
            dt.Columns.Clear();
            dt.Clear();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            ExcelFile ef = ExcelFile.Load("data/" + sheetName + ".xls");
            dt.Columns.Add("ID", typeof(string)); dt.Columns.Add("Name", typeof(string)); dt.Columns.Add("MinLvl", typeof(string)); dt.Columns.Add("MinDmg", typeof(string));
            dt.Columns.Add("MaxDmg", typeof(string)); dt.Columns.Add("Tier", typeof(string)); dt.Columns.Add("Cost", typeof(string)); dt.Columns.Add("HealthRegen", typeof(string));
            dt.Columns.Add("ManaRegen", typeof(string)); dt.Columns.Add("SpellDamage", typeof(string)); dt.Columns.Add("LifeSteal", typeof(string)); dt.Columns.Add("Mana Steal", typeof(string));
            dt.Columns.Add("XPBonus", typeof(string)); dt.Columns.Add("LootBonus", typeof(string)); dt.Columns.Add("Location", typeof(string));
            ExcelWorksheet ws = ef.Worksheets[0];
            ExtractToDataTableOptions options = new ExtractToDataTableOptions(0, 0, 50);
            options.ExtractDataOptions = ExtractDataOptions.StopAtFirstEmptyRow;
            options.ExcelCellToDataTableCellConverting += (sender, e) =>
            {
                if (!e.IsDataTableValueValid)
                {
                    e.DataTableValue = e.ExcelCellValue == null ? null : e.ExcelCellValue.ToString();
                    e.Action = ExtractDataEventAction.Continue;
                }
            };
            ws.ExtractToDataTable(dt, options);
        }
        #endregion
        #region nameFilter
        public void nameFilter()
        {
            getExcelData();
            itemNames.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string baClass = row[5].ToString();
                object obj = row[1];
                if (bClass != "All")
                {
                    if (baClass == bClass) { itemNames.Items.Add(obj); }
                }
                else if (bClass == "All")
                {
                    if (row[5].ToString() == "Tier") { }
                    else
                        itemNames.Items.Add(obj);
                }
                else { }
            }
        }
        #endregion
        #region dispData
        public void dispData(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == itemNames.SelectedItem.ToString())
                {
                    if (custE.Text == "0" || custE.Text == "") { pictureBox2.Visible = false; }
                    else { pictureBox2.Visible = true; em.Text = custE.Text; }
                    if (custEB.Text == "0" || custEB.Text == "") { pictureBox1.Visible = false; }
                    else { pictureBox1.Visible = true; ebl.Text = custE.Text; }
                    if (custLE.Text == "0" || custLE.Text == "") { pictureBox3.Visible = false; }
                    else { pictureBox3.Visible = true; lel.Text = custE.Text; }
                    namePic.Text = row[1].ToString();
                    if (row[1].ToString() == "Purified Helmet of the Legends") { namePic.Text = "Helmet of the Legends"; }
                    nameTxt.Text = row[1].ToString();
                    minLvlTxt.Text = row[2].ToString();
                    lvlPic.Text = "Min. Lvl: " + row[2].ToString();
                    tierTxt.Text = row[5].ToString();
                    idTxt.Text = row[0].ToString();
                    if (row[7].ToString() != "0") { healthRgnTxt.Text = "+ " + row[7].ToString(); } else { healthRgnTxt.Text = "None"; } 
                    if (row[8].ToString() != "0") { manaRgnTxt.Text = "+ " + row[8].ToString(); } else { manaRgnTxt.Text = "None"; }
                    if (row[9].ToString() != "0") { spellDmgTxt.Text = "+ " + row[9].ToString() + "%"; } else { spellDmgTxt.Text = "None"; }
                    if (row[10].ToString() != "0") { lifeStlTxt.Text = "+ " + row[10].ToString(); } else { lifeStlTxt.Text = "None"; }
                    if (row[11].ToString() != "0") { manaStlTxt.Text = "+ " + row[11].ToString(); } else { manaStlTxt.Text = "None"; }
                    if (row[12].ToString() != "0") { xpBnsTxt.Text = "+ " + row[12].ToString() + "%"; } else { xpBnsTxt.Text = "None"; }
                    if (row[13].ToString() != "0") { lootBnsTxt.Text = "+ " + row[13].ToString()+ "%"; } else { lootBnsTxt.Text = "None"; }
                    if (row[6].ToString() == "0") { costTxt.Text = "-"; }
                    else
                    {
                        int cost = Int16.Parse(row[6].ToString());
                        if (cost <= 63) { costTxt.Text = cost.ToString() + " E"; }
                        else if (cost <= 4095)
                        {
                            int o = 0;
                            Math.DivRem(cost, 64, out o);
                            int cost64 = cost - o;
                            cost64 = cost64 / 64;
                            if (o == 0) { costTxt.Text = cost64.ToString() + " EB"; }
                            else { costTxt.Text = cost64.ToString() + " EB, " + o.ToString() + " E"; }
                        }
                        else 
                        {
                            int o = 0;
                            Math.DivRem(cost, 4096, out o);
                            int cost4096 = cost - o;
                            cost4096 = cost4096 / 4096;
                            int p = 0;
                            Math.DivRem(o, 64, out p);
                            int cost64 = o - p;
                            cost64 = cost64 / 64;
                            if (o == 0 && p == 0) { costTxt.Text = cost4096.ToString() + " LE"; }
                            else if (o != 0 && p == 0) { costTxt.Text = cost4096.ToString() + " LE, " + cost64.ToString() + " B"; }
                            else if (o == 0 && p != 0) { costTxt.Text = cost4096.ToString() + " LE, " + p.ToString() + " E"; }
                            else if (o != 0 && p != 0) { costTxt.Text = cost4096.ToString() + " LE, " + cost64.ToString() + " B, " + p.ToString() + " E"; }
                        }
                    }
                    if (sheetName == "Spears" || sheetName == "Wands" || sheetName == "Bows" || sheetName == "Daggers")
                    {
                        statPic.Text = "Dmg: " + row[3].ToString() + " - " + row[4].ToString();
                        defTxt.ForeColor = System.Drawing.Color.Indigo; defTxt.Text = "-";
                        pieceTxt.ForeColor = System.Drawing.Color.Indigo; pieceTxt.Text = "-";
                        minDmgTxt.Text = row[3].ToString() + " (Shp. I: " + (Int16.Parse(row[3].ToString()) * 1.1) + ", Shp. II: " + (Int16.Parse(row[3].ToString()) * 1.15) + ")"; minDmgTxt.ForeColor = System.Drawing.Color.Teal;
                        maxDmgTxt.Text = row[4].ToString() + " (Shp. I: " + (Int16.Parse(row[4].ToString()) * 1.1) + ", Shp. II: " + (Int16.Parse(row[4].ToString()) * 1.15) + ")"; maxDmgTxt.ForeColor = System.Drawing.Color.Teal;
                        double min = Int16.Parse(row[3].ToString());
                        double max = Int16.Parse(row[4].ToString());
                        List<double> avgl = new List<double> { min, max };
                        List<double> avgl1 = new List<double> { (min * 1.1), (max * 1.1) };
                        List<double> avgl2 = new List<double> { (min * 1.15), (max * 1.15) };
                        avgDmgTxt.Text = avgl.Average().ToString() + " (Shp. I: " + avgl1.Average().ToString() + ", Shp. II: " + avgl2.Average().ToString() + ")"; avgDmgTxt.ForeColor = System.Drawing.Color.Teal;
                        switch (sheetName)
                        {
                            case "Spears": clsTxt.Text = "Warrior"; break;
                            case "Wands": clsTxt.Text = "Mage"; break;
                            case "Bows": clsTxt.Text = "Bows"; break;
                            case "Daggers": clsTxt.Text = "Daggers"; break;
                        }
                    }
                    else if (sheetName == "ArmourLeather" || sheetName == "ArmourGold" || sheetName == "ArmourChain" || sheetName == "ArmourIron" || sheetName == "ArmourDiamond" || sheetName == "ArmourSpecial" || sheetName == "ArmourQuest")
                    {
                        statPic.Text = "Def: " + row[3].ToString();
                        minDmgTxt.Text = "-"; minDmgTxt.ForeColor = System.Drawing.Color.Indigo;
                        maxDmgTxt.Text = "-"; maxDmgTxt.ForeColor = System.Drawing.Color.Indigo;
                        avgDmgTxt.Text = "-"; avgDmgTxt.ForeColor = System.Drawing.Color.Indigo;
                        defTxt.Text = row[3].ToString(); defTxt.ForeColor = System.Drawing.Color.Teal;
                        pieceTxt.Text = row[4].ToString(); pieceTxt.ForeColor = System.Drawing.Color.Teal;
                        switch (sheetName)
                        {
                            case "ArmourLeather": clsTxt.Text = "Leather"; break;
                            case "ArmourGold": clsTxt.Text = "Gold"; break;
                            case "ArmourChain": clsTxt.Text = "Chain"; break;
                            case "ArmourIron": clsTxt.Text = "Iron"; break;
                            case "ArmourDiamond": clsTxt.Text = "Diamond"; break;
                            case "ArmourSpecial": clsTxt.Text = "Special"; break;
                            case "ArmourQuest": clsTxt.Text = "Quest"; break;
                        }
                    }
                    if (mccolors) 
                    {
                        if (row[5].ToString() == "Basic") { namePic.ForeColor = System.Drawing.Color.White; }
                        else if (row[5].ToString() == "Unique") { namePic.ForeColor = System.Drawing.Color.Yellow; }
                        else if (row[5].ToString() == "Rare") { namePic.ForeColor = System.Drawing.Color.Magenta; }
                        else if (row[5].ToString() == "Legendary") { namePic.ForeColor = System.Drawing.Color.DeepSkyBlue; }
                        else if (row[5].ToString() == "Special") { namePic.ForeColor = System.Drawing.Color.White; }
                        else if (row[5].ToString() == "Quest") { namePic.ForeColor = System.Drawing.Color.White; }
                    }
                }
            }
        }
        #endregion
        #region getImg
        public void getImg()
        {
            getExcelData();
            if (sheetName == "Spears") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/0/01/Grid_Iron_Shovel.png"; }
            else if (sheetName == "Wands") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e9/Grid_Stick.png"; }
            else if (sheetName == "Bows") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/4/49/Grid_Bow.png"; }
            else if (sheetName == "Daggers") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/1/13/Grid_Shears.png"; }
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == itemNames.SelectedItem.ToString())
                {
                    if (sheetName == "ArmourLeather")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/2/24/Grid_Leather_Cap.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/ed/Grid_Leather_Tunic.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/c/ce/Grid_Leather_Pants.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/0/06/Grid_Leather_Boots.png"; }
                    }
                    else if (sheetName == "ArmourGold")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/4/45/Grid_Golden_Helmet.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/6/67/Grid_Golden_Chestplate.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/f8/Grid_Golden_Leggings.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/fb/Grid_Golden_Boots.png"; }
                    }
                    else if (sheetName == "ArmourChain")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/c/c3/Grid_Chain_Helmet.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/7/77/Grid_Chain_Chestplate.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/2/26/Grid_Chain_Leggings.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/9/93/Grid_Chain_Boots.png"; }
                    }
                    else if (sheetName == "ArmourIron")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/ec/Grid_Iron_Helmet.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/8/8d/Grid_Iron_Chestplate.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/9/99/Grid_Iron_Leggings.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/f5/Grid_Iron_Boots.png"; }
                    }
                    else if (sheetName == "ArmourDiamond")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/b/bd/Grid_Diamond_Helmet.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e7/Grid_Diamond_Chestplate.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e3/Grid_Diamond_Leggings.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/d/d1/Grid_Diamond_Boots.png"; }
                    }
                    else if (sheetName == "ArmourSpecial" || sheetName == "ArmourQuest")
                    {
                        if (row[4].ToString() == "Helmet") { img.Visible = false; }
                        else if (row[4].ToString() == "Chestplate") { img.Visible = false; }
                        else if (row[4].ToString() == "Leggings") { img.Visible = false; }
                        else if (row[4].ToString() == "Boots") { img.Visible = false; }
                    }
                }
            }
        }
        #endregion
        #region Click
        private void click()
        {
            UniqueB.Click += UniqueB_Click;
            BasicB.Click += BasicB_Click;
            RareB.Click += RareB_Click;
            LegendaryB.Click += LegendaryB_Click;
            AllB.Click += AllB_Click;
            healthRgnTxt.TextChanged += healthRgnTxt_TextChanged;
            manaRgnTxt.TextChanged += manaRgnTxt_TextChanged;
            lifeStlTxt.TextChanged += lifeStlTxt_TextChanged;
            manaStlTxt.TextChanged += manaStlTxt_TextChanged;
            xpBnsTxt.TextChanged += xpBnsTxt_TextChanged;
            lootBnsTxt.TextChanged += lootBnsTxt_TextChanged;
            spellDmgTxt.TextChanged += spellDmgTxt_TextChanged;
        }
        #endregion
        #region RadioButtons
        public void BasicB_Click(object sender, EventArgs e)
        {
            if (BasicB.Checked)
            {
                UniqueB.Checked = false;
                RareB.Checked = false;
                LegendaryB.Checked = false;
                AllB.Checked = false;
                bClass = "Basic";
                nameFilter();
            }
            try
            { itemNames.SelectedIndex = 0; }
            catch { }
        }
        public void RareB_Click(object sender, EventArgs e)
        {
            if (RareB.Checked)
            {
                UniqueB.Checked = false;
                BasicB.Checked = false;
                LegendaryB.Checked = false;
                AllB.Checked = false;
                bClass = "Rare";
                nameFilter();
            }
            try
            { itemNames.SelectedIndex = 0; }
            catch { }
        }
        public void LegendaryB_Click(object sender, EventArgs e)
        {
            if (LegendaryB.Checked)
            {
                UniqueB.Checked = false;
                BasicB.Checked = false;
                RareB.Checked = false;
                AllB.Checked = false;
                bClass = "Legendary";
                nameFilter();
            }
            try
            { itemNames.SelectedIndex = 0; }
            catch { }
        }
        public void AllB_Click(object sender, EventArgs e)
        {
            if (AllB.Checked)
            {
                UniqueB.Checked = false;
                BasicB.Checked = false;
                RareB.Checked = false;
                LegendaryB.Checked = false;
                bClass = "All";
                nameFilter();
            }
            try
            { itemNames.SelectedIndex = 0; }
            catch { }
        }
        public void UniqueB_Click(object sender, EventArgs e)
        {
            if (UniqueB.Checked)
            {
                BasicB.Checked = false;
                RareB.Checked = false;
                LegendaryB.Checked = false;
                AllB.Checked = false;
                bClass = "Unique";
                nameFilter();
            }
            try
            { itemNames.SelectedIndex = 0; }
            catch { }
        }
        #endregion
        #region customCost
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int cc = 0;
            if (custE.Text == "") { em.Text = ""; }
            cc = 0; Int32.TryParse(custE.Text, out cc);
            if (cc == 0) { custE.Text = ""; pictureBox2.Visible = false; }
            else { em.Visible = true; pictureBox2.Visible = true;  em.Text = custE.Text; }
        }
        private void custEB_TextChanged(object sender, EventArgs e)
        {
            int cc2 = 0;
            if (custEB.Text == "") { ebl.Text = ""; }
            cc2 = 0; Int32.TryParse(custEB.Text, out cc2);
            if (cc2 == 0) { custEB.Text = ""; pictureBox1.Visible = false; }
            else { ebl.Visible = true; pictureBox1.Visible = true; ebl.Text = custEB.Text; }
        }
        private void custLE_TextChanged(object sender, EventArgs e)
        {
            int cc3 = 0;
            if (custLE.Text == "") { lel.Text = ""; }
            cc3 = 0; Int32.TryParse(custLE.Text, out cc3);
            if (cc3 == 0) { custLE.Text = ""; pictureBox3.Visible = false; }
            else { lel.Visible = true; pictureBox3.Visible = true; lel.Text = custLE.Text; }
        }
        #endregion
        #region Colors
        private void idbColors_CheckedChanged(object sender, EventArgs e)
        {
            mccolors = false;
            mColors.Checked = false;
            namePic.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            statPic.ForeColor = System.Drawing.Color.Teal;
            lvlPic.ForeColor = System.Drawing.Color.DeepSkyBlue;
            HR.ForeColor = System.Drawing.Color.Indigo; MR.ForeColor = System.Drawing.Color.Indigo; LS.ForeColor = System.Drawing.Color.Indigo;
            MS.ForeColor = System.Drawing.Color.Indigo; XB.ForeColor = System.Drawing.Color.Indigo; LB.ForeColor = System.Drawing.Color.Indigo;
            SD.ForeColor = System.Drawing.Color.Indigo;
        }
        private void mColors_CheckedChanged(object sender, EventArgs e)
        {
            mccolors = true;
            idbColors.Checked = false;
            statPic.ForeColor = System.Drawing.Color.Purple;
            lvlPic.ForeColor = System.Drawing.Color.Gold;
            HR.ForeColor = System.Drawing.Color.LightGray; MR.ForeColor = System.Drawing.Color.LightGray; LS.ForeColor = System.Drawing.Color.LightGray;
            MS.ForeColor = System.Drawing.Color.LightGray; XB.ForeColor = System.Drawing.Color.LightGray; LB.ForeColor = System.Drawing.Color.LightGray;
            SD.ForeColor = System.Drawing.Color.LightGray;
        }
        #endregion
        #region getIDS + IDC
        public void getIDS()
        {
            string a = ""; string b = ""; string c = ""; string d = ""; string e = ""; string f = ""; string g = "";
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == itemNames.SelectedItem.ToString()) 
                {
                    a = row[7].ToString(); b = row[8].ToString(); c = row[9].ToString(); d = row[10].ToString();
                    e = row[11].ToString(); f = row[12].ToString(); g = row[13].ToString();
                }
            }
            try { Decimal.Parse(healthRgnTxt.Text.TrimStart('+').TrimEnd('%').Trim()); }
            catch { if (a != "0") { healthRgnTxt.Text = a; } else { healthRgnTxt.Text = "None"; } }
            try { Int16.Parse(manaRgnTxt.Text.TrimStart('+').TrimEnd('%').Trim()); }
            catch { if (b != "0") { manaRgnTxt.Text = b; } else { manaRgnTxt.Text = "None"; } }
            try { Int16.Parse(spellDmgTxt.Text.TrimStart('+').TrimEnd('%').Trim()); }
            catch { if (c != "0") { spellDmgTxt.Text = c; } else { spellDmgTxt.Text = "None"; } }
            try { Decimal.Parse(lifeStlTxt.Text.TrimStart('+').TrimEnd('%').Trim()); }
            catch { if (d != "0") { lifeStlTxt.Text = d; } else { lifeStlTxt.Text = "None"; } }
            try { Int16.Parse(manaStlTxt.Text.TrimStart('+').TrimEnd('%').Trim()); }
            catch { if (e != "0") { manaStlTxt.Text = e; } else { manaStlTxt.Text = "None"; } }
            try { Int16.Parse(xpBnsTxt.Text.TrimStart('+').TrimEnd('%').Trim()); }
            catch { if (f != "0") { xpBnsTxt.Text = f; } else { xpBnsTxt.Text = "None"; } }
            try { Int16.Parse(lootBnsTxt.Text.TrimStart('+').TrimEnd('%').Trim()); }
            catch { if (g != "0") { lootBnsTxt.Text = g; } else { lootBnsTxt.Text = "None"; } }
            if (healthRgnTxt.Text != "None") { HR.Text = "Health Rgn: " + healthRgnTxt.Text; HR.Visible = true; } else { HR.Text = ""; HR.Visible = false; }
            if (manaRgnTxt.Text != "None") { MR.Text = "Mana Rgn: " + manaRgnTxt.Text; MR.Visible = true; } else { MR.Text = ""; MR.Visible = false; }
            if (spellDmgTxt.Text != "None") { SD.Text = "Spell Dmg: " + spellDmgTxt.Text; SD.Visible = true; } else { SD.Text = ""; SD.Visible = false; }
            if (lifeStlTxt.Text != "None") { LS.Text = "Life Stl: " + lifeStlTxt.Text; LS.Visible = true; } else { LS.Text = ""; LS.Visible = false; }
            if (manaStlTxt.Text != "None") { MS.Text = "Mana Stl: " + manaStlTxt.Text; MS.Visible = true; } else { MS.Text = ""; MS.Visible = false; }
            if (xpBnsTxt.Text != "None") { XB.Text = "XP Bns: " + xpBnsTxt.Text; XB.Visible = true; } else { XB.Text = ""; XB.Visible = false; }
            if (lootBnsTxt.Text != "None") { LB.Text = "Loot Bns: " + lootBnsTxt.Text; LB.Visible = true; } else { LB.Text = ""; LB.Visible = false; }
        }
        private void healthRgnTxt_TextChanged(object sender, EventArgs e)
        {
            getIDS();
        }
        private void manaRgnTxt_TextChanged(object sender, EventArgs e)
        {
            getIDS();
        }
        private void lifeStlTxt_TextChanged(object sender, EventArgs e)
        {
            getIDS();
        }
        private void manaStlTxt_TextChanged(object sender, EventArgs e)
        {
            getIDS();
        }
        private void xpBnsTxt_TextChanged(object sender, EventArgs e)
        {
            getIDS();
        }
        private void lootBnsTxt_TextChanged(object sender, EventArgs e)
        {
            getIDS();
        }
        private void spellDmgTxt_TextChanged(object sender, EventArgs e)
        {
            getIDS();
        }
        #endregion
    }
}

