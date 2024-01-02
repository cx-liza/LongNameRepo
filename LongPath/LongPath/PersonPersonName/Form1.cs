using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// notes: many-to-many (EF shortcut): http://thedatafarm.com/LearnEntityFramework/tutorials/many-to-many-relationships-in-the-entity-data-model/
// join: http://msdn.microsoft.com/en-us/library/bb534675.aspx
// linq2sql visualizer: http://www.talentgrouplabs.com/blog/archive/2007/11/25/how-to-trace-linq-generated-sql.aspx
// linq logging: http://www.goondocks.com/blog/08-04-22/using_asp_net_page_trace_to_view_linq_sql.aspx
// linq2sql debug visualizer: http://weblogs.asp.net/scottgu/archive/2007/07/31/linq-to-sql-debug-visualizer.aspx
// visualizer issues: http://codebetter.com/blogs/david.hayden/archive/2007/08/20/linq-to-sql-debugger-visualizer-concerns.aspx
// SQL Server Express Profiler: http://code.google.com/p/sqlexpressprofiler/downloads/list
// Identity: http://blogs.msdn.com/dsimmons/pages/ef-faq-entity-services.aspx#Section_17

namespace PersonPersonName
{
	public partial class Form1 : Form
	{
		protected PersonPersonNameEntities ppnContext;
		protected BindingSource bsppn;

		public Form1()
		{
			InitializeComponent();
			ppnContext = new PersonPersonNameEntities();
			bsppn = new BindingSource();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//ObjectQuery<Person> person = ppnContext.Person;
			//ObjectQuery<PersonName> personName = ppnContext.PersonName;

			//var ppnQuery = from p in person
			//               join pn in personName
			//                on p.PersonName.ID equals pn.ID
			//               select new { p.Gender, pn.FirstName, pn.LastName };					   

			LoadData();

			tbGender.DataBindings.Add(new Binding("Text", bsppn, "Gender"));
			tbFirstName.DataBindings.Add(new Binding("Text", bsppn, "FirstName"));
			tbLastName.DataBindings.Add(new Binding("Text", bsppn, "LastName"));
		}

		protected void LoadData()
		{
			IQueryable<PPN> ppnQuery = ppnContext.Person.Join(
				ppnContext.PersonName,
				person => person.PersonName,
				personName => personName,
				(person, personName) => new PPN()
				{
					Gender = person.Gender,
					LastName = personName.LastName,
					FirstName = personName.FirstName,
					PersonObject = person,
					PersonNameObject = personName
				}).AsQueryable();

			bsppn.DataSource = ppnQuery;
			dgvPersonPersonName.DataSource = bsppn;
			dgvPersonPersonName.Columns["PersonObject"].Visible = false;
			dgvPersonPersonName.Columns["PersonNameObject"].Visible = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (bsppn.Current != null)
			{
				PPN current = bsppn.Current as PPN;
				ppnContext.DeleteObject(current.PersonObject);
				ppnContext.DeleteObject(current.PersonNameObject);
				ppnContext.SaveChanges();
				LoadData();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			PersonName pn = new PersonName();
			pn.FirstName = tbFirstName.Text;
			pn.LastName = tbLastName.Text;

			Person p = new Person();
			p.Gender = tbGender.Text;
			p.PersonName = pn;

			ppnContext.AddToPerson(p);

			ppnContext.SaveChanges();
			LoadData();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (bsppn.Current != null)
			{
				PPN current = bsppn.Current as PPN;
				current.PersonObject.Gender = tbGender.Text;
				current.PersonNameObject.FirstName = tbFirstName.Text;
				current.PersonNameObject.LastName = tbLastName.Text;
				ppnContext.SaveChanges();
				LoadData();
			}
		}
	}

	public class PPN
	{
		public string Gender { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Person PersonObject { get; set; }
		public PersonName PersonNameObject { get; set; }
	}
}
