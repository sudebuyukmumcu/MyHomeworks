using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService (yani burada başka bir servis kullanıcam)
    //eğer bir sınıfın içinde başka bir sınıf kullanıcaksam asla onu newleme!! onun yerine IUSerValidation Service _userValidationService oluştur.
    //ampulden generete constructer de
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService) //kimlik doğrulama siteminin tamamen soyutu
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true) //başka bir managerdan yararlanarak validate etti.
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
    }
}
