namespace WindowsFormsApplication4
{
    partial class Form4
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label дата_поступленияLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label очная_форма_обученияLabel;
            System.Windows.Forms.Label телефонLabel1;
            System.Windows.Forms.Label паспортные_данныеLabel1;
            System.Windows.Forms.Label номер_зачеткиLabel1;
            System.Windows.Forms.Label полLabel1;
            System.Windows.Forms.Label курсLabel;
            System.Windows.Forms.Label родителиLabel;
            System.Windows.Forms.Label код_специальностиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.database61DataSet = new WindowsFormsApplication4.Database61DataSet();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new WindowsFormsApplication4.Database61DataSetTableAdapters.СтудентыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication4.Database61DataSetTableAdapters.TableAdapterManager();
            this.студентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.студентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.дата_поступленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.очная_форма_обученияCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.телефонMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.паспортные_данныеMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.номер_зачеткиMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.курсNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.родителиComboBox = new System.Windows.Forms.ComboBox();
            this.код_специальностиComboBox = new System.Windows.Forms.ComboBox();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиTableAdapter = new WindowsFormsApplication4.Database61DataSetTableAdapters.СпециальностиTableAdapter();
            фИОLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            дата_поступленияLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            очная_форма_обученияLabel = new System.Windows.Forms.Label();
            телефонLabel1 = new System.Windows.Forms.Label();
            паспортные_данныеLabel1 = new System.Windows.Forms.Label();
            номер_зачеткиLabel1 = new System.Windows.Forms.Label();
            полLabel1 = new System.Windows.Forms.Label();
            курсLabel = new System.Windows.Forms.Label();
            родителиLabel = new System.Windows.Forms.Label();
            код_специальностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database61DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).BeginInit();
            this.студентыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курсNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.Location = new System.Drawing.Point(17, 84);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(50, 23);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_рожденияLabel.Location = new System.Drawing.Point(16, 174);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(129, 23);
            дата_рожденияLabel.TabIndex = 7;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel.Location = new System.Drawing.Point(52, 264);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(61, 23);
            адресLabel.TabIndex = 11;
            адресLabel.Text = "Адрес:";
            // 
            // дата_поступленияLabel
            // 
            дата_поступленияLabel.AutoSize = true;
            дата_поступленияLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_поступленияLabel.Location = new System.Drawing.Point(41, 412);
            дата_поступленияLabel.Name = "дата_поступленияLabel";
            дата_поступленияLabel.Size = new System.Drawing.Size(155, 23);
            дата_поступленияLabel.TabIndex = 19;
            дата_поступленияLabel.Text = "Дата поступления:";
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            группаLabel.Location = new System.Drawing.Point(40, 450);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(71, 23);
            группаLabel.TabIndex = 21;
            группаLabel.Text = "Группа:";
            // 
            // очная_форма_обученияLabel
            // 
            очная_форма_обученияLabel.AutoSize = true;
            очная_форма_обученияLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            очная_форма_обученияLabel.Location = new System.Drawing.Point(32, 553);
            очная_форма_обученияLabel.Name = "очная_форма_обученияLabel";
            очная_форма_обученияLabel.Size = new System.Drawing.Size(193, 23);
            очная_форма_обученияLabel.TabIndex = 27;
            очная_форма_обученияLabel.Text = "Очная форма обучения:";
            // 
            // телефонLabel1
            // 
            телефонLabel1.AutoSize = true;
            телефонLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel1.Location = new System.Drawing.Point(30, 312);
            телефонLabel1.Name = "телефонLabel1";
            телефонLabel1.Size = new System.Drawing.Size(83, 23);
            телефонLabel1.TabIndex = 35;
            телефонLabel1.Text = "Телефон:";
            // 
            // паспортные_данныеLabel1
            // 
            паспортные_данныеLabel1.AutoSize = true;
            паспортные_данныеLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            паспортные_данныеLabel1.Location = new System.Drawing.Point(30, 340);
            паспортные_данныеLabel1.Name = "паспортные_данныеLabel1";
            паспортные_данныеLabel1.Size = new System.Drawing.Size(173, 23);
            паспортные_данныеLabel1.TabIndex = 36;
            паспортные_данныеLabel1.Text = "Паспортные данные:";
            // 
            // номер_зачеткиLabel1
            // 
            номер_зачеткиLabel1.AutoSize = true;
            номер_зачеткиLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_зачеткиLabel1.Location = new System.Drawing.Point(39, 376);
            номер_зачеткиLabel1.Name = "номер_зачеткиLabel1";
            номер_зачеткиLabel1.Size = new System.Drawing.Size(128, 23);
            номер_зачеткиLabel1.TabIndex = 37;
            номер_зачеткиLabel1.Text = "Номер зачетки:";
            // 
            // полLabel1
            // 
            полLabel1.AutoSize = true;
            полLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            полLabel1.Location = new System.Drawing.Point(17, 130);
            полLabel1.Name = "полLabel1";
            полLabel1.Size = new System.Drawing.Size(49, 23);
            полLabel1.TabIndex = 38;
            полLabel1.Text = "Пол:";
            // 
            // курсLabel
            // 
            курсLabel.AutoSize = true;
            курсLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            курсLabel.Location = new System.Drawing.Point(40, 486);
            курсLabel.Name = "курсLabel";
            курсLabel.Size = new System.Drawing.Size(51, 23);
            курсLabel.TabIndex = 39;
            курсLabel.Text = "Курс:";
            // 
            // родителиLabel
            // 
            родителиLabel.AutoSize = true;
            родителиLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            родителиLabel.Location = new System.Drawing.Point(41, 227);
            родителиLabel.Name = "родителиLabel";
            родителиLabel.Size = new System.Drawing.Size(87, 23);
            родителиLabel.TabIndex = 40;
            родителиLabel.Text = "Родители:";
            // 
            // код_специальностиLabel
            // 
            код_специальностиLabel.AutoSize = true;
            код_специальностиLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_специальностиLabel.Location = new System.Drawing.Point(39, 515);
            код_специальностиLabel.Name = "код_специальностиLabel";
            код_специальностиLabel.Size = new System.Drawing.Size(164, 23);
            код_специальностиLabel.TabIndex = 41;
            код_специальностиLabel.Text = "Код специальности:";
            // 
            // database61DataSet
            // 
            this.database61DataSet.DataSetName = "Database61DataSet";
            this.database61DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.database61DataSet;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication4.Database61DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = this.студентыTableAdapter;
            // 
            // студентыBindingNavigator
            // 
            this.студентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.студентыBindingNavigator.BindingSource = this.студентыBindingSource;
            this.студентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.студентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.студентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.студентыBindingNavigatorSaveItem});
            this.студентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.студентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.студентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.студентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.студентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.студентыBindingNavigator.Name = "студентыBindingNavigator";
            this.студентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.студентыBindingNavigator.Size = new System.Drawing.Size(616, 25);
            this.студентыBindingNavigator.TabIndex = 0;
            this.студентыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // студентыBindingNavigatorSaveItem
            // 
            this.студентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.студентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("студентыBindingNavigatorSaveItem.Image")));
            this.студентыBindingNavigatorSaveItem.Name = "студентыBindingNavigatorSaveItem";
            this.студентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.студентыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.студентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.студентыBindingNavigatorSaveItem_Click);
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "ФИО", true));
            this.фИОTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИОTextBox.Location = new System.Drawing.Point(198, 81);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 30);
            this.фИОTextBox.TabIndex = 4;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(196, 174);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.дата_рожденияDateTimePicker.TabIndex = 8;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Адрес", true));
            this.адресTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адресTextBox.Location = new System.Drawing.Point(218, 261);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 30);
            this.адресTextBox.TabIndex = 12;
            // 
            // дата_поступленияDateTimePicker
            // 
            this.дата_поступленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата поступления", true));
            this.дата_поступленияDateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_поступленияDateTimePicker.Location = new System.Drawing.Point(223, 405);
            this.дата_поступленияDateTimePicker.Name = "дата_поступленияDateTimePicker";
            this.дата_поступленияDateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.дата_поступленияDateTimePicker.TabIndex = 20;
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Группа", true));
            this.группаTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.группаTextBox.Location = new System.Drawing.Point(223, 443);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(100, 30);
            this.группаTextBox.TabIndex = 22;
            // 
            // очная_форма_обученияCheckBox
            // 
            this.очная_форма_обученияCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.студентыBindingSource, "Очная форма обучения", true));
            this.очная_форма_обученияCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.очная_форма_обученияCheckBox.Location = new System.Drawing.Point(231, 552);
            this.очная_форма_обученияCheckBox.Name = "очная_форма_обученияCheckBox";
            this.очная_форма_обученияCheckBox.Size = new System.Drawing.Size(21, 24);
            this.очная_форма_обученияCheckBox.TabIndex = 28;
            this.очная_форма_обученияCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(34, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 29;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(171, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 53);
            this.button2.TabIndex = 30;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(307, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 53);
            this.button3.TabIndex = 31;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(32, 636);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 100);
            this.button4.TabIndex = 32;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(171, 636);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 46);
            this.button5.TabIndex = 33;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(307, 636);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 100);
            this.button6.TabIndex = 34;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(171, 688);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 48);
            this.button7.TabIndex = 35;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(218, 297);
            this.телефонMaskedTextBox.Mask = "+7(999) 000-0000";
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(100, 30);
            this.телефонMaskedTextBox.TabIndex = 36;
            // 
            // паспортные_данныеMaskedTextBox
            // 
            this.паспортные_данныеMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Паспортные данные", true));
            this.паспортные_данныеMaskedTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.паспортные_данныеMaskedTextBox.Location = new System.Drawing.Point(218, 333);
            this.паспортные_данныеMaskedTextBox.Mask = "0000-000000";
            this.паспортные_данныеMaskedTextBox.Name = "паспортные_данныеMaskedTextBox";
            this.паспортные_данныеMaskedTextBox.Size = new System.Drawing.Size(100, 30);
            this.паспортные_данныеMaskedTextBox.TabIndex = 37;
            // 
            // номер_зачеткиMaskedTextBox
            // 
            this.номер_зачеткиMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Номер зачетки", true));
            this.номер_зачеткиMaskedTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_зачеткиMaskedTextBox.Location = new System.Drawing.Point(223, 369);
            this.номер_зачеткиMaskedTextBox.Mask = "00000";
            this.номер_зачеткиMaskedTextBox.Name = "номер_зачеткиMaskedTextBox";
            this.номер_зачеткиMaskedTextBox.Size = new System.Drawing.Size(100, 30);
            this.номер_зачеткиMaskedTextBox.TabIndex = 38;
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Пол", true));
            this.полComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.полComboBox.Location = new System.Drawing.Point(204, 127);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(121, 31);
            this.полComboBox.TabIndex = 39;
            // 
            // курсNumericUpDown
            // 
            this.курсNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Курс", true));
            this.курсNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.курсNumericUpDown.Location = new System.Drawing.Point(223, 479);
            this.курсNumericUpDown.Name = "курсNumericUpDown";
            this.курсNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.курсNumericUpDown.TabIndex = 40;
            // 
            // родителиComboBox
            // 
            this.родителиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Родители", true));
            this.родителиComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.родителиComboBox.FormattingEnabled = true;
            this.родителиComboBox.Items.AddRange(new object[] {
            "Отец и Мать",
            "Мать",
            "Отец",
            "Нет"});
            this.родителиComboBox.Location = new System.Drawing.Point(204, 219);
            this.родителиComboBox.Name = "родителиComboBox";
            this.родителиComboBox.Size = new System.Drawing.Size(121, 31);
            this.родителиComboBox.TabIndex = 41;
            // 
            // код_специальностиComboBox
            // 
            this.код_специальностиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Код специальности", true));
            this.код_специальностиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.студентыBindingSource, "Код Студента", true));
            this.код_специальностиComboBox.DataSource = this.специальностиBindingSource;
            this.код_специальностиComboBox.DisplayMember = "Наиминование специальности";
            this.код_специальностиComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_специальностиComboBox.FormattingEnabled = true;
            this.код_специальностиComboBox.Location = new System.Drawing.Point(222, 515);
            this.код_специальностиComboBox.Name = "код_специальностиComboBox";
            this.код_специальностиComboBox.Size = new System.Drawing.Size(121, 31);
            this.код_специальностиComboBox.TabIndex = 42;
            this.код_специальностиComboBox.ValueMember = "Код Специальности";
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.database61DataSet;
            // 
            // студентыBindingSource1
            // 
            this.студентыBindingSource1.DataMember = "Студенты";
            this.студентыBindingSource1.DataSource = this.database61DataSet;
            // 
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 748);
            this.Controls.Add(код_специальностиLabel);
            this.Controls.Add(this.код_специальностиComboBox);
            this.Controls.Add(родителиLabel);
            this.Controls.Add(this.родителиComboBox);
            this.Controls.Add(курсLabel);
            this.Controls.Add(this.курсNumericUpDown);
            this.Controls.Add(полLabel1);
            this.Controls.Add(this.полComboBox);
            this.Controls.Add(номер_зачеткиLabel1);
            this.Controls.Add(this.номер_зачеткиMaskedTextBox);
            this.Controls.Add(паспортные_данныеLabel1);
            this.Controls.Add(this.паспортные_данныеMaskedTextBox);
            this.Controls.Add(телефонLabel1);
            this.Controls.Add(this.телефонMaskedTextBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(очная_форма_обученияLabel);
            this.Controls.Add(this.очная_форма_обученияCheckBox);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(дата_поступленияLabel);
            this.Controls.Add(this.дата_поступленияDateTimePicker);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.студентыBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database61DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).EndInit();
            this.студентыBindingNavigator.ResumeLayout(false);
            this.студентыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курсNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database61DataSet database61DataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private Database61DataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private Database61DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator студентыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton студентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DateTimePicker дата_поступленияDateTimePicker;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.CheckBox очная_форма_обученияCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MaskedTextBox телефонMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox паспортные_данныеMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox номер_зачеткиMaskedTextBox;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.NumericUpDown курсNumericUpDown;
        private System.Windows.Forms.ComboBox родителиComboBox;
        private System.Windows.Forms.ComboBox код_специальностиComboBox;
        private System.Windows.Forms.BindingSource студентыBindingSource1;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private Database61DataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
    }
}