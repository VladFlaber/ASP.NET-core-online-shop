using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;
namespace Shop.Util
{

    public static class DB_Initialaizer
    {
        #region ListsProperties
        static List<SubCategory> subCategories { get; set; }
        static List<Category> categories { get; set; }
        static List<Manufacturer> manufacturers { get; set; }
        static List<ManufacturerContact> manufacturerContacts { get; set; }
        static List<ProductImage> productImages { get; set; }
        static List<ProductStorage> productStorages { get; set; }
        static List<User> users { get; set; }
        static List<UserComment> userComments { get; set; }
        static List<Purchase> purchases { get; set; }
        static List<Product> products { get; set; }
        #endregion
        static void  fillCategories()
        {
            categories = new List<Category>();
            categories.Add(new Category() { Name = "Компьютеры" });
            categories.Add(new Category() { Name = "Бытовая техника" });
            categories.Add(new Category() { Name = "Товары для дома" });
            categories.Add(new Category() { Name = "Автомобильные пренадлежности" });
            categories.Add(new Category() { Name = "Компьютеры" });
            categories.Add(new Category() { Name = "Гаджеты" });
        }

        static void fillUsers()
        {
            users = new List<User>();
            users.Add(new User() { Name = "Барына", Surname = "Боб", Login = "qwe", Email = "etwet@gmail.com", Password = "qwe", Phone = "+38054654547" });
            users.Add(new User() { Name = "Корабль", Surname = "Иванович", Login = "asd", Email = "ryrty@ukr.net", Password = "asd", Phone = "+380567347345" });
            users.Add(new User() { Name = "Солдат", Surname = "Солнца", Login = "zxc", Email = "jkklut@gmail.com.", Password = "zxc", Phone = "+380523523577" });
        }
        static void fillUsersComments()
        {
            userComments = new List<UserComment>();
            userComments.Add(new UserComment() { Text = "Говно", User = users[0], Product = products[0] });
            userComments.Add(new UserComment() { Text = "Норм", User = users[2], Product = products[15] });
            userComments.Add(new UserComment() { Text = "сосу за хлеб", User = users[1], Product = products[11] });
            //userComments.Add(new UserComment() { Text = "аяебу собак",User= users[2], Product = products[8] });
            //userComments.Add(new UserComment() { Text = "всегда готов",User= users[0], Product = products[6] });
            //userComments.Add(new UserComment() { Text = "не работает",User= users[0], Product = products[4] });
            //userComments.Add(new UserComment() { Text = "админ петух",User= users[2], Product = products[7] });
            //userComments.Add(new UserComment() { Text = "ыыыыыы",User= users[2] });
            //userComments.Add(new UserComment() { Text = "hard.rozetka.com.ua",User= users[1], Product = products[5] });
        }
        static void fillManufacturers()
        {
            manufacturers = new List<Manufacturer>();
            manufacturers.Add(new Manufacturer() { CompanyName = "Intel", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Apple", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Indesit", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Razor", });
            manufacturers.Add(new Manufacturer() { CompanyName = "NVIDIA", });
            manufacturers.Add(new Manufacturer() { CompanyName = "AMD", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Samsung", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Philips", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Adidas", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Samsung", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Ткань из жопы", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Ковры бобровые", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Nike", });
            manufacturers.Add(new Manufacturer() { CompanyName = "шины от марины", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Побочка протеина", });
            manufacturers.Add(new Manufacturer() { CompanyName = "lukoil", });
            manufacturers.Add(new Manufacturer() { CompanyName = "Nike", });

        }
        static void fillManufacturerContacts()
        {
            manufacturerContacts = new List<ManufacturerContact>();
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "jhgj@gmail.com", Adress = "Киев .", PhoneNumber = "+6589655432", Website = "https://www.hkiyjhki.com", Manufacturer = manufacturers[0] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "tyu@gmail.com", Adress = "New York", PhoneNumber = "+457547834", Website = "https://", Manufacturer = manufacturers[0] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "gfjghk@mail.ru", Adress = "Seatle", PhoneNumber = "+5475475474532", Website = "https://www.hgmhgm.ru", Manufacturer = manufacturers[1] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "hgjhgj@gmail.com", Adress = "Paris", PhoneNumber = "+64565467", Website = "https://www.yjytg.com", Manufacturer = manufacturers[1] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "hgjghjhgj@gmail.com", Adress = "Denver", PhoneNumber = "+3456436346", Website = "https://www.hgkgkhkgk.com", Manufacturer = manufacturers[2] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "jhklhjl@gmail.com", Adress = "Chicago", PhoneNumber = "+3534325423655", Website = "https://www.trurtu.net", Manufacturer = manufacturers[2] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "gfjkfgkj@gmail.com", Adress = "L.A.", PhoneNumber = "+546754745", Website = "https://www.ukergwqe.ru", Manufacturer = manufacturers[3] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "yjktyj@.", Adress = "Berlin", PhoneNumber = "+567567567", Website = "https://www.yhukytfgh.com", Manufacturer = manufacturers[4] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "ytktye@gmail.com", Adress = "Москва", PhoneNumber = "+34543673467", Website = "https://www.rteryu.ru", Manufacturer = manufacturers[5] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "fghfgj@.", Adress = "Будапешт", PhoneNumber = "+567568345", Website = "https://www.ujhtrufgh.com", Manufacturer = manufacturers[5] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "bnmghjm@gmail.com", Adress = "Милан", PhoneNumber = "+536546457", Website = "https://www.gjtrtre.ru", Manufacturer = manufacturers[6] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "tyurtu@.", Adress = "Минск", PhoneNumber = "+3545754745", Website = "https://www.fgjhfgj.com", Manufacturer = manufacturers[7] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "hgkghk@gmail.com", Adress = "Киев", PhoneNumber = "+5465468342", Website = "https://www.utyutykgh.ua", Manufacturer = manufacturers[8] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "ghkghk@.", Adress = "Киев", PhoneNumber = "+8678435346", Website = "https://www.gfjhfgj.fr", Manufacturer = manufacturers[9] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "hgkhgk@gmail.com", Adress = "Монреаль", PhoneNumber = "+7547546546", Website = "https://www.trhutryu.net", Manufacturer = manufacturers[10] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "hgkghkghkbner@.", Adress = "Панама", PhoneNumber = "+54368314325", Website = "https://www.fgjfgj.org", Manufacturer = manufacturers[11] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "u356@gmail.com", Adress = "Луганск", PhoneNumber = "+754754754754", Website = "https://www.rtuyru.ua", Manufacturer = manufacturers[12] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "4124@gmail.com", Adress = "Варшава", PhoneNumber = "+43673475434", Website = "https://www.gfjhfgj.lt", Manufacturer = manufacturers[13] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "fghgfh@mail.ru", Adress = "Люксембург", PhoneNumber = "+658587546", Website = "https://www.fgjufgj.com", Manufacturer = manufacturers[14] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "mhnjmh@gmail.com", Adress = "Беллфаст", PhoneNumber = "+8756856856324", Website = "https://www.fghtjutr.com", Manufacturer = manufacturers[15] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "hgkjhgkt5t4@gmail.com", Adress = "Новый Орлеан", PhoneNumber = "+355", Website = "https://www.tgrujrkir.net", Manufacturer = manufacturers[15] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "7jytj41@gmail.com", Adress = "Прага", PhoneNumber = "+54754754872345", Website = "https://www.hfgiht.ru", Manufacturer = manufacturers[11] });
            manufacturerContacts.Add(new ManufacturerContact()
            { Email = "ghjghjgh@ukr.net", Adress = "Лиссабон", PhoneNumber = "+35554645787866", Website = "https://www.ghjhgkj.ua", Manufacturer = manufacturers[12] });



        }
        static void fillProductImages()
        {
            productImages = new List<ProductImage>();
            productImages.Add(new ProductImage() { Path = "~/images/NoImage.png" });
            productImages.Add(new ProductImage() { Path = "~/images/NoImg2.png" });
        }
        static void fillProduts()
        {
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "AX-2305",
                Description = "Монитор из бутылок",
                Price = 7435,
                Rating = 6,
                Weight = 4000,
                Manufacturer = manufacturers[6],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[0],
            });
            products.Add(new Product()
            {
                Name = "DG-3573284",
                Description = "супер монитор",
                Price = 4357,
                Rating = 3,
                Weight = 3467,
                Manufacturer = manufacturers[7],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
             ,
                SubCategory = subCategories[0],
            }); products.Add(new Product()
            {
                Name = "XD4346",
                Description = "Шариковаая мышка",
                Price = 355,
                Rating = 2,
                Weight = 355,
                Manufacturer = manufacturers[2],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[1],
            }); products.Add(new Product()
            {
                Name = "HGF46216",
                Description = "Мышка для геев",
                Price = 676,
                Rating = 10,
                Weight = 466,
                Manufacturer = manufacturers[2],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[0],
            }); products.Add(new Product()
            {
                Name = "Intel core i7 ",
                Description = "дорогая хуйня",
                Price = 55555,
                Rating = 10,
                Weight = 400,
                Manufacturer = manufacturers[0],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[2],
            }); products.Add(new Product()
            {
                Name = "AMD RX",
                Description = "еще дороже",
                Price = 66666,
                Rating = 8,
                Weight = 555,
                Manufacturer = manufacturers[5],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[2],
            }); products.Add(new Product()
            {
                Name = "gtx 1080ti",
                Description = "переоцененный кал",
                Price = 30000,
                Rating = 2356,
                Weight = 1111,
                Manufacturer = manufacturers[4],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[3],
            }); products.Add(new Product()
            {
                Name = "КУНИ4368",
                Description = "постирает носки за 2мин",
                Price = 10000,
                Rating = 4,
                Weight = 30000,
                Manufacturer = manufacturers[2],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[4],
            }); products.Add(new Product()
            {
                Name = "dfh-36436x",
                Description = "холодильник ",
                Price = 7777,
                Rating = 5,
                Weight = 21111,
                Manufacturer = manufacturers[6],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[5],
            }); products.Add(new Product()
            {
                Name = "Штора красная",
                Description = "мощная штора ",
                Price = 1235,
                Rating = 5,
                Weight = 5555,
                Manufacturer = manufacturers[9],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[6],
            }); products.Add(new Product()
            {
                Name = "Шторы синяя",
                Description = "мега мощная штора",
                Price = 1324,
                Rating = 4,
                Weight = 5555,
                Manufacturer = manufacturers[9],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[6],
            }); products.Add(new Product()
            {
                Name = "Штора зеленая",
                Description = "супер мощная штора",
                Price = 2222,
                Rating = 6,
                Weight = 1245,
                Manufacturer = manufacturers[9],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[6],
            }); products.Add(new Product()
            {
                Name = "Ковер на стену",
                Description = "дух СССР",
                Price = 10000,
                Rating = 3,
                Weight = 8000,
                Manufacturer = manufacturers[10],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[7],
            }); products.Add(new Product()
            {
                Name = "Ковер на стену v2",
                Description = "дух СССР",
                Price = 10000,
                Rating = 5,
                Weight = 7893,
                Manufacturer = manufacturers[10],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[8],
            }); products.Add(new Product()
            {
                Name = "А-95",
                Description = "бензин",
                Price = 20.45M,
                Rating = 0,
                Weight = 1000,
                Manufacturer = manufacturers[15],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[8],
            }); products.Add(new Product()
            {
                Name = "Ракетное топливо",
                Description = "для бытовых нужд",
                Price = 10034,
                Rating = 9,
                Weight = 1000,
                Manufacturer = manufacturers[15],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[8],
            }); products.Add(new Product()
            {
                Name = "Дизель",
                Description = "",
                Price = 14.50M,
                Rating = 5,
                Weight = 1000,
                Manufacturer = manufacturers[15],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[8],
            }); products.Add(new Product()
            {
                Name = "Елочка",
                Description = "Автомобильный ароматизатор",
                Price = 25,
                Rating = 4,
                Weight = 50,
                Manufacturer = manufacturers[13],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[9],
            }); products.Add(new Product()
            {
                Name = "Шина для трактора",
                Description = "балдежная шина для вашего любимого трактора",
                Price = 2000,
                Rating = 3,
                Weight = 30000,
                Manufacturer = manufacturers[13],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[10],
            }); products.Add(new Product()
            {
                Name = "моющее для стекол",
                Description = "помой меня",
                Price = 35,
                Rating = 7,
                Weight = 500,
                Manufacturer = manufacturers[13],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[9],
            }); products.Add(new Product()
            {
                Name = "Летняя резина 19д",
                Description = "доедете до крыма",
                Price = 3299,
                Rating = 10,
                Weight = 8,
                Manufacturer = manufacturers[13],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[10],
            }); products.Add(new Product()
            {
                Name = "Велотренажер pedal 4000",
                Description = "",
                Price = 4000,
                Rating = 6,
                Weight = 20000,
                Manufacturer = manufacturers[12],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[11],
            }); products.Add(new Product()
            {
                Name = "Гриф 30",
                Description = "внутрижопно",
                Price = 1000,
                Rating = 5,
                Weight = 15000,
                Manufacturer = manufacturers[12],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[11],
            }); products.Add(new Product()
            {
                Name = "БАД импотент",
                Description = "",
                Price = 30000,
                Rating = 10,
                Weight = 1000,
                Manufacturer = manufacturers[14],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[12],
            }); products.Add(new Product()
            {
                Name = "Протеин",
                Description = "",
                Price = 5223,
                Rating = 7,
                Weight = 1000,
                Manufacturer = manufacturers[14],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[12],
            }); products.Add(new Product()
            {
                Name = "Костюм черный ",
                Description = " размер XXXL",
                Price = 3333,
                Rating = 5,
                Weight = 1200,
                Manufacturer = manufacturers[8],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[13],
            }); products.Add(new Product()
            {
                Name = "Костюм украина",

                Description = "жовтоблакитный",
                Price = 4666,
                Rating = 10,
                Weight = 666,
                Manufacturer = manufacturers[8],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
              ,
                SubCategory = subCategories[13],
            });
            ////////
            ///
            products.Add(new Product()
            {
                Name = "Galaxy s10",

                Description = "rtrtyuityi",
                Price = 55550,
                Rating = 6,
                Weight = 666,
                Manufacturer = manufacturers[9],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
             ,
                SubCategory = subCategories[14],
            });
            products.Add(new Product()
            {
                Name = "IPhone x46",
                Description = "rytruytrufjhhgjghjghjhikuyokuylkm,jhlkhuj",
                Price = 5555555,
                Rating = 10,
                Weight = 788,
                Manufacturer = manufacturers[1],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
            ,
                SubCategory = subCategories[14],
            });
            products.Add(new Product()
            {
                Name = "Samsung tab 5",

                Description = "",
                Price = 5687,
                Rating = 5,
                Weight = 666,
                Manufacturer = manufacturers[9],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
            ,
                SubCategory = subCategories[15],
            });
            products.Add(new Product()
            {
                Name = "IPad",

                Description = "yeryeryeruyrturtutr",
                Price = 555555,
                Rating = 5,
                Weight = 677,
                Manufacturer = manufacturers[1],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
            ,
                SubCategory = subCategories[15],
            });

            products.Add(new Product()
            {
                Name = "mac x543",

                Description = "t78ghkhyjkyuy",
                Price = 55678,
                Rating = 7,
                Weight = 2555,
                Manufacturer = manufacturers[1],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
            ,
                SubCategory = subCategories[16],
            });
            products.Add(new Product()
            {
                Name = "mac 8jkuu",

                Description = "nghjnjk",
                Price = 55678,
                Rating = 7,
                Weight = 2555,
                Manufacturer = manufacturers[1],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
           ,
                SubCategory = subCategories[16],
            });
            products.Add(new Product()
            {
                Name = "mac bjhhj",

                Description = "t78ghkhyjkyuy",
                Price = 324567,
                Rating = 7,
                Weight = 2555,
                Manufacturer = manufacturers[1],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
           ,
                SubCategory = subCategories[16],
            });
            products.Add(new Product()
            {
                Name = "mac nvbn g6",

                Description = "hujikyuioy",
                Price = 34346,
                Rating = 7,
                Weight = 2555,
                Manufacturer = manufacturers[1],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
           ,
                SubCategory = subCategories[16],
            });
            products.Add(new Product()
            {
                Name = "samsung chitalka ",

                Description = "",
                Price = 6789,
                Rating = 5,
                Weight = 666,
                Manufacturer = manufacturers[6],
                ProductImages = new List<ProductImage>() { productImages[0], productImages[1] }
            ,
                SubCategory = subCategories[17],
            });
        }
        static void fillSubCategories()
        {
            subCategories = new List<SubCategory>();
            subCategories.Add(new SubCategory() { Name = "Мониторы", Category = categories[0] });
            subCategories.Add(new SubCategory() { Name = "Мышки", Category = categories[0] });
            subCategories.Add(new SubCategory() { Name = "Процессоры", Category = categories[0] });
            subCategories.Add(new SubCategory() { Name = "Видеокарты", Category = categories[0] });
            subCategories.Add(new SubCategory() { Name = "Стиральные машины", Category = categories[1] });
            subCategories.Add(new SubCategory() { Name = "Холодильники", Category = categories[1] });
            subCategories.Add(new SubCategory() { Name = "Шторы", Category = categories[2] });
            subCategories.Add(new SubCategory() { Name = "Ковры", Category = categories[2] });
            subCategories.Add(new SubCategory() { Name = "Топливо", Category = categories[3] });
            subCategories.Add(new SubCategory() { Name = "Автомобильные акксесуары", Category = categories[3] });
            subCategories.Add(new SubCategory() { Name = "Шины", Category = categories[3] });
            subCategories.Add(new SubCategory() { Name = "Тренажеры", Category = categories[4] });
            subCategories.Add(new SubCategory() { Name = "Спортивное питание", Category = categories[4] });
            subCategories.Add(new SubCategory() { Name = "Спортивные костюмы", Category = categories[4] });
            subCategories.Add(new SubCategory() { Name = "Смартфоны", Category = categories[5] });
            subCategories.Add(new SubCategory() { Name = "Планшеты", Category = categories[5] });
            subCategories.Add(new SubCategory() { Name = "Ноутбуки", Category = categories[5] });
            subCategories.Add(new SubCategory() { Name = "Читалки", Category = categories[5] });

        }
        static void fillProductStorages()
        {
            productStorages = new List<ProductStorage>();
            productStorages.Add(new ProductStorage()
            {
                Adress = "",
                Phone = "",
                ProductsQuantity = 0,
                Products = new List<Product>() { products[0], products[0] }
            });
            productStorages.Add(new ProductStorage()
            {
                Adress = "",
                Phone = "",
                Products = new List<Product>() { products[0], products[0] }
            });
            productStorages.Add(new ProductStorage()
            {
                Adress = "",
                Phone = "",
                Products = new List<Product>() { products[0], products[0] }
            });
            productStorages.Add(new ProductStorage()
            {
                Adress = "",
                Phone = "",
                Products = new List<Product>() { products[0], products[0] }
            });
            productStorages.Add(new ProductStorage()
            {
                Adress = "",
                Phone = "",
                Products = new List<Product>() { products[0], products[0] }
            });
        }
        static void fillPurchases()
        {
            purchases = new List<Purchase>();
            purchases.Add(new Purchase() { });
        }
        static public void fillDb(StoreContext db)
        {
             
            if (!db.Products.Any())
            {
                fillCategories();
                fillSubCategories();
                fillManufacturers();
                fillManufacturerContacts();
                fillProductImages();
                fillUsers();
                fillProduts();
                fillUsersComments();
                db.Categories.AddRange(categories);
                db.SubCategories.AddRange(subCategories);
                db.Manufacturers.AddRange(manufacturers);
                db.ManufacturerContacts.AddRange(manufacturerContacts);
                db.ProductImages.AddRange(productImages);
                db.Users.AddRange(users);
                db.Products.AddRange(products);
                db.UserComments.AddRange(userComments);

                db.SaveChanges();
            }
           
        }      
    }
}

