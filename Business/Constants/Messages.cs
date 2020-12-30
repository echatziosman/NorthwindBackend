using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Urun Basariyla eklendi";
        public static string ProductDeleted = "Urun Basariyla silindi";
        public static string ProductUpdated = "Urun Basariyla guncellendi";

        public static string UserNotFound = "Kullanici Bulunamadi";
        public static string PasswordError = "Sifre Hatali";
        public static string SuccessfullLogin = "Hosgeldiniz";
        public static string UserAlreadyExists = "Boyle bir kullanici mevcut";
        public static string UserRegistered = "Kullanici Basariyla Kaydedildi";
        public static string AccessTokenCreated = "Access Token Basariyla Olusturuldu";
    }
}
