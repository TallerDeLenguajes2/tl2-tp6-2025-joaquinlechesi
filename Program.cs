using Microsoft.Data.Sqlite;
string connectionString = "Data Source=Tienda.db;";

// Crear conexión a la base de datos
using (SqliteConnection connection = new SqliteConnection(connectionString))
{
    connection.Open();
    // Crear tabla si no existe
    // por lo general este tipo de consultas no se implementa en un porgrama real
    // la aplicamos para poder crear nuestra base de datos desde cero
    // string createTableQuery = "CREATE TABLE IF NOT EXISTS productos (id INTEGER PRIMARY KEY, nombre TEXT, precio REAL)";
    // using (SqliteCommand createTableCmd = new SqliteCommand(createTableQuery, connection))
    // {
    //     createTableCmd.ExecuteNonQuery();
    //     Console.WriteLine("Tabla 'productos' creada o ya existe.");
    // }

    // Insertar datos
    //string insertQuery = "INSERT INTO Presupuestos (NombreDestinatario, FechaCreacion) VALUES ('Carlos Ruiz', '2014-10-25')";
    //using (SqliteCommand insertCmd = new SqliteCommand(insertQuery, connection))
    //{
    //    insertCmd.ExecuteNonQuery();
    //    Console.WriteLine("Datos insertados en la tabla 'Presupuestos'.");
    //} //Funciona

    // c) Insertar registros en PresupuestosDetalle
    string insertQuery = "INSERT INTO PresupuestosDetalle (idPresupuesto, idProducto, Cantidad) VALUES (1, 3, 2)";
    using (SqliteCommand insertCmd = new SqliteCommand(insertQuery, connection))
    {
        insertCmd.ExecuteNonQuery();
        Console.WriteLine("Datos insertados en la tabla 'PresupuestosDetalle'.");
    } //Funciona
    
    // Borrar datos
    //string deleteQuery = "INSERT INTO Productos (Descripcion, Precio) VALUES ('Mouse Cableado Logitech', 5000.0)";
    //using (SqliteCommand insertCmd = new SqliteCommand(insertQuery, connection))
    //{
    //    insertCmd.ExecuteNonQuery();
    //    Console.WriteLine("Datos insertados en la tabla 'Productos'.");
    //}
    // Leer datos
            // string selectQuery = "SELECT * FROM productos";
            // using (SqliteCommand selectCmd = new SqliteCommand(selectQuery, connection))
            // using (SqliteDataReader reader = selectCmd.ExecuteReader())
            // {
            //     Console.WriteLine("Datos en la tabla 'productos':");
            //     while (reader.Read())
            //     {
            //         Console.WriteLine($"ID: {reader["id"]}, Nombre: {reader["nombre"]}, Precio: {reader["precio"]}");
            //     }
            // }
            // Select de la tabla productos
            //string selectQuery = "SELECT * FROM Productos";
            //using (SqliteCommand selectCmd = new SqliteCommand(selectQuery, connection))
            //using (SqliteDataReader reader = selectCmd.ExecuteReader())
            //{
            //    Console.WriteLine("Datos en la tabla 'Productos':");
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"ID: {reader["idProducto"]}, Descripcion: {reader["Descripcion"]}, Precio: {reader["Precio"]}");
            //    }
            //}
            // SELECT de la tabla Presupuestos
            //string selectQuery = "SELECT * FROM Presupuestos";
            //using (SqliteCommand selectCmd = new SqliteCommand(selectQuery, connection))
            //using (SqliteDataReader reader = selectCmd.ExecuteReader())
            //{
            //    Console.WriteLine("Datos en la tabla 'Presupuestos':");
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"ID: {reader["idPresupuestos"]}, Nombre de Destinatario: {reader["NombreDestinatario"]}, Precio: {reader["FechaCreacion"]}");
            //    }
            //}
            // SELECT de la tabla PresupuestosDetalle
            string selectQuery = "SELECT * FROM PresupuestosDetalle";
            using (SqliteCommand selectCmd = new SqliteCommand(selectQuery, connection))
            using (SqliteDataReader reader = selectCmd.ExecuteReader())
            {
                Console.WriteLine("Datos en la tabla 'PresupuestosDetalle':");
                while (reader.Read())
                {
                    Console.WriteLine($"idPresupuesto: {reader["idPresupuesto"]}, idProducto: {reader["idProducto"]}, Cantidad: {reader["Cantidad"]}");
                }
            }

            connection.Close(); // funcionando
}