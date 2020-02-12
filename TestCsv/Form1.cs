using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Csv.Serialization;
using Csv.Serialization.Model;

namespace TestCsv
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSaveCSV_Click(object sender, EventArgs e)
		{
			// Serialization
			var data = GetPeople();
			using (var stream = new FileStream("persons.csv", FileMode.Create, FileAccess.Write))
			{
				var cs = new CsvSerializer<Person>()
				{
					UseTextQualifier = true,
				};
				cs.Serialize(stream, data);
			}
		}
		
		/// <summary>
		/// Create Sample Data
		/// </summary>
		/// <returns></returns>
		private static IList<Person> GetPeople()
		{
			var employees = new List<Person>()
			{
				new Person()
				{
					Address1 = "The Club, 33 Dalgety St",
					BitFlags = 12345,
					BitMask = 0xab,
					BSB1 = "061234",
					ContactName = "Rmeov",
					ContactTitle = "Mr",
					DepartmentCode = "GT",
					DirectAccount1 = "09874578",
					DOB = DateTime.Parse("23 January, 1910"),
					eMailAddress = "django@jazzclub.com",					
					FirstName = "Django",
					Id = Guid.NewGuid(),
					LastName = "Reinhardt",					
					MobilePhone = "023984761",
					PostCode = "3000",
					State = "FR",					
					Suburb = "Bayswater",					
				},
				new Person()
				{
					Address1 = "9 Fifth Avenue",
					BitFlags = 12345,
					BitMask = 0xab,
					BSB1 = "061234",
					ContactName = "Xlot,lol",
					ContactTitle = "Ms",
					DepartmentCode = "AB",
					DirectAccount1 = "09874578",
					DOB = DateTime.Parse("23 January 1910"),
					eMailAddress = "xlot@msoft.com",					
					FirstName = "Ambere",
					Id = Guid.NewGuid(),
					LastName = "Hawkins",					
					MobilePhone = "023432761",
					PostCode = "5000",
					State = "CA",					
					Suburb = "Mermaid Beach",					
				},
		};
			return employees;
		}

		private void btnLoadCSV_Click(object sender, EventArgs e)
		{
			// Deserialization
			IList<Person> deserializedData = null;
			using (var stream = new FileStream("persons.csv", FileMode.Open, FileAccess.Read))
			{
				var cs = new CsvSerializer<Person>()
				{
					UseTextQualifier = true,
				};

				deserializedData = cs.Deserialize(stream);
				var strTmp = deserializedData[0].ToText();
				MessageBox.Show(strTmp);
			}
		}
	}
}
