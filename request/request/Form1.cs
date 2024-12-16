using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace request
{
    /// <summary>
    /// Основная форма приложения, отвечающая за отображение и управление заявками.
    /// </summary>
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost; Database=Requests; Integrated Security=True;";
        private List<Request> requests;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Form1"/> и загружает заявки из базы данных.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            LoadRequests();
        }

        /// <summary>
        /// Загружает заявки из базы данных и заполняет выпадающий список <c>cmbRequests</c> данными.
        /// </summary>
        private void LoadRequests()
        {
            requests = new List<Request>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Requests", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    requests.Add(new Request
                    {
                        Request_ID = reader.GetInt32(0),
                        Equipment_ID = reader.GetString(1),
                        Description = reader.GetString(4),
                        Request_Date = reader.GetDateTime(2),
                        Status = reader.GetString(3)
                    });
                }
            }

            cmbRequests.DataSource = requests;
            cmbRequests.DisplayMember = "Equipment_ID";
            cmbRequests.ValueMember = "Request_ID";
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного элемента в выпадающем списке <c>cmbRequests</c>,
        /// обновляя текстовые поля с информацией о выбранной заявке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void cmbRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRequests.SelectedItem is Request selectedRequest)
            {
                txtEquipmentName.Text = selectedRequest.Equipment_ID;
                txtDescription.Text = selectedRequest.Description;
                txtRequestDate.Text = selectedRequest.Request_Date.ToString("g");
                txtPriority.Text = selectedRequest.Status;
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле <c>txtEquipmentName</c>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void txtEquipmentName_TextChanged(object sender, EventArgs e)
        {
            // Логика обработки изменения текста (если требуется)
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле <c>txtDescription</c>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            // Логика обработки изменения текста (если требуется)
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле <c>txtRequestDate</c>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void txtRequestDate_TextChanged(object sender, EventArgs e)
        {
            // Логика обработки изменения текста (если требуется)
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле <c>txtPriority</c>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void txtPriority_TextChanged(object sender, EventArgs e)
        {
            // Логика обработки изменения текста (если требуется)
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки для удаления заявки и отображает сообщение об успешном удалении.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заявка удалена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки для отметки заявки как выполненной и отображает соответствующее сообщение.
        /// </summary>
        /// <param name ="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void btnMarkAsCompleted_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заявка успешно выполнена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки для изменения заявки и отображает сообщение об успешном изменении.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заявка успешно изменена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    /// <summary>
    /// Представляет заявку с идентификатором, идентификатором оборудования, описанием, датой заявки и статусом.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Получает или задает идентификатор заявки.
        /// </summary>
        public int Request_ID { get; set; }

        /// <summary>
        /// Получает или задает идентификатор оборудования, связанного с заявкой.
        /// </summary>
        public string Equipment_ID { get; set; }

        /// <summary>
        /// Получает или задает описание заявки.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Получает или задает дату подачи заявки.
        /// </summary>
        public DateTime Request_Date { get; set; }

        /// <summary>
        /// Получает или задает статус заявки.
        /// </summary>
        public string Status { get; set; }
    }
}