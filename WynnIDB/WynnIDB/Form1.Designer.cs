namespace WynnIDB
{
    partial class wynnidb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wynnidb));
            this.itemClass = new System.Windows.Forms.ComboBox();
            this.itemNames = new System.Windows.Forms.ComboBox();
            this.UniqueB = new System.Windows.Forms.RadioButton();
            this.RareB = new System.Windows.Forms.RadioButton();
            this.LegendaryB = new System.Windows.Forms.RadioButton();
            this.BasicB = new System.Windows.Forms.RadioButton();
            this.AllB = new System.Windows.Forms.RadioButton();
            this.minDmg = new System.Windows.Forms.PictureBox();
            this.maxDmg = new System.Windows.Forms.PictureBox();
            this.def = new System.Windows.Forms.PictureBox();
            this.minLvl = new System.Windows.Forms.PictureBox();
            this.avgDmg = new System.Windows.Forms.PictureBox();
            this.cls = new System.Windows.Forms.PictureBox();
            this.piece = new System.Windows.Forms.PictureBox();
            this.minDmgTxt = new System.Windows.Forms.TextBox();
            this.maxDmgTxt = new System.Windows.Forms.TextBox();
            this.avgDmgTxt = new System.Windows.Forms.TextBox();
            this.minLvlTxt = new System.Windows.Forms.TextBox();
            this.clsTxt = new System.Windows.Forms.TextBox();
            this.pieceTxt = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.PictureBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.defTxt = new System.Windows.Forms.TextBox();
            this.tier = new System.Windows.Forms.PictureBox();
            this.tierTxt = new System.Windows.Forms.TextBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.PictureBox();
            this.cost = new System.Windows.Forms.PictureBox();
            this.healthRgn = new System.Windows.Forms.PictureBox();
            this.manaRgn = new System.Windows.Forms.PictureBox();
            this.spellDmg = new System.Windows.Forms.PictureBox();
            this.lifeStl = new System.Windows.Forms.PictureBox();
            this.manaStl = new System.Windows.Forms.PictureBox();
            this.xpBns = new System.Windows.Forms.PictureBox();
            this.lootBns = new System.Windows.Forms.PictureBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.costTxt = new System.Windows.Forms.TextBox();
            this.healthRgnTxt = new System.Windows.Forms.TextBox();
            this.manaRgnTxt = new System.Windows.Forms.TextBox();
            this.spellDmgTxt = new System.Windows.Forms.TextBox();
            this.lifeStlTxt = new System.Windows.Forms.TextBox();
            this.manaStlTxt = new System.Windows.Forms.TextBox();
            this.xpBnsTxt = new System.Windows.Forms.TextBox();
            this.lootBnsTxt = new System.Windows.Forms.TextBox();
            this.credits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.def)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthRgn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaRgn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeStl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaStl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootBns)).BeginInit();
            this.SuspendLayout();
            // 
            // itemClass
            // 
            this.itemClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemClass.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemClass.FormattingEnabled = true;
            this.itemClass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.itemClass.Items.AddRange(new object[] {
            "Spears",
            "Wands",
            "Bows",
            "Daggers",
            "Leather Armour",
            "Gold Armour",
            "Chain Armour",
            "Iron Armour",
            "Diamond Armour",
            "Special Armour",
            "Quest Armour"});
            this.itemClass.Location = new System.Drawing.Point(12, 12);
            this.itemClass.MaxDropDownItems = 5;
            this.itemClass.Name = "itemClass";
            this.itemClass.Size = new System.Drawing.Size(467, 27);
            this.itemClass.TabIndex = 0;
            this.itemClass.SelectedIndexChanged += new System.EventHandler(this.itemClass_SelectedIndexChanged);
            // 
            // itemNames
            // 
            this.itemNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemNames.Font = new System.Drawing.Font("Minecraft", 12.5F);
            this.itemNames.FormattingEnabled = true;
            this.itemNames.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.itemNames.IntegralHeight = false;
            this.itemNames.Location = new System.Drawing.Point(12, 101);
            this.itemNames.MaxDropDownItems = 9;
            this.itemNames.Name = "itemNames";
            this.itemNames.Size = new System.Drawing.Size(318, 25);
            this.itemNames.TabIndex = 2;
            this.itemNames.SelectedIndexChanged += new System.EventHandler(this.itemNames_SelectedIndexChanged);
            // 
            // UniqueB
            // 
            this.UniqueB.AutoSize = true;
            this.UniqueB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UniqueB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UniqueB.BackgroundImage")));
            this.UniqueB.Font = new System.Drawing.Font("Minecraft", 12.5F, System.Drawing.FontStyle.Italic);
            this.UniqueB.ForeColor = System.Drawing.SystemColors.Control;
            this.UniqueB.Location = new System.Drawing.Point(100, 57);
            this.UniqueB.Name = "UniqueB";
            this.UniqueB.Size = new System.Drawing.Size(95, 21);
            this.UniqueB.TabIndex = 4;
            this.UniqueB.TabStop = true;
            this.UniqueB.Text = "Unique";
            this.UniqueB.UseVisualStyleBackColor = false;
            // 
            // RareB
            // 
            this.RareB.AutoSize = true;
            this.RareB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RareB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RareB.BackgroundImage")));
            this.RareB.Font = new System.Drawing.Font("Minecraft", 12.5F, System.Drawing.FontStyle.Italic);
            this.RareB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RareB.Location = new System.Drawing.Point(201, 57);
            this.RareB.Name = "RareB";
            this.RareB.Size = new System.Drawing.Size(78, 21);
            this.RareB.TabIndex = 5;
            this.RareB.TabStop = true;
            this.RareB.Text = "Rare";
            this.RareB.UseVisualStyleBackColor = false;
            // 
            // LegendaryB
            // 
            this.LegendaryB.AutoSize = true;
            this.LegendaryB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LegendaryB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LegendaryB.BackgroundImage")));
            this.LegendaryB.Font = new System.Drawing.Font("Minecraft", 12.5F, System.Drawing.FontStyle.Italic);
            this.LegendaryB.ForeColor = System.Drawing.SystemColors.Control;
            this.LegendaryB.Location = new System.Drawing.Point(285, 57);
            this.LegendaryB.Name = "LegendaryB";
            this.LegendaryB.Size = new System.Drawing.Size(143, 21);
            this.LegendaryB.TabIndex = 6;
            this.LegendaryB.TabStop = true;
            this.LegendaryB.Text = "Legendary";
            this.LegendaryB.UseVisualStyleBackColor = false;
            // 
            // BasicB
            // 
            this.BasicB.AutoSize = true;
            this.BasicB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BasicB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BasicB.BackgroundImage")));
            this.BasicB.Font = new System.Drawing.Font("Minecraft", 12.5F, System.Drawing.FontStyle.Italic);
            this.BasicB.ForeColor = System.Drawing.SystemColors.Control;
            this.BasicB.Location = new System.Drawing.Point(12, 57);
            this.BasicB.Name = "BasicB";
            this.BasicB.Size = new System.Drawing.Size(82, 21);
            this.BasicB.TabIndex = 7;
            this.BasicB.TabStop = true;
            this.BasicB.Text = "Basic";
            this.BasicB.UseVisualStyleBackColor = false;
            // 
            // AllB
            // 
            this.AllB.AutoSize = true;
            this.AllB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AllB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllB.BackgroundImage")));
            this.AllB.Font = new System.Drawing.Font("Minecraft", 12.5F, System.Drawing.FontStyle.Italic);
            this.AllB.ForeColor = System.Drawing.SystemColors.Control;
            this.AllB.Location = new System.Drawing.Point(434, 57);
            this.AllB.Name = "AllB";
            this.AllB.Size = new System.Drawing.Size(51, 21);
            this.AllB.TabIndex = 8;
            this.AllB.TabStop = true;
            this.AllB.Text = "All";
            this.AllB.UseVisualStyleBackColor = false;
            // 
            // minDmg
            // 
            this.minDmg.Image = ((System.Drawing.Image)(resources.GetObject("minDmg.Image")));
            this.minDmg.Location = new System.Drawing.Point(30, 202);
            this.minDmg.Name = "minDmg";
            this.minDmg.Size = new System.Drawing.Size(116, 31);
            this.minDmg.TabIndex = 14;
            this.minDmg.TabStop = false;
            // 
            // maxDmg
            // 
            this.maxDmg.Image = ((System.Drawing.Image)(resources.GetObject("maxDmg.Image")));
            this.maxDmg.Location = new System.Drawing.Point(30, 240);
            this.maxDmg.Name = "maxDmg";
            this.maxDmg.Size = new System.Drawing.Size(116, 31);
            this.maxDmg.TabIndex = 15;
            this.maxDmg.TabStop = false;
            // 
            // def
            // 
            this.def.Image = ((System.Drawing.Image)(resources.GetObject("def.Image")));
            this.def.Location = new System.Drawing.Point(30, 388);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(116, 31);
            this.def.TabIndex = 16;
            this.def.TabStop = false;
            // 
            // minLvl
            // 
            this.minLvl.Image = ((System.Drawing.Image)(resources.GetObject("minLvl.Image")));
            this.minLvl.Location = new System.Drawing.Point(30, 314);
            this.minLvl.Name = "minLvl";
            this.minLvl.Size = new System.Drawing.Size(116, 31);
            this.minLvl.TabIndex = 17;
            this.minLvl.TabStop = false;
            // 
            // avgDmg
            // 
            this.avgDmg.Image = ((System.Drawing.Image)(resources.GetObject("avgDmg.Image")));
            this.avgDmg.Location = new System.Drawing.Point(30, 277);
            this.avgDmg.Name = "avgDmg";
            this.avgDmg.Size = new System.Drawing.Size(116, 31);
            this.avgDmg.TabIndex = 19;
            this.avgDmg.TabStop = false;
            // 
            // cls
            // 
            this.cls.Image = ((System.Drawing.Image)(resources.GetObject("cls.Image")));
            this.cls.Location = new System.Drawing.Point(30, 351);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(116, 31);
            this.cls.TabIndex = 20;
            this.cls.TabStop = false;
            // 
            // piece
            // 
            this.piece.Image = ((System.Drawing.Image)(resources.GetObject("piece.Image")));
            this.piece.Location = new System.Drawing.Point(270, 388);
            this.piece.Name = "piece";
            this.piece.Size = new System.Drawing.Size(116, 31);
            this.piece.TabIndex = 21;
            this.piece.TabStop = false;
            // 
            // minDmgTxt
            // 
            this.minDmgTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.minDmgTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minDmgTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.minDmgTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.minDmgTxt.ForeColor = System.Drawing.Color.Indigo;
            this.minDmgTxt.Location = new System.Drawing.Point(152, 210);
            this.minDmgTxt.Name = "minDmgTxt";
            this.minDmgTxt.ReadOnly = true;
            this.minDmgTxt.Size = new System.Drawing.Size(354, 15);
            this.minDmgTxt.TabIndex = 22;
            // 
            // maxDmgTxt
            // 
            this.maxDmgTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.maxDmgTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxDmgTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxDmgTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.maxDmgTxt.ForeColor = System.Drawing.Color.Indigo;
            this.maxDmgTxt.Location = new System.Drawing.Point(152, 247);
            this.maxDmgTxt.Name = "maxDmgTxt";
            this.maxDmgTxt.ReadOnly = true;
            this.maxDmgTxt.Size = new System.Drawing.Size(354, 15);
            this.maxDmgTxt.TabIndex = 23;
            // 
            // avgDmgTxt
            // 
            this.avgDmgTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.avgDmgTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avgDmgTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.avgDmgTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.avgDmgTxt.ForeColor = System.Drawing.Color.Indigo;
            this.avgDmgTxt.Location = new System.Drawing.Point(152, 284);
            this.avgDmgTxt.Name = "avgDmgTxt";
            this.avgDmgTxt.ReadOnly = true;
            this.avgDmgTxt.Size = new System.Drawing.Size(354, 15);
            this.avgDmgTxt.TabIndex = 24;
            // 
            // minLvlTxt
            // 
            this.minLvlTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.minLvlTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minLvlTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.minLvlTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.minLvlTxt.ForeColor = System.Drawing.Color.Indigo;
            this.minLvlTxt.Location = new System.Drawing.Point(152, 321);
            this.minLvlTxt.Name = "minLvlTxt";
            this.minLvlTxt.ReadOnly = true;
            this.minLvlTxt.Size = new System.Drawing.Size(114, 15);
            this.minLvlTxt.TabIndex = 25;
            // 
            // clsTxt
            // 
            this.clsTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.clsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clsTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.clsTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.clsTxt.ForeColor = System.Drawing.Color.Indigo;
            this.clsTxt.Location = new System.Drawing.Point(152, 358);
            this.clsTxt.Name = "clsTxt";
            this.clsTxt.ReadOnly = true;
            this.clsTxt.Size = new System.Drawing.Size(114, 15);
            this.clsTxt.TabIndex = 26;
            // 
            // pieceTxt
            // 
            this.pieceTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.pieceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pieceTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.pieceTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.pieceTxt.ForeColor = System.Drawing.Color.Indigo;
            this.pieceTxt.Location = new System.Drawing.Point(392, 395);
            this.pieceTxt.Name = "pieceTxt";
            this.pieceTxt.ReadOnly = true;
            this.pieceTxt.Size = new System.Drawing.Size(114, 15);
            this.pieceTxt.TabIndex = 27;
            // 
            // name
            // 
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(30, 166);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(116, 31);
            this.name.TabIndex = 28;
            this.name.TabStop = false;
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.nameTxt.ForeColor = System.Drawing.Color.Indigo;
            this.nameTxt.Location = new System.Drawing.Point(152, 173);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.ReadOnly = true;
            this.nameTxt.Size = new System.Drawing.Size(354, 15);
            this.nameTxt.TabIndex = 29;
            // 
            // defTxt
            // 
            this.defTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.defTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.defTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.defTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.defTxt.ForeColor = System.Drawing.Color.Indigo;
            this.defTxt.Location = new System.Drawing.Point(152, 395);
            this.defTxt.Name = "defTxt";
            this.defTxt.ReadOnly = true;
            this.defTxt.Size = new System.Drawing.Size(114, 15);
            this.defTxt.TabIndex = 30;
            // 
            // tier
            // 
            this.tier.Image = ((System.Drawing.Image)(resources.GetObject("tier.Image")));
            this.tier.Location = new System.Drawing.Point(270, 351);
            this.tier.Name = "tier";
            this.tier.Size = new System.Drawing.Size(116, 31);
            this.tier.TabIndex = 31;
            this.tier.TabStop = false;
            // 
            // tierTxt
            // 
            this.tierTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.tierTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tierTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.tierTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.tierTxt.ForeColor = System.Drawing.Color.Indigo;
            this.tierTxt.Location = new System.Drawing.Point(392, 358);
            this.tierTxt.Name = "tierTxt";
            this.tierTxt.ReadOnly = true;
            this.tierTxt.Size = new System.Drawing.Size(114, 15);
            this.tierTxt.TabIndex = 32;
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img.Location = new System.Drawing.Point(392, 424);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(32, 32);
            this.img.TabIndex = 57;
            this.img.TabStop = false;
            // 
            // id
            // 
            this.id.Image = ((System.Drawing.Image)(resources.GetObject("id.Image")));
            this.id.Location = new System.Drawing.Point(270, 314);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(116, 31);
            this.id.TabIndex = 62;
            this.id.TabStop = false;
            // 
            // cost
            // 
            this.cost.Image = ((System.Drawing.Image)(resources.GetObject("cost.Image")));
            this.cost.Location = new System.Drawing.Point(30, 425);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(116, 31);
            this.cost.TabIndex = 63;
            this.cost.TabStop = false;
            // 
            // healthRgn
            // 
            this.healthRgn.Image = ((System.Drawing.Image)(resources.GetObject("healthRgn.Image")));
            this.healthRgn.Location = new System.Drawing.Point(512, 165);
            this.healthRgn.Name = "healthRgn";
            this.healthRgn.Size = new System.Drawing.Size(116, 31);
            this.healthRgn.TabIndex = 64;
            this.healthRgn.TabStop = false;
            // 
            // manaRgn
            // 
            this.manaRgn.Image = ((System.Drawing.Image)(resources.GetObject("manaRgn.Image")));
            this.manaRgn.Location = new System.Drawing.Point(701, 165);
            this.manaRgn.Name = "manaRgn";
            this.manaRgn.Size = new System.Drawing.Size(116, 31);
            this.manaRgn.TabIndex = 65;
            this.manaRgn.TabStop = false;
            // 
            // spellDmg
            // 
            this.spellDmg.Image = ((System.Drawing.Image)(resources.GetObject("spellDmg.Image")));
            this.spellDmg.Location = new System.Drawing.Point(512, 277);
            this.spellDmg.Name = "spellDmg";
            this.spellDmg.Size = new System.Drawing.Size(116, 31);
            this.spellDmg.TabIndex = 66;
            this.spellDmg.TabStop = false;
            // 
            // lifeStl
            // 
            this.lifeStl.Image = ((System.Drawing.Image)(resources.GetObject("lifeStl.Image")));
            this.lifeStl.Location = new System.Drawing.Point(512, 202);
            this.lifeStl.Name = "lifeStl";
            this.lifeStl.Size = new System.Drawing.Size(116, 31);
            this.lifeStl.TabIndex = 67;
            this.lifeStl.TabStop = false;
            // 
            // manaStl
            // 
            this.manaStl.Image = ((System.Drawing.Image)(resources.GetObject("manaStl.Image")));
            this.manaStl.Location = new System.Drawing.Point(701, 202);
            this.manaStl.Name = "manaStl";
            this.manaStl.Size = new System.Drawing.Size(116, 31);
            this.manaStl.TabIndex = 68;
            this.manaStl.TabStop = false;
            // 
            // xpBns
            // 
            this.xpBns.Image = ((System.Drawing.Image)(resources.GetObject("xpBns.Image")));
            this.xpBns.Location = new System.Drawing.Point(512, 239);
            this.xpBns.Name = "xpBns";
            this.xpBns.Size = new System.Drawing.Size(116, 31);
            this.xpBns.TabIndex = 69;
            this.xpBns.TabStop = false;
            // 
            // lootBns
            // 
            this.lootBns.Image = ((System.Drawing.Image)(resources.GetObject("lootBns.Image")));
            this.lootBns.Location = new System.Drawing.Point(701, 240);
            this.lootBns.Name = "lootBns";
            this.lootBns.Size = new System.Drawing.Size(116, 31);
            this.lootBns.TabIndex = 70;
            this.lootBns.TabStop = false;
            // 
            // idTxt
            // 
            this.idTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.idTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.idTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.idTxt.ForeColor = System.Drawing.Color.Indigo;
            this.idTxt.Location = new System.Drawing.Point(392, 321);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(114, 15);
            this.idTxt.TabIndex = 71;
            // 
            // costTxt
            // 
            this.costTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.costTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.costTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.costTxt.ForeColor = System.Drawing.Color.Indigo;
            this.costTxt.Location = new System.Drawing.Point(152, 432);
            this.costTxt.Name = "costTxt";
            this.costTxt.ReadOnly = true;
            this.costTxt.Size = new System.Drawing.Size(114, 15);
            this.costTxt.TabIndex = 72;
            // 
            // healthRgnTxt
            // 
            this.healthRgnTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.healthRgnTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.healthRgnTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.healthRgnTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.healthRgnTxt.ForeColor = System.Drawing.Color.Indigo;
            this.healthRgnTxt.Location = new System.Drawing.Point(634, 173);
            this.healthRgnTxt.Name = "healthRgnTxt";
            this.healthRgnTxt.ReadOnly = true;
            this.healthRgnTxt.Size = new System.Drawing.Size(61, 15);
            this.healthRgnTxt.TabIndex = 73;
            // 
            // manaRgnTxt
            // 
            this.manaRgnTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.manaRgnTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manaRgnTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.manaRgnTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.manaRgnTxt.ForeColor = System.Drawing.Color.Indigo;
            this.manaRgnTxt.Location = new System.Drawing.Point(823, 173);
            this.manaRgnTxt.Name = "manaRgnTxt";
            this.manaRgnTxt.ReadOnly = true;
            this.manaRgnTxt.Size = new System.Drawing.Size(61, 15);
            this.manaRgnTxt.TabIndex = 74;
            // 
            // spellDmgTxt
            // 
            this.spellDmgTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.spellDmgTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spellDmgTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.spellDmgTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.spellDmgTxt.ForeColor = System.Drawing.Color.Indigo;
            this.spellDmgTxt.Location = new System.Drawing.Point(634, 210);
            this.spellDmgTxt.Name = "spellDmgTxt";
            this.spellDmgTxt.ReadOnly = true;
            this.spellDmgTxt.Size = new System.Drawing.Size(61, 15);
            this.spellDmgTxt.TabIndex = 75;
            // 
            // lifeStlTxt
            // 
            this.lifeStlTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.lifeStlTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lifeStlTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lifeStlTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.lifeStlTxt.ForeColor = System.Drawing.Color.Indigo;
            this.lifeStlTxt.Location = new System.Drawing.Point(823, 210);
            this.lifeStlTxt.Name = "lifeStlTxt";
            this.lifeStlTxt.ReadOnly = true;
            this.lifeStlTxt.Size = new System.Drawing.Size(61, 15);
            this.lifeStlTxt.TabIndex = 76;
            // 
            // manaStlTxt
            // 
            this.manaStlTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.manaStlTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manaStlTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.manaStlTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.manaStlTxt.ForeColor = System.Drawing.Color.Indigo;
            this.manaStlTxt.Location = new System.Drawing.Point(634, 284);
            this.manaStlTxt.Name = "manaStlTxt";
            this.manaStlTxt.ReadOnly = true;
            this.manaStlTxt.Size = new System.Drawing.Size(61, 15);
            this.manaStlTxt.TabIndex = 77;
            // 
            // xpBnsTxt
            // 
            this.xpBnsTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.xpBnsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpBnsTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.xpBnsTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.xpBnsTxt.ForeColor = System.Drawing.Color.Indigo;
            this.xpBnsTxt.Location = new System.Drawing.Point(634, 247);
            this.xpBnsTxt.Name = "xpBnsTxt";
            this.xpBnsTxt.ReadOnly = true;
            this.xpBnsTxt.Size = new System.Drawing.Size(61, 15);
            this.xpBnsTxt.TabIndex = 78;
            // 
            // lootBnsTxt
            // 
            this.lootBnsTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.lootBnsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lootBnsTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lootBnsTxt.Font = new System.Drawing.Font("Minecraft", 11F, System.Drawing.FontStyle.Bold);
            this.lootBnsTxt.ForeColor = System.Drawing.Color.Indigo;
            this.lootBnsTxt.Location = new System.Drawing.Point(823, 247);
            this.lootBnsTxt.Name = "lootBnsTxt";
            this.lootBnsTxt.ReadOnly = true;
            this.lootBnsTxt.Size = new System.Drawing.Size(61, 15);
            this.lootBnsTxt.TabIndex = 79;
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Minecraft", 11F);
            this.credits.ForeColor = System.Drawing.SystemColors.Control;
            this.credits.Location = new System.Drawing.Point(527, 19);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(337, 30);
            this.credits.TabIndex = 80;
            this.credits.Text = "WynnIDB v1.11_1 created by Acer78. \r\nOriginal Item Guide by Dakota.";
            // 
            // wynnidb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(904, 468);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.lootBnsTxt);
            this.Controls.Add(this.xpBnsTxt);
            this.Controls.Add(this.manaStlTxt);
            this.Controls.Add(this.lifeStlTxt);
            this.Controls.Add(this.spellDmgTxt);
            this.Controls.Add(this.manaRgnTxt);
            this.Controls.Add(this.healthRgnTxt);
            this.Controls.Add(this.costTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.lootBns);
            this.Controls.Add(this.xpBns);
            this.Controls.Add(this.manaStl);
            this.Controls.Add(this.lifeStl);
            this.Controls.Add(this.spellDmg);
            this.Controls.Add(this.manaRgn);
            this.Controls.Add(this.healthRgn);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.id);
            this.Controls.Add(this.img);
            this.Controls.Add(this.tierTxt);
            this.Controls.Add(this.tier);
            this.Controls.Add(this.defTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pieceTxt);
            this.Controls.Add(this.clsTxt);
            this.Controls.Add(this.minLvlTxt);
            this.Controls.Add(this.avgDmgTxt);
            this.Controls.Add(this.maxDmgTxt);
            this.Controls.Add(this.minDmgTxt);
            this.Controls.Add(this.piece);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.avgDmg);
            this.Controls.Add(this.minLvl);
            this.Controls.Add(this.def);
            this.Controls.Add(this.maxDmg);
            this.Controls.Add(this.minDmg);
            this.Controls.Add(this.AllB);
            this.Controls.Add(this.BasicB);
            this.Controls.Add(this.LegendaryB);
            this.Controls.Add(this.RareB);
            this.Controls.Add(this.UniqueB);
            this.Controls.Add(this.itemNames);
            this.Controls.Add(this.itemClass);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "wynnidb";
            this.Text = "WynnIDB [v1.11_1]";
            ((System.ComponentModel.ISupportInitialize)(this.minDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.def)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthRgn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaRgn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeStl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaStl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootBns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox itemClass;
        private System.Windows.Forms.ComboBox itemNames;
        private System.Windows.Forms.RadioButton UniqueB;
        private System.Windows.Forms.RadioButton RareB;
        private System.Windows.Forms.RadioButton LegendaryB;
        private System.Windows.Forms.RadioButton BasicB;
        private System.Windows.Forms.RadioButton AllB;
        private System.Windows.Forms.PictureBox minDmg;
        private System.Windows.Forms.PictureBox maxDmg;
        private System.Windows.Forms.PictureBox def;
        private System.Windows.Forms.PictureBox minLvl;
        private System.Windows.Forms.PictureBox avgDmg;
        private System.Windows.Forms.PictureBox cls;
        private System.Windows.Forms.PictureBox piece;
        private System.Windows.Forms.TextBox minDmgTxt;
        private System.Windows.Forms.TextBox maxDmgTxt;
        private System.Windows.Forms.TextBox avgDmgTxt;
        private System.Windows.Forms.TextBox minLvlTxt;
        private System.Windows.Forms.TextBox clsTxt;
        private System.Windows.Forms.TextBox pieceTxt;
        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox defTxt;
        private System.Windows.Forms.PictureBox tier;
        private System.Windows.Forms.TextBox tierTxt;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.PictureBox id;
        private System.Windows.Forms.PictureBox cost;
        private System.Windows.Forms.PictureBox healthRgn;
        private System.Windows.Forms.PictureBox manaRgn;
        private System.Windows.Forms.PictureBox spellDmg;
        private System.Windows.Forms.PictureBox lifeStl;
        private System.Windows.Forms.PictureBox manaStl;
        private System.Windows.Forms.PictureBox xpBns;
        private System.Windows.Forms.PictureBox lootBns;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox costTxt;
        private System.Windows.Forms.TextBox healthRgnTxt;
        private System.Windows.Forms.TextBox manaRgnTxt;
        private System.Windows.Forms.TextBox spellDmgTxt;
        private System.Windows.Forms.TextBox lifeStlTxt;
        private System.Windows.Forms.TextBox manaStlTxt;
        private System.Windows.Forms.TextBox xpBnsTxt;
        private System.Windows.Forms.TextBox lootBnsTxt;
        private System.Windows.Forms.Label credits;
    }
}

