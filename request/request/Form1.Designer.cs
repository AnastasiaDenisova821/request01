using System;

namespace request
{
    partial class Form1
    {
        // <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освобождает все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">true, если управляемые ресурсы должны быть освобождены; иначе — false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный Windows Form Designer

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSelectRequest = new System.Windows.Forms.Label();
            this.cmbRequests = new System.Windows.Forms.ComboBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.txtRequestDate = new System.Windows.Forms.TextBox();
            this.btnMarkAsCompleted = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(203, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Обработка заявки на ремонт";
            // 
            // lblSelectRequest
            // 
            this.lblSelectRequest.AutoSize = true;
            this.lblSelectRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectRequest.Location = new System.Drawing.Point(123, 62);
            this.lblSelectRequest.Name = "lblSelectRequest";
            this.lblSelectRequest.Size = new System.Drawing.Size(143, 20);
            this.lblSelectRequest.TabIndex = 1;
            this.lblSelectRequest.Text = "Выберите заявку:";
            // 
            // cmbRequests
            // 
            this.cmbRequests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequests.FormattingEnabled = true;
            this.cmbRequests.Location = new System.Drawing.Point(286, 64);
            this.cmbRequests.Name = "cmbRequests";
            this.cmbRequests.Size = new System.Drawing.Size(244, 21);
            this.cmbRequests.TabIndex = 2;
            this.cmbRequests.SelectedIndexChanged += new System.EventHandler(this.cmbRequests_SelectedIndexChanged);
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEquipmentName.Location = new System.Drawing.Point(67, 113);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(199, 20);
            this.lblEquipmentName.TabIndex = 3;
            this.lblEquipmentName.Text = "Название оборудования:";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEquipmentName.Location = new System.Drawing.Point(286, 115);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.ReadOnly = true;
            this.txtEquipmentName.Size = new System.Drawing.Size(244, 20);
            this.txtEquipmentName.TabIndex = 4;
            this.txtEquipmentName.TextChanged += new System.EventHandler(this.txtEquipmentName_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(98, 159);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(168, 20);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Описание проблемы:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescription.Location = new System.Drawing.Point(286, 159);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(244, 60);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriority.Location = new System.Drawing.Point(200, 284);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(66, 20);
            this.lblPriority.TabIndex = 7;
            this.lblPriority.Text = "Статус:";
       
            // 
            // txtPriority
            // 
            this.txtPriority.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPriority.Location = new System.Drawing.Point(286, 284);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.ReadOnly = true;
            this.txtPriority.Size = new System.Drawing.Size(244, 20);
            this.txtPriority.TabIndex = 8;
            this.txtPriority.TextChanged += new System.EventHandler(this.txtPriority_TextChanged);
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRequestDate.Location = new System.Drawing.Point(158, 243);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(108, 20);
            this.lblRequestDate.TabIndex = 9;
            this.lblRequestDate.Text = "Дата заявки:";
            // 
            // txtRequestDate
            // 
            this.txtRequestDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRequestDate.Location = new System.Drawing.Point(286, 243);
            this.txtRequestDate.Name = "txtRequestDate";
            this.txtRequestDate.ReadOnly = true;
            this.txtRequestDate.Size = new System.Drawing.Size(244, 20);
            this.txtRequestDate.TabIndex = 10;
            this.txtRequestDate.TextChanged += new System.EventHandler(this.txtRequestDate_TextChanged);
            // 
            // btnMarkAsCompleted
            // 
            this.btnMarkAsCompleted.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMarkAsCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMarkAsCompleted.Location = new System.Drawing.Point(255, 368);
            this.btnMarkAsCompleted.Name = "btnMarkAsCompleted";
            this.btnMarkAsCompleted.Size = new System.Drawing.Size(178, 49);
            this.btnMarkAsCompleted.TabIndex = 11;
            this.btnMarkAsCompleted.Text = "Отметить как выполнено";
            this.btnMarkAsCompleted.UseVisualStyleBackColor = false;
            this.btnMarkAsCompleted.Click += new System.EventHandler(this.btnMarkAsCompleted_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 300);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Удалить заявку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(485, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Изменить заявку";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 429);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnMarkAsCompleted);
            this.Controls.Add(this.txtRequestDate);
            this.Controls.Add(this.lblRequestDate);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.cmbRequests);
            this.Controls.Add(this.lblSelectRequest);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Обработка заявки на ремонт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSelectRequest;
        private System.Windows.Forms.ComboBox cmbRequests;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.TextBox txtRequestDate;
        private System.Windows.Forms.Button btnMarkAsCompleted;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

