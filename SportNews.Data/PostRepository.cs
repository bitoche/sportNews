﻿namespace SportNews.Data
{
    public class PostRepository
    {
        private List<Post> posts;

        public PostRepository()
        {
            User user = new User("Andrey Schelkov");

            posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Месси блистает в «ПСЖ»: продвигает, обостряет, " +
                    "забивает. Больше никто не думает, что он топ только в «Барсе»",
                    Author = new User("Schelkov Andrey"),
                    Description = "После сложного дебютного сезона " +
                    "в Париже Лионель Месси возвращается на топовый " +
                    "уровень и по результативности. Он лучший ассистент" +
                    " топ-5 лиг (9 ассистов, столько же у Кевина де Брюйне)," +
                    " набил 6+9 по гол+пас (1,4 результативных действия в " +
                    "пересчете на 90 минут), больше него набрали лишь Эрлинг" +
                    " Холанд (17+3), Роберт Левандовски (12+4) и Неймар (9+7).",
                    Created = DateTime.Now,
                    Image = "https://s5o.ru/storage/simple/ru/edt/fb/15/8c/b4/rue1e3da00729.jpg",
                    Discipline = Discipline.GetById(1)
                },
                new Post
                {
                    Id = 2,
                    Title = "Русский талант превратился в хрусталь. Кравцов получил три травмы за четыре матча НХЛ!",
                    Author = new User("Schelkov Andrey"),
                    Description="Сложно понять, что за проклятие преследует Виталия Кравцова." +
                    " К концу октября у него четыре проведённых матча в НХЛ и сразу три травмы." +
                    " В первом случае явно перестарался Виктор Хедман из «Тампы», который " +
                    "слишком сильно нажал на голову русского форварда. Обстоятельства второго" +
                    " повреждения не были известны — о нём объявил главный тренер «Рейнджерс» " +
                    "Жерар Галлан, из-за него Виталий пропустил одну игру с «Айлендерс».",
                    Created = DateTime.Now,
                    Image = "https://img.championat.com/s/735x490/news/big/a/d/u-vitaliya-kravcova-tri-travmy_16671269161184557244.jpg",
                    Discipline = Discipline.GetById(2)
                },
            };
            CreatePost("УЕФА на встрече со спонсором Суперлиги вновь подтвердил несогласие с проектом",
                "Союз европейских футбольных ассоциаций (УЕФА) вновь подтвердил несогласие с «отколовшимися проектами» на встрече с компанией A22 Sports Management, которая создана для спонсорства и помощи в создании европейской Суперлиги, сообщается на сайте УЕФА.",
                "https://s-cdn.sportbox.ru/images/styles/960_auto/fp_fotos/bd/78/cff43dab2e66d59dadae0ec105448f606270115aef59e767920976.jpg",
                user,
                1);
            CreatePost("ЕЩЕ ОДНА ЖЕРТВА ОВЕЧКИНА. РОССИЙСКИЙ СНАЙПЕР ВЗЯЛ МОДУ КОЛЛЕКЦИОНИРОВАТЬ СКАЛЬПЫ ЧУЖИХ ВРАТАРЕЙ", "Обозреватель «Матч ТВ» рассказывает о том, как Александр Овечкин забил 788-й гол в карьере, а его «Вашингтон» обыграл дома «Эдмонтон» (5:4). Что интересно, Ови поразил ворота уже 163 голкиперов! Впереди еще один вечный рекорд…", "https://s-cdn.sportbox.ru/images/styles/960_auto/fp_fotos/55/68/ce2622b53d5a115cd85f7072c4552f136369f31201c4d723895603.jpg", user, 2);
            CreatePost("ЗАМАХНУЛСЯ НА ДВА ПОЯСА: МАЛЫХИН БРОСИТ ВЫЗОВ ДЕ РИДДЕРУ", "Временный чемпион мира в тяжелом весе Анатолий Малыхин опустится на дивизион ниже в бою за пояс чемпиона мира ONE в полутяжелом весе 2 декабря.", "https://s-cdn.sportbox.ru/images/styles/960_auto/fp_fotos/1d/b0/d5bef2624656a8ae42ee9fca2dc72b7d63107f70ed2c9610237922.jpg", user, 5);
            CreatePost("Проще бросить курить, чем научить Бена Симмонса бросать. Почему игрок НБА боится мяча?!", "Может, это иллюзорность времени, а может, и было совсем недавно, но во многих объемных материалах о Бене Симмонсе за 2019-2020 год легко обнаружить уйму восторженно-вычурных метафор. Вроде той, что при виде Бена глаза болельщиков «Сиксерс» загораются так же, как при виде портрета его тезки Франклина на стодолларовой банкноте. Где-то в это же время неравнодушный к «Филадельфии» аналитик ESPN Стивен Эй Смит продолжал утверждать: «He’s box office» («Этот парень джек-пот»).\r\n\r\nНо вот чего никак и никогда нельзя было вписать в эти умильные валютные аллюзии, так это самого главного. Money – типичная и самая бурная реакция англоязычных комментаторов на точное и своевременное попадание. А у Симмонса никогда не было стабильного броска. И вероятнее всего, он никогда и не стремился им обзавестись. Во многом поэтому трехкратного участника Матча Звезд могут обменять второй раз за календарный год.", "https://s5o.ru/storage/simple/ru/edt/c4/b6/8f/28/rue8a5dbe5b2f.jpg", user, 4);
            CreatePost("Крис Пол – главный популяризатор боулинга в НБА: поднимает рейтинги, подсаживает других звезд и зарабатывает сам", "Крис Пол входит в категорию игроков, которым сопереживают даже самые нейтральные болельщики. Разыгрывающий годами кружил вокруг шанса заполучить чемпионский титул, в сезоне-2020/2021 вплотную подошел к осуществлению своей мечты, но его «Финикс» уступил в финале «Милуоки» 2-4. Он определенно в будущем будет введен Зала Славы, но чемпионский перстень – тот самый атрибут, который не оставит никаких сомнений в успешности и без того выдающейся карьеры Пола.\r\n\r\nОднако для самого игрока, который считает себя максималистом, перстень чемпиона НБА не единственный трофей о котором он грезит. Существует еще одна цель, еще один перстень, о котором Крис Пол начал мечтать раньше, чем о чемпионстве НБА. Речь о кольце, которое вручается профессиональному игроку в боулинг за партию без единого промаха.", "https://s5o.ru/storage/simple/ru/edt/7e/f2/0e/8e/ruecc7fe14edc.jpg", user, 4);
            CreatePost("Новый рекорд Леброна – по числу игр с 20+ очками. А где лидируют Джордан, Карим и Чемберлен?", "Когда Леброн в 2018-м переходил в «Лейкерс», заявленной целью было усилить баскетбольное наследие Джеймса. Самый популярный баскетболист современности объединяется с самой популярной командой всех времен и собирается вернуть ее на вершину после необычно долгого прозябания на дне.\r\n\r\nС одной стороны, Леброн выполнил эту миссию – принес титул в 2020 году.\r\n\r\nС другой стороны, привыкший к победам Лос-Анджелес за эти четыре года увидел только один победный матч плей-офф от «Лейкерс». Чемпионство-то добывалось в Диснейленде, а в «нормальные» сезоны «озерники» и близко не были похожи на претендента на титул, лишь один раз вышли в плей-офф и там вылетели в первом же раунде. И старт юбилейного 20-го сезона Леброна не вселяет надежд в болельщиков.", "https://s5o.ru/storage/simple/ru/edt/f0/de/52/60/rued7612da43d.36.jpg", user, 4);
            CreatePost("У Кайри Ирвинга теперь тоже есть легендарная пресс-конференция", "Чего у Ирвинга всегда было не отнять, так это умения выкручиваться. Каждый раз, когда его вынуждали отвечать за слова, он очень ловко уходил. Делал вид, что его цель состояла лишь в том, чтобы «все задумались», подчеркивал, что не настаивает именно на своей точке зрения, и извинялся – но не за то, что продвигает антинаучный бред, а за что-нибудь другое.", "https://s5o.ru/storage/simple/ru/edt/b0/ac/78/26/rue9bdce8621a.jpg", user, 4);
            CreatePost("«НАДЕЮСЬ, ПОБОЛЬШЕ ВЫХОДНЫХ ДАДУТ ПОСЛЕ ПОБЕДЫ НА СПАРТАКИАДЕ» — ВОЛЕЙБОЛИСТКА СТАРЦЕВА", "Волейболистка сборной Москвы, чемпионка мира Евгения Старцева выразила надежду, что ее команде дадут побольше выходных после победы на Спартакиаде.\r\n\r\nВ субботу волейболистки сборной Москвы победили команду Республики Татарстан со счетом 3:0 в финале Спартакиады. Старцева была признана самым ценным игроком турнира. Сборную Москвы представляли волейболистки столичного «Динамо».\r\n\r\n— Сейчас я очень рада! Мы прошли такой долгий, тяжелый путь, и теперь можно выдохнуть. Хорошо, что мы с медалями.\r\n\r\n— В чем вы были сильнее команды Татарстана?\r\n\r\n— Мы выбили соперниц с приема. В первой партии у нас было очень много результативных блоков, 8 блоков. Мы хорошо сыграли на блоке и в защите.\r\n\r\n— Московское «Динамо» давно не выигрывало титулы. Эта победа наверняка послужит хорошим подспорьем в сезоне?\r\n\r\n— Надеюсь, что мы продолжим сезон так же. Сезон длинный, и закончится он только в мае. Еще много работы, мы только начали сезон, все еще только впереди.\r\n\r\n— После такого напряженного турнира выходные, наверное, особенно ждете?\r\n\r\n— Да, просто очень хочется домой. Все‑таки 11 дней живем в отеле.\r\n\r\n— Сколько будет выходных?\r\n\r\n— Пока не знаю, еще не говорил тренер. Надеюсь, побольше! — сказала Старцева журналистам.", "https://s-cdn.sportbox.ru/images/styles/960_auto/fp_fotos/46/22/204d7b73d3d10337453884be9b82e7f960acce6f11674745294110.jpg", user, 3);
            CreatePost("БК «Челбаскет» усилили опытным спортсменом из Красноярска", "Об этом сегодня, 8 ноября, рассказали представители клуба на пресс-конференции в медиахолдинге «Гранада Пресс». Краткосрочный контакт, на два месяца, заключили с Павлом Крыковым. Сам баскетболист из Красноярска, но уже успел побыть частью саратовского «Автодора», самарских «Красных крыльев» и других сильных клубов. Павел опытный игрок, который хорошо проявил себя – в сезоне-2017/18 его признали лучшим атакующим защитником Суперлиги-2.\r\n\r\nЕсли Павел Крыков хорошо покажет себя и в «Челбаскете», то контракт с ним готовы продлить до конца сезона. Нового игрока пришлось пригласить в команду из-за травм, которые получили на выезде двое центровых, Сергей Жульков и Кирилл Епанов.", "https://cheltoday.ru/upload/iblock/247/bk_chelbasket_usilili_opytnym_sportsmenom_iz_krasnoyarska.jpg", user, 4);
            CreatePost("Ловчев отреагировал на решение не включать его в комитет ветеранов «Спартака»", " Бывший футболист «Спартака» Евгений Ловчев отреагировал на решение не включать его в комитет ветеранов красно - белых.Известный в прошлом футболист считает, что причина такого решения заключается в его чрезмерной прямоте, которая не нравится руководству. «Я не особенно что - то знаю о создании комитета ветеранов.Вчера как раз встречался перед этим с Симоняном, который с Мирзояном ехал в «Лукойл», где был совет директоров.Я слышал буквально одну фразу, что создаётся совет ветеранов, почётным президентом, может быть, будет Симонян, ведь это ещё не было утверждено, а руководителем — Романцев.Всё, что я знаю.", "https://img.championat.com/s/735x490/news/big/h/j/lovchev-otreagiroval-na-resh.jpg", user, 1);
            CreatePost("«О сборной России думать глупо.Играть должны россияне». Интервью с Клаудиньо из «Зенита»", "Бразилец пока не считает сине - бело - голубых чемпионами. Прошлый сезон для Клаудиньо получился крутым.Он стал лучшим игроком «Зенита» по разным опросам и выбил 8 + 4 в 23 матчах РПЛ – очень неплохо для дебюта.А в этом сезоне засверкал Малком – его ближайший друг, с которым они вместе с детства.Сам Клаудиньо чуть притормозил.В том числе и потому, что словил травму в начале сезона.Но теперь он снова в порядке.Доказательство – гол в ворота «Пари НН» с двойным обыгрышем защитников.Просто мастер.В эксклюзивном интервью «Чемпионату» бразилец рассказал о старте «Зенита» в новом сезоне, разъяснил позицию по получению российского гражданства и поделился целями до 2027 года — когда истечёт его обновлённый контракт с петербургским клубом.", "https://img.championat.com/s/735x490/news/big/d/y/intervyu-s-poluzaschitnikom-zenita-klaudino_1667918216812413804.jpg", user, 1);
            CreatePost("«Ну что, обиженки, еду на радио». Разин анонсировал радиоэфир со своим участием", "Главный тренер «Северстали» Андрей Разин анонсировал радиоэфир, в котором специалист будет отвечать на различные вопросы.«Ну что, обиженные корреспонденты, еду на радио.Кому вчера не ответил, сегодня задавайте вопросы, всем отвечу.Обиженки, блин», — сказал Разин в видеобращении на своём телеграм - канале.Напомним, на пресс - конференции после вчерашнего поражения «Северстали» в матче с «Автомобилистом» (2:3 ОТ) Разин отказался давать какие - либо комментарии.Председатель спортивно - дисциплинарного комитета КХЛ Валерий Каменский сообщил, что не видит ничего плохого в таком поведении главного тренера череповецкой команды. С начала сезона - 2022 / 2023 Разин уже дважды получал штраф от КХЛ за критику арбитров.После второго штрафа и одноматчевой дисквалификации специалист отметил, что «теперь мои пресс - конференции будут скучными».", "https://img.championat.com/s/735x490/news/big/t/b/nu-chto-obizhenki-edu-na-rad.jpg", user, 2);
            CreatePost("Тренер «Миннесоты»: перед удалением Капризова толкали в спину и били.Это жёстко", "Главный тренер «Миннесоты Уайлд» Дин Эвасон остался недоволен действиями арбитров в матче с «Лос - Анджелес Кингз» (0:1).Специалист считает, что судьи пропустили несколько нарушений на игроках «дикарей». В середине встречи матч - штраф получил российский форвард «Уайлд» Кирилл Капризов за удар по лицу клюшкой защитника «Кингз» Дрю Даути.«Это жёстко, да ? Очевидно, что он один из лучших игроков в НХЛ.Он всё время владеет шайбой, и в прошлом году он по своему умению зарабатывать на себе удаления входил в топ - 5 лиги.Гарантирую вам, сейчас этот показатель намного ниже.", "https://img.championat.com/s/735x490/news/big/s/b/trener-minnesoty-pered-udaleniem-kaprizova-tolkali-v-spinu-i-bili-eto-zhyostko_16679789662033286251.jpg", user, 2);
            CreatePost("Ледеки установила мировой рекорд на 800-метровке кролем на короткой воде", "Американская пловчиха Кэти Ледеки установила новый мировой рекорд на короткой воде на дистанции 800 метров вольным стилем на третьем этапе Кубка мира, который проходит в Индианаполисе (США).\r\n\r\nЛедеки в финальном заплыве показала на дистанции 800 метров время 7 минут 57,42 секунды.\r\n\r\nПредыдущий мировой рекорд на данной дистанции - 7.59,34 - продержался больше девяти лет. Его установила Мирея Бельмонте Гарсия 10 августа 2013 года. Тогда испанка также установила рекорд на Кубке мира.", "https://cdnn21.img.ria.ru/images/07e5/07/1f/1743721266_0:157:3084:1892_1920x0_80_0_0_348ddc65b8497aa0bc0f836441fac657.jpg.webp", user, 6);
            CreatePost("Криминалист объяснил, в каком случае у Грайнер будут проблемы с сокамерницами в колонии РФ", "Криминалист Михаил Игнатов поделился мыслями о предстоящем пребывании американской баскетболистки Бриттни Грайнер в российской колонии.Напомним, сегодня, 9 ноября, стало известно, что Бриттни была переведена туда из СИЗО.По мнению Игнатова, в случае если Бриттни не будет воровать у сокамерниц и плести интриги, проблем у неё не возникнет.Более того, скорее всего, в колонии она будет пользоваться авторитетом.«Насчёт иностранки, насчёт спортсменки — каких - то притеснений не бывает.Наоборот, к спортсменам отношение другое, уважительное в основном.Из - за плохого знания языка тоже проблем не будет — будут помогать.Языком овладеет лучше — хочешь не хочешь, надо общаться.Если не противопоставит себя коллективу, если не будет воровать у сокамерниц, не будет плести интриги, то особых проблем я не вижу и со стороны сокамерниц, и со стороны администрации.Образ жизни будет нормальный, как у всех.В колониях нет дискриминации по принадлежности к стране, языку.", "https://img.championat.com/s/735x490/news/big/s/q/kriminalist-obyasnil-v-kakom-sluchae-u-grajner-budut-problemy-s-sokamernicami-v-kolonii-rf_16679966181359164513.jpg", user, 4);
            CreatePost("Перед ЧМ в Катаре построили город, где пройдет финал. Это уникальная история", "Катар подходит к чемпионату миру с невиданным размахом: на турнир потратили более 200 миллиардов долларов (в 17 раз больше, чем Россия – на ЧМ-2018). Но нельзя сказать, что шейхи просто разбрасываются деньгами. Большую часть объектов, построенных к чемпионату мира, включили в проект «Катар-2030». Это национальный план развития, который затрагивает почти все сферы жизни, – от медицины до образования. Если его реализовать, то к 2030-му Катар станет одной из самых процветающих стран мира.\r\n\r\nЛусаил – центральная часть этого проекта. В городе, расположенном на берегу Персидского залива (примерно в 25 километрах от Дохи), пройдет финал турнира. Катар выстроил его специально к турниру практически с нуля.", "https://s5o.ru/storage/simple/ru/edt/dd/1e/02/42/rue440d868b51.jpg", user, 1);
            CreatePost("Из «Авангарда» посреди сезона ушел генеральный менеджер. Говорит, что в клубе его не слушали", "Когда из клуба, который полтора года назад выиграл Кубок Гагарина, вдруг посреди сезона уходит генеральный менеджер, а перед этим еще и тренер – это означает, что там не все так хорошо, как может показаться.\r\n\r\nАлексей Волков написал заявление по собственному желанию и объявил об этом через журналистов. Релиз от «Авангарда» появился позднее и в нем нет никакой прощальной цитаты (пожалуй, Волков и так много сказал), нет объяснений от главного босса Александра Крылова, а только сухой факт и скромная благодарность за проделанную работу – в одном предложении. Как будто и не было Кубка Гагарина в апреле 2021-го, пусть даже Волков, возможно, и не главный творец той победы.", "https://s5o.ru/storage/simple/ru/edt/f9/ae/97/c4/rue33c9a8e501.jpg", user, 2);
            CreatePost("Томас Бах: «Необходимо, чтобы в Олимпиадах участвовали все страны, в том числе конфликтующие. Если будут участвовать только страны-союзники, символа мира из Игр не получится»", "Глава Международного олимпийского комитета (МОК) Томас Бах призвал лидеров G20 включить пункт о «спортивной нейтральности» в совместное заявление по итогам саммита на Бали.\r\n\r\n«Олимпийские игры, прошедшие в Токио и в Пекине в разгар пандемии, дали всему миру надежду.\r\n\r\nОлимпиада способна объединить весь мир, только если атлеты со всего мира буду в ней участвовать.\r\n\r\nВ отличие от других конфликтов между странами в прошлом, в этот раз некоторые страны решили, что имеют право отказывать атлетам в участии в Олимпийских играх по политическим соображениям. Если спорт станет инструментом для политического воздействия, он полностью развалится.\r\n\r\nСама суть спорта в том, что решения должны принимать только исходя из спортивных результатов, а не чего либо еще.\r\n\r\nНеобходимо, чтобы в Олимпийских играх принимали участие все страны, в том числе – и даже в особенности – конфликтующие. Если будут участвовать только страны-союзники, настоящего символа мира из Олимпийских игр не получится. У человечества не так уж и много возможностей объединиться.\r\n\r\nЯ обращаюсь к вам, лидеры G20, с просьбой услышать мой призыв к миру и дать ему шанс. Пожалуйста, включите свою нейтральность в отношении спорта в совместное заявление по итогам саммита», – сказал Бах. ", "", user, 3);
            CreatePost("«Думал о самоубийстве каждый день». Бен Гордон стал кумиром Чикаго после Джордана, а сейчас сходит с ума и бросается на людей", "Удивительно, но решение ментальных проблем у спортсменов часто рассматривается через оптику их состоятельности и медийной популярности. В действительности причиной серьезного психического расстройства может стать все что угодно, даже те качества, которые люди некогда расценивали как свои наиболее сильные. Именно так случилось с Беном Гордоном: он проделал путь от одной из главных надежд «Чикаго» пост-Джордановской эпохи до неврастеника, сомневающегося в реальности своего существования.", "https://s5o.ru/storage/simple/ru/edt/27/c5/b4/14/rue66bf27df8b.jpg", user, 4);
            CreatePost("Стал алкоголиком в 13 лет, бросил школу и принял ислам: безумный путь соперника Адесаньи к титулу UFC", "Алекс Перейра – титулованный кикбоксер, который сперва стал двойным чемпионом топовой организации Glory, а в 35 лет вышел на титульник UFC. Утром воскресенья бразилец подерется за пояс против Исраэля Адесаньи, которого дважды побеждал еще в Glory.\r\n\r\nПеред громким турниром мы вспомнили тернистый путь Перейры к вершине. Путь, на котором он сражался не только с соперниками, но и с внутренними демонами. ", "https://s5o.ru/storage/simple/ru/edt/32/28/17/21/rue0d1fd84dd8.jpg", user, 5);


        }
        public void CreatePost(string title, string description, string imageLink, User user, int disciplineId)
        {
            if (user == null || title == null)
                throw new ArgumentNullException();

            var post = new Post(posts.Count + 1, title, DateTime.Now, description, user, imageLink, Discipline.GetById(disciplineId));

            posts.Add(post);
        }
        public List<Post> GetPosts()
        {
            return posts.OrderByDescending(x => x.Created).ToList();
        }
        public void RemovePost(int id)
        {
            var post = GetById(id);
            posts.Remove(post);
        }
        public Post GetById(int id)
        {
            return posts.Single(post => post.Id == id);
        }
    }
}