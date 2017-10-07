using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JobFairs
{
  public partial class frmAddPeople : Form
  {
    public frmAddPeople()
    {
      InitializeComponent();
    }

    private void m_btnAddPerson_Click(object sender, EventArgs e)
    {
      People p = NewMethod();

      InsertPerson(p);
    }

    private People NewMethod()
    {
      People p = new People();
      p.First = m_tbFirstName.Text;
      p.Last = m_tbLastName.Text;
      p.MI = m_tbMI.Text;
      p.Title = m_tbTitle.Text;
      p.Address1 = m_tbAddress1.Text;
      p.Address2 = m_tbAddress2.Text;
      p.City = m_tbCity.Text;
      p.State = m_tbState.Text;
      p.Zip = m_tbZip.Text;
      p.EMail = m_tbEMail.Text;
      p.Phone = m_tbPhone.Text;
      return p;
    }

    string InsertPerson(People p)
    {
      //  The following line contains a connection string for a database that is on my local machine (server).
      //  Beware of storing a connection string that includes a username and password for an online server
      //  in public places like this GitHub repository since that would allow everyone to see those credentials.
      
      // Home
      string dbConnStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JobFair;Integrated Security=True";
      // Office
      //string dbConnStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JobFairs;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
      string retVal;

      SqlConnection sc = new SqlConnection(dbConnStr);     // Create a .Net framework SQL Server connection object
                                                           // based on the connection string.

      sc.Open();                                          // Establish an opened connection to the DB.

      SqlCommand cmd = new SqlCommand();                  // A SqlCommand can have a variety of property values

      cmd.CommandText =
        "INSERT INTO People" +
                  "(First, MI, Last, Title, Address1, Address2, City, State, Zip, EMail, Phone) " +
        "VALUES (" +
        "'" + m_tbFirstName.Text + "'," +
        "'" + m_tbMI.Text + "'," +
        "'" + m_tbLastName.Text + "'," +
        "'" + m_tbTitle.Text + "'," +     // changed to a varchar(10) field from int
        "'" + m_tbAddress1.Text + "'," +
        "'" + m_tbAddress2.Text + "'," +
        "'" + m_tbCity.Text + "'," +
        "'" + m_tbState.Text + "'," +
        "'" + m_tbZip.Text + "'," +
        "'" + m_tbEMail.Text + "'," +
        "'" + m_tbPhone.Text + "'" +
        ")" + ";";


      // Line above establishes the SQL command to be 
      // be executed.  The next two lines, establish other 
      // features of the SQLCommand object.  There are about
      // a dozen SQLCommand object properties.  See the documentation
      // for a complete list.
      cmd.CommandType = CommandType.Text;
      cmd.Connection = sc;
      retVal = cmd.ExecuteNonQuery().ToString();


      // set return value to the last generated identity value
      cmd.CommandText = "SELECT @@IDENTITY;";
      retVal = cmd.ExecuteScalar().ToString();

      MessageBox.Show("Identity is : " + retVal.ToString());
      sc.Close();                                       // Don't forget to close the connection object when finished 
      return retVal;
    }


  }
}
