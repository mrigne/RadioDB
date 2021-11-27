using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRadioDB.Models;

namespace TestRadioDB
{
    class DBHelper
    {
        private SqliteConnection connection;
        private static DBHelper instance;

        public static DBHelper GetInstance()
        {
            if (instance == null) {
                instance = new DBHelper();
            }
            return instance;
        }

        private DBHelper()
        {
            connection = new SqliteConnection("Data Source=database.db");
            OpenConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Containers(
                    ContainerId TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    Barcode TEXT
                );
                CREATE TABLE IF NOT EXISTS Details(
                    DetailId TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    ContainerId TEXT,
                    FOREIGN KEY(ContainerId) REFERENCES Containers(ContainerId)
                );
            ";
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void OpenConnection()
        {
            if (connection?.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection?.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public List<DetailRow> GetDetails()
        {
            try
            {
                this.OpenConnection();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT *
                    FROM Details
                ";

                var reader = command.ExecuteReader();
                List<DetailRow> detailsList = new List<DetailRow>();
                while (reader.Read())
                {
                    var detailItemRow = new DetailRow();
                    detailItemRow.DetailId = reader.GetString(reader.GetOrdinal("DetailId"));
                    detailItemRow.Name = reader.GetString(reader.GetOrdinal("Name"));
                    if (!reader.IsDBNull(reader.GetOrdinal("ContainerId")))
                    {
                        detailItemRow.ContainerId = reader.GetString(reader.GetOrdinal("ContainerId"));
                    }
                    
                    detailsList.Add(detailItemRow);
                }
                return detailsList;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<DetailRow> GetDetailsByPartialName(string partOfName)
        {
            try
            {
                this.OpenConnection();
                var command = connection.CreateCommand();
                if (!String.IsNullOrWhiteSpace(partOfName))
                {
                    command.CommandText = @"
                    SELECT *
                    FROM Details
                    WHERE Name LIKE $PARTIALNAME
                ";
                    command.Parameters.AddWithValue("$PARTIALNAME", partOfName);
                }
                else
                {
                    command.CommandText = @"
                    SELECT *
                    FROM Details
                ";
                }
                var reader = command.ExecuteReader();
                List<DetailRow> detailsList = new List<DetailRow>();
                while (reader.Read())
                {
                    var detailItemRow = new DetailRow();
                    detailItemRow.DetailId = reader.GetString(reader.GetOrdinal("DetailId"));
                    detailItemRow.Name = reader.GetString(reader.GetOrdinal("Name"));
                    if (!reader.IsDBNull(reader.GetOrdinal("ContainerId")))
                    {
                        detailItemRow.ContainerId = reader.GetString(reader.GetOrdinal("ContainerId"));
                    }

                    detailsList.Add(detailItemRow);
                }
                return detailsList;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<ContainerRow> GetContainers()
        {
            try
            {
                this.OpenConnection();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT *
                    FROM Containers
                ";
                var reader = command.ExecuteReader();
                List<ContainerRow> containersList = new List<ContainerRow>();
                while (reader.Read())
                {
                    var containerItemRow = new ContainerRow();
                    containerItemRow.ContainerId = reader.GetString(reader.GetOrdinal("ContainerId"));
                    containerItemRow.Name = reader.GetString(reader.GetOrdinal("Name"));
                    if (!reader.IsDBNull(reader.GetOrdinal("Barcode")))
                    {
                        containerItemRow.Barcode = reader.GetString(reader.GetOrdinal("Barcode"));
                    }
                    containersList.Add(containerItemRow);
                }
                return containersList;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public ContainerRow GetContainerById(string containerId)
        {
            try
            {
                this.OpenConnection();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT *
                    FROM Containers
                    WHERE ContainerId = $id
                ";
                command.Parameters.AddWithValue("$id", containerId);
                var reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    var containerItemRow = new ContainerRow();
                    containerItemRow.ContainerId = reader.GetString(reader.GetOrdinal("ContainerId"));
                    containerItemRow.Name = reader.GetString(reader.GetOrdinal("Name"));
                    if (!reader.IsDBNull(reader.GetOrdinal("Barcode")))
                    {
                        containerItemRow.Barcode = reader.GetString(reader.GetOrdinal("Barcode"));
                    }
                    return containerItemRow;
                } else
                {
                    return null;
                }
            }
            finally
            {
                this.CloseConnection();
            }
        }
        
        public void AddContainer(ContainerRow container)
        {
            if (container != null)
            {
                try
                {
                    this.OpenConnection();
                    var command = connection.CreateCommand();
                    command.CommandText = @"
                    INSERT
                    INTO Containers
                    VALUES (
                        $containerId,
                        $name,
                        $barcode
                    )
                ";
                    command.Parameters.AddWithValue("$containerId", container.ContainerId.ToString());
                    command.Parameters.AddWithValue("$name", container.Name);
                    command.Parameters.AddWithValue("$barcode", container.Barcode == null ? DBNull.Value : container.Barcode);
                    command.ExecuteNonQuery();
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public void UpdateContainer(ContainerRow container)
        {
            if (container != null)
            {
                try
                {
                    this.OpenConnection();
                    var command = connection.CreateCommand();
                    command.CommandText = @"
                    UPDATE Containers
                    SET Name = $name, Barcode = $barcode
                    WHERE ContainerId = $containerId
                ";
                    command.Parameters.AddWithValue("$containerId", container.ContainerId.ToString());
                    command.Parameters.AddWithValue("$name", container.Name);
                    command.Parameters.AddWithValue("$barcode", container.Barcode == null ? DBNull.Value : container.Barcode);
                    command.ExecuteNonQuery();
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public void AddDetail(DetailRow detail)
        {
            if (detail != null)
            {
                try
                {
                    this.OpenConnection();
                    var command = connection.CreateCommand();
                    command.CommandText = @"
                    INSERT
                    INTO Details
                    VALUES (
                        $detailId,
                        $name,
                        $containerId
                    )
                ";
                    command.Parameters.AddWithValue("$detailId", detail.DetailId.ToString());
                    command.Parameters.AddWithValue("$name", detail.Name);
                    command.Parameters.AddWithValue("$containerId", detail.ContainerId == null ? DBNull.Value : detail.ContainerId.ToString());
                    command.ExecuteNonQuery();
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public void AddDetails(List<DetailRow> details)
        {
            try
            {
                this.OpenConnection();
                if (details != null && details.Count > 0)
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        var command = connection.CreateCommand();
                        command.CommandText = @"
                        INSERT INTO Details
                        VALUES (
                            $detailId, 
                            $name,
                            $containerId
                        )
                    ";

                        var detailIdParameter = command.CreateParameter();
                        detailIdParameter.ParameterName = "$detailId";
                        command.Parameters.Add(detailIdParameter);

                        var nameParameter = command.CreateParameter();
                        nameParameter.ParameterName = "$name";
                        command.Parameters.Add(nameParameter);

                        var containerIdParameter = command.CreateParameter();
                        containerIdParameter.ParameterName = "$containerId";
                        command.Parameters.Add(containerIdParameter);

                        foreach (var detailRow in details)
                        {
                            detailIdParameter.Value = detailRow.DetailId;
                            nameParameter.Value = detailRow.Name;
                            containerIdParameter.Value = detailRow.ContainerId;

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void DeleteTopNRows(string detailName, string? containerId, int numberOfRows = 1)
        {
            try
            {
                this.OpenConnection();
                var command = connection.CreateCommand();
                if (containerId == null)
                {
                    command.CommandText = @"
                        DELETE
                        FROM Details
                        WHERE DetailId IN (
                            SELECT DetailId
                            FROM Details
                            WHERE Name = $detailName AND ContainerId IS NULL
                            LIMIT $numberOfRows
                        )
                    ";
                } else
                {
                    command.CommandText = @"
                        DELETE
                        FROM Details
                        WHERE DetailId IN (
                            SELECT DetailId
                            FROM Details
                            WHERE Name = $detailName AND ContainerId = $containerId
                            LIMIT $numberOfRows
                        )
                    ";
                    command.Parameters.AddWithValue("$containerId", containerId == null ? DBNull.Value : containerId);
                }
                command.Parameters.AddWithValue("$detailName", detailName);
                command.Parameters.AddWithValue("$numberOfRows", numberOfRows);

                command.ExecuteNonQuery();
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void DeleteContainer(string containerId)
        {
            try
            {
                this.OpenConnection();
                var command = connection.CreateCommand();
                command.CommandText = @"
                        DELETE
                        FROM Containers
                        WHERE ContainerId = $containerId
                    ";

                command.Parameters.AddWithValue("$containerId", containerId);

                command.ExecuteNonQuery();
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void DeleteAllDetailsFromContainer(string containerId)
        {
            try
            {
                this.OpenConnection();
                var command = connection.CreateCommand();
                command.CommandText = @"
                        DELETE
                        FROM Details
                        WHERE ContainerId = $containerId
                    ";

                command.Parameters.AddWithValue("$containerId", containerId);

                command.ExecuteNonQuery();
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
