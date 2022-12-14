//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Clinica.Database
{

    [Persistent(@"medico")]
    public partial class Medico : XPLiteObject
    {
        int fId_medi;
        [Key]
        [Persistent(@"id_medi")]
        public int Id_medi
        {
            get { return fId_medi; }
            set { SetPropertyValue<int>(nameof(Id_medi), ref fId_medi, value); }
        }
        string fNombre;
        [Size(20)]
        [Persistent(@"nombre")]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fApellido;
        [Size(20)]
        [Persistent(@"apellido")]
        public string Apellido
        {
            get { return fApellido; }
            set { SetPropertyValue<string>(nameof(Apellido), ref fApellido, value); }
        }
        string fEspecialidad;
        [Size(15)]
        [Persistent(@"especialidad")]
        public string Especialidad
        {
            get { return fEspecialidad; }
            set { SetPropertyValue<string>(nameof(Especialidad), ref fEspecialidad, value); }
        }
        [Association(@"UserReferencesMedico")]
        public XPCollection<User> Users { get { return GetCollection<User>(nameof(Users)); } }
    }

}
