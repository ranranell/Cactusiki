//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cactusiki.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public int id_Login { get; set; }
        public Nullable<int> Role_id { get; set; }
        public string Login1 { get; set; }
        public string Password { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}
