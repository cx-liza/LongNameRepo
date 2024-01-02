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

namespace PersonName
{
	public partial class Form1 : Form
	{
		protected PersonNameEntities personNameContext;

		public Form1()
		{
			InitializeComponent();
			personNameContext = new PersonNameEntities();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ObjectQuery<PersonName> personNameQuery = personNameContext.PersonName;
			dgvPersonName.DataSource = personNameQuery;
			dgvPersonName.Columns["ID"].Visible = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			personNameContext.SaveChanges();
		}
	}
}
