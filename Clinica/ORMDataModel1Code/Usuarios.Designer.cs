﻿//------------------------------------------------------------------------------
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

    [Persistent(@"usuarios")]
    public partial class Usuarios : XPLiteObject
    {
        int fUser;
        [Key]
        [Persistent(@"user")]
        public int User
        {
            get { return fUser; }
            set { SetPropertyValue<int>(nameof(User), ref fUser, value); }
        }
        string fPassword;
        [Size(64)]
        [Persistent(@"password")]
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>(nameof(Password), ref fPassword, value); }
        }
    }

}
