//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task1.Logic.Shawarma
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeController
    {
        public int TimeControllerId { get; set; }
        public int SellerId { get; set; }
        public System.DateTime WorkStart { get; set; }
        public System.DateTime WorkEnd { get; set; }
    
        public virtual Seller Seller { get; set; }
    }
}
