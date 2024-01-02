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

namespace PersonNameLocation
{
	public partial class Form1 : Form
	{
		protected PersonNameLocationEntities context;
		protected BindingSource bsPersonName;
		protected BindingSource bsLocation;

		public Form1()
		{
			InitializeComponent();
			context = new PersonNameLocationEntities();
			bsPersonName = new BindingSource();
			bsLocation = new BindingSource();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ObjectQuery<PersonName> personQuery = context.PersonName;
			ObjectQuery<Location> locationQuery = context.Location;
			bsPersonName.DataSource = personQuery;
			bsLocation.DataSource = locationQuery;
			dgvPersonName.DataSource = bsPersonName;
			dgvLocation.DataSource = bsLocation;

			dgvPersonName.Columns["ID"].Visible = false;
			dgvPersonName.Columns["PersonNameLocationAssociation"].Visible = false;
			dgvLocation.Columns["ID"].Visible = false;
			dgvLocation.Columns["PersonNameLocationAssociation"].Visible = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
		}

		private void btnAssociate_Click(object sender, EventArgs e)
		{
			if ((bsLocation.Current != null) && (bsPersonName.Current != null))
			{
				PersonName pn = (PersonName)bsPersonName.Current;
				Location loc = (Location)bsLocation.Current;
				PersonNameLocationAssociation assoc = new PersonNameLocationAssociation();
				assoc.PersonName = pn;
				assoc.Location = loc;
				assoc.AssocType = "Lives At";
				pn.PersonNameLocationAssociation.Add(assoc);
				loc.PersonNameLocationAssociation.Add(assoc);
				context.SaveChanges();
			}
		}
	}
}
