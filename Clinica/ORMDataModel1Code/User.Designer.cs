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

    [Persistent(@"user")]
    public partial class User : XPLiteObject
    {
        int fId;
        [Key]
        [Persistent(@"id")]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        string fPassword;
        [Size(32)]
        [Persistent(@"password")]
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>(nameof(Password), ref fPassword, value); }
        }
        Medico fId_medi;
        [Persistent(@"id_medi")]
        [Association(@"UserReferencesMedico")]
        public Medico Id_medi
        {
            get { return fId_medi; }
            set { SetPropertyValue<Medico>(nameof(Id_medi), ref fId_medi, value); }
        }
    }

}
