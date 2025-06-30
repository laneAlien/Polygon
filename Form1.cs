namespace MyWinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button createDatabaseButton;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.TextBox columnPromptTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button insertDataButton;
        private System.Windows.Forms.Button displayDataButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.createDatabaseButton = new System.Windows.Forms.Button();
            this.createTableButton = new System.Windows.Forms.Button();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.columnPromptTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.insertDataButton = new System.Windows.Forms.Button();
            this.displayDataButton = new System.Windows.Forms.Button();

            // 
            // createDatabaseButton
            // 
            this.createDatabaseButton.Location = new System.Drawing.Point(30, 20);
            this.createDatabaseButton.Size = new System.Drawing.Size(150, 30);
            this.createDatabaseButton.Text = "Создать Базу Данных";
            this.createDatabaseButton.Click += new System.EventHandler(this.CreateDatabaseButton_Click);
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(30, 100);
            this.createTableButton.Size = new System.Drawing.Size(150, 30);
            this.createTableButton.Text = "Создать Таблицу";
            this.createTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(200, 100);
            this.tableNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.tableNameTextBox.PlaceholderText = "Введите имя таблицы";
            // 
            // columnPromptTextBox
            // 
            this.columnPromptTextBox.Location = new System.Drawing.Point(30, 150);
            this.columnPromptTextBox.Size = new System.Drawing.Size(370, 20);
            this.columnPromptTextBox.PlaceholderText = "Введите данные через запятую";
            // 
            // dataGridView
            // 
            this.dataGridView.Location = new System.Drawing.Point(30, 200);
            this.dataGridView.Size = new System.Drawing.Size(500, 200);
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // insertDataButton
            // 
            this.insertDataButton.Location = new System.Drawing.Point(30, 400);
            this.insertDataButton.Size = new System.Drawing.Size(150, 30);
            this.insertDataButton.Text = "Добавить Данные";
            this.insertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            // 
            // displayDataButton
            // 
            this.displayDataButton.Location = new System.Drawing.Point(200, 400);
            this.displayDataButton.Size = new System.Drawing.Size(150, 30);
            this.displayDataButton.Text = "Показать Данные";
            this.displayDataButton.Click += new System.EventHandler(this.DisplayDataButton_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.createDatabaseButton);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.tableNameTextBox);
            this.Controls.Add(this.columnPromptTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.insertDataButton);
            this.Controls.Add(this.displayDataButton);
            this.Text = "Учет и инвентаризация кафедры";
        }
    }
}
