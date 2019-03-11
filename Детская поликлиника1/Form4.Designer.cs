namespace Детская_поликлиника1
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
            System.Windows.Forms.Label код_приёмаLabel;
            System.Windows.Forms.Label код_врачаLabel;
            System.Windows.Forms.Label код_пациентаLabel;
            System.Windows.Forms.Label температураLabel;
            System.Windows.Forms.Label давлениеLabel;
            System.Windows.Forms.Label диагнозLabel;
            this.детская_поликлиника_1DataSet = new Детская_поликлиника1.Детская_поликлиника_1DataSet();
            this.приёмBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приёмTableAdapter = new Детская_поликлиника1.Детская_поликлиника_1DataSetTableAdapters.ПриёмTableAdapter();
            this.tableAdapterManager = new Детская_поликлиника1.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager();
            this.код_приёмаTextBox = new System.Windows.Forms.TextBox();
            this.код_врачаTextBox = new System.Windows.Forms.TextBox();
            this.код_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.температураTextBox = new System.Windows.Forms.TextBox();
            this.давлениеTextBox = new System.Windows.Forms.TextBox();
            this.диагнозTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            код_приёмаLabel = new System.Windows.Forms.Label();
            код_врачаLabel = new System.Windows.Forms.Label();
            код_пациентаLabel = new System.Windows.Forms.Label();
            температураLabel = new System.Windows.Forms.Label();
            давлениеLabel = new System.Windows.Forms.Label();
            диагнозLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приёмBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // детская_поликлиника_1DataSet
            // 
            this.детская_поликлиника_1DataSet.DataSetName = "Детская_поликлиника_1DataSet";
            this.детская_поликлиника_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // приёмBindingSource
            // 
            this.приёмBindingSource.DataMember = "Приём";
            this.приёмBindingSource.DataSource = this.детская_поликлиника_1DataSet;
            // 
            // приёмTableAdapter
            // 
            this.приёмTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Детская_поликлиника1.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АнализыTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = null;
            this.tableAdapterManager.ПриёмTableAdapter = this.приёмTableAdapter;
            this.tableAdapterManager.ПроцедурыTableAdapter = null;
            // 
            // код_приёмаLabel
            // 
            код_приёмаLabel.AutoSize = true;
            код_приёмаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_приёмаLabel.Location = new System.Drawing.Point(193, 72);
            код_приёмаLabel.Name = "код_приёмаLabel";
            код_приёмаLabel.Size = new System.Drawing.Size(87, 16);
            код_приёмаLabel.TabIndex = 1;
            код_приёмаLabel.Text = "Код приёма:";
            // 
            // код_приёмаTextBox
            // 
            this.код_приёмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Код приёма", true));
            this.код_приёмаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_приёмаTextBox.Location = new System.Drawing.Point(297, 72);
            this.код_приёмаTextBox.Name = "код_приёмаTextBox";
            this.код_приёмаTextBox.Size = new System.Drawing.Size(180, 22);
            this.код_приёмаTextBox.TabIndex = 2;
            // 
            // код_врачаLabel
            // 
            код_врачаLabel.AutoSize = true;
            код_врачаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_врачаLabel.Location = new System.Drawing.Point(193, 101);
            код_врачаLabel.Name = "код_врачаLabel";
            код_врачаLabel.Size = new System.Drawing.Size(78, 16);
            код_врачаLabel.TabIndex = 3;
            код_врачаLabel.Text = "Код врача:";
            // 
            // код_врачаTextBox
            // 
            this.код_врачаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Код врача", true));
            this.код_врачаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_врачаTextBox.Location = new System.Drawing.Point(297, 98);
            this.код_врачаTextBox.Name = "код_врачаTextBox";
            this.код_врачаTextBox.Size = new System.Drawing.Size(180, 22);
            this.код_врачаTextBox.TabIndex = 4;
            this.код_врачаTextBox.TextChanged += new System.EventHandler(this.код_врачаTextBox_TextChanged);
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_пациентаLabel.Location = new System.Drawing.Point(193, 127);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(101, 16);
            код_пациентаLabel.TabIndex = 5;
            код_пациентаLabel.Text = "Код пациента:";
            // 
            // код_пациентаTextBox
            // 
            this.код_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Код пациента", true));
            this.код_пациентаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_пациентаTextBox.Location = new System.Drawing.Point(297, 124);
            this.код_пациентаTextBox.Name = "код_пациентаTextBox";
            this.код_пациентаTextBox.Size = new System.Drawing.Size(180, 22);
            this.код_пациентаTextBox.TabIndex = 6;
            // 
            // температураLabel
            // 
            температураLabel.AutoSize = true;
            температураLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            температураLabel.Location = new System.Drawing.Point(193, 153);
            температураLabel.Name = "температураLabel";
            температураLabel.Size = new System.Drawing.Size(100, 16);
            температураLabel.TabIndex = 7;
            температураLabel.Text = "Температура:";
            // 
            // температураTextBox
            // 
            this.температураTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Температура", true));
            this.температураTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.температураTextBox.Location = new System.Drawing.Point(297, 150);
            this.температураTextBox.Name = "температураTextBox";
            this.температураTextBox.Size = new System.Drawing.Size(180, 22);
            this.температураTextBox.TabIndex = 8;
            // 
            // давлениеLabel
            // 
            давлениеLabel.AutoSize = true;
            давлениеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            давлениеLabel.Location = new System.Drawing.Point(193, 179);
            давлениеLabel.Name = "давлениеLabel";
            давлениеLabel.Size = new System.Drawing.Size(76, 16);
            давлениеLabel.TabIndex = 9;
            давлениеLabel.Text = "Давление:";
            // 
            // давлениеTextBox
            // 
            this.давлениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Давление", true));
            this.давлениеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.давлениеTextBox.Location = new System.Drawing.Point(297, 176);
            this.давлениеTextBox.Name = "давлениеTextBox";
            this.давлениеTextBox.Size = new System.Drawing.Size(180, 22);
            this.давлениеTextBox.TabIndex = 10;
            // 
            // диагнозLabel
            // 
            диагнозLabel.AutoSize = true;
            диагнозLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            диагнозLabel.Location = new System.Drawing.Point(193, 205);
            диагнозLabel.Name = "диагнозLabel";
            диагнозLabel.Size = new System.Drawing.Size(66, 16);
            диагнозLabel.TabIndex = 11;
            диагнозLabel.Text = "Диагноз:";
            // 
            // диагнозTextBox
            // 
            this.диагнозTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Диагноз", true));
            this.диагнозTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.диагнозTextBox.Location = new System.Drawing.Point(297, 202);
            this.диагнозTextBox.Name = "диагнозTextBox";
            this.диагнозTextBox.Size = new System.Drawing.Size(180, 22);
            this.диагнозTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(331, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_приёмаLabel);
            this.Controls.Add(this.код_приёмаTextBox);
            this.Controls.Add(код_врачаLabel);
            this.Controls.Add(this.код_врачаTextBox);
            this.Controls.Add(код_пациентаLabel);
            this.Controls.Add(this.код_пациентаTextBox);
            this.Controls.Add(температураLabel);
            this.Controls.Add(this.температураTextBox);
            this.Controls.Add(давлениеLabel);
            this.Controls.Add(this.давлениеTextBox);
            this.Controls.Add(диагнозLabel);
            this.Controls.Add(this.диагнозTextBox);
            this.Name = "Form4";
            this.Text = "Детская поликлиника";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приёмBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Детская_поликлиника_1DataSet детская_поликлиника_1DataSet;
        private System.Windows.Forms.BindingSource приёмBindingSource;
        private Детская_поликлиника_1DataSetTableAdapters.ПриёмTableAdapter приёмTableAdapter;
        private Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_приёмаTextBox;
        private System.Windows.Forms.TextBox код_врачаTextBox;
        private System.Windows.Forms.TextBox код_пациентаTextBox;
        private System.Windows.Forms.TextBox температураTextBox;
        private System.Windows.Forms.TextBox давлениеTextBox;
        private System.Windows.Forms.TextBox диагнозTextBox;
        private System.Windows.Forms.Button button1;
    }
}