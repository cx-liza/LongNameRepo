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

// Original file name:
// Generation date: 2/9/2009 11:13:03 AM
namespace PersonName
{
    
    /// <summary>
    /// There are no comments for PersonNameEntities in the schema.
    /// </summary>
    public partial class PersonNameEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new PersonNameEntities object using the connection string found in the 'PersonNameEntities' section of the application configuration file.
        /// </summary>
        public PersonNameEntities() : 
                base("name=PersonNameEntities", "PersonNameEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new PersonNameEntities object.
        /// </summary>
        public PersonNameEntities(string connectionString) : 
                base(connectionString, "PersonNameEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new PersonNameEntities object.
        /// </summary>
        public PersonNameEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "PersonNameEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
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
        /// There are no comments for PersonName in the schema.
        /// </summary>
        public void AddToPersonName(PersonName personName)
        {
            base.AddObject("PersonName", personName);
        }
    }
    /// <summary>
    /// There are no comments for eftestModel.PersonName in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="eftestModel", Name="PersonName")]
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
    }
}