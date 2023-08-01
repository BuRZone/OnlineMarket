using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static OnlineMarket.DAL.ApplicationDbContext;

namespace OnlineMarket.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        { 
                if (context.Users.Any())
                {
                    return;
                }
                context.Users.AddRange(
                    new User() { /*Id = 1,*/ UserName = "Test1@mail.com", Role = Enum.Role.User, Password = HashPasswordHelper.HashPassowrd("123456") },
                    new User() { /*Id = 2,*/ UserName = "Test2@mail.com", Role = Enum.Role.User, Password = HashPasswordHelper.HashPassowrd("123456") },
                    new User() { /*Id = 3,*/ UserName = "Test3@mail.com", Role = Enum.Role.User, Password = HashPasswordHelper.HashPassowrd("123456") },
                    new User() { /*Id = 4,*/ UserName = "Test4@mail.com", Role = Enum.Role.User, Password = HashPasswordHelper.HashPassowrd("123456") },
                    new User() { /*Id = 5,*/ UserName = "burbon@mail.com", Role = Enum.Role.Admin, Password = HashPasswordHelper.HashPassowrd("123456") }
                    );
            context.SaveChanges();

            context.Baskets.AddRange(
                    new Basket() { /*Id = 1,*/ UserId = 1 },
                    new Basket() { /*Id = 2,*/ UserId = 2 },
                    new Basket() { /*Id = 3,*/ UserId = 3 },
                    new Basket() { /*Id = 4,*/ UserId = 4 },
                    new Basket() { /*Id = 5,*/ UserId = 5 }
                );
            context.SaveChanges();

            context.Sellers.AddRange(
                 new Seller()
                 {
                     //Id = 1,
                     UserId = 1,
                     SellerName = "OLESA CHUGUNOVA",
                     SellerPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\logo.jpg"),
                     SellerDescription = "заглушка"
                 },
                new Seller()
                {
                    //Id = 2,
                    UserId = 2,
                    SellerName = "Darya Selskaya".ToUpper(),
                    SellerPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\2.Darya Selskaya\Darya Selskaya в интернет-магазине Wildberries_files\logo.jpg"),
                    SellerDescription = "заглушка"
                },
                new Seller()
                {
                    //Id = 3,
                    UserId = 3,
                    SellerName = "MOVATTY",
                    SellerPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\logo.jpg"),
                    SellerDescription = "заглушка"
                }
                );
            context.SaveChanges();

            context.Categories.AddRange(
                        new Category() { /*Id = 1, */CategoryName = "Женщинам" },
                        new Category() { /*Id = 2, */CategoryName = "Обувь" },
                        new Category() { /*Id = 3, */CategoryName = "Детям" },
                        new Category() { /*Id = 4, */CategoryName = "Мужчинам" },
                        new Category() { /*Id = 5, */CategoryName = "Дом" },
                        new Category() { /*Id = 6, */CategoryName = "Красота" },
                        new Category() { /*Id = 7, */CategoryName = "Аксессуары" },
                        new Category() { /*Id = 8, */CategoryName = "Электроника" },
                        new Category() { /*Id = 9, */CategoryName = "Игрушки" },
                        new Category() { /*Id = 10,*/ CategoryName = "Мебель" },
                        new Category() { /*Id = 11,*/ CategoryName = "Продукты" },
                        new Category() { /*Id = 12,*/ CategoryName = "Бытовая техника" },
                        new Category() { /*Id = 13,*/ CategoryName = "Зоотовары" },
                        new Category() { /*Id = 14,*/ CategoryName = "Спорт" },
                        new Category() { /*Id = 15,*/ CategoryName = "Автотовары" },
                        new Category() { /*Id = 16,*/ CategoryName = "Школа" },
                        new Category() { /*Id = 17,*/ CategoryName = "Книги" },
                        new Category() { /*Id = 18,*/ CategoryName = "Ювелирные изделия" },
                        new Category() { /*Id = 19,*/ CategoryName = "Для ремонта" },
                        new Category() { /*Id = 20,*/ CategoryName = "Сад и дача" },
                        new Category() { /*Id = 21,*/ CategoryName = "Здоровье" },
                        new Category() { /*Id = 22,*/ CategoryName = "Канцтовары" },
                        new Category() { /*Id = 23,*/ CategoryName = "Цифровые товары" }
                    );
            context.SaveChanges();

            context.SubCategories.AddRange(
                new SubCategory() { /*Id = 1, */CategoryId = 1, CategoryName = "Блузки и рубашки" },
                new SubCategory() { /*Id = 2, */CategoryId = 1, CategoryName = "Брюки" },
                new SubCategory() { /*Id = 3, */CategoryId = 1, CategoryName = "Верхняя одежда" },
                new SubCategory() { /*Id = 4, */CategoryId = 1, CategoryName = "Джемперы, водолазки и кардиганы" },
                new SubCategory() { /*Id = 5, */CategoryId = 1, CategoryName = "Джинсы" },
                new SubCategory() { /*Id = 6, */CategoryId = 1, CategoryName = "Комбинезоны" },
                new SubCategory() { /*Id = 7, */CategoryId = 1, CategoryName = "Костюмы" },
                new SubCategory() { /*Id = 8, */CategoryId = 1, CategoryName = "Лонгсливы" },
                new SubCategory() { /*Id = 9, */CategoryId = 1, CategoryName = "Пиджаки, жилеты и жакеты" },
                new SubCategory() { /*Id = 10,*/ CategoryId = 1, CategoryName = "Платья и сарафаны" },
                new SubCategory() { /*Id = 11,*/ CategoryId = 1, CategoryName = "Толстовки, свитшоты и худи" },
                new SubCategory() { /*Id = 12,*/ CategoryId = 1, CategoryName = "Туники" },
                new SubCategory() { /*Id = 13,*/ CategoryId = 1, CategoryName = "Футболки и топы" },
                new SubCategory() { /*Id = 14,*/ CategoryId = 1, CategoryName = "Халаты" },
                new SubCategory() { /*Id = 15,*/ CategoryId = 1, CategoryName = "Шорты" },
                new SubCategory() { /*Id = 16,*/ CategoryId = 1, CategoryName = "Юбки" },
                new SubCategory() { /*Id = 17,*/ CategoryId = 1, CategoryName = "Белье" },
                new SubCategory() { /*Id = 18,*/ CategoryId = 1, CategoryName = "Большие размеры" },
                new SubCategory() { /*Id = 19,*/ CategoryId = 1, CategoryName = "Будущие мамы" },
                new SubCategory() { /*Id = 20,*/ CategoryId = 1, CategoryName = "Для высоких" },
                new SubCategory() { /*Id = 21,*/ CategoryId = 1, CategoryName = "Для невысоких" },
                new SubCategory() { /*Id = 22,*/ CategoryId = 1, CategoryName = "Одежда для дома" },
                new SubCategory() { /*Id = 23,*/ CategoryId = 1, CategoryName = "Офис" },
                new SubCategory() { /*Id = 24,*/ CategoryId = 1, CategoryName = "Пляжная мода" },
                new SubCategory() { /*Id = 25,*/ CategoryId = 1, CategoryName = "Религиозная" },
                new SubCategory() { /*Id = 26,*/ CategoryId = 1, CategoryName = "Свадьба" },

                new SubCategory() { /*Id = 27,*/ CategoryId = 2, CategoryName = "Детская" },
                new SubCategory() { /*Id = 28,*/ CategoryId = 2, CategoryName = "Для новорожденных" },
                new SubCategory() { /*Id = 29,*/ CategoryId = 2, CategoryName = "Женская" },
                new SubCategory() { /*Id = 30,*/ CategoryId = 2, CategoryName = "Мужская" },
                new SubCategory() { /*Id = 31,*/ CategoryId = 2, CategoryName = "Ортопедическая обувь" },
                new SubCategory() { /*Id = 32,*/ CategoryId = 2, CategoryName = "Аксессуары для обуви" },

                new SubCategory() { /*Id = 33,*/ CategoryId = 3, CategoryName = "Для девочек" },
                new SubCategory() { /*Id = 34,*/ CategoryId = 3, CategoryName = "Для мальчиков" },
                new SubCategory() { /*Id = 35,*/ CategoryId = 3, CategoryName = "Для новорожденных" },
                new SubCategory() { /*Id = 36,*/ CategoryId = 3, CategoryName = "Детская электроника" },
                new SubCategory() { /*Id = 37,*/ CategoryId = 3, CategoryName = "Конструкторы" },
                new SubCategory() { /*Id = 38,*/ CategoryId = 3, CategoryName = "Детский транспорт" },
                new SubCategory() { /*Id = 39,*/ CategoryId = 3, CategoryName = "Детское питание" },
                new SubCategory() { /*Id = 40,*/ CategoryId = 3, CategoryName = "Религиозная одежда" },
                new SubCategory() { /*Id = 41,*/ CategoryId = 3, CategoryName = "Товары для малыша" },
                new SubCategory() { /*Id = 42,*/ CategoryId = 3, CategoryName = "Подгузники" },
                new SubCategory() { /*Id = 43,*/ CategoryId = 3, CategoryName = "Подарки детям" },

                new SubCategory() { /*Id = 44,*/ CategoryId = 4, CategoryName = "Брюки" },
                new SubCategory() { /*Id = 45,*/ CategoryId = 4, CategoryName = "Верхняя одежда" },
                new SubCategory() { /*Id = 46,*/ CategoryId = 4, CategoryName = "Джемперы, водолазки и кардиганы" },
                new SubCategory() { /*Id = 47,*/ CategoryId = 4, CategoryName = "Джинсы" },
                new SubCategory() { /*Id = 48,*/ CategoryId = 4, CategoryName = "Комбинезоны и полукомбинезоны" },
                new SubCategory() { /*Id = 49,*/ CategoryId = 4, CategoryName = "Костюмы" },
                new SubCategory() { /*Id = 50,*/ CategoryId = 4, CategoryName = "Лонгсливы" },
                new SubCategory() { /*Id = 51,*/ CategoryId = 4, CategoryName = "Майки" },
                new SubCategory() { /*Id = 52,*/ CategoryId = 4, CategoryName = "Пиджаки, жилеты и жакеты" },
                new SubCategory() { /*Id = 53,*/ CategoryId = 4, CategoryName = "Пижамы" },
                new SubCategory() { /*Id = 54,*/ CategoryId = 4, CategoryName = "Рубашки" },
                new SubCategory() { /*Id = 55,*/ CategoryId = 4, CategoryName = "Толстовки, свитшоты и худи" },
                new SubCategory() { /*Id = 56,*/ CategoryId = 4, CategoryName = "Футболки" },
                new SubCategory() { /*Id = 57,*/ CategoryId = 4, CategoryName = "Футболки-поло" },
                new SubCategory() { /*Id = 58,*/ CategoryId = 4, CategoryName = "Халаты" },
                new SubCategory() { /*Id = 59,*/ CategoryId = 4, CategoryName = "Шорты" },
                new SubCategory() { /*Id = 60,*/ CategoryId = 4, CategoryName = "Белье" },
                new SubCategory() { /*Id = 61,*/ CategoryId = 4, CategoryName = "Большие размеры" },
                new SubCategory() { /*Id = 62,*/ CategoryId = 4, CategoryName = "Для высоких" },
                new SubCategory() { /*Id = 63,*/ CategoryId = 4, CategoryName = "Для невысоких" },
                new SubCategory() { /*Id = 64,*/ CategoryId = 4, CategoryName = "Одежда для дома" },
                new SubCategory() { /*Id = 65,*/ CategoryId = 4, CategoryName = "Офис" },
                new SubCategory() { /*Id = 66,*/ CategoryId = 4, CategoryName = "Пляжная одежда" },
                new SubCategory() { /*Id = 67,*/ CategoryId = 4, CategoryName = "Религиозная" },
                new SubCategory() { /*Id = 68,*/ CategoryId = 4, CategoryName = "Свадьба" },

                new SubCategory() { /*Id = 69,*/ CategoryId = 5, CategoryName = "Ванная" },
                new SubCategory() { /*Id = 70,*/ CategoryId = 5, CategoryName = "Кухня" },
                new SubCategory() { /*Id = 71,*/ CategoryId = 5, CategoryName = "Предметы интерьера" },
                new SubCategory() { /*Id = 72,*/ CategoryId = 5, CategoryName = "Спальня" },
                new SubCategory() { /*Id = 73,*/ CategoryId = 5, CategoryName = "Гостиная" },
                new SubCategory() { /*Id = 74,*/ CategoryId = 5, CategoryName = "Детская" },
                new SubCategory() { /*Id = 75,*/ CategoryId = 5, CategoryName = "Досуг и творчество" },
                new SubCategory() { /*Id = 76,*/ CategoryId = 5, CategoryName = "Все для праздника" },
                new SubCategory() { /*Id = 77,*/ CategoryId = 5, CategoryName = "Зеркала" },
                new SubCategory() { /*Id = 78,*/ CategoryId = 5, CategoryName = "Коврики" },
                new SubCategory() { /*Id = 79,*/ CategoryId = 5, CategoryName = "Кронштейны" },
                new SubCategory() { /*Id = 80,*/ CategoryId = 5, CategoryName = "Освещение" },
                new SubCategory() { /*Id = 81,*/ CategoryId = 5, CategoryName = "Для курения" },
                new SubCategory() { /*Id = 82,*/ CategoryId = 5, CategoryName = "Отдых на природе" },
                new SubCategory() { /*Id = 83,*/ CategoryId = 5, CategoryName = "Парфюмерия для дома" },
                new SubCategory() { /*Id = 84,*/ CategoryId = 5, CategoryName = "Прихожая" },
                new SubCategory() { /*Id = 85,*/ CategoryId = 5, CategoryName = "Религия, эзотерика" },
                new SubCategory() { /*Id = 86,*/ CategoryId = 5, CategoryName = "Сувенирная продукция" },
                new SubCategory() { /*Id = 87,*/ CategoryId = 5, CategoryName = "Хозяйственные товары" },
                new SubCategory() { /*Id = 88,*/ CategoryId = 5, CategoryName = "Хранение вещей" },
                new SubCategory() { /*Id = 89,*/ CategoryId = 5, CategoryName = "Цветы, вазы и кашпо" },
                new SubCategory() { /*Id = 90,*/ CategoryId = 5, CategoryName = "Шторы" },
                new SubCategory() { /*Id = 91,*/ CategoryId = 6, CategoryName = "Аксессуары" },
                new SubCategory() { /*Id = 92,*/ CategoryId = 6, CategoryName = "Волосы" },
                new SubCategory() { /*Id = 93,*/ CategoryId = 6, CategoryName = "Аптечная косметика" },
                new SubCategory() { /*Id = 94,*/ CategoryId = 6, CategoryName = "Детская декоративная косметика" },
                new SubCategory() { /*Id = 95,*/ CategoryId = 6, CategoryName = "Для загара" },
                new SubCategory() { /*Id = 96,*/ CategoryId = 6, CategoryName = "Для мам и малышей" },
                new SubCategory() { /*Id = 97,*/ CategoryId = 6, CategoryName = "Израильская косметика" },
                new SubCategory() { /*Id = 98,*/ CategoryId = 6, CategoryName = "Инструменты для парикмахеров" },
                new SubCategory() { /*Id = 99,*/ CategoryId = 6, CategoryName = "Корейские бренды" },
                new SubCategory() { /*Id = 100,*/ CategoryId = 6, CategoryName = "Косметические аппараты и аксессуары" },
                new SubCategory() { /*Id = 101,*/ CategoryId = 6, CategoryName = "Макияж" },
                new SubCategory() { /*Id = 102,*/ CategoryId = 6, CategoryName = "Мужская линия" },
                new SubCategory() { /*Id = 103,*/ CategoryId = 6, CategoryName = "Наборы для ухода" },
                new SubCategory() { /*Id = 104,*/ CategoryId = 6, CategoryName = "Ногти" },
                new SubCategory() { /*Id = 105,*/ CategoryId = 6, CategoryName = "Органическая косметика" },
                new SubCategory() { /*Id = 106,*/ CategoryId = 6, CategoryName = "Парфюмерия" },
                new SubCategory() { /*Id = 107,*/ CategoryId = 6, CategoryName = "Подарочные наборы" },
                new SubCategory() { /*Id = 108,*/ CategoryId = 6, CategoryName = "Профессиональная косметика" },
                new SubCategory() { /*Id = 109,*/ CategoryId = 6, CategoryName = "Средства личной гигиены" },
                new SubCategory() { /*Id = 110,*/ CategoryId = 6, CategoryName = "Гигиена полости рта" },
                new SubCategory() { /*Id = 111,*/ CategoryId = 6, CategoryName = "Уход за кожей" },
                new SubCategory() { /*Id = 112,*/ CategoryId = 7, CategoryName = "Аксессуары для волос" },
                new SubCategory() { /*Id = 113,*/ CategoryId = 7, CategoryName = "Аксессуары для одежды" },
                new SubCategory() { /*Id = 114,*/ CategoryId = 7, CategoryName = "Бижутерия" },
                new SubCategory() { /*Id = 115,*/ CategoryId = 7, CategoryName = "Веера" },
                new SubCategory() { /*Id = 116,*/ CategoryId = 7, CategoryName = "Галстуки и бабочки" },
                new SubCategory() { /*Id = 117,*/ CategoryId = 7, CategoryName = "Головные уборы" },
                new SubCategory() { /*Id = 118,*/ CategoryId = 7, CategoryName = "Зеркальца" },
                new SubCategory() { /*Id = 119,*/ CategoryId = 7, CategoryName = "Зонты" },
                new SubCategory() { /*Id = 120,*/ CategoryId = 7, CategoryName = "Кошельки и кредитницы" },
                new SubCategory() { /*Id = 121,*/ CategoryId = 7, CategoryName = "Маски для сна" },
                new SubCategory() { /*Id = 122,*/ CategoryId = 7, CategoryName = "Носовые платки" },
                new SubCategory() { /*Id = 123,*/ CategoryId = 7, CategoryName = "Очки и футляры" },
                new SubCategory() { /*Id = 124,*/ CategoryId = 7, CategoryName = "Перчатки и варежки" },
                new SubCategory() { /*Id = 125,*/ CategoryId = 7, CategoryName = "Платки и шарфы" },
                new SubCategory() { /*Id = 126,*/ CategoryId = 7, CategoryName = "Религиозные" },
                new SubCategory() { /*Id = 127,*/ CategoryId = 7, CategoryName = "Ремни и пояса" },
                new SubCategory() { /*Id = 128,*/ CategoryId = 7, CategoryName = "Сумки и рюкзаки" },
                new SubCategory() { /*Id = 129,*/ CategoryId = 7, CategoryName = "Часы и ремешки" },
                new SubCategory() { /*Id = 130,*/ CategoryId = 7, CategoryName = "Чемоданы и защита багажа" },
                new SubCategory() { /*Id = 131,*/ CategoryId = 8, CategoryName = "Автоэлектроника и навигация" },
                new SubCategory() { /*Id = 132,*/ CategoryId = 8, CategoryName = "Гарнитуры и наушники" },
                new SubCategory() { /*Id = 133,*/ CategoryId = 8, CategoryName = "Детская электроника" },
                new SubCategory() { /*Id = 134,*/ CategoryId = 8, CategoryName = "Игровые консоли и игры" },
                new SubCategory() { /*Id = 135,*/ CategoryId = 8, CategoryName = "Кабели и зарядные устройства" },
                new SubCategory() { /*Id = 136,*/ CategoryId = 8, CategoryName = "Музыка и видео" },
                new SubCategory() { /*Id = 137,*/ CategoryId = 8, CategoryName = "Ноутбуки и компьютеры" },
                new SubCategory() { /*Id = 138,*/ CategoryId = 8, CategoryName = "Офисная техника" },
                new SubCategory() { /*Id = 139,*/ CategoryId = 8, CategoryName = "Развлечения и гаджеты" },
                new SubCategory() { /*Id = 140,*/ CategoryId = 8, CategoryName = "Сетевое оборудование" },
                new SubCategory() { /*Id = 141,*/ CategoryId = 8, CategoryName = "Системы безопасности" },
                new SubCategory() { /*Id = 142,*/ CategoryId = 8, CategoryName = "Смартфоны и телефоны" },
                new SubCategory() { /*Id = 143,*/ CategoryId = 8, CategoryName = "Смарт-часы и браслеты" },
                new SubCategory() { /*Id = 144,*/ CategoryId = 8, CategoryName = "Солнечные электростанции и комплектующие" },
                new SubCategory() { /*Id = 145,*/ CategoryId = 8, CategoryName = "ТВ, Аудио, Фото, Видео техника" },
                new SubCategory() { /*Id = 146,*/ CategoryId = 8, CategoryName = "Торговое оборудование" },
                new SubCategory() { /*Id = 147,*/ CategoryId = 8, CategoryName = "Умный дом" },
                new SubCategory() { /*Id = 148,*/ CategoryId = 8, CategoryName = "Электротранспорт и аксессуары" },
                new SubCategory() { /*Id = 149,*/ CategoryId = 9, CategoryName = "Антистресс" },
                new SubCategory() { /*Id = 150,*/ CategoryId = 9, CategoryName = "Для малышей" },
                new SubCategory() { /*Id = 151,*/ CategoryId = 9, CategoryName = "Для песочницы" },
                new SubCategory() { /*Id = 152,*/ CategoryId = 9, CategoryName = "Игровые комплексы" },
                new SubCategory() { /*Id = 153,*/ CategoryId = 9, CategoryName = "Игровые наборы" },
                new SubCategory() { /*Id = 154,*/ CategoryId = 9, CategoryName = "Игрушечное оружие и аксессуары" },
                new SubCategory() { /*Id = 155,*/ CategoryId = 9, CategoryName = "Игрушечный транспорт" },
                new SubCategory() { /*Id = 156,*/ CategoryId = 9, CategoryName = "Игрушки для ванной" },
                new SubCategory() { /*Id = 157,*/ CategoryId = 9, CategoryName = "Интерактивные" },
                new SubCategory() { /*Id = 158,*/ CategoryId = 9, CategoryName = "Кинетический песок" },
                new SubCategory() { /*Id = 159,*/ CategoryId = 9, CategoryName = "Конструкторы" },
                new SubCategory() { /*Id = 160,*/ CategoryId = 9, CategoryName = "Конструкторы LEGO" },
                new SubCategory() { /*Id = 161,*/ CategoryId = 9, CategoryName = "Куклы и аксессуары" },
                new SubCategory() { /*Id = 162,*/ CategoryId = 9, CategoryName = "Музыкальные" },
                new SubCategory() { /*Id = 163,*/ CategoryId = 9, CategoryName = "Мыльные пузыри" },
                new SubCategory() { /*Id = 164,*/ CategoryId = 9, CategoryName = "Мягкие игрушки" },
                new SubCategory() { /*Id = 165,*/ CategoryId = 9, CategoryName = "Наборы для опытов" },
                new SubCategory() { /*Id = 166,*/ CategoryId = 9, CategoryName = "Настольные игры" },
                new SubCategory() { /*Id = 167,*/ CategoryId = 9, CategoryName = "Радиоуправляемые" },
                new SubCategory() { /*Id = 168,*/ CategoryId = 9, CategoryName = "Развивающие игрушки" },
                new SubCategory() { /*Id = 169,*/ CategoryId = 9, CategoryName = "Сборные модели" },
                new SubCategory() { /*Id = 170,*/ CategoryId = 9, CategoryName = "Спортивные игры" },
                new SubCategory() { /*Id = 171,*/ CategoryId = 9, CategoryName = "Сюжетно-ролевые игры" },
                new SubCategory() { /*Id = 172,*/ CategoryId = 9, CategoryName = "Творчество и рукоделие" },
                new SubCategory() { /*Id = 173,*/ CategoryId = 9, CategoryName = "Фигурки и роботы" },
                new SubCategory() { /*Id = 174,*/ CategoryId = 10, CategoryName = "Бескаркасная мебель" },
                new SubCategory() { /*Id = 175,*/ CategoryId = 10, CategoryName = "Детская мебель" },
                new SubCategory() { /*Id = 176,*/ CategoryId = 10, CategoryName = "Диваны и кресла" },
                new SubCategory() { /*Id = 177,*/ CategoryId = 10, CategoryName = "Столы и стулья" },
                new SubCategory() { /*Id = 178,*/ CategoryId = 10, CategoryName = "Компьютерная мебель" },
                new SubCategory() { /*Id = 179,*/ CategoryId = 10, CategoryName = "Мебель для геймеров" },
                new SubCategory() { /*Id = 180,*/ CategoryId = 10, CategoryName = "Мебель для гостиной" },
                new SubCategory() { /*Id = 181,*/ CategoryId = 10, CategoryName = "Мебель для кухни" },
                new SubCategory() { /*Id = 182,*/ CategoryId = 10, CategoryName = "Мебель для прихожей" },
                new SubCategory() { /*Id = 183,*/ CategoryId = 10, CategoryName = "Мебель для спальни" },
                new SubCategory() { /*Id = 184,*/ CategoryId = 10, CategoryName = "Гардеробная мебель" },
                new SubCategory() { /*Id = 185,*/ CategoryId = 10, CategoryName = "Офисная мебель" },
                new SubCategory() { /*Id = 186,*/ CategoryId = 10, CategoryName = "Торговая мебель" },
                new SubCategory() { /*Id = 187,*/ CategoryId = 10, CategoryName = "Зеркала" },
                new SubCategory() { /*Id = 188,*/ CategoryId = 10, CategoryName = "Мебельная фурнитура" },
                new SubCategory() { /*Id = 189,*/ CategoryId = 11, CategoryName = "Вкусные подарки" },
                new SubCategory() { /*Id = 190,*/ CategoryId = 11, CategoryName = "Чай и кофе" },
                new SubCategory() { /*Id = 191,*/ CategoryId = 11, CategoryName = "Сладости и хлебобулочные изделия" },
                new SubCategory() { /*Id = 192,*/ CategoryId = 11, CategoryName = "Бакалея" },
                new SubCategory() { /*Id = 193,*/ CategoryId = 11, CategoryName = "Детское питание" },
                new SubCategory() { /*Id = 194,*/ CategoryId = 11, CategoryName = "Добавки пищевые" },
                new SubCategory() { /*Id = 195,*/ CategoryId = 11, CategoryName = "Здоровое питание" },
                new SubCategory() { /*Id = 196,*/ CategoryId = 11, CategoryName = "Мясная продукция" },
                new SubCategory() { /*Id = 197,*/ CategoryId = 11, CategoryName = "Молочные продукты и яйца" },
                new SubCategory() { /*Id = 198,*/ CategoryId = 11, CategoryName = "Напитки" },
                new SubCategory() { /*Id = 199,*/ CategoryId = 11, CategoryName = "Снеки" },
                new SubCategory() { /*Id = 200,*/ CategoryId = 11, CategoryName = "Замороженная продукция" },
                new SubCategory() { /*Id = 201,*/ CategoryId = 11, CategoryName = "Фрукты и ягоды" },
                new SubCategory() { /*Id = 202,*/ CategoryId = 11, CategoryName = "Овощи" },
                new SubCategory() { /*Id = 203,*/ CategoryId = 12, CategoryName = "Климатическая техника" },
                new SubCategory() { /*Id = 204,*/ CategoryId = 12, CategoryName = "Красота и здоровье" },
                new SubCategory() { /*Id = 205,*/ CategoryId = 12, CategoryName = "Садовая техника" },
                new SubCategory() { /*Id = 206,*/ CategoryId = 12, CategoryName = "Техника для дома" },
                new SubCategory() { /*Id = 207,*/ CategoryId = 12, CategoryName = "Техника для кухни" },
                new SubCategory() { /*Id = 208,*/ CategoryId = 12, CategoryName = "Крупная бытовая техника" },
                new SubCategory() { /*Id = 209,*/ CategoryId = 13, CategoryName = "Для кошек" },
                new SubCategory() { /*Id = 210,*/ CategoryId = 13, CategoryName = "Для собак" },
                new SubCategory() { /*Id = 211,*/ CategoryId = 13, CategoryName = "Для птиц" },
                new SubCategory() { /*Id = 212,*/ CategoryId = 13, CategoryName = "Для грызунов и хорьков" },
                new SubCategory() { /*Id = 213,*/ CategoryId = 13, CategoryName = "Для лошадей" },
                new SubCategory() { /*Id = 214,*/ CategoryId = 13, CategoryName = "Аквариумистика" },
                new SubCategory() { /*Id = 215,*/ CategoryId = 13, CategoryName = "Террариумистика" },
                new SubCategory() { /*Id = 216,*/ CategoryId = 13, CategoryName = "Фермерство" },
                new SubCategory() { /*Id = 217,*/ CategoryId = 13, CategoryName = "Корм и лакомства" },
                new SubCategory() { /*Id = 218,*/ CategoryId = 13, CategoryName = "Аксессуары для кормления" },
                new SubCategory() { /*Id = 219,*/ CategoryId = 13, CategoryName = "Лотки и наполнители" },
                new SubCategory() { /*Id = 220,*/ CategoryId = 13, CategoryName = "Когтеточки и домики" },
                new SubCategory() { /*Id = 221,*/ CategoryId = 13, CategoryName = "Транспортировка" },
                new SubCategory() { /*Id = 222,*/ CategoryId = 13, CategoryName = "Амуниция и дрессировка" },
                new SubCategory() { /*Id = 223,*/ CategoryId = 13, CategoryName = "Игрушки" },
                new SubCategory() { /*Id = 224,*/ CategoryId = 13, CategoryName = "Груминг и уход" },
                new SubCategory() { /*Id = 225,*/ CategoryId = 13, CategoryName = "Одежда" },
                new SubCategory() { /*Id = 226,*/ CategoryId = 13, CategoryName = "Ветаптека" },
                new SubCategory() { /*Id = 227,*/ CategoryId = 14, CategoryName = "Фитнес и тренажеры" },
                new SubCategory() { /*Id = 228,*/ CategoryId = 14, CategoryName = "Велоспорт" },
                new SubCategory() { /*Id = 229,*/ CategoryId = 14, CategoryName = "Йога/Пилатес" },
                new SubCategory() { /*Id = 230,*/ CategoryId = 14, CategoryName = "Охота и рыбалка" },
                new SubCategory() { /*Id = 231,*/ CategoryId = 14, CategoryName = "Самокаты/Ролики/Скейтборды" },
                new SubCategory() { /*Id = 232,*/ CategoryId = 14, CategoryName = "Туризм/Походы" },
                new SubCategory() { /*Id = 233,*/ CategoryId = 14, CategoryName = "Бег/Ходьба" },
                new SubCategory() { /*Id = 234,*/ CategoryId = 14, CategoryName = "Командные виды спорта" },
                new SubCategory() { /*Id = 235,*/ CategoryId = 14, CategoryName = "Водные виды спорта" },
                new SubCategory() { /*Id = 236,*/ CategoryId = 14, CategoryName = "Зимние виды спорта" },
                new SubCategory() { /*Id = 237,*/ CategoryId = 14, CategoryName = "Поддержка и восстановление" },
                new SubCategory() { /*Id = 238,*/ CategoryId = 14, CategoryName = "Спортивное питание и косметика" },
                new SubCategory() { /*Id = 239,*/ CategoryId = 14, CategoryName = "Бадминтон/Теннис" },
                new SubCategory() { /*Id = 240,*/ CategoryId = 14, CategoryName = "Бильярд/Гольф/Дартс/Метание ножей" },
                new SubCategory() { /*Id = 241,*/ CategoryId = 14, CategoryName = "Единоборства" },
                new SubCategory() { /*Id = 242,*/ CategoryId = 14, CategoryName = "Конный спорт" },
                new SubCategory() { /*Id = 243,*/ CategoryId = 14, CategoryName = "Мотоспорт" },
                new SubCategory() { /*Id = 244,*/ CategoryId = 14, CategoryName = "Оборудование для сдачи нормативов" },
                new SubCategory() { /*Id = 245,*/ CategoryId = 14, CategoryName = "Парусный спорт" },
                new SubCategory() { /*Id = 246,*/ CategoryId = 14, CategoryName = "Скалолазание/Альпинизм" },
                new SubCategory() { /*Id = 247,*/ CategoryId = 14, CategoryName = "Страйкбол и пейнтбол" },
                new SubCategory() { /*Id = 248,*/ CategoryId = 14, CategoryName = "Танцы/Гимнастика" },
                new SubCategory() { /*Id = 249,*/ CategoryId = 14, CategoryName = "Для детей" },
                new SubCategory() { /*Id = 250,*/ CategoryId = 14, CategoryName = "Для женщин" },
                new SubCategory() { /*Id = 251,*/ CategoryId = 14, CategoryName = "Для мужчин" },
                new SubCategory() { /*Id = 252,*/ CategoryId = 14, CategoryName = "Спортивная обувь" },
                new SubCategory() { /*Id = 253,*/ CategoryId = 14, CategoryName = "Товары для самообороны" },
                new SubCategory() { /*Id = 254,*/ CategoryId = 14, CategoryName = "Электроника" },
                new SubCategory() { /*Id = 255,*/ CategoryId = 15, CategoryName = "Запчасти на легковые автомобили" },
                new SubCategory() { /*Id = 256,*/ CategoryId = 15, CategoryName = "Масла и жидкости" },
                new SubCategory() { /*Id = 257,*/ CategoryId = 15, CategoryName = "Автокосметика и автохимия" },
                new SubCategory() { /*Id = 258,*/ CategoryId = 15, CategoryName = "Краски и грунтовки" },
                new SubCategory() { /*Id = 259,*/ CategoryId = 15, CategoryName = "Автоэлектроника и навигация" },
                new SubCategory() { /*Id = 260,*/ CategoryId = 15, CategoryName = "Аксессуары в салон и багажник" },
                new SubCategory() { /*Id = 261,*/ CategoryId = 15, CategoryName = "Коврики" },
                new SubCategory() { /*Id = 262,*/ CategoryId = 15, CategoryName = "Внешний тюнинг" },
                new SubCategory() { /*Id = 263,*/ CategoryId = 15, CategoryName = "Другие аксессуары и доп. оборудование" },
                new SubCategory() { /*Id = 264,*/ CategoryId = 15, CategoryName = "Шины и диски колесные" },
                new SubCategory() { /*Id = 265,*/ CategoryId = 15, CategoryName = "Инструменты" },
                new SubCategory() { /*Id = 266,*/ CategoryId = 15, CategoryName = "Мойки высокого давления и аксессуары" },
                new SubCategory() { /*Id = 267,*/ CategoryId = 15, CategoryName = "Мототовары" },
                new SubCategory() { /*Id = 268,*/ CategoryId = 15, CategoryName = "OFFroad" },
                new SubCategory() { /*Id = 269,*/ CategoryId = 15, CategoryName = "Запчасти на силовую технику" },
                new SubCategory() { /*Id = 270,*/ CategoryId = 15, CategoryName = "Запчасти для лодок и катеров" },
                new SubCategory() { /*Id = 271,*/ CategoryId = 16, CategoryName = "Одежда для девочек" },
                new SubCategory() { /*Id = 272,*/ CategoryId = 16, CategoryName = "Одежда для мальчиков" },
                new SubCategory() { /*Id = 273,*/ CategoryId = 16, CategoryName = "Банты" },
                new SubCategory() { /*Id = 274,*/ CategoryId = 16, CategoryName = "Галстуки и бабочки" },
                new SubCategory() { /*Id = 275,*/ CategoryId = 16, CategoryName = "Дошкольные рюкзаки" },
                new SubCategory() { /*Id = 276,*/ CategoryId = 16, CategoryName = "Ленты выпускника" },
                new SubCategory() { /*Id = 277,*/ CategoryId = 16, CategoryName = "Мешки для обуви" },
                new SubCategory() { /*Id = 278,*/ CategoryId = 16, CategoryName = "Обувь для девочек" },
                new SubCategory() { /*Id = 279,*/ CategoryId = 16, CategoryName = "Обувь для мальчиков" },
                new SubCategory() { /*Id = 280,*/ CategoryId = 16, CategoryName = "Ранцы" },
                new SubCategory() { /*Id = 281,*/ CategoryId = 16, CategoryName = "Спорт" },
                new SubCategory() { /*Id = 282,*/ CategoryId = 16, CategoryName = "Тележки для ранцев" },
                new SubCategory() { /*Id = 283,*/ CategoryId = 16, CategoryName = "Учебная литература" },
                new SubCategory() { /*Id = 284,*/ CategoryId = 16, CategoryName = "Школьные принадлежности" },
                new SubCategory() { /*Id = 285,*/ CategoryId = 16, CategoryName = "Школьные рюкзаки" },
                new SubCategory() { /*Id = 286,*/ CategoryId = 17, CategoryName = "Художественная литература" },
                new SubCategory() { /*Id = 287,*/ CategoryId = 17, CategoryName = "Комиксы и манга" },
                new SubCategory() { /*Id = 288,*/ CategoryId = 17, CategoryName = "Книги для детей" },
                new SubCategory() { /*Id = 289,*/ CategoryId = 17, CategoryName = "Воспитание и развитие ребенка" },
                new SubCategory() { /*Id = 290,*/ CategoryId = 17, CategoryName = "Образование" },
                new SubCategory() { /*Id = 291,*/ CategoryId = 17, CategoryName = "Самообразование и развитие" },
                new SubCategory() { /*Id = 292,*/ CategoryId = 17, CategoryName = "Бизнес и менеджмент" },
                new SubCategory() { /*Id = 293,*/ CategoryId = 17, CategoryName = "Хобби и досуг" },
                new SubCategory() { /*Id = 294,*/ CategoryId = 17, CategoryName = "Астрология и эзотерика" },
                new SubCategory() { /*Id = 295,*/ CategoryId = 17, CategoryName = "Дом, сад и огород" },
                new SubCategory() { /*Id = 296,*/ CategoryId = 17, CategoryName = "Красота, здоровье и спорт" },
                new SubCategory() { /*Id = 297,*/ CategoryId = 17, CategoryName = "Научно-популярная литература" },
                new SubCategory() { /*Id = 298,*/ CategoryId = 17, CategoryName = "Интернет и технологии" },
                new SubCategory() { /*Id = 299,*/ CategoryId = 17, CategoryName = "Литературоведение и публицистика" },
                new SubCategory() { /*Id = 300,*/ CategoryId = 17, CategoryName = "Историческая и военная литература" },
                new SubCategory() { /*Id = 301,*/ CategoryId = 17, CategoryName = "Философия" },
                new SubCategory() { /*Id = 302,*/ CategoryId = 17, CategoryName = "Религия" },
                new SubCategory() { /*Id = 303,*/ CategoryId = 17, CategoryName = "Политика и право" },
                new SubCategory() { /*Id = 304,*/ CategoryId = 17, CategoryName = "Букинистика" },
                new SubCategory() { /*Id = 305,*/ CategoryId = 17, CategoryName = "Книги на иностранных языках" },
                new SubCategory() { /*Id = 306,*/ CategoryId = 17, CategoryName = "Плакаты" },
                new SubCategory() { /*Id = 307,*/ CategoryId = 17, CategoryName = "Календари" },
                new SubCategory() { /*Id = 308,*/ CategoryId = 17, CategoryName = "Коллекционные издания" },
                new SubCategory() { /*Id = 309,*/ CategoryId = 17, CategoryName = "Репринтные издания" },
                new SubCategory() { /*Id = 310,*/ CategoryId = 17, CategoryName = "Мультимедиа" },
                new SubCategory() { /*Id = 311,*/ CategoryId = 17, CategoryName = "Аудиокниги" },
                new SubCategory() { /*Id = 312,*/ CategoryId = 17, CategoryName = "Цифровые книги" },
                new SubCategory() { /*Id = 313,*/ CategoryId = 17, CategoryName = "Цифровые аудиокниги" },
                new SubCategory() { /*Id = 314,*/ CategoryId = 18, CategoryName = "Кольца" },
                new SubCategory() { /*Id = 315,*/ CategoryId = 18, CategoryName = "Серьги" },
                new SubCategory() { /*Id = 316,*/ CategoryId = 18, CategoryName = "Браслеты" },
                new SubCategory() { /*Id = 317,*/ CategoryId = 18, CategoryName = "Подвески и шармы" },
                new SubCategory() { /*Id = 318,*/ CategoryId = 18, CategoryName = "Комплекты" },
                new SubCategory() { /*Id = 319,*/ CategoryId = 18, CategoryName = "Колье, цепи, шнурки" },
                new SubCategory() { /*Id = 320,*/ CategoryId = 18, CategoryName = "Броши" },
                new SubCategory() { /*Id = 321,*/ CategoryId = 18, CategoryName = "Пирсинг" },
                new SubCategory() { /*Id = 322,*/ CategoryId = 18, CategoryName = "Часы" },
                new SubCategory() { /*Id = 323,*/ CategoryId = 18, CategoryName = "Зажимы, запонки, ремни" },
                new SubCategory() { /*Id = 324,*/ CategoryId = 18, CategoryName = "Четки" },
                new SubCategory() { /*Id = 325,*/ CategoryId = 18, CategoryName = "Сувениры и столовое серебро" },
                new SubCategory() { /*Id = 326,*/ CategoryId = 18, CategoryName = "Украшения из золота" },
                new SubCategory() { /*Id = 327,*/ CategoryId = 18, CategoryName = "Украшения из серебра" },
                new SubCategory() { /*Id = 328,*/ CategoryId = 18, CategoryName = "Украшения из керамики" },
                new SubCategory() { /*Id = 329,*/ CategoryId = 18, CategoryName = "Аксессуары для украшений" },
                new SubCategory() { /*Id = 330,*/ CategoryId = 19, CategoryName = "Двери, окна и фурнитура" },
                new SubCategory() { /*Id = 331,*/ CategoryId = 19, CategoryName = "Инструменты и оснастка" },
                new SubCategory() { /*Id = 332,*/ CategoryId = 19, CategoryName = "Отделочные материалы" },
                new SubCategory() { /*Id = 333,*/ CategoryId = 19, CategoryName = "Электрика" },
                new SubCategory() { /*Id = 334,*/ CategoryId = 19, CategoryName = "Лакокрасочные материалы" },
                new SubCategory() { /*Id = 335,*/ CategoryId = 19, CategoryName = "Сантехника, отопление и газоснабжение" },
                new SubCategory() { /*Id = 336,*/ CategoryId = 19, CategoryName = "Вентиляция" },
                new SubCategory() { /*Id = 337,*/ CategoryId = 19, CategoryName = "Крепеж" },
                new SubCategory() { /*Id = 338,*/ CategoryId = 19, CategoryName = "Стройматериалы" },
                new SubCategory() { /*Id = 339,*/ CategoryId = 19, CategoryName = "Сборные конструкции" },
                new SubCategory() { /*Id = 340,*/ CategoryId = 20, CategoryName = "Бассейны" },
                new SubCategory() { /*Id = 341,*/ CategoryId = 20, CategoryName = "Горшки, опоры и все для рассады" },
                new SubCategory() { /*Id = 342,*/ CategoryId = 20, CategoryName = "Грили, мангалы и барбекю" },
                new SubCategory() { /*Id = 343,*/ CategoryId = 20, CategoryName = "Дачные умывальники, души и туалеты" },
                new SubCategory() { /*Id = 344,*/ CategoryId = 20, CategoryName = "Мойки высокого давления и аксессуары" },
                new SubCategory() { /*Id = 345,*/ CategoryId = 20, CategoryName = "Полив и водоснабжение" },
                new SubCategory() { /*Id = 346,*/ CategoryId = 20, CategoryName = "Растения, семена и грунты" },
                new SubCategory() { /*Id = 347,*/ CategoryId = 20, CategoryName = "Садовая мебель" },
                new SubCategory() { /*Id = 348,*/ CategoryId = 20, CategoryName = "Садовая техника" },
                new SubCategory() { /*Id = 349,*/ CategoryId = 20, CategoryName = "Садовый декор" },
                new SubCategory() { /*Id = 350,*/ CategoryId = 20, CategoryName = "Садовый инструмент" },
                new SubCategory() { /*Id = 351,*/ CategoryId = 20, CategoryName = "Теплицы, парники, укрывной материал" },
                new SubCategory() { /*Id = 352,*/ CategoryId = 20, CategoryName = "Товары для бани и сауны" },
                new SubCategory() { /*Id = 353,*/ CategoryId = 20, CategoryName = "Товары для кемпинга, пикника и отдыха" },
                new SubCategory() { /*Id = 354,*/ CategoryId = 20, CategoryName = "Удобрения, химикаты и средства защиты" },
                new SubCategory() { /*Id = 355,*/ CategoryId = 21, CategoryName = "БАДы" },
                new SubCategory() { /*Id = 356,*/ CategoryId = 21, CategoryName = "Грибы сушеные и капсулированные" },
                new SubCategory() { /*Id = 357,*/ CategoryId = 21, CategoryName = "Дезинфекция, стерилизация и утилизация" },
                new SubCategory() { /*Id = 358,*/ CategoryId = 21, CategoryName = "Ухо, горло, нос" },
                new SubCategory() { /*Id = 359,*/ CategoryId = 21, CategoryName = "Контрацептивы и лубриканты" },
                new SubCategory() { /*Id = 360,*/ CategoryId = 21, CategoryName = "Лечебное питание" },
                new SubCategory() { /*Id = 361,*/ CategoryId = 21, CategoryName = "Маски защитные" },
                new SubCategory() { /*Id = 362,*/ CategoryId = 21, CategoryName = "Медицинские изделия" },
                new SubCategory() { /*Id = 363,*/ CategoryId = 21, CategoryName = "Медицинские приборы" },
                new SubCategory() { /*Id = 364,*/ CategoryId = 21, CategoryName = "Оздоровление" },
                new SubCategory() { /*Id = 365,*/ CategoryId = 21, CategoryName = "Оптика" },
                new SubCategory() { /*Id = 366,*/ CategoryId = 21, CategoryName = "Ортопедия" },
                new SubCategory() { /*Id = 367,*/ CategoryId = 21, CategoryName = "Реабилитация" },
                new SubCategory() { /*Id = 368,*/ CategoryId = 21, CategoryName = "Сиропы и бальзамы" },
                new SubCategory() { /*Id = 369,*/ CategoryId = 21, CategoryName = "Уход за полостью рта" },
                new SubCategory() { /*Id = 370,*/ CategoryId = 22, CategoryName = "Бумажная продукция" },
                new SubCategory() { /*Id = 371,*/ CategoryId = 22, CategoryName = "Карты и глобусы" },
                new SubCategory() { /*Id = 372,*/ CategoryId = 22, CategoryName = "Офисные принадлежности" },
                new SubCategory() { /*Id = 373,*/ CategoryId = 22, CategoryName = "Письменные принадлежности" },
                new SubCategory() { /*Id = 374,*/ CategoryId = 22, CategoryName = "Рисование и лепка" },
                new SubCategory() { /*Id = 375,*/ CategoryId = 22, CategoryName = "Счетный материал" },
                new SubCategory() { /*Id = 376,*/ CategoryId = 22, CategoryName = "Торговые принадлежности" },
                new SubCategory() { /*Id = 377,*/ CategoryId = 22, CategoryName = "Чертежные принадлежности" },
                new SubCategory() { /*Id = 378,*/ CategoryId = 23, CategoryName = "Видео" },
                new SubCategory() { /*Id = 379,*/ CategoryId = 23, CategoryName = "Аудио" },
                new SubCategory() { /*Id = 380,*/ CategoryId = 23, CategoryName = "Электронные Книги" },
                new SubCategory() { /*Id = 381,*/ CategoryId = 23, CategoryName = "Аудиокниги" },
                new SubCategory() { /*Id = 382,*/ CategoryId = 23, CategoryName = "Ключи и сертификаты" },
                new SubCategory() { /*Id = 383,*/ CategoryId = 23, CategoryName = "Контент" },
                new SubCategory() { /*Id = 384,*/ CategoryId = 23, CategoryName = "Услуги" }
                );
            context.SaveChanges();
            context.Products.AddRange(
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "Рубашка оверсайз базовая",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 1,
                     ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(0).webp"),
                     ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                 },
                  new Product()
                  {
                      //Id = 1,
                      ProductName = "Рубашка оверсайз базовая",
                      Price = 1310,
                      Quantity = 500,
                      SubCategoryId = 1,
                      ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(1).webp"),
                      ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                  },
                   new Product()
                   {
                       //Id = 1,
                       ProductName = "Рубашка оверсайз базовая",
                       Price = 1310,
                       Quantity = 500,
                       SubCategoryId = 1,
                       ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(2).webp"),
                       ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                   },
                    new Product()
                    {
                        //Id = 1,
                        ProductName = "Рубашка оверсайз базовая",
                        Price = 1310,
                        Quantity = 500,
                        SubCategoryId = 1,
                        ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(3).webp"),
                        ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                    },
                     new Product()
                     {
                         //Id = 1,
                         ProductName = "Рубашка оверсайз базовая",
                         Price = 1310,
                         Quantity = 500,
                         SubCategoryId = 1,
                         ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(4).webp"),
                         ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                     },
                      new Product()
                      {
                          //Id = 1,
                          ProductName = "Рубашка оверсайз базовая",
                          Price = 1310,
                          Quantity = 500,
                          SubCategoryId = 1,
                          ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(5).webp"),
                          ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                      },
                       new Product()
                       {
                           //Id = 1,
                           ProductName = "Рубашка оверсайз базовая",
                           Price = 1310,
                           Quantity = 500,
                           SubCategoryId = 1,
                           ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(6).webp"),
                           ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                       },
                        new Product()
                        {
                            //Id = 1,
                            ProductName = "Рубашка оверсайз базовая",
                            Price = 1310,
                            Quantity = 500,
                            SubCategoryId = 1,
                            ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(7).webp"),
                            ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                        },
                         new Product()
                         {
                             //Id = 1,
                             ProductName = "Рубашка оверсайз базовая",
                             Price = 1310,
                             Quantity = 500,
                             SubCategoryId = 1,
                             ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(8).webp"),
                             ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                         },
                          new Product()
                          {
                              //Id = 1,
                              ProductName = "Рубашка оверсайз базовая",
                              Price = 1310,
                              Quantity = 500,
                              SubCategoryId = 1,
                              ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(9).webp"),
                              ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                          },
                           new Product()
                           {
                               //Id = 1,
                               ProductName = "Рубашка оверсайз базовая",
                               Price = 1310,
                               Quantity = 500,
                               SubCategoryId = 1,
                               ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(10).webp"),
                               ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                           },
                            new Product()
                            {
                                //Id = 1,
                                ProductName = "Рубашка оверсайз базовая",
                                Price = 1310,
                                Quantity = 500,
                                SubCategoryId = 1,
                                ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(11).webp"),
                                ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                            },
                             new Product()
                             {
                                 //Id = 1,
                                 ProductName = "Рубашка оверсайз базовая",
                                 Price = 1310,
                                 Quantity = 500,
                                 SubCategoryId = 1,
                                 ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(12).webp"),
                                 ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                             },
                              new Product()
                              {
                                  //Id = 1,
                                  ProductName = "Рубашка оверсайз базовая",
                                  Price = 1310,
                                  Quantity = 500,
                                  SubCategoryId = 1,
                                  ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(13).webp"),
                                  ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                              },
                               new Product()
                               {
                                   //Id = 1,
                                   ProductName = "Рубашка оверсайз базовая",
                                   Price = 1310,
                                   Quantity = 500,
                                   SubCategoryId = 1,
                                   ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(14).webp"),
                                   ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                               },
                                new Product()
                                {
                                    //Id = 1,
                                    ProductName = "Рубашка оверсайз базовая",
                                    Price = 1310,
                                    Quantity = 500,
                                    SubCategoryId = 1,
                                    ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(15).webp"),
                                    ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                                },
                                 new Product()
                                 {
                                     //Id = 1,
                                     ProductName = "Рубашка оверсайз базовая",
                                     Price = 1410,
                                     Quantity = 500,
                                     SubCategoryId = 1,
                                     ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(16).webp"),
                                     ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                                 },
                                  new Product()
                                  {
                                      //Id = 1,
                                      ProductName = "Рубашка оверсайз базовая",
                                      Price = 1350,
                                      Quantity = 500,
                                      SubCategoryId = 1,
                                      ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(17).webp"),
                                      ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                                  },
                                   new Product()
                                   {
                                       //Id = 1,
                                       ProductName = "Рубашка оверсайз базовая",
                                       Price = 2310,
                                       Quantity = 500,
                                       SubCategoryId = 1,
                                       ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(18).webp"),
                                       ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                                   },
                                    new Product()
                                    {
                                        //Id = 1,
                                        ProductName = "Рубашка оверсайз базовая",
                                        Price = 1315,
                                        Quantity = 500,
                                        SubCategoryId = 1,
                                        ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(19).webp"),
                                        ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                                    },
                                     new Product()
                                     {
                                         //Id = 1,
                                         ProductName = "Рубашка оверсайз базовая",
                                         Price = 1510,
                                         Quantity = 500,
                                         SubCategoryId = 1,
                                         ProductPhoto = File.ReadAllBytes("D:\\VS_Projects\\OnlineMarket\\For_Database\\1.Olesa Chugunova\\Olesa Chugunova - каталог 2022-2023 в интернет магазине WildBerries.ru_files\\1(20).webp"),
                                         ProductDescription = "Рубашка женская оверсайз.Наш хит, но в новом исполнении. Чтобы изделие меньше мялось и было менее прихотливым в уходе - мы создали рубашку из смесового хлопка. Женская рубашка. Рубашка из качественного материала в стиле OVERSIZE белого цвета. Тонкий длинноволокнистый хлопок особенно прочный, отлично пропускает воздух и впитывает влагу, что делает его идеальным выбором для любого гардероба. Свободная и удлиненная женская рубашка оверсайз, позволяет с легкостью скрыть недостатки фигуры и подчёркнуть её достоинства. Она дополнит любой ваш образ с шортами и короткими топами, легинсами, джинсами, брюками и юбками. А также рубашку можно носить как блузку, или же носить как второй слой поверх футболки или топа. Если вам нужна блузка для офиса, блузка на новый год, блузка вечерняя или также рубашка на новый год, то эта белая базовая и черная рубашки будут идеальными вариантами вашего гардероба. На 1 сентября женская оверсайз летняя хлопок, классическая рубашка, рубашка женская в клетку, белая рубашка, черная рубашка, чёрная рубашка, джинсовая рубашка женская, льняная рубашка женская, рубашка-платье, розовая рубашка с коротким рукавом с длинным рукавом"
                                     },


                new Product()
                {
                    //Id = 2,
                    ProductName = "Блузка женская праздничная с коротким рукавом офисная летняя",
                    Price = 1377,
                    Quantity = 500,
                    SubCategoryId = 1,
                    ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\2.Darya Selskaya\Darya Selskaya в интернет-магазине Wildberries_files\1.webp"),
                    ProductDescription = "Женская удлиненная рубашка - оверсайз - базовая вещь в гардеробе девочки- подростка, девушки и женщины. Благодаря универсальному прямому крою рубашка подойдет как высоким, так и невысоким девушкам, худым и полным. Отличный вариант и для беременных женщин, поскольку блузка не сковывает телодвижения. Будущие мамы оценят мягкость ткани и прямой крой модели. Модная рубашка изготовлена из хлопка 70%, поэтому так приятна к телу, не сильно мнется и удобна в носке. Два базовых цвета: черный и белый позволяют вписать классическую вещь в любой гардероб. Популярные красивые модели oversize сегодня можно надевать куда угодно. Её можно носить дома в качестве повседневной домашней одежды. Представленная модель прослужит несколько сезонов. Очаровательный блузон с накладными карманами поможет вам создать яркий деловой или неформальный образ. Рубашка с длинным рукавом отлично подойдет для подростков в школу как дополнение школьной формы. Строгую универсальную рубашку можно надевать в офис, дополнив стандартный офисный комплект одежды. Мы предлагаем широкий размерный ряд от 36 до 56. Нарядная стильная рубашка с длинным рукавом подойдет даже к спортивному стилю. Летом можно отправиться в ней на прогулку как в пляжной, зимний вариант - надеть сверху пиджак. Плотная хлопковая однотонная рубаха - отличное решение на каждый день. Тканевую рубашку с воротником можно носить на выпуск. Дополните ее аксессуарами, и можно смело отправляться на вечеринку. Модель относится к демисезонным и круглогодичным вещам: на весну, лето, зиму, осень. Молодежная необычная рубашка с вырезом и застежками - пуговицами прекрасно подойдет для уличной прогулки и отдыха. Классическая рубашка - незаменимая элегантная вещь, которая должна быть в гардеробе каждой девушки. Она подходит как для высоких, так и для невысоких девушек. Современная текстильная блузка будет удачно смотреться с юбкой, брюками и шортами. Также ее можно носить с джинсами, красиво подчеркивающими фигуру. Свободную рубашку с некоротким рукавом можно надеть поверх футболки или топа в клетку. У нас есть акции и распродажи, вы можете купить наши товары в подарок со скидкой! Лучшая модная женская одежда - короткая блузка летняя хлопок рубашка с коротким рукавом льняная в клетку оверсайз. Также скоро в продаже джинсовая рубашка на весну и осень, мода 2023, стиль, Рубашка женская тонкая, стильная одежда популярная."
                },

                new Product()
                {
                    //Id = 3,
                    ProductName = "Рубашка женская оверсайз белая летняя с длинным рукавом",
                    Price = 1476,
                    Quantity = 500,
                    SubCategoryId = 1,
                    ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\1(1).webp"),
                    ProductDescription = "Блузка женская нарядная летняя - новинка от MOVATTY. Блузка школьная праздничная вечерняя, благодаря качественной ткани лапша и правильному лекалу сделает Ваш образ стильным, модным и женственным. Блузка для девочки школьная идеально подойдет как школьная форма. Блузка с объемными рукавами - всесезонная, можно надеть: на вечеринку, на свадьбу, на свидание, в ресторан, в путешествие, в отпуск, на праздник, для подружек невесты. Блузка женская офисная, и на каждый день подойдет для повседневного образа: в офис, на учебу, блуза на работу и прогулку. Рукав волан (флаттер) блузки женской нарядной сделает акцент в Вашем образе и направит взгляд на легкость волн. Блузка летняя в офис представлена в цветах: черная, белая, розовая (фуксия). Блузка женская нарядная сделает ваш образ неотразимым. Блузки, кофты и рубашки - неотъемлемая часть гардероба. Блузка с воланами однотонная - базовая вещь в коллекции женской одежды. Блузка с коротким рукавом не оставит Вас равнодушной! Блузка женская в офис ждёт Ваши отзывы с фотографиями. С уважением, MOVATTY."
                },
                 new Product()
                 {
                     //Id = 3,
                     ProductName = "Рубашка женская оверсайз белая летняя с длинным рукавом",
                     Price = 1476,
                     Quantity = 500,
                     SubCategoryId = 1,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\1(2).webp"),
                     ProductDescription = "Блузка женская нарядная летняя - новинка от MOVATTY. Блузка школьная праздничная вечерняя, благодаря качественной ткани лапша и правильному лекалу сделает Ваш образ стильным, модным и женственным. Блузка для девочки школьная идеально подойдет как школьная форма. Блузка с объемными рукавами - всесезонная, можно надеть: на вечеринку, на свадьбу, на свидание, в ресторан, в путешествие, в отпуск, на праздник, для подружек невесты. Блузка женская офисная, и на каждый день подойдет для повседневного образа: в офис, на учебу, блуза на работу и прогулку. Рукав волан (флаттер) блузки женской нарядной сделает акцент в Вашем образе и направит взгляд на легкость волн. Блузка летняя в офис представлена в цветах: черная, белая, розовая (фуксия). Блузка женская нарядная сделает ваш образ неотразимым. Блузки, кофты и рубашки - неотъемлемая часть гардероба. Блузка с воланами однотонная - базовая вещь в коллекции женской одежды. Блузка с коротким рукавом не оставит Вас равнодушной! Блузка женская в офис ждёт Ваши отзывы с фотографиями. С уважением, MOVATTY."
                 },
                  new Product()
                  {
                      //Id = 3,
                      ProductName = "Рубашка женская оверсайз белая летняя с длинным рукавом",
                      Price = 1476,
                      Quantity = 500,
                      SubCategoryId = 1,
                      ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\1(3).webp"),
                      ProductDescription = "Блузка женская нарядная летняя - новинка от MOVATTY. Блузка школьная праздничная вечерняя, благодаря качественной ткани лапша и правильному лекалу сделает Ваш образ стильным, модным и женственным. Блузка для девочки школьная идеально подойдет как школьная форма. Блузка с объемными рукавами - всесезонная, можно надеть: на вечеринку, на свадьбу, на свидание, в ресторан, в путешествие, в отпуск, на праздник, для подружек невесты. Блузка женская офисная, и на каждый день подойдет для повседневного образа: в офис, на учебу, блуза на работу и прогулку. Рукав волан (флаттер) блузки женской нарядной сделает акцент в Вашем образе и направит взгляд на легкость волн. Блузка летняя в офис представлена в цветах: черная, белая, розовая (фуксия). Блузка женская нарядная сделает ваш образ неотразимым. Блузки, кофты и рубашки - неотъемлемая часть гардероба. Блузка с воланами однотонная - базовая вещь в коллекции женской одежды. Блузка с коротким рукавом не оставит Вас равнодушной! Блузка женская в офис ждёт Ваши отзывы с фотографиями. С уважением, MOVATTY."
                  },
                   new Product()
                   {
                       //Id = 3,
                       ProductName = "Рубашка женская оверсайз белая летняя с длинным рукавом",
                       Price = 1476,
                       Quantity = 500,
                       SubCategoryId = 1,
                       ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\1(4).webp"),
                       ProductDescription = "Блузка женская нарядная летняя - новинка от MOVATTY. Блузка школьная праздничная вечерняя, благодаря качественной ткани лапша и правильному лекалу сделает Ваш образ стильным, модным и женственным. Блузка для девочки школьная идеально подойдет как школьная форма. Блузка с объемными рукавами - всесезонная, можно надеть: на вечеринку, на свадьбу, на свидание, в ресторан, в путешествие, в отпуск, на праздник, для подружек невесты. Блузка женская офисная, и на каждый день подойдет для повседневного образа: в офис, на учебу, блуза на работу и прогулку. Рукав волан (флаттер) блузки женской нарядной сделает акцент в Вашем образе и направит взгляд на легкость волн. Блузка летняя в офис представлена в цветах: черная, белая, розовая (фуксия). Блузка женская нарядная сделает ваш образ неотразимым. Блузки, кофты и рубашки - неотъемлемая часть гардероба. Блузка с воланами однотонная - базовая вещь в коллекции женской одежды. Блузка с коротким рукавом не оставит Вас равнодушной! Блузка женская в офис ждёт Ваши отзывы с фотографиями. С уважением, MOVATTY."
                   },
                    new Product()
                    {
                        //Id = 3,
                        ProductName = "Рубашка женская оверсайз белая летняя с длинным рукавом",
                        Price = 1476,
                        Quantity = 500,
                        SubCategoryId = 1,
                        ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\1(5).webp"),
                        ProductDescription = "Блузка женская нарядная летняя - новинка от MOVATTY. Блузка школьная праздничная вечерняя, благодаря качественной ткани лапша и правильному лекалу сделает Ваш образ стильным, модным и женственным. Блузка для девочки школьная идеально подойдет как школьная форма. Блузка с объемными рукавами - всесезонная, можно надеть: на вечеринку, на свадьбу, на свидание, в ресторан, в путешествие, в отпуск, на праздник, для подружек невесты. Блузка женская офисная, и на каждый день подойдет для повседневного образа: в офис, на учебу, блуза на работу и прогулку. Рукав волан (флаттер) блузки женской нарядной сделает акцент в Вашем образе и направит взгляд на легкость волн. Блузка летняя в офис представлена в цветах: черная, белая, розовая (фуксия). Блузка женская нарядная сделает ваш образ неотразимым. Блузки, кофты и рубашки - неотъемлемая часть гардероба. Блузка с воланами однотонная - базовая вещь в коллекции женской одежды. Блузка с коротким рукавом не оставит Вас равнодушной! Блузка женская в офис ждёт Ваши отзывы с фотографиями. С уважением, MOVATTY."
                    },
                     new Product()
                     {
                         //Id = 3,
                         ProductName = "Рубашка женская оверсайз белая летняя с длинным рукавом",
                         Price = 1476,
                         Quantity = 500,
                         SubCategoryId = 1,
                         ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\1(6).webp"),
                         ProductDescription = "Блузка женская нарядная летняя - новинка от MOVATTY. Блузка школьная праздничная вечерняя, благодаря качественной ткани лапша и правильному лекалу сделает Ваш образ стильным, модным и женственным. Блузка для девочки школьная идеально подойдет как школьная форма. Блузка с объемными рукавами - всесезонная, можно надеть: на вечеринку, на свадьбу, на свидание, в ресторан, в путешествие, в отпуск, на праздник, для подружек невесты. Блузка женская офисная, и на каждый день подойдет для повседневного образа: в офис, на учебу, блуза на работу и прогулку. Рукав волан (флаттер) блузки женской нарядной сделает акцент в Вашем образе и направит взгляд на легкость волн. Блузка летняя в офис представлена в цветах: черная, белая, розовая (фуксия). Блузка женская нарядная сделает ваш образ неотразимым. Блузки, кофты и рубашки - неотъемлемая часть гардероба. Блузка с воланами однотонная - базовая вещь в коллекции женской одежды. Блузка с коротким рукавом не оставит Вас равнодушной! Блузка женская в офис ждёт Ваши отзывы с фотографиями. С уважением, MOVATTY."
                     },
                      new Product()
                      {
                          //Id = 3,
                          ProductName = "Рубашка женская оверсайз белая летняя с длинным рукавом",
                          Price = 1476,
                          Quantity = 500,
                          SubCategoryId = 1,
                          ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\1(7).webp"),
                          ProductDescription = "Блузка женская нарядная летняя - новинка от MOVATTY. Блузка школьная праздничная вечерняя, благодаря качественной ткани лапша и правильному лекалу сделает Ваш образ стильным, модным и женственным. Блузка для девочки школьная идеально подойдет как школьная форма. Блузка с объемными рукавами - всесезонная, можно надеть: на вечеринку, на свадьбу, на свидание, в ресторан, в путешествие, в отпуск, на праздник, для подружек невесты. Блузка женская офисная, и на каждый день подойдет для повседневного образа: в офис, на учебу, блуза на работу и прогулку. Рукав волан (флаттер) блузки женской нарядной сделает акцент в Вашем образе и направит взгляд на легкость волн. Блузка летняя в офис представлена в цветах: черная, белая, розовая (фуксия). Блузка женская нарядная сделает ваш образ неотразимым. Блузки, кофты и рубашки - неотъемлемая часть гардероба. Блузка с воланами однотонная - базовая вещь в коллекции женской одежды. Блузка с коротким рукавом не оставит Вас равнодушной! Блузка женская в офис ждёт Ваши отзывы с фотографиями. С уважением, MOVATTY."
                      },
                       new Product()
                       {
                           //Id = 3,
                           ProductName = "Рубашка женская оверсайз белая летняя с длинным рукавом",
                           Price = 1476,
                           Quantity = 500,
                           SubCategoryId = 1,
                           ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\1(8).webp"),
                           ProductDescription = "Блузка женская нарядная летняя - новинка от MOVATTY. Блузка школьная праздничная вечерняя, благодаря качественной ткани лапша и правильному лекалу сделает Ваш образ стильным, модным и женственным. Блузка для девочки школьная идеально подойдет как школьная форма. Блузка с объемными рукавами - всесезонная, можно надеть: на вечеринку, на свадьбу, на свидание, в ресторан, в путешествие, в отпуск, на праздник, для подружек невесты. Блузка женская офисная, и на каждый день подойдет для повседневного образа: в офис, на учебу, блуза на работу и прогулку. Рукав волан (флаттер) блузки женской нарядной сделает акцент в Вашем образе и направит взгляд на легкость волн. Блузка летняя в офис представлена в цветах: черная, белая, розовая (фуксия). Блузка женская нарядная сделает ваш образ неотразимым. Блузки, кофты и рубашки - неотъемлемая часть гардероба. Блузка с воланами однотонная - базовая вещь в коллекции женской одежды. Блузка с коротким рукавом не оставит Вас равнодушной! Блузка женская в офис ждёт Ваши отзывы с фотографиями. С уважением, MOVATTY."
                       },
                        new Product()
                        {
                            //Id = 3,
                            ProductName = "Рубашка женская оверсайз белая летняя с длинным рукавом",
                            Price = 1476,
                            Quantity = 500,
                            SubCategoryId = 1,
                            ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\3.MOVATTY\MOVATTY в интернет-магазине Wildberries_files\1(9).webp"),
                            ProductDescription = "Блузка женская нарядная летняя - новинка от MOVATTY. Блузка школьная праздничная вечерняя, благодаря качественной ткани лапша и правильному лекалу сделает Ваш образ стильным, модным и женственным. Блузка для девочки школьная идеально подойдет как школьная форма. Блузка с объемными рукавами - всесезонная, можно надеть: на вечеринку, на свадьбу, на свидание, в ресторан, в путешествие, в отпуск, на праздник, для подружек невесты. Блузка женская офисная, и на каждый день подойдет для повседневного образа: в офис, на учебу, блуза на работу и прогулку. Рукав волан (флаттер) блузки женской нарядной сделает акцент в Вашем образе и направит взгляд на легкость волн. Блузка летняя в офис представлена в цветах: черная, белая, розовая (фуксия). Блузка женская нарядная сделает ваш образ неотразимым. Блузки, кофты и рубашки - неотъемлемая часть гардероба. Блузка с воланами однотонная - базовая вещь в коллекции женской одежды. Блузка с коротким рукавом не оставит Вас равнодушной! Блузка женская в офис ждёт Ваши отзывы с фотографиями. С уважением, MOVATTY."
                        },

            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1.webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1(1).webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1(2).webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1(3).webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1(4).webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1(5).webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1(6).webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1(7).webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1(8).webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
            new Product()
            {
                //Id = 3,
                ProductName = "Бескаркасное кресло. Диван.",
                Price = 10205,
                Quantity = 500,
                SubCategoryId = 174,
                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\4.Мебель\4.1.Бескаркасная мебель\Бескаркасная мебель в интернет-магазине Wildberries_files\1(9).webp"),
                ProductDescription = "Кресло трансформер. Кровать. Пуф. Мини диван бескаркасный. Мечта. Любовь. Как не назови такую мебель, но это незаменимый вариант для любой комнаты – детской, гостиной, для балкона, в спальню и даже на дачу. Дополнительное спальное место необходимо всегда для гостей, родственников и ребенка. Можно соорудить шалаш для игр или использовать, как коврик для йоги. Фантазия использования этого чудесного бескаркасного матраса безгранична! Поставим два кресла рядом и у вас получится диван для всей семьи, вообще в этих трансформерах классно все. Удобно сидеть, спать, лежать, играть. Он легкий, можно брать в поход и это еще не все плюсы. Мы изготавливаем этот мини диван из эластичной и гипоаллергенной пены, благодаря чему мягкий пуфик будет служить вам долго и не деформируется. Диванчик имеет идеальные размеры высоту 60см и глубину 80см. Спальное место в разложенном виде 69*180см. как полноценная односпальная кровать. Большой выбор интересных расцветок и принтов в стиле IKEA. Обивка в ткани велюр создаст уютную атмосферу и позволит комфортно провести время Вам и вашим гостям. При заказе двух и более пуфов, можно комбинировать между собой по цветам. Кресло раскладное имеет съемный чехол в том числе и на подушке, это позволяет легко ухаживать за ним и поддерживать в чистоте. Цвет обивки изделия может отличаться от цвета на фотографии товара. Это связано с разной цветопередачей мониторов устройств, а также от партии поставляемой ткани.Рассмотрите данный предмет мебели, как подарок на новоселье или день рождения ребенку, маме, друзьям."
            },
             new Product()
             {
                 //Id = 1,
                 ProductName = "куртка женская",
                 Price = 13100,
                 Quantity = 500,
                 SubCategoryId = 3,
                 ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1.webp"),
                 ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
             },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(1).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(2).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(3).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(4).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(5).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(6).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(7).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(8).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(9).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(10).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(11).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(12).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(13).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(14).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(15).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(16).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(17).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "куртка женская",
                     Price = 13100,
                     Quantity = 500,
                     SubCategoryId = 3,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(18).webp"),
                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
                 },
                  new Product()
                  {
                      //Id = 1,
                      ProductName = "брюки женские",
                      Price = 1310,
                      Quantity = 500,
                      SubCategoryId = 2,
                      ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1.webp"),
                      ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                  },
                  new Product()
                  {
                      //Id = 1,
                      ProductName = "брюки женские",
                      Price = 1310,
                      Quantity = 500,
                      SubCategoryId = 2,
                      ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(1).webp"),
                      ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                  },
                   new Product()
                   {
                       //Id = 1,
                       ProductName = "брюки женские",
                       Price = 1310,
                       Quantity = 500,
                       SubCategoryId = 2,
                       ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(2).webp"),
                       ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                   },
                    new Product()
                    {
                        //Id = 1,
                        ProductName = "брюки женские",
                        Price = 1310,
                        Quantity = 500,
                        SubCategoryId = 2,
                        ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(3).webp"),
                        ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                    },
                     new Product()
                     {
                         //Id = 1,
                         ProductName = "брюки женские",
                         Price = 1310,
                         Quantity = 500,
                         SubCategoryId = 2,
                         ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(4).webp"),
                         ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                     },
                      new Product()
                      {
                          //Id = 1,
                          ProductName = "брюки женские",
                          Price = 1310,
                          Quantity = 500,
                          SubCategoryId = 2,
                          ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(5).webp"),
                          ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                      },
                       new Product()
                       {
                           //Id = 1,
                           ProductName = "брюки женские",
                           Price = 1310,
                           Quantity = 500,
                           SubCategoryId = 2,
                           ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(6).webp"),
                           ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                       },
                        new Product()
                        {
                            //Id = 1,
                            ProductName = "брюки женские",
                            Price = 1310,
                            Quantity = 500,
                            SubCategoryId = 2,
                            ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(7).webp"),
                            ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                        },
                         new Product()
                         {
                             //Id = 1,
                             ProductName = "брюки женские",
                             Price = 1310,
                             Quantity = 500,
                             SubCategoryId = 2,
                             ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(8).webp"),
                             ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                         },
                          new Product()
                          {
                              //Id = 1,
                              ProductName = "брюки женские",
                              Price = 1310,
                              Quantity = 500,
                              SubCategoryId = 2,
                              ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(9).webp"),
                              ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                          },
                           new Product()
                           {
                               //Id = 1,
                               ProductName = "брюки женские",
                               Price = 1310,
                               Quantity = 500,
                               SubCategoryId = 2,
                               ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(10).webp"),
                               ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                           },
                            new Product()
                            {
                                //Id = 1,
                                ProductName = "брюки женские",
                                Price = 1310,
                                Quantity = 500,
                                SubCategoryId = 2,
                                ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(11).webp"),
                                ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                            },
                             new Product()
                             {
                                 //Id = 1,
                                 ProductName = "брюки женские",
                                 Price = 1310,
                                 Quantity = 500,
                                 SubCategoryId = 2,
                                 ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(12).webp"),
                                 ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                             },
                              new Product()
                              {
                                  //Id = 1,
                                  ProductName = "брюки женские",
                                  Price = 1310,
                                  Quantity = 500,
                                  SubCategoryId = 2,
                                  ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(13).webp"),
                                  ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                              },
                               new Product()
                               {
                                   //Id = 1,
                                   ProductName = "брюки женские",
                                   Price = 1310,
                                   Quantity = 500,
                                   SubCategoryId = 2,
                                   ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(14).webp"),
                                   ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                               },
                                new Product()
                                {
                                    //Id = 1,
                                    ProductName = "брюки женские",
                                    Price = 1310,
                                    Quantity = 500,
                                    SubCategoryId = 2,
                                    ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(15).webp"),
                                    ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                                },
                                 new Product()
                                 {
                                     //Id = 1,
                                     ProductName = "брюки женские",
                                     Price = 1310,
                                     Quantity = 500,
                                     SubCategoryId = 2,
                                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(16).webp"),
                                     ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                                 },
                                  new Product()
                                  {
                                      //Id = 1,
                                      ProductName = "брюки женские",
                                      Price = 1310,
                                      Quantity = 500,
                                      SubCategoryId = 2,
                                      ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(17).webp"),
                                      ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                                  },
                                   new Product()
                                   {
                                       //Id = 1,
                                       ProductName = "брюки женские",
                                       Price = 1310,
                                       Quantity = 500,
                                       SubCategoryId = 2,
                                       ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(18).webp"),
                                       ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                                   },
                                    new Product()
                                    {
                                        //Id = 1,
                                        ProductName = "брюки женские",
                                        Price = 1310,
                                        Quantity = 500,
                                        SubCategoryId = 2,
                                        ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\5.Женские_брюки\Купить женские брюки в интернет магазине WildBerries.ru_files\1(19).webp"),
                                        ProductDescription = "Велосипедки женские высокая талия удобные и практичные, сшиты из высококачественной эластичной ткани, отлично подойдут и для спорта, и для дома, и для улицы, и для отдыха. Черные велосипедки идут с высокой посадкой. Велосипедки короткие имеют пришитую широкую резинку, которая скрываем проблемные зоны, не давая им сползать с талии. Велосипедки в нижней части не перетягивает ноги за счет эластичного шва. Велосипедки женские шорты в меру тянутся, не зацепляются , не скатываются , не растягиваются , не просвечивают, не линяют, приятные к телу и на ощупь , позволяют коже дышать. Велосипедки женские сшиты из ткани, которая при высоких физических нагрузках отводить влагу и быстро сохнет. Велосипедки спортивные с эффектом легкой компрессии скрывают несовершенства фигуры и визуально подтягивают ее. Велосипедки женские черные подходят и взрослым, и подросткам. Велосипедки для фитнеса плотные сочетаются с топом, футболкой, рубашкой. Шорты велосипедки женские размер 40 - велосипедки для девочки. На модели велосипедки женские черные - размер 42 Отличные качественные велосипедки как для спорта, фитнеса так и для домашнего использования."
                                    },
                                     new Product()
                                     {
                                         //Id = 1,
                                         ProductName = "свитер женский",
                                         Price = 1310,
                                         Quantity = 500,
                                         SubCategoryId = 4,
                                         ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1.webp"),
                                         ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                                     },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(2).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(3).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(4).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(5).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(6).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(7).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(8).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(9).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(10).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(11).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(12).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(13).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(14).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(15).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(16).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(17).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(18).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(19).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 },
                 new Product()
                 {
                     //Id = 1,
                     ProductName = "свитер женский",
                     Price = 1310,
                     Quantity = 500,
                     SubCategoryId = 4,
                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\7.Женские_свитеры\Купить женские джемперы и кардиганы в интернет магазине WildBerries.ru_files\1(20).webp"),
                     ProductDescription = "Вязаный женский свитер от LaUris идеально подойдет для зимы, осени, демисезона, весны и лета. Прекрасно дополнит образ для работы в офисе, школы и дома. Кофта женская оверсайз идеально впишется в повседневный и вечерний наряд. Стильный зимний джемпер сделает ваш образ необычным и уникальным и не оставит равнодушным никого. Объёмная утепленная кофта с модным принтом и длинным широким рукавом -этот свитер абсолютный тренд 2023 года и должен быть в гардеробе каждой модницы. Теплый уютный, отлично согреет вас в холодную погоду."
                 }

            );

            context.SaveChanges();
        }
            
    }
        public static class HashPasswordHelper
        {
            public static string HashPassowrd(string password)
            {
                using (var sha256 = SHA256.Create())
                {
                    var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                    return hash;
                }
            }
        }
}

