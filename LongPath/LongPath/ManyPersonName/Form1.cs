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

namespace ManyPersonName
{
	public partial class Form1 : Form
	{
		protected ManyPersonNameEntities mpnContext;
		protected BindingSource bsPerson;

		public Form1()
		{
			InitializeComponent();
			mpnContext = new ManyPersonNameEntities();
			bsPerson = new BindingSource();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ObjectQuery<Person> personQuery = mpnContext.Person.Include("PersonName");
			bsPerson.DataSource = personQuery;
			dgvPerson.DataSource = bsPerson;
			dgvPerson.Columns["ID"].Visible = false;
			dgvPerson.Columns["PersonName"].Visible = false;

			dgvPersonName.DataBindings.Add(new Binding("DataSource", bsPerson, "PersonName"));
			dgvPersonName.Columns["ID"].Visible = false;
			dgvPersonName.Columns["Person"].Visible = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			mpnContext.SaveChanges();
		}
	}
}
