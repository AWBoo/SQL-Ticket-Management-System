using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRG4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void SetupDataGridView()
        {
            dataGrid.Columns[4].DefaultCellStyle.Format = "F2"; // Format as fixed-point with 2 decimal places
        }


        private void RefreshData()
        {
            DataTable yourDataTable = GetYourData();

            if (yourDataTable != null)
            {
                dataGrid.DataSource = yourDataTable;

                SetupDataGridView();
            }


            textBoxTicketIdToEdit.Text = "(TicketID)";
            textBoxUpdatedPassengerName.Text = "(Passenger Name)";
            textBoxUpdatedDestination.Text = "(Destination Text)";
            textBoxUpdatedTicketPrice.Text = "(Ticket Price)";
            textBoxTicketIdToDelete.Text = "(Ticket ID To Delete)";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Call RefreshData on form load to display data initially
            RefreshData();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asher\\source\\repos\\PRG4\\PRG4\\BusTicketDB.mdf;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string passengerName = textBoxPassengerName.Text;
                string destination = textBoxDestination.Text;
                DateTime date = dateTimePickerDestination.Value;


                if (!decimal.TryParse(textBoxTicketPrice.Text, out decimal ticketPrice))
                {
                    MessageBox.Show("Invalid ticket price. Please enter a valid number.");
                    return;
                }

                BookTicket(passengerName, destination, ticketPrice, date);

                // Optional: Clear the textboxes after booking
                textBoxPassengerName.Clear();
                textBoxDestination.Clear();
                textBoxTicketPrice.Clear();

                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking ticket: " + ex.Message);
            }
        }

        private void BookTicket(string passengerName, string destination, decimal ticketPrice, DateTime date)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Generate a random TicketId
                    Random random = new Random();
                    int ticketId = random.Next(1000, 9999); // Adjust the range as needed

                    // Omit TicketId in the query; it will be set manually
                    string query = "INSERT INTO BookedTickets (TicketId, PassengerName, Destination, Date, TicketPrice) " +
                                   "VALUES (@TicketId, @PassengerName, @Destination, @Date, @TicketPrice);";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Set the parameters before executing the query
                    command.Parameters.AddWithValue("@TicketId", ticketId);
                    command.Parameters.AddWithValue("@PassengerName", passengerName);
                    command.Parameters.AddWithValue("@Destination", destination);
                    command.Parameters.AddWithValue("@Date", date);

                    command.Parameters.AddWithValue("@TicketPrice", ticketPrice);

                    // Execute the query
                    command.ExecuteNonQuery();

                    MessageBox.Show($"Ticket {ticketId} booked successfully!");
                }




            }
            catch (Exception ex)
            {
                throw new Exception("Error booking ticket: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

                DataTable yourDataTable = GetYourData();

                // Set the data source for dataGridView1 to display the entire table
                dataGrid.DataSource = yourDataTable;

        }

        private DataTable GetYourData()
        {
            DataTable dataTable = new DataTable("BookedTickets");

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM BookedTickets";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately in your application
                MessageBox.Show("Error: " + ex.Message);
                return null; // Ensure a non-null DataTable is returned
            }

            return dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the TicketId from the user
                if (!int.TryParse(textBoxTicketIdToDelete.Text, out int ticketIdToDelete))
                {
                    MessageBox.Show("Invalid Ticket ID. Please enter a valid number.");
                    return;
                }

                DeleteTicket(ticketIdToDelete);

                // Optional: Clear the TextBox after deleting
                textBoxTicketIdToDelete.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting ticket: " + ex.Message);
            }
        }

        private void DeleteTicket(int ticketId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Specify the DELETE query with a WHERE clause based on TicketId
                    string query = "DELETE FROM BookedTickets WHERE TicketId = @TicketId;";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Set the parameter for TicketId before executing the query
                    command.Parameters.AddWithValue("@TicketId", ticketId);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Ticket {ticketId} deleted successfully!");
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show($"Ticket {ticketId} not found.");
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting ticket: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the TicketId from the user 
                if (!int.TryParse(textBoxTicketIdToEdit.Text, out int ticketIdToEdit))
                {
                    MessageBox.Show("Invalid Ticket ID. Please enter a valid number.");
                    return;
                }

                // Get updated information from the user
                string updatedPassengerName = textBoxUpdatedPassengerName.Text;
                string updatedDestination = textBoxUpdatedDestination.Text;

                if (!decimal.TryParse(textBoxUpdatedTicketPrice.Text, out decimal updatedTicketPrice))
                {
                    MessageBox.Show("Invalid updated ticket price. Please enter a valid number.");
                    return;
                }

                EditTicket(ticketIdToEdit, updatedPassengerName, updatedDestination, updatedTicketPrice);

                // Optional: Clear the TextBoxes after editing
                textBoxTicketIdToEdit.Clear();
                textBoxUpdatedPassengerName.Clear();
                textBoxUpdatedDestination.Clear();
                textBoxUpdatedTicketPrice.Clear();

                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing ticket: " + ex.Message);
            }
        }

        private void EditTicket(int ticketId, string updatedPassengerName, string updatedDestination, decimal updatedTicketPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Specify the UPDATE query with a WHERE clause based on TicketId
                    string query = "UPDATE BookedTickets " +
                                   "SET PassengerName = @UpdatedPassengerName, Destination = @UpdatedDestination, TicketPrice = @UpdatedTicketPrice " +
                                   "WHERE TicketId = @TicketId;";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Set the parameters for updated information and TicketId before executing the query
                    command.Parameters.AddWithValue("@UpdatedPassengerName", updatedPassengerName);
                    command.Parameters.AddWithValue("@UpdatedDestination", updatedDestination);
                    command.Parameters.AddWithValue("@UpdatedTicketPrice", updatedTicketPrice);
                    command.Parameters.AddWithValue("@TicketId", ticketId);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Ticket {ticketId} updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Ticket {ticketId} not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error editing ticket: " + ex.Message);
            }
        }
    }
}
