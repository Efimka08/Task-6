namespace DataBase_5
{
    partial class Form2
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
            System.Windows.Forms.Label semesterLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label markLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label record_numberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.efim_DatabaseDataSet = new DataBase_5.Efim_DatabaseDataSet();
            this.ratingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ratingTableAdapter = new DataBase_5.Efim_DatabaseDataSetTableAdapters.RatingTableAdapter();
            this.tableAdapterManager = new DataBase_5.Efim_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.studentsTableAdapter = new DataBase_5.Efim_DatabaseDataSetTableAdapters.StudentsTableAdapter();
            this.ratingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ratingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.record_numberComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.groupToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.groupToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            semesterLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            markLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            record_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.efim_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingNavigator)).BeginInit();
            this.ratingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // semesterLabel
            // 
            semesterLabel.AutoSize = true;
            semesterLabel.Location = new System.Drawing.Point(19, 185);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new System.Drawing.Size(68, 17);
            semesterLabel.TabIndex = 3;
            semesterLabel.Text = "Семестр:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(19, 227);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(94, 17);
            subjectLabel.TabIndex = 5;
            subjectLabel.Text = "Дисциплина:";
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Location = new System.Drawing.Point(19, 266);
            markLabel.Name = "markLabel";
            markLabel.Size = new System.Drawing.Size(62, 17);
            markLabel.TabIndex = 7;
            markLabel.Text = "Оценка:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(19, 307);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(89, 17);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Дата сдачи:";
            // 
            // record_numberLabel
            // 
            record_numberLabel.AutoSize = true;
            record_numberLabel.Location = new System.Drawing.Point(19, 143);
            record_numberLabel.Name = "record_numberLabel";
            record_numberLabel.Size = new System.Drawing.Size(74, 17);
            record_numberLabel.TabIndex = 14;
            record_numberLabel.Text = "Фамилия:";
            // 
            // efim_DatabaseDataSet
            // 
            this.efim_DatabaseDataSet.DataSetName = "Efim_DatabaseDataSet";
            this.efim_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ratingBindingSource
            // 
            this.ratingBindingSource.DataMember = "Rating";
            this.ratingBindingSource.DataSource = this.efim_DatabaseDataSet;
            // 
            // ratingTableAdapter
            // 
            this.ratingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RatingTableAdapter = this.ratingTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBase_5.Efim_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // ratingBindingNavigator
            // 
            this.ratingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ratingBindingNavigator.BindingSource = this.ratingBindingSource;
            this.ratingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ratingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ratingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ratingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ratingBindingNavigatorSaveItem});
            this.ratingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ratingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ratingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ratingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ratingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ratingBindingNavigator.Name = "ratingBindingNavigator";
            this.ratingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ratingBindingNavigator.Size = new System.Drawing.Size(368, 27);
            this.ratingBindingNavigator.TabIndex = 0;
            this.ratingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ratingBindingNavigatorSaveItem
            // 
            this.ratingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ratingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ratingBindingNavigatorSaveItem.Image")));
            this.ratingBindingNavigatorSaveItem.Name = "ratingBindingNavigatorSaveItem";
            this.ratingBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ratingBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ratingBindingNavigatorSaveItem.Click += new System.EventHandler(this.ratingBindingNavigatorSaveItem_Click);
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "Semester", true));
            this.semesterTextBox.Location = new System.Drawing.Point(135, 182);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(200, 22);
            this.semesterTextBox.TabIndex = 4;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "Subject", true));
            this.subjectTextBox.Location = new System.Drawing.Point(135, 224);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(200, 22);
            this.subjectTextBox.TabIndex = 6;
            // 
            // markTextBox
            // 
            this.markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratingBindingSource, "Mark", true));
            this.markTextBox.Location = new System.Drawing.Point(135, 263);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(200, 22);
            this.markTextBox.TabIndex = 8;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ratingBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(135, 303);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.efim_DatabaseDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Оценки";
            // 
            // record_numberComboBox
            // 
            this.record_numberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ratingBindingSource, "Record_number", true));
            this.record_numberComboBox.DataSource = this.studentsBindingSource;
            this.record_numberComboBox.DisplayMember = "Surname";
            this.record_numberComboBox.FormattingEnabled = true;
            this.record_numberComboBox.Location = new System.Drawing.Point(135, 140);
            this.record_numberComboBox.Name = "record_numberComboBox";
            this.record_numberComboBox.Size = new System.Drawing.Size(200, 24);
            this.record_numberComboBox.TabIndex = 15;
            this.record_numberComboBox.ValueMember = "Record_number";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(139, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Список студентов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripLabel,
            this.groupToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(368, 27);
            this.fillByToolStrip.TabIndex = 18;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // groupToolStripLabel
            // 
            this.groupToolStripLabel.Name = "groupToolStripLabel";
            this.groupToolStripLabel.Size = new System.Drawing.Size(129, 24);
            this.groupToolStripLabel.Text = "Поиск по группе:";
            // 
            // groupToolStripTextBox
            // 
            this.groupToolStripTextBox.Name = "groupToolStripTextBox";
            this.groupToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillByToolStripButton.Text = "Найти";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 458);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(record_numberLabel);
            this.Controls.Add(this.record_numberComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(semesterLabel);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(markLabel);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.ratingBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.efim_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingNavigator)).EndInit();
            this.ratingBindingNavigator.ResumeLayout(false);
            this.ratingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Efim_DatabaseDataSet efim_DatabaseDataSet;
        private System.Windows.Forms.BindingSource ratingBindingSource;
        private Efim_DatabaseDataSetTableAdapters.RatingTableAdapter ratingTableAdapter;
        private Efim_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ratingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ratingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox semesterTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private Efim_DatabaseDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox record_numberComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel groupToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox groupToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}