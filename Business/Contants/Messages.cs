using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Success = "Başarılı";
        public static string Error = "Hata";
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductDeleteded = "Ürün başarıyla silindi";
        public static string CategoryAdded = "Kategori başarıyla eklendi";
        public static string CategoryUpdated = "Kategori başarıyla güncellendi";
        public static string CategoryDeleteded = "Kategori başarıyla silindi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz bulunamadı";
    }
}
