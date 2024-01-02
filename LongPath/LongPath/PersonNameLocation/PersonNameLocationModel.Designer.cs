﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("PersonNameLocationModel", "FK_Location_Association", "Location", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(PersonNameLocation.Location), "PersonNameLocationAssociation", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PersonNameLocation.PersonNameLocationAssociation))]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("PersonNameLocationModel", "FK_Person_Association", "PersonName", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(PersonNameLocation.PersonName), "PersonNameLocationAssociation", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PersonNameLocation.PersonNameLocationAssociation))]

// Original file name:
// Generation date: 2/11/2009 9:32:36 PM
namespace PersonNameLocation
{
    
    /// <summary>
    /// There are no comments for PersonNameLocationEntities in the schema.
    /// </summary>
    public partial class PersonNameLocationEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new PersonNameLocationEntities object using the connection string found in the 'PersonNameLocationEntities' section of the application configuration file.
        /// </summary>
        public PersonNameLocationEntities() : 
                base("name=PersonNameLocationEntities", "PersonNameLocationEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new PersonNameLocationEntities object.
        /// </summary>
        public PersonNameLocationEntities(string connectionString) : 
                base(connectionString, "PersonNameLocationEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new PersonNameLocationEntities object.
        /// </summary>
        public PersonNameLocationEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "PersonNameLocationEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Location in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Location> Location
        {
            get
            {
                if ((this._Location == null))
                {
                    this._Location = base.CreateQuery<Location>("[Location]");
                }
                return this._Location;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Location> _Location;
        /// <summary>
        /// There are no comments for PersonName in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<PersonName> PersonName
        {
            get
            {
                if ((this._PersonName == null))
                {
                    this._PersonName = base.CreateQuery<PersonName>("[PersonName]");
                }
                return this._PersonName;
            }
        }
        private global::System.Data.Objects.ObjectQuery<PersonName> _PersonName;
        /// <summary>
        /// There are no comments for PersonNameLocationAssociation in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<PersonNameLocationAssociation> PersonNameLocationAssociation
        {
            get
            {
                if ((this._PersonNameLocationAssociation == null))
                {
                    this._PersonNameLocationAssociation = base.CreateQuery<PersonNameLocationAssociation>("[PersonNameLocationAssociation]");
                }
                return this._PersonNameLocationAssociation;
            }
        }
        private global::System.Data.Objects.ObjectQuery<PersonNameLocationAssociation> _PersonNameLocationAssociation;
        /// <summary>
        /// There are no comments for Location in the schema.
        /// </summary>
        public void AddToLocation(Location location)
        {
            base.AddObject("Location", location);
        }
        /// <summary>
        /// There are no comments for PersonName in the schema.
        /// </summary>
        public void AddToPersonName(PersonName personName)
        {
            base.AddObject("PersonName", personName);
        }
        /// <summary>
        /// There are no comments for PersonNameLocationAssociation in the schema.
        /// </summary>
        public void AddToPersonNameLocationAssociation(PersonNameLocationAssociation personNameLocationAssociation)
        {
            base.AddObject("PersonNameLocationAssociation", personNameLocationAssociation);
        }
    }
    /// <summary>
    /// There are no comments for PersonNameLocationModel.Location in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="PersonNameLocationModel", Name="Location")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Location : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Location object.
        /// </summary>
        /// <param name="id">Initial value of ID.</param>
        /// <param name="number">Initial value of Number.</param>
        /// <param name="street">Initial value of Street.</param>
        /// <param name="zip">Initial value of Zip.</param>
        public static Location CreateLocation(int id, string number, string street, string zip)
        {
            Location location = new Location();
            location.ID = id;
            location.Number = number;
            location.Street = street;
            location.Zip = zip;
            return location;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this.ReportPropertyChanging("ID");
                this._ID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ID");
                this.OnIDChanged();
            }
        }
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Number in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Number
        {
            get
            {
                return this._Number;
            }
            set
            {
                this.OnNumberChanging(value);
                this.ReportPropertyChanging("Number");
                this._Number = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Number");
                this.OnNumberChanged();
            }
        }
        private string _Number;
        partial void OnNumberChanging(string value);
        partial void OnNumberChanged();
        /// <summary>
        /// There are no comments for Property Street in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                this.OnStreetChanging(value);
                this.ReportPropertyChanging("Street");
                this._Street = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Street");
                this.OnStreetChanged();
            }
        }
        private string _Street;
        partial void OnStreetChanging(string value);
        partial void OnStreetChanged();
        /// <summary>
        /// There are no comments for Property Zip in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Zip
        {
            get
            {
                return this._Zip;
            }
            set
            {
                this.OnZipChanging(value);
                this.ReportPropertyChanging("Zip");
                this._Zip = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Zip");
                this.OnZipChanged();
            }
        }
        private string _Zip;
        partial void OnZipChanging(string value);
        partial void OnZipChanged();
        /// <summary>
        /// There are no comments for PersonNameLocationAssociation in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("PersonNameLocationModel", "FK_Location_Association", "PersonNameLocationAssociation")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<PersonNameLocationAssociation> PersonNameLocationAssociation
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<PersonNameLocationAssociation>("PersonNameLocationModel.FK_Location_Association", "PersonNameLocationAssociation");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<PersonNameLocationAssociation>("PersonNameLocationModel.FK_Location_Association", "PersonNameLocationAssociation", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for PersonNameLocationModel.PersonName in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="PersonNameLocationModel", Name="PersonName")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class PersonName : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new PersonName object.
        /// </summary>
        /// <param name="id">Initial value of ID.</param>
        /// <param name="firstName">Initial value of FirstName.</param>
        /// <param name="lastName">Initial value of LastName.</param>
        public static PersonName CreatePersonName(int id, string firstName, string lastName)
        {
            PersonName personName = new PersonName();
            personName.ID = id;
            personName.FirstName = firstName;
            personName.LastName = lastName;
            return personName;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this.ReportPropertyChanging("ID");
                this._ID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ID");
                this.OnIDChanged();
            }
        }
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property FirstName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this.ReportPropertyChanging("FirstName");
                this._FirstName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("FirstName");
                this.OnFirstNameChanged();
            }
        }
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for Property LastName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this.ReportPropertyChanging("LastName");
                this._LastName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("LastName");
                this.OnLastNameChanged();
            }
        }
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        /// <summary>
        /// There are no comments for PersonNameLocationAssociation in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("PersonNameLocationModel", "FK_Person_Association", "PersonNameLocationAssociation")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<PersonNameLocationAssociation> PersonNameLocationAssociation
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<PersonNameLocationAssociation>("PersonNameLocationModel.FK_Person_Association", "PersonNameLocationAssociation");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<PersonNameLocationAssociation>("PersonNameLocationModel.FK_Person_Association", "PersonNameLocationAssociation", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for PersonNameLocationModel.PersonNameLocationAssociation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonNameID
    /// LocationID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="PersonNameLocationModel", Name="PersonNameLocationAssociation")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class PersonNameLocationAssociation : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new PersonNameLocationAssociation object.
        /// </summary>
        /// <param name="personNameID">Initial value of PersonNameID.</param>
        /// <param name="locationID">Initial value of LocationID.</param>
        /// <param name="assocType">Initial value of AssocType.</param>
        public static PersonNameLocationAssociation CreatePersonNameLocationAssociation(int personNameID, int locationID, string assocType)
        {
            PersonNameLocationAssociation personNameLocationAssociation = new PersonNameLocationAssociation();
            personNameLocationAssociation.PersonNameID = personNameID;
            personNameLocationAssociation.LocationID = locationID;
            personNameLocationAssociation.AssocType = assocType;
            return personNameLocationAssociation;
        }
        /// <summary>
        /// There are no comments for Property PersonNameID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonNameID
        {
            get
            {
                return this._PersonNameID;
            }
            set
            {
                this.OnPersonNameIDChanging(value);
                this.ReportPropertyChanging("PersonNameID");
                this._PersonNameID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("PersonNameID");
                this.OnPersonNameIDChanged();
            }
        }
        private int _PersonNameID;
        partial void OnPersonNameIDChanging(int value);
        partial void OnPersonNameIDChanged();
        /// <summary>
        /// There are no comments for Property LocationID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int LocationID
        {
            get
            {
                return this._LocationID;
            }
            set
            {
                this.OnLocationIDChanging(value);
                this.ReportPropertyChanging("LocationID");
                this._LocationID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("LocationID");
                this.OnLocationIDChanged();
            }
        }
        private int _LocationID;
        partial void OnLocationIDChanging(int value);
        partial void OnLocationIDChanged();
        /// <summary>
        /// There are no comments for Property AssocType in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string AssocType
        {
            get
            {
                return this._AssocType;
            }
            set
            {
                this.OnAssocTypeChanging(value);
                this.ReportPropertyChanging("AssocType");
                this._AssocType = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("AssocType");
                this.OnAssocTypeChanged();
            }
        }
        private string _AssocType;
        partial void OnAssocTypeChanging(string value);
        partial void OnAssocTypeChanged();
        /// <summary>
        /// There are no comments for Location in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("PersonNameLocationModel", "FK_Location_Association", "Location")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Location Location
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Location>("PersonNameLocationModel.FK_Location_Association", "Location").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Location>("PersonNameLocationModel.FK_Location_Association", "Location").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Location in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Location> LocationReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Location>("PersonNameLocationModel.FK_Location_Association", "Location");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Location>("PersonNameLocationModel.FK_Location_Association", "Location", value);
                }
            }
        }
        /// <summary>
        /// There are no comments for PersonName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("PersonNameLocationModel", "FK_Person_Association", "PersonName")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public PersonName PersonName
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<PersonName>("PersonNameLocationModel.FK_Person_Association", "PersonName").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<PersonName>("PersonNameLocationModel.FK_Person_Association", "PersonName").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for PersonName in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<PersonName> PersonNameReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<PersonName>("PersonNameLocationModel.FK_Person_Association", "PersonName");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<PersonName>("PersonNameLocationModel.FK_Person_Association", "PersonName", value);
                }
            }
        }
    }
}
