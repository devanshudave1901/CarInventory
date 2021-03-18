
namespace CarInventory
{
    partial class formCarInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.checkBoxNew = new System.Windows.Forms.CheckBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelErrorOutput = new System.Windows.Forms.Label();
            this.buttonToEnter = new System.Windows.Forms.Button();
            this.buttonToReset = new System.Windows.Forms.Button();
            this.buttonToExit = new System.Windows.Forms.Button();
            this.listViewCar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelMake
            // 
            this.labelMake.Location = new System.Drawing.Point(30, 27);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(79, 34);
            this.labelMake.TabIndex = 0;
            this.labelMake.Text = "&Make:";
            // 
            // labelYear
            // 
            this.labelYear.Location = new System.Drawing.Point(30, 119);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(62, 35);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "&Year: ";
            // 
            // labelModel
            // 
            this.labelModel.Location = new System.Drawing.Point(30, 72);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(76, 35);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "&Model:";
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(30, 166);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 35);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "&Price: ";
            // 
            // checkBoxNew
            // 
            this.checkBoxNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNew.Location = new System.Drawing.Point(30, 218);
            this.checkBoxNew.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNew.Name = "checkBoxNew";
            this.checkBoxNew.Size = new System.Drawing.Size(87, 29);
            this.checkBoxNew.TabIndex = 8;
            this.checkBoxNew.Text = "&New: ";
            this.toolTip1.SetToolTip(this.checkBoxNew, "Check if the Car is New");
            this.checkBoxNew.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(113, 163);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(186, 31);
            this.textBoxPrice.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxPrice, "Enter the Price of the Car");
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(113, 72);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(186, 31);
            this.textBoxModel.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxModel, "Please Enter the model of your Car");
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "",
            "Honda",
            "Nissan",
            "Toyota",
            "Ford",
            "Fiat",
            "Audi",
            "Bentley",
            "BMW",
            "Citroen",
            "Ferrari",
            "Dodge",
            "Jaguar",
            "Jeep",
            "Kia",
            "Mini",
            "Tesla"});
            this.comboBoxTitle.Location = new System.Drawing.Point(111, 24);
            this.comboBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(188, 33);
            this.comboBoxTitle.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxTitle, "Select Make(company) of your car.");
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.comboBox1.Location = new System.Drawing.Point(113, 119);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 33);
            this.comboBox1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.comboBox1, "Select Year of your Car");
            // 
            // labelErrorOutput
            // 
            this.labelErrorOutput.BackColor = System.Drawing.SystemColors.Window;
            this.labelErrorOutput.Location = new System.Drawing.Point(14, 560);
            this.labelErrorOutput.Name = "labelErrorOutput";
            this.labelErrorOutput.Size = new System.Drawing.Size(512, 104);
            this.labelErrorOutput.TabIndex = 10;
            this.toolTip1.SetToolTip(this.labelErrorOutput, "Display the error ");
            // 
            // buttonToEnter
            // 
            this.buttonToEnter.Location = new System.Drawing.Point(150, 682);
            this.buttonToEnter.Name = "buttonToEnter";
            this.buttonToEnter.Size = new System.Drawing.Size(112, 34);
            this.buttonToEnter.TabIndex = 11;
            this.buttonToEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonToEnter, "Press Enter button to execute");
            this.buttonToEnter.UseVisualStyleBackColor = true;
            this.buttonToEnter.Click += new System.EventHandler(this.ButtonToEnter);
            // 
            // buttonToReset
            // 
            this.buttonToReset.Location = new System.Drawing.Point(285, 682);
            this.buttonToReset.Name = "buttonToReset";
            this.buttonToReset.Size = new System.Drawing.Size(112, 34);
            this.buttonToReset.TabIndex = 12;
            this.buttonToReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonToReset, "Please enter Reset");
            this.buttonToReset.UseVisualStyleBackColor = true;
            this.buttonToReset.Click += new System.EventHandler(this.ButtonToReset);
            // 
            // buttonToExit
            // 
            this.buttonToExit.Location = new System.Drawing.Point(414, 682);
            this.buttonToExit.Name = "buttonToExit";
            this.buttonToExit.Size = new System.Drawing.Size(112, 34);
            this.buttonToExit.TabIndex = 13;
            this.buttonToExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.buttonToExit, "Press Close button to close the form.");
            this.buttonToExit.UseVisualStyleBackColor = true;
            this.buttonToExit.Click += new System.EventHandler(this.ButtonToExit);
            // 
            // listViewCar
            // 
            this.listViewCar.CheckBoxes = true;
            this.listViewCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCar.HideSelection = false;
            this.listViewCar.Location = new System.Drawing.Point(17, 254);
            this.listViewCar.MultiSelect = false;
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(506, 281);
            this.listViewCar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.listViewCar, "List to view your entries");
            this.listViewCar.UseCompatibleStateImageBehavior = false;
            this.listViewCar.View = System.Windows.Forms.View.Details;
            this.listViewCar.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PreventCheck);
            this.listViewCar.SelectedIndexChanged += new System.EventHandler(this.CarSelected);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "New";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Make";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Year";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 80;
            // 
            // formCarInventory
            // 
            this.AcceptButton = this.buttonToEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonToExit;
            this.ClientSize = new System.Drawing.Size(549, 739);
            this.Controls.Add(this.listViewCar);
            this.Controls.Add(this.buttonToExit);
            this.Controls.Add(this.buttonToReset);
            this.Controls.Add(this.buttonToEnter);
            this.Controls.Add(this.labelErrorOutput);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.checkBoxNew);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMake);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCarInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Inventory";
            this.Load += new System.EventHandler(this.formCarInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkBoxNew;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelErrorOutput;
        private System.Windows.Forms.Button buttonToEnter;
        private System.Windows.Forms.Button buttonToReset;
        private System.Windows.Forms.Button buttonToExit;
        private System.Windows.Forms.ListView listViewCar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

