# **Responsi Junior Project**

This repository contains a Windows Forms application called **Responsi Junior Project**, designed to manage employee data in a PostgreSQL database. The application includes functionalities for inserting, updating, and deleting employee records, as well as populating department and job title dropdowns from the database.

## **Technologies Used**
- **C#**: The primary programming language used for the Windows Forms application.
- **Windows Forms**: The UI framework for building the graphical user interface.
- **PostgreSQL**: The relational database used to store employee data.
- **Npgsql**: A .NET data provider for PostgreSQL, used for database interaction.

## **Features**
- **Insert Employee Data**: Insert new employee records, including employee name, department, and job title.
- **Edit Employee Data**: Select an employee from a DataGridView to update their details.
- **Delete Employee Data**: Select an employee to delete their record from the database.
- **Populate Dropdowns**: Department and job title dropdowns are populated with data fetched from the database.

## **Setup and Installation**

### Prerequisites
- **.NET Framework**: Ensure you have .NET Framework 4.8 or higher installed.
- **PostgreSQL**: A running instance of PostgreSQL with the necessary database and tables set up.

### Steps to Run the Application
1. Clone or download this repository to your local machine.
   ```
   git clone https://github.com/yourusername/ResponsiJuniorProject.git
   ```
2. Open the project in Visual Studio.
3. Update the connection string in the ```Form1.cs``` file to point to your PostgreSQL instance.
   ```
   string connString = "Host=localhost;Port=5432;Username=postgres;Password=yourpassword;Database=ResponsiJuniorProject";
   ```
4. Build and run the application within Visual Studio.

## **Database Schema**
1. Employee (Karyawan): Contains employee data with columns like id_karyawan (pk), nama_karyawan, id_dep (fk), and id_jabatan (fk).
2. Department (Departemen): Contains department data with columns like id_dep (pk) and nama_dep.
3. Job Title (Jabatan): Contains job title data with columns like id_jabatan (pk) and nama_jabatan.

## **Functions and Stored Procedures**   
- ```insert_karyawan```: Inserts a new employee record into the karyawan table.
- ```update_karyawan```: Updates an existing employee record in the karyawan table.
- ```delete_by_id```: Deletes an employee record by id_karyawan.
- ```load_all_karyawan_info```: Fetches all employee records for display in the DataGridView.

---

<p align="center"><i>Nibroos Aurore Majiid Haryanto</i></p>
<p align="center"><i>22/494882/TK/54329</i></p>
