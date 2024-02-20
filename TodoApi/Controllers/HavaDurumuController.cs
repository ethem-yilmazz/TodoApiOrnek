using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Dtos;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HavaDurumuController : ControllerBase
    {
        readonly Random rnd = new Random();
        readonly string[] _durumlar = ["Açık", "Parçalı Bulutlu", "Çok Bulutlu", "Sisli", "Puslu", "Yağmurlu", "Sağanak Yağışlı", "Kar Yağışlı", "Karla Karışık Yağmur", "Dolu", "Sıcak", "Soğuk", "Rüzgarlı", "Fırtına", "Kasırga"];

        [HttpGet]
        public List<HavaDto> Get()
        {
            var tahminler = new List<HavaDto>();

            for (int i = 0; i < 5; i++)
            {
                tahminler.Add(new HavaDto()
                {
                    Tarih= DateOnly.FromDateTime(DateTime.Today.AddDays(i)),
                    Sicaklik = rnd.Next(-5,31),
                    Aciklama = _durumlar[rnd.Next(_durumlar.Length)]
                });
            }

            return tahminler;
        }
    }
}
