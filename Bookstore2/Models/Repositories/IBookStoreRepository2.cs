using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore2.Models
{
    interface IBookStoreRepository2<TEntity>
    {
        IList<TEntity> List();// تعني احضر لي الشيء الذي من النوع TEntity "generic"
        //و اعمل عمل منه قائمة List 
        // النوع TEntity يعني انه يقبل اي شيء يعني قد يكون الانتيتي Book or Author 
        TEntity Find(int id); // هذه الميثود هي عملية البحث عن عنصر لذالك القيمة التي سترجع لنا هي قيمة العنصر نفسه 
        // لذالك بدأنا ب TEntity find هذا اسم الذي اخترناه للابيرشون 
        //TEntity Find(int id); int id هو الشيء الذي سابحث على اساسه لذالك انا هنا سوف احضر العنصر بنائا على ال id الخاص به 
        //  وهنا نبحث اما من خلال ال Id الخاص بالكتاب او الID  الخاص بالمؤلف 
        // ويرجع لنا النوع نفسه سواء كتاب او مؤلف 
        void Add(TEntity entity); //عملية الاضافة احادية الجانب فقط انت تقوم بارسال البيانات لذالك هي و لا احتاج الى ارجاع اي شيء  void 

        void Update(int id ,TEntity entity);// نفس الشيء عملية التعديل او التحديث 
        void Delete(int id); // وايضا عملية الحذف هي احادية الجانب و العنصر الذي نريد ان نحذفه ندخل الرقم المرحعي له و نخذفه 
        // هكذا اكتملت بناء عمليات الريبوسوتري داخل الانترفيس 


    } 
}
