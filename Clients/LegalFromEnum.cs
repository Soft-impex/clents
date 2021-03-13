using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clients
{
    public enum LegalFromEnum
    {
        [Description("ООО")]
        OOO = 1,
        [Description("ИП")]
        IP = 2,
        [Description("ОАО")]
        OAO = 3,
        [Description("ЗАО")]
        ZAO = 4,
        [Description("ООО ТД")]
        OOOTD = 5,
        [Description("ОГУП")]
        OGUP = 6,
        [Description("ОГКУ")]
        OGKY = 7,
        [Description("ФИЗ")]
        FIZ = 8,
        [Description("НИУ")]
        NIY = 9,
        [Description("АО")]
        AO = 10,
        [Description("ГК")]
        GK = 11,
        [Description("")]
        Entry = 12
    }
}
