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
            emlI.Visible = false; eml.Visible = false; eblI.Visible = false; ebl.Visible = false; lelI.Visible = false; lel.Visible = false;
            emlI_2.Visible = false; eml_2.Visible = false; eblI_2.Visible = false; ebl_2.Visible = false; lelI_2.Visible = false; lel_2.Visible = false;
            imgSelect.SelectedIndex = 0;
            colors.SelectedIndex = 0;
        }
        DataTable dt = new DataTable();
        int imgSelected = 1;
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
                    nameTxt.Text = row[1].ToString();
                    minLvlTxt.Text = row[2].ToString();
                    tierTxt.Text = row[5].ToString();
                    idTxt.Text = row[0].ToString();
                    if (row[7].ToString() != "0") { healthRgnTxt.Text = row[7].ToString(); } else { healthRgnTxt.Text = "None"; } 
                    if (row[8].ToString() != "0") { manaRgnTxt.Text = row[8].ToString(); } else { manaRgnTxt.Text = "None"; }
                    if (row[9].ToString() != "0") { spellDmgTxt.Text = row[9].ToString(); minmaxSpell.Text = "SD: " + Math.Round(Double.Parse(row[9].ToString()) * 0.7,0,MidpointRounding.AwayFromZero).ToString() + " | " + Math.Round(Double.Parse(row[9].ToString()) * 1.3,0,MidpointRounding.AwayFromZero).ToString(); } else { spellDmgTxt.Text = "None"; }
                    if (row[10].ToString() != "0") { lifeStlTxt.Text = row[10].ToString(); } else { lifeStlTxt.Text = "None"; }
                    if (row[11].ToString() != "0") { manaStlTxt.Text = row[11].ToString(); } else { manaStlTxt.Text = "None"; }
                    if (row[12].ToString() != "0") { xpBnsTxt.Text = row[12].ToString(); minmaxXP.Text = "XP: " + Math.Round(Double.Parse(row[12].ToString()) * 0.7,0,MidpointRounding.AwayFromZero).ToString() + " | " + Math.Round(Double.Parse(row[12].ToString()) * 1.3,0,MidpointRounding.AwayFromZero).ToString(); } else { xpBnsTxt.Text = "None"; }
                    if (row[13].ToString() != "0") { lootBnsTxt.Text = row[13].ToString(); minmaxLoot.Text = "LB: " + Math.Round(Double.Parse(row[13].ToString()) * 0.7,0,MidpointRounding.AwayFromZero).ToString() + " | " + Math.Round(Double.Parse(row[13].ToString()) * 1.3,0,MidpointRounding.AwayFromZero).ToString(); } else { lootBnsTxt.Text = "None"; }
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
                        defTxt.ForeColor = System.Drawing.Color.Indigo; defTxt.Text = "-";
                        pieceTxt.ForeColor = System.Drawing.Color.Indigo; pieceTxt.Text = "-";
                        minDmgTxt.Text = row[3].ToString() + " | " + (Int16.Parse(row[3].ToString()) * 1.1) + " | " + (Int16.Parse(row[3].ToString()) * 1.15); minDmgTxt.ForeColor = System.Drawing.Color.Teal;
                        maxDmgTxt.Text = row[4].ToString() + " | " + (Int16.Parse(row[4].ToString()) * 1.1) + " | " + (Int16.Parse(row[4].ToString()) * 1.15); maxDmgTxt.ForeColor = System.Drawing.Color.Teal;
                        double min = Int16.Parse(row[3].ToString());
                        double max = Int16.Parse(row[4].ToString());
                        List<double> avgl = new List<double> { min, max };
                        List<double> avgl1 = new List<double> { (min * 1.1), (max * 1.1) };
                        List<double> avgl2 = new List<double> { (min * 1.15), (max * 1.15) };
                        avgDmgTxt.Text = avgl.Average().ToString() + " | " + avgl1.Average().ToString() + " | " + avgl2.Average().ToString(); avgDmgTxt.ForeColor = System.Drawing.Color.Teal;
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
                }
            }
        }
        #endregion
        #region getImg
        public void getImg()
        {
            getExcelData();
            if (imgSelected == 1)
            {
            if (imgClass.Text == "Spears") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/0/01/Grid_Iron_Shovel.png"; }
            else if (imgClass.Text == "Wands") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e9/Grid_Stick.png"; }
            else if (imgClass.Text == "Bows") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/4/49/Grid_Bow.png"; }
            else if (imgClass.Text == "Daggers") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/1/13/Grid_Shears.png"; }
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == itemNames.SelectedItem.ToString())
                {
                    if (imgClass.Text == "ArmourLeather")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/2/24/Grid_Leather_Cap.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/ed/Grid_Leather_Tunic.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/c/ce/Grid_Leather_Pants.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/0/06/Grid_Leather_Boots.png"; }
                    }
                    else if (imgClass.Text == "ArmourGold")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/4/45/Grid_Golden_Helmet.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/6/67/Grid_Golden_Chestplate.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/f8/Grid_Golden_Leggings.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/fb/Grid_Golden_Boots.png"; }
                    }
                    else if (imgClass.Text == "ArmourChain")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/c/c3/Grid_Chain_Helmet.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/7/77/Grid_Chain_Chestplate.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/2/26/Grid_Chain_Leggings.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/9/93/Grid_Chain_Boots.png"; }
                    }
                    else if (imgClass.Text == "ArmourIron")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/ec/Grid_Iron_Helmet.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/8/8d/Grid_Iron_Chestplate.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/9/99/Grid_Iron_Leggings.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/f5/Grid_Iron_Boots.png"; }
                    }
                    else if (imgClass.Text == "ArmourDiamond")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/b/bd/Grid_Diamond_Helmet.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e7/Grid_Diamond_Chestplate.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e3/Grid_Diamond_Leggings.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/d/d1/Grid_Diamond_Boots.png"; }
                    }
                    else if (imgClass.Text == "ArmourSpecial" || imgClass.Text == "ArmourQuest")
                    {
                        if (row[4].ToString() == "Helmet") { img.ImageLocation = "http://imgur.com/Z3urkUb.png"; }
                        else if (row[4].ToString() == "Chestplate") { img.ImageLocation = "http://imgur.com/XQsTi5q.png"; }
                        else if (row[4].ToString() == "Leggings") { img.ImageLocation = "http://imgur.com/Ei6Mmto.png"; }
                        else if (row[4].ToString() == "Boots") { img.ImageLocation = "http://imgur.com/xH0lieT.png"; }
                    }
                }
                }
            }
            else if (imgSelected == 2)
            {
                if (imgClass_2.Text == "Spears") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/0/01/Grid_Iron_Shovel.png"; }
                else if (imgClass_2.Text == "Wands") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e9/Grid_Stick.png"; }
                else if (imgClass_2.Text == "Bows") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/4/49/Grid_Bow.png"; }
                else if (imgClass_2.Text == "Daggers") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/1/13/Grid_Shears.png"; }
                foreach (DataRow row in dt.Rows)
                {
                    if (row[1].ToString() == itemNames.SelectedItem.ToString())
                    {
                        if (imgClass_2.Text == "ArmourLeather")
                        {
                            if (row[4].ToString() == "Helmet") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/2/24/Grid_Leather_Cap.png"; }
                            else if (row[4].ToString() == "Chestplate") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/ed/Grid_Leather_Tunic.png"; }
                            else if (row[4].ToString() == "Leggings") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/c/ce/Grid_Leather_Pants.png"; }
                            else if (row[4].ToString() == "Boots") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/0/06/Grid_Leather_Boots.png"; }
                        }
                        else if (imgClass_2.Text == "ArmourGold")
                        {
                            if (row[4].ToString() == "Helmet") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/4/45/Grid_Golden_Helmet.png"; }
                            else if (row[4].ToString() == "Chestplate") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/6/67/Grid_Golden_Chestplate.png"; }
                            else if (row[4].ToString() == "Leggings") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/f8/Grid_Golden_Leggings.png"; }
                            else if (row[4].ToString() == "Boots") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/fb/Grid_Golden_Boots.png"; }
                        }
                        else if (imgClass_2.Text == "ArmourChain")
                        {
                            if (row[4].ToString() == "Helmet") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/c/c3/Grid_Chain_Helmet.png"; }
                            else if (row[4].ToString() == "Chestplate") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/7/77/Grid_Chain_Chestplate.png"; }
                            else if (row[4].ToString() == "Leggings") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/2/26/Grid_Chain_Leggings.png"; }
                            else if (row[4].ToString() == "Boots") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/9/93/Grid_Chain_Boots.png"; }
                        }
                        else if (imgClass_2.Text == "ArmourIron")
                        {
                            if (row[4].ToString() == "Helmet") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/ec/Grid_Iron_Helmet.png"; }
                            else if (row[4].ToString() == "Chestplate") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/8/8d/Grid_Iron_Chestplate.png"; }
                            else if (row[4].ToString() == "Leggings") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/9/99/Grid_Iron_Leggings.png"; }
                            else if (row[4].ToString() == "Boots") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/f5/Grid_Iron_Boots.png"; }
                        }
                        else if (imgClass_2.Text == "ArmourDiamond")
                        {
                            if (row[4].ToString() == "Helmet") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/b/bd/Grid_Diamond_Helmet.png"; }
                            else if (row[4].ToString() == "Chestplate") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e7/Grid_Diamond_Chestplate.png"; }
                            else if (row[4].ToString() == "Leggings") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e3/Grid_Diamond_Leggings.png"; }
                            else if (row[4].ToString() == "Boots") { img_2.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/d/d1/Grid_Diamond_Boots.png"; }
                        }
                        else if (imgClass_2.Text == "ArmourSpecial" || imgClass_2.Text == "ArmourQuest")
                        {
                            if (row[4].ToString() == "Helmet") { img_2.ImageLocation = "http://imgur.com/Z3urkUb.png"; }
                            else if (row[4].ToString() == "Chestplate") { img_2.ImageLocation = "http://imgur.com/XQsTi5q.png"; }
                            else if (row[4].ToString() == "Leggings") { img_2.ImageLocation = "http://imgur.com/Ei6Mmto.png"; }
                            else if (row[4].ToString() == "Boots") { img_2.ImageLocation = "http://imgur.com/xH0lieT.png"; }
                        }
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
            if (imgSelected == 1)
            {
                int cc = 0;
                if (custE.Text == "") { eml.Text = ""; }
                cc = 0; Int32.TryParse(custE.Text, out cc);
                if (cc == 0) { custE.Text = ""; emlI.Visible = false; }
                else { eml.Visible = true; emlI.Visible = true; eml.Text = custE.Text; }
            }
            if (imgSelected == 2)
            {
                int cc_2 = 0;
                if (custE_2.Text == "") { eml_2.Text = ""; }
                cc_2 = 0; Int32.TryParse(custE_2.Text, out cc_2);
                if (cc_2 == 0) { custE_2.Text = ""; emlI_2.Visible = false; }
                else { eml_2.Visible = true; emlI_2.Visible = true; eml_2.Text = custE_2.Text; }
            }
        }
        private void custEB_TextChanged(object sender, EventArgs e)
        {
            if (imgSelected == 1)
            {
                int cc2 = 0;
                if (custEB.Text == "") { ebl.Text = ""; }
                cc2 = 0; Int32.TryParse(custEB.Text, out cc2);
                if (cc2 == 0) { custEB.Text = ""; eblI.Visible = false; }
                else { ebl.Visible = true; eblI.Visible = true; ebl.Text = custEB.Text; }
            }
            if (imgSelected == 2)
            {
                int cc2_2 = 0;
                if (custEB_2.Text == "") { ebl_2.Text = ""; }
                cc2_2 = 0; Int32.TryParse(custEB_2.Text, out cc2_2);
                if (cc2_2 == 0) { custEB_2.Text = ""; eblI_2.Visible = false; }
                else { ebl_2.Visible = true; eblI_2.Visible = true; ebl_2.Text = custEB_2.Text; }
            }
        }
        private void custLE_TextChanged(object sender, EventArgs e)
        {
            if (imgSelected == 1)
            {
                int cc3 = 0;
                if (custLE.Text == "") { lel.Text = ""; }
                cc3 = 0; Int32.TryParse(custLE.Text, out cc3);
                if (cc3 == 0) { custLE.Text = ""; lelI.Visible = false; }
                else { lel.Visible = true; lelI.Visible = true; lel.Text = custLE.Text; }
            }
            if (imgSelected == 2)
            {
                int cc3_2 = 0;
                if (custLE_2.Text == "") { lel_2.Text = ""; }
                cc3_2 = 0; Int32.TryParse(custLE_2.Text, out cc3_2);
                if (cc3_2 == 0) { custLE_2.Text = ""; lelI_2.Visible = false; }
                else { lel_2.Visible = true; lelI_2.Visible = true; lel_2.Text = custLE_2.Text; }
            }
        }
        #endregion
        #region Colors
        private void colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colors.SelectedIndex == 0) { mccolors = false; }
            else if (colors.SelectedIndex == 1) { mccolors = true; }
            else { mccolors = false; }
            if (mccolors) { mColor(); }
            else if (!mccolors) { idbColor(); }
        }
        private void idbColor()
        {
            namePic.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            statPic.ForeColor = System.Drawing.Color.Teal;
            lvlPic.ForeColor = System.Drawing.Color.DeepSkyBlue;
            HR.ForeColor = System.Drawing.Color.Indigo; MR.ForeColor = System.Drawing.Color.Indigo; LS.ForeColor = System.Drawing.Color.Indigo;
            MS.ForeColor = System.Drawing.Color.Indigo; XB.ForeColor = System.Drawing.Color.Indigo; LB.ForeColor = System.Drawing.Color.Indigo;
            SD.ForeColor = System.Drawing.Color.Indigo;
            if (P.Text == "Sharpness I" || P.Text == "Thorns I") { P.ForeColor = System.Drawing.Color.Green; }
            else if (P.Text == "Sharpness II" || P.Text == "Thorns II") { P.ForeColor = System.Drawing.Color.DarkGreen; }
            else if (P.Text == "Fire Aspect I" || P.Text == "Blast Protection I") { P.ForeColor = System.Drawing.Color.Red; }
            else if (P.Text == "Fire Aspect II" || P.Text == "Blast Protection II") { P.ForeColor = System.Drawing.Color.DarkRed; }
            else if (P.Text == "Knockback I" || P.Text == "Feather Falling I") { P.ForeColor = System.Drawing.Color.Blue; }
            else if (P.Text == "Knockback II" || P.Text == "Feather Falling II") { P.ForeColor = System.Drawing.Color.DarkBlue; }
            namePic_2.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0);
            statPic_2.ForeColor = System.Drawing.Color.Teal;
            lvlPic_2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            HR_2.ForeColor = System.Drawing.Color.Indigo; MR_2.ForeColor = System.Drawing.Color.Indigo; LS_2.ForeColor = System.Drawing.Color.Indigo;
            MS_2.ForeColor = System.Drawing.Color.Indigo; XB_2.ForeColor = System.Drawing.Color.Indigo; LB_2.ForeColor = System.Drawing.Color.Indigo;
            SD_2.ForeColor = System.Drawing.Color.Indigo;
            if (P_2.Text == "Sharpness I" || P_2.Text == "Thorns I") { P_2.ForeColor = System.Drawing.Color.Green; }
            else if (P_2.Text == "Sharpness II" || P_2.Text == "Thorns II") { P_2.ForeColor = System.Drawing.Color.DarkGreen; }
            else if (P_2.Text == "Fire Aspect I" || P_2.Text == "Blast Protection I") { P_2.ForeColor = System.Drawing.Color.Red; }
            else if (P_2.Text == "Fire Aspect II" || P_2.Text == "Blast Protection II") { P_2.ForeColor = System.Drawing.Color.DarkRed; }
            else if (P_2.Text == "Knockback I" || P_2.Text == "Feather Falling I") { P_2.ForeColor = System.Drawing.Color.Blue; }
            else if (P_2.Text == "Knockback II" || P_2.Text == "Feather Falling II") { P_2.ForeColor = System.Drawing.Color.DarkBlue; }
        }
        private void mColor()
        {
            statPic.ForeColor = System.Drawing.Color.Purple;
            lvlPic.ForeColor = System.Drawing.Color.Gold;
            HR.ForeColor = System.Drawing.Color.Gray; MR.ForeColor = System.Drawing.Color.Gray; LS.ForeColor = System.Drawing.Color.Gray;
            MS.ForeColor = System.Drawing.Color.Gray; XB.ForeColor = System.Drawing.Color.Gray; LB.ForeColor = System.Drawing.Color.Gray;
            SD.ForeColor = System.Drawing.Color.Gray;
            P.ForeColor = System.Drawing.Color.Gray;
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == namePic.Text)
                {
                    if (row[5].ToString() == "Basic") { namePic.ForeColor = System.Drawing.Color.White; }
                    else if (row[5].ToString() == "Unique") { namePic.ForeColor = System.Drawing.Color.Yellow; }
                    else if (row[5].ToString() == "Rare") { namePic.ForeColor = System.Drawing.Color.Magenta; }
                    else if (row[5].ToString() == "Legendary") { namePic.ForeColor = System.Drawing.Color.DeepSkyBlue; }
                    else if (row[5].ToString() == "Special") { namePic.ForeColor = System.Drawing.Color.White; }
                    else if (row[5].ToString() == "Quest") { namePic.ForeColor = System.Drawing.Color.White; }
                }
            }
            statPic_2.ForeColor = System.Drawing.Color.Purple;
            lvlPic_2.ForeColor = System.Drawing.Color.Gold;
            HR_2.ForeColor = System.Drawing.Color.Gray; MR_2.ForeColor = System.Drawing.Color.Gray; LS_2.ForeColor = System.Drawing.Color.Gray;
            MS_2.ForeColor = System.Drawing.Color.Gray; XB_2.ForeColor = System.Drawing.Color.Gray; LB_2.ForeColor = System.Drawing.Color.Gray;
            SD_2.ForeColor = System.Drawing.Color.Gray;
            P_2.ForeColor = System.Drawing.Color.Gray;
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == namePic_2.Text)
                {
                    if (row[5].ToString() == "Basic") { namePic_2.ForeColor = System.Drawing.Color.White; }
                    else if (row[5].ToString() == "Unique") { namePic_2.ForeColor = System.Drawing.Color.Yellow; }
                    else if (row[5].ToString() == "Rare") { namePic_2.ForeColor = System.Drawing.Color.Magenta; }
                    else if (row[5].ToString() == "Legendary") { namePic_2.ForeColor = System.Drawing.Color.DeepSkyBlue; }
                    else if (row[5].ToString() == "Special") { namePic_2.ForeColor = System.Drawing.Color.White; }
                }
            }
        }
        #endregion
        #region getImgData + IDC
        public void getImgData()
        {
            if (mccolors) { mColor(); }
            else if (!mccolors) { idbColor(); }
            if (imgSelected == 1)
            {
                if (sheetName == "Spears" || sheetName == "Wands" || sheetName == "Bows" || sheetName == "Daggers")
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row[1].ToString() == namePic.Text)
                        {
                            statPic.Text = "Dmg: " + row[3].ToString() + " - " + row[4].ToString();
                            switch(sheetName)
                            {
                                case "Spears": { imgClass.Text = "Spears"; }
                                    break;
                                case "Wands": { imgClass.Text = "Wands"; }
                                    break;
                                case "Bows": { imgClass.Text = "Bows"; }
                                    break;
                                case "Daggers": { imgClass.Text = "Daggers"; }
                                    break;
                            }
                        }
                    }
                    powder.Items.Clear(); powder.Items.Add((object)"None");
                    powder.Items.Add((object)"Sharpness I"); powder.Items.Add((object)"Sharpness II"); powder.Items.Add((object)"Fire Aspect I");
                    powder.Items.Add((object)"Fire Aspect II"); powder.Items.Add((object)"Knockback I"); powder.Items.Add((object)"Knockback II");
                    try { powder.SelectedIndex = 0; }
                    catch { }
                }
                else if (sheetName == "ArmourLeather" || sheetName == "ArmourGold" || sheetName == "ArmourChain" || sheetName == "ArmourIron" || sheetName == "ArmourDiamond" || sheetName == "ArmourSpecial" || sheetName == "ArmourQuest")
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row[1].ToString() == namePic.Text)
                        {
                            statPic.Text = "Def: " + row[3].ToString();
                            switch (sheetName)
                            {
                                case "ArmourLeather": { imgClass.Text = "ArmourLeather"; }
                                    break;
                                case "ArmourGold": { imgClass.Text = "ArmourGold"; }
                                    break;
                                case "ArmourChain": { imgClass.Text = "ArmourChain"; }
                                    break;
                                case "ArmourIron": { imgClass.Text = "ArmourIron"; }
                                    break;
                                case "ArmourDiamond": { imgClass.Text = "ArmourDiamond"; }
                                    break;
                                case "ArmourSpecial": { imgClass.Text = "ArmourSpecial"; }
                                    break;
                                case "ArmourQuest": { imgClass.Text = "ArmourQuest"; }
                                    break;
                            }
                        }
                    }
                    powder.Items.Clear(); powder.Items.Clear(); powder.Items.Add((object)"None");
                    powder.Items.Add((object)"Thorns I"); powder.Items.Add((object)"Thorns II"); powder.Items.Add((object)"Blast Protection I");
                    powder.Items.Add((object)"Blast Protection II"); powder.Items.Add((object)"Feather Falling I"); powder.Items.Add((object)"Feather Falling II");
                    try { powder.SelectedIndex = 0; }
                    catch { }
                }
                lvlPic.Text = "Min. Lvl: " + minLvlTxt.Text;
                if (custE.Text == "0" || custE.Text == "") { emlI.Visible = false; }
                else { emlI.Visible = true; eml.Text = custE.Text; }
                if (custEB.Text == "0" || custEB.Text == "") { eblI.Visible = false; }
                else { eblI.Visible = true; ebl.Text = custE.Text; }
                if (custLE.Text == "0" || custLE.Text == "") { lelI.Visible = false; }
                else { lelI.Visible = true; lel.Text = custE.Text; }
                namePic.Text = nameTxt.Text;
                if (nameTxt.Text == "Purified Helmet of the Legends") { namePic.Text = "Helmet of the Legends"; }
                if (healthRgnTxt.Text != "None") { HR.Text = "Health Rgn: " + healthRgnTxt.Text; HR.Visible = true; } else { HR.Text = ""; HR.Visible = false; }
                if (manaRgnTxt.Text != "None") { MR.Text = "Mana Rgn: " + manaRgnTxt.Text; MR.Visible = true; } else { MR.Text = ""; MR.Visible = false; }
                if (spellDmgTxt.Text != "None") { SD.Text = "Spell Dmg: " + "+" + spellDmgTxt.Text + "%"; SD.Visible = true; } else { SD.Text = ""; SD.Visible = false; }
                if (lifeStlTxt.Text != "None") { LS.Text = "Life Stl: " + lifeStlTxt.Text; LS.Visible = true; } else { LS.Text = ""; LS.Visible = false; }
                if (manaStlTxt.Text != "None") { MS.Text = "Mana Stl: " + manaStlTxt.Text; MS.Visible = true; } else { MS.Text = ""; MS.Visible = false; }
                if (xpBnsTxt.Text != "None") { XB.Text = "XP Bns: " + "+" + xpBnsTxt.Text + "%"; XB.Visible = true; } else { XB.Text = ""; XB.Visible = false; }
                if (lootBnsTxt.Text != "None") { LB.Text = "Loot Bns: " + "+" + lootBnsTxt.Text; LB.Visible = true; } else { LB.Text = ""; LB.Visible = false; }
            }
            else if (imgSelected == 2)
            {
                if (sheetName == "Spears" || sheetName == "Wands" || sheetName == "Bows" || sheetName == "Daggers")
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row[1].ToString() == namePic_2.Text)
                        {
                            statPic_2.Text = "Dmg: " + row[3].ToString() + " - " + row[4].ToString();
                            switch (sheetName)
                            {
                                case "Spears": { imgClass_2.Text = "Spears"; }
                                    break;
                                case "Wands": { imgClass_2.Text = "Wands"; }
                                    break;
                                case "Bows": { imgClass_2.Text = "Bows"; }
                                    break;
                                case "Daggers": { imgClass_2.Text = "Daggers"; }
                                    break;
                            }
                        }
                    }
                    powder_2.Items.Clear(); powder_2.Items.Add((object)"None");
                    powder_2.Items.Add((object)"Sharpness I"); powder_2.Items.Add((object)"Sharpness II"); powder_2.Items.Add((object)"Fire Aspect I");
                    powder_2.Items.Add((object)"Fire Aspect II"); powder_2.Items.Add((object)"Knockback I"); powder_2.Items.Add((object)"Knockback II");
                    try { powder_2.SelectedIndex = 0; }
                    catch { }
                }
                else if (sheetName == "ArmourLeather" || sheetName == "ArmourGold" || sheetName == "ArmourChain" || sheetName == "ArmourIron" || sheetName == "ArmourDiamond" || sheetName == "ArmourSpecial" || sheetName == "ArmourQuest")
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row[1].ToString() == namePic_2.Text)
                        {
                            statPic_2.Text = "Def: " + row[3].ToString();
                            switch (sheetName)
                            {
                                case "ArmourLeather": { imgClass_2.Text = "ArmourLeather"; }
                                    break;
                                case "ArmourGold": { imgClass_2.Text = "ArmourGold"; }
                                    break;
                                case "ArmourChain": { imgClass_2.Text = "ArmourChain"; }
                                    break;
                                case "ArmourIron": { imgClass_2.Text = "ArmourIron"; }
                                    break;
                                case "ArmourDiamond": { imgClass_2.Text = "ArmourDiamond"; }
                                    break;
                                case "ArmourSpecial": { imgClass_2.Text = "ArmourSpecial"; }
                                    break;
                                case "ArmourQuest": { imgClass_2.Text = "ArmourQuest"; }
                                    break;
                            }
                        }
                    }
                    powder_2.Items.Clear(); powder_2.Items.Clear(); powder_2.Items.Add((object)"None");
                    powder_2.Items.Add((object)"Thorns I"); powder_2.Items.Add((object)"Thorns II"); powder_2.Items.Add((object)"Blast Protection I");
                    powder_2.Items.Add((object)"Blast Protection II"); powder_2.Items.Add((object)"Feather Falling I"); powder_2.Items.Add((object)"Feather Falling II");
                    try { powder_2.SelectedIndex = 0; }
                    catch { }
                }
                lvlPic_2.Text = "Min. Lvl: " + minLvlTxt.Text;
                if (custE_2.Text == "0" || custE_2.Text == "") { emlI_2.Visible = false; }
                else { emlI_2.Visible = true; eml_2.Text = custE.Text; }
                if (custEB_2.Text == "0" || custEB_2.Text == "") { eblI_2.Visible = false; }
                else { eblI_2.Visible = true; ebl_2.Text = custE_2.Text; }
                if (custLE_2.Text == "0" || custLE_2.Text == "") { lelI_2.Visible = false; }
                else { lelI_2.Visible = true; lel_2.Text = custE_2.Text; }
                namePic_2.Text = nameTxt.Text;
                if (nameTxt.Text == "Purified Helmet of the Legends") { namePic_2.Text = "Helmet of the Legends"; }
                if (healthRgnTxt.Text != "None") { HR_2.Text = "Health Rgn: " + healthRgnTxt.Text; HR_2.Visible = true; } else { HR_2.Text = ""; HR_2.Visible = false; }
                if (manaRgnTxt.Text != "None") { MR_2.Text = "Mana Rgn: " + manaRgnTxt.Text; MR_2.Visible = true; } else { MR_2.Text = ""; MR_2.Visible = false; }
                if (spellDmgTxt.Text != "None") { SD_2.Text = "Spell Dmg: " + "+" + spellDmgTxt.Text + "%"; SD_2.Visible = true; } else { SD_2.Text = ""; SD_2.Visible = false; }
                if (lifeStlTxt.Text != "None") { LS_2.Text = "Life Stl: " + lifeStlTxt.Text; LS_2.Visible = true; } else { LS_2.Text = ""; LS_2.Visible = false; }
                if (manaStlTxt.Text != "None") { MS_2.Text = "Mana Stl: " + manaStlTxt.Text; MS_2.Visible = true; } else { MS_2.Text = ""; MS_2.Visible = false; }
                if (xpBnsTxt.Text != "None") { XB_2.Text = "XP Bns: " + "+" + xpBnsTxt.Text + "%"; XB_2.Visible = true; } else { XB_2.Text = ""; XB_2.Visible = false; }
                if (lootBnsTxt.Text != "None") { LB_2.Text = "Loot Bns: " + "+" + lootBnsTxt.Text; LB_2.Visible = true; } else { LB_2.Text = ""; LB_2.Visible = false; }
            }
        }
        private void healthRgnTxt_TextChanged(object sender, EventArgs e)
        {
            getImgData();
        }
        private void manaRgnTxt_TextChanged(object sender, EventArgs e)
        {
            getImgData();
        }
        private void lifeStlTxt_TextChanged(object sender, EventArgs e)
        {
            getImgData();
        }
        private void manaStlTxt_TextChanged(object sender, EventArgs e)
        {
            getImgData();
        }
        private void xpBnsTxt_TextChanged(object sender, EventArgs e)
        {
            getImgData();
        }
        private void lootBnsTxt_TextChanged(object sender, EventArgs e)
        {
            getImgData();
        }
        private void spellDmgTxt_TextChanged(object sender, EventArgs e)
        {
            getImgData();
        }
        #endregion
        #region powder
        private void powder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sheetName == "Spears" || sheetName == "Wands" || sheetName == "Bows" || sheetName == "Daggers")
            {
                if (powder.Text != "None") { P.Text = powder.Text; P.Visible = true; } else { powder.Text = ""; P.Visible = false; }
            }
            else if (sheetName == "ArmourLeather" || sheetName == "ArmourGold" || sheetName == "ArmourChain" || sheetName == "ArmourIron" || sheetName == "ArmourDiamond" || sheetName == "ArmourSpecial" || sheetName == "ArmourQuest")
            {
                if (powder.Text != "None") { P.Text = powder.Text; P.Visible = true; } else { powder.Text = ""; P.Visible = false; }
            }
            if (!mccolors)
            {
                if (P.Text == "Sharpness I" || P.Text == "Thorns I") { P.ForeColor = System.Drawing.Color.LightGreen; }
                else if (P.Text == "Sharpness II" || P.Text == "Thorns II") { P.ForeColor = System.Drawing.Color.Green; }
                else if (P.Text == "Fire Aspect I" || P.Text == "Blast Protection I") { P.ForeColor = System.Drawing.Color.Red; }
                else if (P.Text == "Fire Aspect II" || P.Text == "Blast Protection II") { P.ForeColor = System.Drawing.Color.DarkRed; }
                else if (P.Text == "Knockback I" || P.Text == "Feather Falling I") { P.ForeColor = System.Drawing.Color.LightBlue; }
                else if (P.Text == "Knockback II" || P.Text == "Feather Falling II") { P.ForeColor = System.Drawing.Color.Blue; }
            }
            else
            {
                P.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void powder_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sheetName == "Spears" || sheetName == "Wands" || sheetName == "Bows" || sheetName == "Daggers")
            {
                if (powder_2.Text != "None") { P_2.Text = powder_2.Text; P_2.Visible = true; } else { powder_2.Text = ""; P_2.Visible = false; }
            }
            else if (sheetName == "ArmourLeather" || sheetName == "ArmourGold" || sheetName == "ArmourChain" || sheetName == "ArmourIron" || sheetName == "ArmourDiamond" || sheetName == "ArmourSpecial" || sheetName == "ArmourQuest")
            {
                if (powder_2.Text != "None") { P_2.Text = powder_2.Text; P_2.Visible = true; } else { powder_2.Text = ""; P_2.Visible = false; }
            }
            if (!mccolors)
            {
                if (P_2.Text == "Sharpness I" || P_2.Text == "Thorns I") { P_2.ForeColor = System.Drawing.Color.LightGreen; }
                else if (P_2.Text == "Sharpness II" || P_2.Text == "Thorns II") { P_2.ForeColor = System.Drawing.Color.Green; }
                else if (P_2.Text == "Fire Aspect I" || P_2.Text == "Blast P_2rotection I") { P_2.ForeColor = System.Drawing.Color.Red; }
                else if (P_2.Text == "Fire Aspect II" || P_2.Text == "Blast P_2rotection II") { P_2.ForeColor = System.Drawing.Color.DarkRed; }
                else if (P_2.Text == "Knockback I" || P_2.Text == "Feather Falling I") { P_2.ForeColor = System.Drawing.Color.LightBlue; }
                else if (P_2.Text == "Knockback II" || P_2.Text == "Feather Falling II") { P_2.ForeColor = System.Drawing.Color.Blue; }
            }
            else
            {
                P_2.ForeColor = System.Drawing.Color.Gray;
            }
        }
        #endregion
        #region imgSelect
        private void imgSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imgSelect.SelectedItem.ToString() == "First") { imgSelected = 1; }
            if (imgSelect.SelectedItem.ToString() == "Second") { imgSelected = 2; }
            else { imgSelected = 1; }
        }
        #endregion
    }
}

