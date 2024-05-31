using HSYMDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

// npm
// pub.dev
// nuget
// SqlConnection
// Ctrl +. ==> suggestion
// F10 ==>step Over
//F11 ==> Step Off
//F9 ==> Breakpoint


//=> C# =>DB


/*SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "MSI"; //server name
stringBuilder.InitialCatalog = "HSYMDotNetCore";
stringBuilder.UserID = "sa";
stringBuilder.Password = "sasa@123";
SqlConnection	connection = new SqlConnection(stringBuilder.ConnectionString);


connection.Open();
Console.WriteLine("Connection open.");

string query = "select * from tbl_blog";
SqlCommand cmd = new SqlCommand(query, connection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
sqlDataAdapter.Fill(dt);

connection.Close();
Console.WriteLine("Connection close.");

//Dataset ==> datatable more than one
//Datatable ==> datarow
//Datarow ==> datacolumn

foreach (DataRow dr in dt.Rows)
{
	Console.WriteLine("Blog Id => " + dr["BlogId"]);
	Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
	Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
	Console.WriteLine("Blog Content => " + dr["BlogContent"]);
	Console.WriteLine("--------------------------------------");
}*/

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");

//adoDotNetExample.Update(1, "test title", "test author", "test content");
/*adoDotNetExample.Delete(1);
adoDotNetExample.Delete(2);
adoDotNetExample.Delete(3);
adoDotNetExample.Delete(4);*/
adoDotNetExample.Edit(1);
adoDotNetExample.Edit(5);

Console.ReadKey();
