﻿//using OnlineMarket.DAL.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OnlineMarket.DAL.Db_Products
//{
//    public static class Женская_Верхняя_Одежда
//    {
//        public static void Initialize(ApplicationDbContext context)
//        {
//            //if (context.Products.Any())
//            //{
//            //    return;
//            //}

//            context.Products.AddRange(

//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1.webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(1).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(2).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(3).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(4).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(5).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(6).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(7).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(8).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(9).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(10).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(11).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(12).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(13).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(14).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(15).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(16).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(17).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 },
//                 new Product()
//                 {
//                     //Id = 1,
//                     ProductName = "куртка женская",
//                     Price = 13100,
//                     Quantity = 500,
//                     SubCategoryId = 3,
//                     ProductPhoto = File.ReadAllBytes(@"D:\VS_Projects\OnlineMarket\For_Database\6.Женская_верхняя_одежда\Купить верхнюю женскую одежду в интернет магазине WildBerries.ru_files\1(18).webp"),
//                     ProductDescription = "Идеальная куртка на осень , проверенная временем , с наполнителем холлофайбер 150 г МОДНАЯ КУРТКА ИЗ ЭКОЛОГИЧНОГО МАТЕРИАЛА ЭКО-КОЖА. МЯГКИЙ ИЗНОСОСТОЙКИЙ МАТЕРИАЛ. ВЫГЛЯДИТ ДОРОГО И КРАСИВО. ТЕПЛАЯ КУРТКА ЖЕНСКАЯ ОСЕНЬ ЗАЩИЩАЕТ ОТ ДОЖДЯ, ВЕТРА, ХОЛОДА. ТЕМПЕРАТУРНЫЙ РЕЖИМ +5-20 С. КУРТКА ЖЕНСКАЯ БУДЕТ СОЧЕТАТЬСЯ С ЛЮБЫМ ГАРДЕРОБОМ. КУРТКА С КАПЮШОНОМ - ЭТО ПРАКТИЧНО И ОЧЕНЬ СТИЛЬНО."
//                 }

//                );
//            context.SaveChanges();
//        }

//    }
//}
