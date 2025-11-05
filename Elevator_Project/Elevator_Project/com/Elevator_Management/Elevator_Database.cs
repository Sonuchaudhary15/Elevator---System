using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Elevator_Project
{
    class Elevator_Database
    {
        // MongoDB setup
        private readonly MongoClient _mongoClient;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<CurrentFloorDoc> _currentFloorCol;

        public Elevator_Database()
        {
            // Default to local MongoDB. Change as needed.
            var connectionString = "mongodb://localhost:27017";
            var dbName = "ElevatorDB";
            _mongoClient = new MongoClient(connectionString);
            _database = _mongoClient.GetDatabase(dbName);
            _currentFloorCol = _database.GetCollection<CurrentFloorDoc>("Current_Floor");
        }

        // Function to return current floor of the Elevator from MongoDB
        internal string GetCurrentFloor() {
            try
            {
                var last = _currentFloorCol.Find(FilterDefinition<CurrentFloorDoc>.Empty)
                    .SortByDescending(d => d.CreatedAt)
                    .Limit(1)
                    .FirstOrDefault();
                if (last != null)
                {
                    return last.Floor_number.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Something is wrong with MongoDB " + ex.Message);
            }
            return "No Current Floor Records Available";
        }

        // Function to Set current floor of the Elevator
        internal void SetCurrentFloor(int State) {
            if (State == 1 || State == 2)
            {
                SetFloorToDatabase(State);
            }
            else {
                MessageBox.Show("Error!!! You only can set Elevator to floor 1 or 2");
            }
        }

        // Function to Set the Current Floor of the Elevator in MongoDB
        private void SetFloorToDatabase(int State)
        {
            try
            {
                string date_time = DateTime.Now.ToString("dd-MM-yyyy 'at' h:mm:ss tt");
                var doc = new CurrentFloorDoc
                {
                    Floor_number = State,
                    Date_Time = date_time,
                    CreatedAt = DateTime.UtcNow
                };
                _currentFloorCol.InsertOne(doc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Something is wrong with MongoDB " + ex.Message);
            }
        }

        // Function to showing tables of database in the form gridview
        internal void GetTablesData()
        {
            try
            {
                var all = _currentFloorCol.Find(FilterDefinition<CurrentFloorDoc>.Empty)
                    .SortBy(d => d.CreatedAt)
                    .ToList();

                // Build a DataTable with expected columns
                DataTable DbTable = new DataTable();
                DbTable.Columns.Add("Current_Floor_id", typeof(int));
                DbTable.Columns.Add("Floor_id", typeof(int));
                DbTable.Columns.Add("Date_Time", typeof(string));

                int idx = 1;
                foreach (var rec in all)
                {
                    // Preserve old UI mapping: 7 -> 1, 8 -> 2
                    int floorId = rec.Floor_number == 1 ? 7 : 8;
                    DbTable.Rows.Add(idx++, floorId, rec.Date_Time);
                }

                Main_Form.Self.database_grid_view.AutoGenerateColumns = false;
                Main_Form.Self.database_grid_view.DataSource = DbTable;

                // chenge the floor_id to floor_number in datagridviewTable
                foreach (DataGridViewRow DataRow in Main_Form.Self.database_grid_view.Rows)
                {
                    foreach (DataGridViewCell DataCell in DataRow.Cells)
                    {
                        if (DataCell.Value != null && DataCell.Value.Equals(7))
                        {
                            DataCell.Value = 1;
                        }
                        else if (DataCell.Value != null && DataCell.Value.Equals(8))
                        {
                            DataCell.Value = 2;
                        }
                    }
                }
                // deselct default and then select last row of the table which indicate last log of the elevator
                if (Main_Form.Self.database_grid_view.Rows.Count > 0)
                {
                    Main_Form.Self.database_grid_view.CurrentCell.Selected = false;
                    Main_Form.Self.database_grid_view.Rows[Main_Form.Self.database_grid_view.Rows.Count - 1].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Something is wrong Loading data from MongoDB " + ex.Message);
            }
        }

        // Function to delete a log entry from MongoDB
        internal bool DeleteLogEntry(int floorNumber, string dateTime)
        {
            try
            {
                // Find the document matching the floor number and date/time
                var filter = Builders<CurrentFloorDoc>.Filter.And(
                    Builders<CurrentFloorDoc>.Filter.Eq(d => d.Floor_number, floorNumber),
                    Builders<CurrentFloorDoc>.Filter.Eq(d => d.Date_Time, dateTime)
                );

                var result = _currentFloorCol.DeleteOne(filter);
                
                if (result.DeletedCount > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Log entry not found in database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Something is wrong deleting from MongoDB: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Function to delete all log entries from MongoDB
        internal int DeleteAllLogs()
        {
            try
            {
                // Delete all documents in the collection
                var result = _currentFloorCol.DeleteMany(FilterDefinition<CurrentFloorDoc>.Empty);
                
                return (int)result.DeletedCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! Something is wrong deleting all logs from MongoDB: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // MongoDB document model
        private class CurrentFloorDoc
        {
            public ObjectId Id { get; set; }
            public int Floor_number { get; set; }
            public string Date_Time { get; set; }
            public DateTime CreatedAt { get; set; }
        }
    }
}
