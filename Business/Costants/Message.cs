using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Costants
{
    public static class Message
    {
        public static string AddToCar = "Araç eklendi.";
        public static string AddToBrand="Marka eklendi.";
        public static string RemoveBrand="Marka silindi.";
        public static string AllBrandsListed="Markalar listelendi.";
        public static string GetBrandMessage="Marka görüntülendi.";
        public static string UpdateBrand="Marka güncellendi.";
        public static string GetAllCarMessage="Bütün araçlar listelendi.";
        public static string GetCarDetailMessage="Araç detayları listelendi.";
        public static string RemoveCar="Araç silindi";
        public static string UpdateCar="Araç güncellendi.";
        public static string AddColour="Renk eklendi";
        public static string GetAllColoursMessage="Renkler listelendi";
        public static string RemoveColour="Renk silindi";
        public static string AuthorizationDenied = "Yetkiniz yok !";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        internal static string ImageUploaded;
        internal static string ImageRemoved;
        internal static string ImagesListed;
        internal static string ImageLimit;
        internal static string UserUpdated;
    }
}
