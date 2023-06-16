using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;

public class DatabaseController : MonoBehaviour {
  // Start is called before the first frame update
  private string _databaseName = "URI=file:fish-database.db";
  private string _databaseInitilisationCommands =
    // Creating the fish types table
    "CREATE TABLE IF NOT EXISTS FishTypes(" +
    "id INT NOT NULL UNIQUE," +
    "name VARCHAR(255) NOT NULL UNIQUE," +
    "temperature_min float NOT NULL," +
    "temperature_max float NOT NULL," +
    "acidity_min float NOT NULL," +
    "acidity_max float NOT NULL," +
    "PRIMARY KEY (id));" +
    // Creating the fish table itself
    "CREATE TABLE IF NOT EXISTS Fish(" +
    "id INT NOT NULL UNIQUE," +
    "name VARCHAR(255) NOT NULL UNIQUE," +
    "description VARCHAR(255)," +
    "fk_fishtype INT NOT NULL," +
    "PRIMARY KEY (id)," +
    "FOREIGN KEY (fk_fishtype) REFERENCES FishTypes(id));";

  void Awake() {
    _initialiseDatabase();
  }
  private void _initialiseDatabase() {
    using (var _connection = new SqliteConnection(_databaseName)) {
      _connection.Open();
      using (var command = new SqliteCommand(_databaseInitilisationCommands, _connection)) {
        command.ExecuteNonQuery();
      }
      _connection.Close();
    }
    Debug.Log("Database initialised");
  }
}
