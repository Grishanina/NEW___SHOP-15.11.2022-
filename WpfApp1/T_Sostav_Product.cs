
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WpfApp1
{

using System;
    using System.Collections.Generic;
    
public partial class T_Sostav_Product
{

    public int id_sostav_product { get; set; }

    public int id_product { get; set; }

    public int id_sostav { get; set; }



    public virtual T_Product T_Product { get; set; }

    public virtual T_Sostav T_Sostav { get; set; }

}

}
