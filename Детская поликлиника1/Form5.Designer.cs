namespace Детская_поликлиника1
{
    partial class Form5
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
            System.Windows.Forms.Label код_процедурLabel;
            System.Windows.Forms.TextBox код_процедурTextBox;
            System.Windows.Forms.Label код_пациентаLabel;
            System.Windows.Forms.TextBox код_пациентаTextBox;
            System.Windows.Forms.Label наименование_процедурыLabel;
            System.Windows.Forms.TextBox наименование_процедурыTextBox;
            System.Windows.Forms.Label описание_процедурыLabel;
            System.Windows.Forms.TextBox описание_процедурыTextBox;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.DateTimePicker датаDateTimePicker;
            this.процедурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.детская_поликлиника_1DataSet = new Детская_поликлиника1.Детская_поликлиника_1DataSet();
            this.процедурыTableAdapter = new Детская_поликлиника1.Детская_поликлиника_1DataSetTableAdapters.ПроцедурыTableAdapter();
            this.tableAdapterManager = new Детская_поликлиника1.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            код_процедурLabel = new System.Windows.Forms.Label();
            код_процедурTextBox = new System.Windows.Forms.TextBox();
            код_пациентаLabel = new System.Windows.Forms.Label();
            код_пациентаTextBox = new System.Windows.Forms.TextBox();
            наименование_процедурыLabel = new System.Windows.Forms.Label();
            наименование_процедурыTextBox = new System.Windows.Forms.TextBox();
            описание_процедурыLabel = new System.Windows.Forms.Label();
            описание_процедурыTextBox = new System.Windows.Forms.TextBox();
            датаLabel = new System.Windows.Forms.Label();
            датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.процедурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // код_процедурLabel
            // 
            код_процедурLabel.AutoSize = true;
            код_процедурLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_процедурLabel.Location = new System.Drawing.Point(84, 74);
            код_процедурLabel.Name = "код_процедурLabel";
            код_процедурLabel.Size = new System.Drawing.Size(102, 16);
            код_процедурLabel.TabIndex = 1;
            код_процедурLabel.Text = "Код процедур:";
            // 
            // код_процедурTextBox
            // 
            код_процедурTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедурыBindingSource, "Код процедур", true));
            код_процедурTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_процедурTextBox.Location = new System.Drawing.Point(276, 71);
            код_процедурTextBox.Name = "код_процедурTextBox";
            код_процедурTextBox.Size = new System.Drawing.Size(200, 22);
            код_процедурTextBox.TabIndex = 2;
            // 
            // процедурыBindingSource
            // 
            this.процедурыBindingSource.DataMember = "Процедуры";
            this.процедурыBindingSource.DataSource = this.детская_поликлиника_1DataSet;
            // 
            // детская_поликлиника_1DataSet
            // 
            this.детская_поликлиника_1DataSet.DataSetName = "Детская_поликлиника_1DataSet";
            this.детская_поликлиника_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_пациентаLabel.Location = new System.Drawing.Point(84, 100);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(101, 16);
            код_пациентаLabel.TabIndex = 3;
            код_пациентаLabel.Text = "Код пациента:";
            // 
            // код_пациентаTextBox
            // 
            код_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедурыBindingSource, "Код пациента", true));
            код_пациентаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_пациентаTextBox.Location = new System.Drawing.Point(276, 97);
            код_пациентаTextBox.Name = "код_пациентаTextBox";
            код_пациентаTextBox.Size = new System.Drawing.Size(200, 22);
            код_пациентаTextBox.TabIndex = 4;
            // 
            // наименование_процедурыLabel
            // 
            наименование_процедурыLabel.AutoSize = true;
            наименование_процедурыLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименование_процедурыLabel.Location = new System.Drawing.Point(84, 126);
            наименование_процедурыLabel.Name = "наименование_процедурыLabel";
            наименование_процедурыLabel.Size = new System.Drawing.Size(186, 16);
            наименование_процедурыLabel.TabIndex = 5;
            наименование_процедурыLabel.Text = "Наименование процедуры:";
            // 
            // наименование_процедурыTextBox
            // 
            наименование_процедурыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедурыBindingSource, "Наименование процедуры", true));
            наименование_процедурыTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименование_процедурыTextBox.Location = new System.Drawing.Point(276, 123);
            наименование_процедурыTextBox.Name = "наименование_процедурыTextBox";
            наименование_процедурыTextBox.Size = new System.Drawing.Size(200, 22);
            наименование_процедурыTextBox.TabIndex = 6;
            // 
            // описание_процедурыLabel
            // 
            описание_процедурыLabel.AutoSize = true;
            описание_процедурыLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            описание_процедурыLabel.Location = new System.Drawing.Point(84, 152);
            описание_процедурыLabel.Name = "описание_процедурыLabel";
            описание_процедурыLabel.Size = new System.Drawing.Size(152, 16);
            описание_процедурыLabel.TabIndex = 7;
            описание_процедурыLabel.Text = "Описание процедуры:";
            // 
            // описание_процедурыTextBox
            // 
            описание_процедурыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедурыBindingSource, "Описание процедуры", true));
            описание_процедурыTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            описание_процедурыTextBox.Location = new System.Drawing.Point(276, 149);
            описание_процедурыTextBox.Name = "описание_процедурыTextBox";
            описание_процедурыTextBox.Size = new System.Drawing.Size(200, 22);
            описание_процедурыTextBox.TabIndex = 8;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(84, 179);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(43, 16);
            датаLabel.TabIndex = 9;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.процедурыBindingSource, "Дата", true));
            датаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаDateTimePicker.Location = new System.Drawing.Point(276, 174);
            датаDateTimePicker.Name = "датаDateTimePicker";
            датаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            датаDateTimePicker.TabIndex = 10;
            // 
            // процедурыTableAdapter
            // 
            this.процедурыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Детская_поликлиника1.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АнализыTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = null;
            this.tableAdapterManager.ПриёмTableAdapter = null;
            this.tableAdapterManager.ПроцедурыTableAdapter = this.процедурыTableAdapter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(329, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_процедурLabel);
            this.Controls.Add(код_процедурTextBox);
            this.Controls.Add(код_пациентаLabel);
            this.Controls.Add(код_пациентаTextBox);
            this.Controls.Add(наименование_процедурыLabel);
            this.Controls.Add(наименование_процедурыTextBox);
            this.Controls.Add(описание_процедурыLabel);
            this.Controls.Add(описание_процедурыTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(датаDateTimePicker);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.процедурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Детская_поликлиника_1DataSet детская_поликлиника_1DataSet;
        private System.Windows.Forms.BindingSource процедурыBindingSource;
        private Детская_поликлиника_1DataSetTableAdapters.ПроцедурыTableAdapter процедурыTableAdapter;
        private Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
    }
}