using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Clinica.Database
{

    public partial class Diagnostico
    {
        public Diagnostico(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
