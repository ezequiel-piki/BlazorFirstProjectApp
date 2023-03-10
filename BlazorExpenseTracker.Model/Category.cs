using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorExpenseTracker.Model
{
    public class Category
    {
       // [Range(1,10)] el formulario va ser invalido si se pasa de este rango 1-10
       public int Id { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Category Name is required")]
        // [EmailAddress] el campo deberá ser de tipo email
        //[StringLength(25)]
        [MinLength(2)]
        public string Name { get; set; }
    }
}
