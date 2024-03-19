using System.ComponentModel.DataAnnotations;

namespace CoreValidation_2Tekrar.Models.ViewModels.PureVM.Categories
{
    //PureVM
    //CategoryVM
    //CategoryRequestModel
    //CategoryResponeModel
    public class CategoryRequestModel
    {
        //DataAnnaotation'da yer tutucu operatörleri sayılarla verilir. 0 ilgili property neyse direkt o ismi alır.

        [Required(ErrorMessage ="{0} Zorunlu Bir Alandır.")]
        [Display(Name ="Kategori İsmi")] // Bizim Property'miz kullanısıya ne şekilde gözüksün istiyorsak onu yazıyoruz.
        [MaxLength(15,ErrorMessage ="{0} En Fazla {1} Karakter Alabilir")]
        [MinLength(5,ErrorMessage ="{0} En Az {1} Karakter Alabilir")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage ="{0} Zorunlu Bir Alandır")]
        [Display(Name ="Aciklama")]
        [MinLength(10,ErrorMessage ="{0} En az {1} Karakter Alabilir")]
        public string Description { get; set; }

    }
}
