namespace HotelSql
{
    partial class Rooms
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
            System.Windows.Forms.Label iD_RoomLabel;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Label sleepsLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label iD_EmployeesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.Комнаты = new System.Windows.Forms.Label();
            this.hotelDataSet = new HotelSql.HotelDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new HotelSql.HotelDataSetTableAdapters.RoomTableAdapter();
            this.tableAdapterManager = new HotelSql.HotelDataSetTableAdapters.TableAdapterManager();
            this.roomBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.roomBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_RoomTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.sleepsTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.iD_EmployeesTextBox = new System.Windows.Forms.TextBox();
            iD_RoomLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            sleepsLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            iD_EmployeesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingNavigator)).BeginInit();
            this.roomBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_RoomLabel
            // 
            iD_RoomLabel.AutoSize = true;
            iD_RoomLabel.Location = new System.Drawing.Point(310, 98);
            iD_RoomLabel.Name = "iD_RoomLabel";
            iD_RoomLabel.Size = new System.Drawing.Size(52, 13);
            iD_RoomLabel.TabIndex = 2;
            iD_RoomLabel.Text = "ID Room:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(310, 141);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(69, 13);
            roomNameLabel.TabIndex = 4;
            roomNameLabel.Text = "Room Name:";
            // 
            // sleepsLabel
            // 
            sleepsLabel.AutoSize = true;
            sleepsLabel.Location = new System.Drawing.Point(310, 182);
            sleepsLabel.Name = "sleepsLabel";
            sleepsLabel.Size = new System.Drawing.Size(42, 13);
            sleepsLabel.TabIndex = 6;
            sleepsLabel.Text = "Sleeps:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(310, 223);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(310, 260);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Price:";
            // 
            // iD_EmployeesLabel
            // 
            iD_EmployeesLabel.AutoSize = true;
            iD_EmployeesLabel.Location = new System.Drawing.Point(310, 293);
            iD_EmployeesLabel.Name = "iD_EmployeesLabel";
            iD_EmployeesLabel.Size = new System.Drawing.Size(75, 13);
            iD_EmployeesLabel.TabIndex = 12;
            iD_EmployeesLabel.Text = "ID Employees:";
            // 
            // Комнаты
            // 
            this.Комнаты.AutoSize = true;
            this.Комнаты.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Комнаты.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Комнаты.Location = new System.Drawing.Point(293, 37);
            this.Комнаты.Name = "Комнаты";
            this.Комнаты.Size = new System.Drawing.Size(184, 24);
            this.Комнаты.TabIndex = 0;
            this.Комнаты.Text = "Таблица \"Комнаты\"";
            this.Комнаты.Click += new System.EventHandler(this.Клиенты_Click);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotelDataSet;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = this.roomTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelSql.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomBindingNavigator
            // 
            this.roomBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roomBindingNavigator.BindingSource = this.roomBindingSource;
            this.roomBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roomBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.roomBindingNavigatorSaveItem});
            this.roomBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roomBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roomBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomBindingNavigator.Name = "roomBindingNavigator";
            this.roomBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.roomBindingNavigator.TabIndex = 1;
            this.roomBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // roomBindingNavigatorSaveItem
            // 
            this.roomBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roomBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roomBindingNavigatorSaveItem.Image")));
            this.roomBindingNavigatorSaveItem.Name = "roomBindingNavigatorSaveItem";
            this.roomBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.roomBindingNavigatorSaveItem.Text = "Save Data";
            this.roomBindingNavigatorSaveItem.Click += new System.EventHandler(this.roomBindingNavigatorSaveItem_Click);
            // 
            // iD_RoomTextBox
            // 
            this.iD_RoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "ID_Room", true));
            this.iD_RoomTextBox.Location = new System.Drawing.Point(385, 95);
            this.iD_RoomTextBox.Name = "iD_RoomTextBox";
            this.iD_RoomTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_RoomTextBox.TabIndex = 3;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "RoomName", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(385, 138);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomNameTextBox.TabIndex = 5;
            // 
            // sleepsTextBox
            // 
            this.sleepsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Sleeps", true));
            this.sleepsTextBox.Location = new System.Drawing.Point(385, 182);
            this.sleepsTextBox.Name = "sleepsTextBox";
            this.sleepsTextBox.Size = new System.Drawing.Size(100, 20);
            this.sleepsTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(385, 220);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(270, 20);
            this.descriptionTextBox.TabIndex = 9;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(385, 257);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 11;
            // 
            // iD_EmployeesTextBox
            // 
            this.iD_EmployeesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "ID_Employees", true));
            this.iD_EmployeesTextBox.Location = new System.Drawing.Point(385, 290);
            this.iD_EmployeesTextBox.Name = "iD_EmployeesTextBox";
            this.iD_EmployeesTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_EmployeesTextBox.TabIndex = 13;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_EmployeesLabel);
            this.Controls.Add(this.iD_EmployeesTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(sleepsLabel);
            this.Controls.Add(this.sleepsTextBox);
            this.Controls.Add(roomNameLabel);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(iD_RoomLabel);
            this.Controls.Add(this.iD_RoomTextBox);
            this.Controls.Add(this.roomBindingNavigator);
            this.Controls.Add(this.Комнаты);
            this.Name = "Rooms";
            this.Text = "Комнаты";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingNavigator)).EndInit();
            this.roomBindingNavigator.ResumeLayout(false);
            this.roomBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Комнаты;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator roomBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton roomBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_RoomTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.TextBox sleepsTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox iD_EmployeesTextBox;
    }
}