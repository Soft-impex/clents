using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace SynchSQKServer.Models
{
    public enum LegalForms
    {
        [Repr("ООО")]
        [Description("ООО")]
        OOO=1,
        [Repr("ИП")]
        [Description("ИП")]
        IP =2,
        [Repr("ОАО")]
        [Description("ОАО")]
        OAO =3,
        [Repr("ЗАО")]
        [Description("ЗАО")]
        ZAO = 4,
        [Repr("ООО ТД")]
        [Description("ООО ТД")]
        OOOTD = 5,
        [Repr("ОГУП")]
        [Description("ОГУП")]
        OGUP = 6,
        [Repr("ОГКУ")]
        [Description("ОГКУ")]
        OGKY = 7,
        [Repr("ФИЗ")]
        [Description("ФИЗ")]
        FIZ = 8,
        [Repr("НИУ")]
        [Description("НИУ")]
        NIY = 9,
        [Repr("АО")]
        [Description("АО")]
        AO = 10,
        [Repr("ГК")]
        [Description("ГК")]
        GK = 11,
        [Repr("")]
        [Description("")]
        Entry = 12
    }
}
