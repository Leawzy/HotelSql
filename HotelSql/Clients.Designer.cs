namespace HotelSql
{
    partial class Clients
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            System.Windows.Forms.Label iD_ClientsLabel;
            System.Windows.Forms.Label fullNaneLabel;
            System.Windows.Forms.Label pasportDataLabel;
            System.Windows.Forms.Label checkInDateLabel;
            System.Windows.Forms.Label checkOutDateLabel;
            System.Windows.Forms.Label iD_RoomLabel;
            System.Windows.Forms.Label iD_Services1Label;
            System.Windows.Forms.Label iD_Services2Label;
            System.Windows.Forms.Label iD_Services3Label;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label iD_EmployeesLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.hotelDataSet = new HotelSql.HotelDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new HotelSql.HotelDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new HotelSql.HotelDataSetTableAdapters.TableAdapterManager();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ClientsTextBox = new System.Windows.Forms.TextBox();
            this.fullNaneTextBox = new System.Windows.Forms.TextBox();
            this.pasportDataTextBox = new System.Windows.Forms.TextBox();
            this.checkInDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkOutDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_RoomTextBox = new System.Windows.Forms.TextBox();
            this.iD_Services1TextBox = new System.Windows.Forms.TextBox();
            this.iD_Services2TextBox = new System.Windows.Forms.TextBox();
            this.iD_Services3TextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.iD_EmployeesTextBox = new System.Windows.Forms.TextBox();
            iD_ClientsLabel = new System.Windows.Forms.Label();
            fullNaneLabel = new System.Windows.Forms.Label();
            pasportDataLabel = new System.Windows.Forms.Label();
            checkInDateLabel = new System.Windows.Forms.Label();
            checkOutDateLabel = new System.Windows.Forms.Label();
            iD_RoomLabel = new System.Windows.Forms.Label();
            iD_Services1Label = new System.Windows.Forms.Label();
            iD_Services2Label = new System.Windows.Forms.Label();
            iD_Services3Label = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            iD_EmployeesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(304, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Клиенты\"";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hotelDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelSql.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientsBindingNavigatorSaveItem});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.clientsBindingNavigator.TabIndex = 1;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.clientsBindingNavigatorSaveItem.Text = "Save Data";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // iD_ClientsLabel
            // 
            iD_ClientsLabel.AutoSize = true;
            iD_ClientsLabel.Location = new System.Drawing.Point(295, 79);
            iD_ClientsLabel.Name = "iD_ClientsLabel";
            iD_ClientsLabel.Size = new System.Drawing.Size(55, 13);
            iD_ClientsLabel.TabIndex = 2;
            iD_ClientsLabel.Text = "ID Clients:";
            // 
            // iD_ClientsTextBox
            // 
            this.iD_ClientsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ID_Clients", true));
            this.iD_ClientsTextBox.Location = new System.Drawing.Point(388, 76);
            this.iD_ClientsTextBox.Name = "iD_ClientsTextBox";
            this.iD_ClientsTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ClientsTextBox.TabIndex = 3;
            // 
            // fullNaneLabel
            // 
            fullNaneLabel.AutoSize = true;
            fullNaneLabel.Location = new System.Drawing.Point(295, 116);
            fullNaneLabel.Name = "fullNaneLabel";
            fullNaneLabel.Size = new System.Drawing.Size(55, 13);
            fullNaneLabel.TabIndex = 4;
            fullNaneLabel.Text = "Full Nane:";
            // 
            // fullNaneTextBox
            // 
            this.fullNaneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "FullNane", true));
            this.fullNaneTextBox.Location = new System.Drawing.Point(388, 113);
            this.fullNaneTextBox.Name = "fullNaneTextBox";
            this.fullNaneTextBox.Size = new System.Drawing.Size(100, 20);
            this.fullNaneTextBox.TabIndex = 5;
            // 
            // pasportDataLabel
            // 
            pasportDataLabel.AutoSize = true;
            pasportDataLabel.Location = new System.Drawing.Point(295, 157);
            pasportDataLabel.Name = "pasportDataLabel";
            pasportDataLabel.Size = new System.Drawing.Size(72, 13);
            pasportDataLabel.TabIndex = 6;
            pasportDataLabel.Text = "Pasport Data:";
            // 
            // pasportDataTextBox
            // 
            this.pasportDataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "PasportData", true));
            this.pasportDataTextBox.Location = new System.Drawing.Point(388, 150);
            this.pasportDataTextBox.Name = "pasportDataTextBox";
            this.pasportDataTextBox.Size = new System.Drawing.Size(100, 20);
            this.pasportDataTextBox.TabIndex = 7;
            // 
            // checkInDateLabel
            // 
            checkInDateLabel.AutoSize = true;
            checkInDateLabel.Location = new System.Drawing.Point(295, 190);
            checkInDateLabel.Name = "checkInDateLabel";
            checkInDateLabel.Size = new System.Drawing.Size(79, 13);
            checkInDateLabel.TabIndex = 8;
            checkInDateLabel.Text = "Check In Date:";
            // 
            // checkInDateDateTimePicker
            // 
            this.checkInDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "CheckInDate", true));
            this.checkInDateDateTimePicker.Location = new System.Drawing.Point(388, 184);
            this.checkInDateDateTimePicker.Name = "checkInDateDateTimePicker";
            this.checkInDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.checkInDateDateTimePicker.TabIndex = 9;
            // 
            // checkOutDateLabel
            // 
            checkOutDateLabel.AutoSize = true;
            checkOutDateLabel.Location = new System.Drawing.Point(295, 228);
            checkOutDateLabel.Name = "checkOutDateLabel";
            checkOutDateLabel.Size = new System.Drawing.Size(87, 13);
            checkOutDateLabel.TabIndex = 10;
            checkOutDateLabel.Text = "Check Out Date:";
            // 
            // checkOutDateDateTimePicker
            // 
            this.checkOutDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "CheckOutDate", true));
            this.checkOutDateDateTimePicker.Location = new System.Drawing.Point(388, 222);
            this.checkOutDateDateTimePicker.Name = "checkOutDateDateTimePicker";
            this.checkOutDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.checkOutDateDateTimePicker.TabIndex = 11;
            // 
            // iD_RoomLabel
            // 
            iD_RoomLabel.AutoSize = true;
            iD_RoomLabel.Location = new System.Drawing.Point(295, 264);
            iD_RoomLabel.Name = "iD_RoomLabel";
            iD_RoomLabel.Size = new System.Drawing.Size(52, 13);
            iD_RoomLabel.TabIndex = 12;
            iD_RoomLabel.Text = "ID Room:";
            // 
            // iD_RoomTextBox
            // 
            this.iD_RoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ID_Room", true));
            this.iD_RoomTextBox.Location = new System.Drawing.Point(388, 264);
            this.iD_RoomTextBox.Name = "iD_RoomTextBox";
            this.iD_RoomTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_RoomTextBox.TabIndex = 13;
            // 
            // iD_Services1Label
            // 
            iD_Services1Label.AutoSize = true;
            iD_Services1Label.Location = new System.Drawing.Point(295, 299);
            iD_Services1Label.Name = "iD_Services1Label";
            iD_Services1Label.Size = new System.Drawing.Size(71, 13);
            iD_Services1Label.TabIndex = 14;
            iD_Services1Label.Text = "ID Services1:";
            // 
            // iD_Services1TextBox
            // 
            this.iD_Services1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ID_Services1", true));
            this.iD_Services1TextBox.Location = new System.Drawing.Point(388, 296);
            this.iD_Services1TextBox.Name = "iD_Services1TextBox";
            this.iD_Services1TextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_Services1TextBox.TabIndex = 15;
            // 
            // iD_Services2Label
            // 
            iD_Services2Label.AutoSize = true;
            iD_Services2Label.Location = new System.Drawing.Point(295, 333);
            iD_Services2Label.Name = "iD_Services2Label";
            iD_Services2Label.Size = new System.Drawing.Size(71, 13);
            iD_Services2Label.TabIndex = 16;
            iD_Services2Label.Text = "ID Services2:";
            // 
            // iD_Services2TextBox
            // 
            this.iD_Services2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ID_Services2", true));
            this.iD_Services2TextBox.Location = new System.Drawing.Point(388, 330);
            this.iD_Services2TextBox.Name = "iD_Services2TextBox";
            this.iD_Services2TextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_Services2TextBox.TabIndex = 17;
            // 
            // iD_Services3Label
            // 
            iD_Services3Label.AutoSize = true;
            iD_Services3Label.Location = new System.Drawing.Point(295, 368);
            iD_Services3Label.Name = "iD_Services3Label";
            iD_Services3Label.Size = new System.Drawing.Size(71, 13);
            iD_Services3Label.TabIndex = 18;
            iD_Services3Label.Text = "ID Services3:";
            // 
            // iD_Services3TextBox
            // 
            this.iD_Services3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ID_Services3", true));
            this.iD_Services3TextBox.Location = new System.Drawing.Point(388, 365);
            this.iD_Services3TextBox.Name = "iD_Services3TextBox";
            this.iD_Services3TextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_Services3TextBox.TabIndex = 19;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(295, 402);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 20;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(388, 399);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 21;
            // 
            // iD_EmployeesLabel
            // 
            iD_EmployeesLabel.AutoSize = true;
            iD_EmployeesLabel.Location = new System.Drawing.Point(295, 435);
            iD_EmployeesLabel.Name = "iD_EmployeesLabel";
            iD_EmployeesLabel.Size = new System.Drawing.Size(75, 13);
            iD_EmployeesLabel.TabIndex = 22;
            iD_EmployeesLabel.Text = "ID Employees:";
            // 
            // iD_EmployeesTextBox
            // 
            this.iD_EmployeesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ID_Employees", true));
            this.iD_EmployeesTextBox.Location = new System.Drawing.Point(386, 432);
            this.iD_EmployeesTextBox.Name = "iD_EmployeesTextBox";
            this.iD_EmployeesTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_EmployeesTextBox.TabIndex = 23;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(iD_EmployeesLabel);
            this.Controls.Add(this.iD_EmployeesTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(iD_Services3Label);
            this.Controls.Add(this.iD_Services3TextBox);
            this.Controls.Add(iD_Services2Label);
            this.Controls.Add(this.iD_Services2TextBox);
            this.Controls.Add(iD_Services1Label);
            this.Controls.Add(this.iD_Services1TextBox);
            this.Controls.Add(iD_RoomLabel);
            this.Controls.Add(this.iD_RoomTextBox);
            this.Controls.Add(checkOutDateLabel);
            this.Controls.Add(this.checkOutDateDateTimePicker);
            this.Controls.Add(checkInDateLabel);
            this.Controls.Add(this.checkInDateDateTimePicker);
            this.Controls.Add(pasportDataLabel);
            this.Controls.Add(this.pasportDataTextBox);
            this.Controls.Add(fullNaneLabel);
            this.Controls.Add(this.fullNaneTextBox);
            this.Controls.Add(iD_ClientsLabel);
            this.Controls.Add(this.iD_ClientsTextBox);
            this.Controls.Add(this.clientsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Clients";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ClientsTextBox;
        private System.Windows.Forms.TextBox fullNaneTextBox;
        private System.Windows.Forms.TextBox pasportDataTextBox;
        private System.Windows.Forms.DateTimePicker checkInDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker checkOutDateDateTimePicker;
        private System.Windows.Forms.TextBox iD_RoomTextBox;
        private System.Windows.Forms.TextBox iD_Services1TextBox;
        private System.Windows.Forms.TextBox iD_Services2TextBox;
        private System.Windows.Forms.TextBox iD_Services3TextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox iD_EmployeesTextBox;
    }
}