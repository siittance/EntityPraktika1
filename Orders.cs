//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityPrakt1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int ID_Order { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int Client_ID { get; set; }
        public int Pet_ID { get; set; }
    
        public virtual Clients Clients { private get; set; }
        public virtual Pets Pets { private get; set; }
    }
}
