namespace CourseWork
{
    partial class ProfileForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.editProfileButton = new System.Windows.Forms.Button();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.mode1Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mode2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NonActivLabel1 = new System.Windows.Forms.Label();
            this.NonActivLavel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mode1Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mode2Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(128, 60);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(141, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(128, 103);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(141, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(28, 153);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(51, 17);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин:";
            // 
            // editProfileButton
            // 
            this.editProfileButton.Location = new System.Drawing.Point(121, 196);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(148, 65);
            this.editProfileButton.TabIndex = 3;
            this.editProfileButton.Text = "Изменить данный";
            this.editProfileButton.UseVisualStyleBackColor = true;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Location = new System.Drawing.Point(121, 373);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(148, 65);
            this.deletePersonButton.TabIndex = 4;
            this.deletePersonButton.Text = "Удалить профиль";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(28, 106);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(74, 17);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Фамилия:";
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(28, 63);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(39, 17);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "Имя:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(121, 287);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(148, 65);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // mode1Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.mode1Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mode1Chart.Legends.Add(legend1);
            this.mode1Chart.Location = new System.Drawing.Point(366, 60);
            this.mode1Chart.Name = "mode1Chart";
            this.mode1Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Правильный ответ";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Неверный ответ";
            this.mode1Chart.Series.Add(series1);
            this.mode1Chart.Series.Add(series2);
            this.mode1Chart.Size = new System.Drawing.Size(547, 201);
            this.mode1Chart.TabIndex = 8;
            this.mode1Chart.Text = "Сопоставь";
            // 
            // mode2Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.mode2Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.mode2Chart.Legends.Add(legend2);
            this.mode2Chart.Location = new System.Drawing.Point(366, 289);
            this.mode2Chart.Name = "mode2Chart";
            this.mode2Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Минутный коэффециент";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.mode2Chart.Series.Add(series3);
            this.mode2Chart.Size = new System.Drawing.Size(547, 201);
            this.mode2Chart.TabIndex = 9;
            this.mode2Chart.Text = "Парочки";
            this.mode2Chart.Click += new System.EventHandler(this.chart2_Click);
            // 
            // NonActivLabel1
            // 
            this.NonActivLabel1.AutoSize = true;
            this.NonActivLabel1.Location = new System.Drawing.Point(366, 266);
            this.NonActivLabel1.Name = "NonActivLabel1";
            this.NonActivLabel1.Size = new System.Drawing.Size(63, 17);
            this.NonActivLabel1.TabIndex = 10;
            this.NonActivLabel1.Text = "Режим 2";
            // 
            // NonActivLavel
            // 
            this.NonActivLavel.AutoSize = true;
            this.NonActivLavel.Location = new System.Drawing.Point(366, 40);
            this.NonActivLavel.Name = "NonActivLavel";
            this.NonActivLavel.Size = new System.Drawing.Size(63, 17);
            this.NonActivLavel.TabIndex = 11;
            this.NonActivLavel.Text = "Режим 1";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 502);
            this.Controls.Add(this.NonActivLavel);
            this.Controls.Add(this.NonActivLabel1);
            this.Controls.Add(this.mode2Chart);
            this.Controls.Add(this.mode1Chart);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.deletePersonButton);
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "ProfileForm";
            this.Text = "Профиль";
            ((System.ComponentModel.ISupportInitialize)(this.mode1Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mode2Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button editProfileButton;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart mode1Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart mode2Chart;
        private System.Windows.Forms.Label NonActivLabel1;
        private System.Windows.Forms.Label NonActivLavel;
    }
}