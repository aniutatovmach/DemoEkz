//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_TovmachAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public int ID { get; set; }
        public string Post { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> Last_entry { get; set; }
        public string Entry_type { get; set; }
        public byte[] Preview { get; set; }
    }
}
