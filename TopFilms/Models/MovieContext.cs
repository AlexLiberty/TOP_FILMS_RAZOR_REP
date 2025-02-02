﻿using Microsoft.EntityFrameworkCore;

namespace TopFilms.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            if (Database.EnsureCreated())
            {
                Movies?.Add(new Movie
                {
                    Title = "Зеленая миля",
                    Genre = "Драма",
                    ReleaseYear = 1999,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/1898899/443e111e-f714-4954-83d0-3e0acca2a561/1920x",
                    Description = "Пол Эджкомб — начальник блока смертников в тюрьме «Холодная гора», каждый из узников которого однажды проходит «зеленую милю» по пути к месту казни. Пол повидал много заключённых и надзирателей за время работы. Однако гигант Джон Коффи, обвинённый в страшном преступлении, стал одним из самых необычных обитателей блока.",
                });

                Movies?.Add(new Movie
                {
                    Title = "Форрест Гамп",
                    Genre = "Драма",
                    ReleaseYear = 1994,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/4303601/64bc47ac-ad53-461f-ac0f-46e6b9876681/1920x",
                    Description = "Сидя на автобусной остановке, Форрест Гамп — не очень умный, но добрый и открытый парень — рассказывает случайным встречным историю своей необыкновенной жизни. С самого малолетства парень страдал от заболевания ног, соседские мальчишки дразнили его, но в один прекрасный день Форрест открыл в себе невероятные способности к бегу. Подруга детства Дженни всегда его поддерживала и защищала, но вскоре дороги их разошлись.",
                });

                Movies?.Add(new Movie
                {
                    Title = "Легенды осени",
                    Genre = "Драма",
                    ReleaseYear = 1994,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/1600647/edea4a0e-06da-4661-93b1-7c0e645ff86f/1920x",
                    Description = "Некоторые люди очень ясно слышат свой внутренний голос и живут так, как он им подсказывает. Такие люди сходят с ума. Или становятся легендами». Так начинается история семьи Ладлоу — стремительный и романтический рассказ о трёх братьях, их отце и молодой и неотразимой женщине, которая роковым образом изменяет жизнь каждого из них.",
                });

                Movies?.Add(new Movie
                {
                    Title = "Интерстеллар",
                    Genre = "Фантастика",
                    ReleaseYear = 2004,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/1600647/78c36c0f-aefd-4102-bc3b-bac0dd4314d8/1920x",
                    Description = "Когда засуха, пыльные бури и вымирание растений приводят человечество к продовольственному кризису, коллектив исследователей и учёных отправляется сквозь червоточину (которая предположительно соединяет области пространства-времени через большое расстояние) в путешествие, чтобы превзойти прежние ограничения для космических путешествий человека и найти планету с подходящими для человечества условиями.",
                });

                Movies?.Add(new Movie
                {
                    Title = "Побег из Шоушенка",
                    Genre = "Драма",
                    ReleaseYear = 1994,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/1773646/e26044e5-2d5a-4b38-a133-a776ad93366f/1920x",
                    Description = "Бухгалтер Энди Дюфрейн обвинён в убийстве собственной жены и её любовника. Оказавшись в тюрьме под названием Шоушенк, он сталкивается с жестокостью и беззаконием, царящими по обе стороны решётки. Каждый, кто попадает в эти стены, становится их рабом до конца жизни. Но Энди, обладающий живым умом и доброй душой, находит подход как к заключённым, так и к охранникам, добиваясь их особого к себе расположения.",
                });

                Movies?.Add(new Movie
                {
                    Title = "Загадочная история Бенджамина Баттона",
                    Genre = "Драма",
                    ReleaseYear = 2008,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/1600647/1439ad3b-fd22-4fc1-a5cf-2b4fb901a505/1920x",
                    Description = "Фильм о мужчине, который родился в возрасте 80 лет, а затем… начал молодеть. Этот человек, как и каждый из нас, не мог остановить время. Его путь в ХХI век, берущий свое начало в Новом Орлеане в 1918 году в самом конце Первой Мировой войны, будет столь необычен, что вряд ли мог иметь место в жизни кого-либо другого. Фильм повествует о судьбе уникального человека, о людях и событиях, что ждут его впереди, о любви, которую он обретет и потеряет, о радостях жизни и грусти потерь и о том, что остается с нами вне времени.",
                });

                Movies?.Add(new Movie
                {
                    Title = "Достучаться до небес",
                    Genre = "Драма",
                    ReleaseYear = 1997,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/1946459/be46b4a0-d5f4-4ba8-9bf8-dd248b0c33d4/1920x",
                    Description = "Волею судеб две абсолютные противоположности, тихоня Руди и разгильдяй Мартин, оказываются в одной больничной палате. Узнав неутешительные прогнозы, друзья решают использовать последние дни на полную катушку — угнать машину с деньгами, напиться текилы, и, конечно, увидеть море.",
                });

                Movies?.Add(new Movie
                {
                    Title = "Криминальное чтиво",
                    Genre = "Криминал",
                    ReleaseYear = 1994,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/6201401/97ed7256-db80-4532-ab6b-6688d2eab4b2/1920x",
                    Description = "Двое бандитов Винсент Вега и Джулс Винфилд ведут философские беседы в перерывах между разборками и решением проблем с должниками криминального босса Марселласа Уоллеса.\r\n\r\nВ первой истории Винсент проводит незабываемый вечер с женой Марселласа Мией. Во второй Марселлас покупает боксёра Бутча Кулиджа, чтобы тот сдал бой. В третьей истории Винсент и Джулс по нелепой случайности попадают в неприятности.",
                });

                Movies?.Add(new Movie
                {
                    Title = "Не грози Южному Централу, попивая сок у себя в квартале",
                    Genre = "Комедия",
                    ReleaseYear = 1995,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/1704946/0ff7142f-4f4f-49af-90e8-20c00d2d4ab7/1920x",
                    Description = "Молодой афроамериканец по прозвищу Пепельница переезжает в Южный Централ к своему отцу, где редкий молодой человек доживает до 18. Парень гордится, что они с отцом почти ровесники — он старше папы всего на два года. Гордится он и бабулей, которая в свои-то преклонные годы покуривает и не стесняется крепких словечек. Вскоре Пепельница встречается со своим кузеном по прозвищу Лок Дог. Этот парень — гангстер, в его личном арсенале не только пистолеты и автомат, но и ядерная боеголовка советского производства — для самозащиты, разумеется. Пепельница должен выбрать дальнейший путь в жизни: он может стать «просто хорошим чернокожим» или «опасным чернокожим», примкнув к банде своего кузена.",
                });

                Movies?.Add(new Movie
                {
                    Title = "Эквилибриум",
                    Genre = "Фантастика",
                    ReleaseYear = 2002,
                    ImagePath = "https://avatars.mds.yandex.net/get-kinopoisk-image/1777765/ecc77c5c-17cb-4258-b9c9-f58e3a541bf6/1920x",
                    Description = "В будущем люди лишены возможности выражать эмоции. Это цена, которую человечество платит за устранение из своей жизни войны. Теперь книги, искусство и музыка находятся вне закона, а любое чувство — преступление, наказуемое смертью. Для приведения в жизнь существующего правила используется принудительное применение лекарства прозиум. Правительственный агент Джон Престон борется с теми, кто нарушает правила. В один прекрасный момент он забывает принять очередную дозу лекарства, и с ним происходит духовное преображение, что приводит его к конфликту не только с режимом, но и с самим собой.",
                });

                SaveChanges();
            }
        }
    }
}
