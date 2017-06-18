using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IndoWars.Models
{
    public class WarsContextSeedData
    {
        private WarsContext _context;
        private UserManager<DbUser> _userManager;

        public WarsContextSeedData(WarsContext context,
                                    UserManager<DbUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task EnsureSeedData()
        {
            if (await _userManager.FindByEmailAsync("louisvernando28@gmail.com") == null)
            {
                var user = new DbUser()
                {
                    UserName = "louisvpr",
                    Email = "louisvernando28@gmail.com",
                    ChapterProgress = 0

                };
                await _userManager.CreateAsync(user, "louis321");
            }

            if (!_context.News.Any())
            {
                var initNews = new News()
                {
                    Date = Convert.ToDateTime("15/06/2016"),
                    Description = "First Development",
                    Type = "Development"
                };
                _context.News.Add(initNews);

                var SecondNews = new News()
                {
                    Date = Convert.ToDateTime("01/05/2017"),
                    Description = "Finalizing Application Logic",
                    Type = "Development"
                };
                _context.News.Add(SecondNews);

                var ThirdNews = new News()
                {
                    Date = Convert.ToDateTime("01/10/2017"),
                    Description = "Finalizing Chapter & Design",
                    Type = "Development"
                };
                _context.News.Add(ThirdNews);

                var FourthNews = new News()
                {
                    Date = DateTime.UtcNow,
                    Description = "Publishing in Internet Environment",
                    Type = "Development"
                };
                _context.News.Add(FourthNews);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    
                }
                
            }

            if (!_context.QIntroductions.Any())
            {
                var question1 = new qIntroduction()
                {
                    Questions = "Siapakah Ketua Uni-Soviet yang menandatangani Perjanjian Gencatan Senjata Jerman-Soviet?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction(){ Choices = "A", Text = "Joseph Stalin"},
                        new aIntroduction(){ Choices = "B", Text = "Joe Taslim"},
                        new aIntroduction(){ Choices = "C", Text = "John Pepper"},
                        new aIntroduction(){ Choices = "D", Text = "John Cena"}
                    },
                    RightChoices = "A"
                };
                _context.QIntroductions.Add(question1);
                _context.AIntroductions.AddRange(question1.Answer);

                var question2 = new qIntroduction()
                {
                    Questions = "Setelah menjadi Reich Chancellor pada tahun 1933, Hitler menyatakan dirinya sebagai?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction() {Choices = "A", Text = "Flugel"},
                        new aIntroduction() {Choices = "B", Text = "Fuhrer"},
                        new aIntroduction() {Choices = "C", Text = "Aryan"},
                        new aIntroduction() {Choices = "D", Text = "Lebensraum"}
                    },
                    RightChoices = "B"
                };
                _context.QIntroductions.Add(question2);
                _context.AIntroductions.AddRange(question2.Answer);

                var question3 = new qIntroduction()
                {
                    Questions = "Buku 'Mein Kampf' yang ditulis oleh hitler, memprediksi bahwa Perang Eropa akan membawa?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction() { Choices = "A", Text = "Kesepakatan perjanjian dengan Uni-Soviet dalam Invasi"},
                        new aIntroduction() { Choices = "B", Text = "Pemusnahan etnik komunis di Jerman"},
                        new aIntroduction() { Choices = "C", Text = "Pengangkatan jabatan hitler menjadi 'Reich Chancellor'"},
                        new aIntroduction() { Choices = "D", Text = "Pemusnahan ras Yahudi di Jerman"}
                    },
                    RightChoices = "D"
                };
                _context.QIntroductions.Add(question3);
                _context.AIntroductions.AddRange(question3.Answer);

                var question4 = new qIntroduction()
                {
                    Questions = "Pada tahun berapakah, Hitler mulai mempersiapkan persenjataan Jerman untuk memulai invasinya?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction() {Choices = "A", Text = "1930"},
                        new aIntroduction() {Choices = "B", Text = "1932"},
                        new aIntroduction() {Choices = "C", Text = "1934"},
                        new aIntroduction() {Choices = "D", Text = "1938"}
                    },
                    RightChoices = "A"
                };
                _context.QIntroductions.Add(question4);
                _context.AIntroductions.AddRange(question4.Answer);

                var question5 = new qIntroduction()
                {
                    Questions = "Pada tahun berapakah, Perjanjian Gencatan Senjata Jerman-Soviet ditandatangani?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction() {Choices = "A", Text = "1937"},
                        new aIntroduction() {Choices = "B", Text = "1940"},
                        new aIntroduction() {Choices = "C", Text = "1939"},
                        new aIntroduction() {Choices = "D", Text = "1938"}
                    },
                    RightChoices = "C"
                };
                _context.QIntroductions.Add(question5);
                _context.AIntroductions.AddRange(question5.Answer);

                var question6 = new qIntroduction()
                {
                    Questions = "Perang apakah yang menjadi titik balik bagi armada U.S untuk melancarkan serangan balasan pada jepang di Pasifik?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction() {Choices = "A", Text = "Battle of Solomon"},
                        new aIntroduction() {Choices = "B", Text = "Battle of Midway"},
                        new aIntroduction() {Choices = "C", Text = "Operation Balbarossa"},
                        new aIntroduction() {Choices = "D", Text = "Battle of Postdam"}
                    },
                    RightChoices = "B"
                };
                _context.QIntroductions.Add(question6);
                _context.AIntroductions.AddRange(question6.Answer);

                var question7 = new qIntroduction()
                {
                    Questions = "Dalam Operasi Barbarossa yang dilakukan oleh hitler, Pasukan Jerman melakukan invasi kepada negara?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction() {Choices = "A", Text = "Balkan"},
                        new aIntroduction() {Choices = "B", Text = "Yunani"},
                        new aIntroduction() {Choices = "C", Text = "United States"},
                        new aIntroduction() {Choices = "D", Text = "Uni-Soviet"}
                    },
                    RightChoices = "D"
                };
                _context.QIntroductions.Add(question7);
                _context.AIntroductions.AddRange(question7.Answer);

                var question8 = new qIntroduction()
                {
                    Questions = "Apakah sebutan lain untuk Magiot Line, sebuah benteng yang menghalangi operangi 'Blitzkrieg' Hitler?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction() {Choices = "A", Text = "The Unmovable Barrier"},
                        new aIntroduction() {Choices = "B", Text = "Impenetrable Defensive Barrier"},
                        new aIntroduction() {Choices = "C", Text = "Absolute Defensive Line"},
                        new aIntroduction() {Choices = "C", Text = "Impenetrable Defensive Line"}
                    },
                    RightChoices = "B"
                };
                _context.QIntroductions.Add(question8);
                _context.AIntroductions.AddRange(question8.Answer);

                var question9 = new qIntroduction()
                {
                    Questions =
                        "Siapakah pahlawan Perang Dunia I Perancis yang menjadi Pemerintah Paris, saat perancis dibagi menjadi 2 bagian?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction() {Choices = "A", Text = "Joseph Stalin"},
                        new aIntroduction() {Choices = "B", Text = "Harry S. Truman"},
                        new aIntroduction() {Choices = "C", Text = "Philippe Petain"},
                        new aIntroduction() {Choices = "D", Text = "Louis Vernando"}
                    },
                    RightChoices = "C"
                };
                _context.QIntroductions.Add(question9);
                _context.AIntroductions.AddRange(question9.Answer);

                var question10 = new qIntroduction()
                {
                    Questions =
                        "Di ujung timur Peta Perang Dunia II, terdapat satu pertempuran yang diakui oleh dunia sebagai salah satu pertempuran terganas yang pernah dilakukan, Perang apakah itu?",
                    Answer = new List<aIntroduction>()
                    {
                        new aIntroduction() {Choices = "A", Text = "Battle of Axis"},
                        new aIntroduction() {Choices = "B", Text = "Attack on Pearl Harbor"},
                        new aIntroduction() {Choices = "C", Text = "Battle of Stalingard"},
                        new aIntroduction() {Choices = "D", Text = "Battle of Bulge"}
                    },
                    RightChoices = "C"
                };
                _context.QIntroductions.Add(question10);
                _context.AIntroductions.AddRange(question10.Answer);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {

                }
            }

            if (!_context.QHindiaBelanda.Any())
            {
                var question1 = new qHindiaBelanda()
                {
                    Questions = "Hindia Belanda merupakan salah satu target utama jepang, saat pertama kali Perang Dunia II dimulai. Apa alasannya?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda(){ Choices = "A", Text = "Kekayaan Rempah-rempahnya"},
                        new aHindiaBelanda(){ Choices = "B", Text = "Sumber daya minyaknya"},
                        new aHindiaBelanda(){ Choices = "C", Text = "Pengrajin besi dan tambang yang melimpah"},
                        new aHindiaBelanda(){ Choices = "D", Text = "Karena Belanda menduduki wilayah ini"}
                    },
                    RightChoices = "B"
                };
                _context.QHindiaBelanda.Add(question1);
                _context.AHindiaBelanda.AddRange(question1.Answer);

                var question2 = new qHindiaBelanda()
                {
                    Questions = "Negara apakah yang dianggap Jepang sebagai musuh terakhirnya, dengan harapan mereka tidak menyerang jepang terlebih dahulu?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda() {Choices = "A", Text = "America"},
                        new aHindiaBelanda() {Choices = "B", Text = "Belanda"},
                        new aHindiaBelanda() {Choices = "C", Text = "Inggris"},
                        new aHindiaBelanda() {Choices = "D", Text = "China"}
                    },
                    RightChoices = "B"
                };
                _context.QHindiaBelanda.Add(question2);
                _context.AHindiaBelanda.AddRange(question2.Answer);

                var question3 = new qHindiaBelanda()
                {
                    Questions = "Perang apakah yang menjadi penyerangan pertama pasukan jepang dari Hindia Belanda?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda() { Choices = "A", Text = "Perang Borneo"},
                        new aHindiaBelanda() { Choices = "B", Text = "Perang Manado"},
                        new aHindiaBelanda() { Choices = "C", Text = "Perang Tarakan"},
                        new aHindiaBelanda() { Choices = "D", Text = "Perang Sarawak"}
                    },
                    RightChoices = "A"
                };
                _context.QHindiaBelanda.Add(question3);
                _context.AHindiaBelanda.AddRange(question3.Answer);

                var question4 = new qHindiaBelanda()
                {
                    Questions = "Pada perang borneo pasukan Jepang berniat untuk mengambil alih beberapa daerah dibawah ini, kecuali?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda() {Choices = "A", Text = "Kalimantan Barat"},
                        new aHindiaBelanda() {Choices = "B", Text = "Borneo Utara"},
                        new aHindiaBelanda() {Choices = "C", Text = "Borneo Selatan"},
                        new aHindiaBelanda() {Choices = "D", Text = "Kerajaan Sarawak"}
                    },
                    RightChoices = "c"
                };
                _context.QHindiaBelanda.Add(question4);
                _context.AHindiaBelanda.AddRange(question4.Answer);

                var question5 = new qHindiaBelanda()
                {
                    Questions = "Penyerangan Jepang pada perang borneo dimulai dengan pengambil alihan daerah?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda() {Choices = "A", Text = "Kuching"},
                        new aHindiaBelanda() {Choices = "B", Text = "Singkawang"},
                        new aHindiaBelanda() {Choices = "C", Text = "Lutong"},
                        new aHindiaBelanda() {Choices = "D", Text = "Miri"}
                    },
                    RightChoices = "D"
                };
                _context.QHindiaBelanda.Add(question5);
                _context.AHindiaBelanda.AddRange(question5.Answer);

                var question6 = new qHindiaBelanda()
                {
                    Questions = "Apakah nama kapal Destroyer Jepang yang berhasil ditenggelamkan oleh HNLMS K XVI pada malam 23-24 Desember?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda() {Choices = "A", Text = "Kawaguchi"},
                        new aHindiaBelanda() {Choices = "B", Text = "Hokkai Maru"},
                        new aHindiaBelanda() {Choices = "C", Text = "Sagiri"},
                        new aHindiaBelanda() {Choices = "D", Text = "Hiyoshi Maru"}
                    },
                    RightChoices = "C"
                };
                _context.QHindiaBelanda.Add(question6);
                _context.AHindiaBelanda.AddRange(question6.Answer);

                var question7 = new qHindiaBelanda()
                {
                    Questions = "Siapakah nama pasukan belanda yang mencoba untuk menyerang sumber pengiriman jepang dari 'Singkawa II' yang berakhir gagal?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda() {Choices = "A", Text = "Martin B-10"},
                        new aHindiaBelanda() {Choices = "B", Text = "K XIV"},
                        new aHindiaBelanda() {Choices = "C", Text = "HNLMS KIV"},
                        new aHindiaBelanda() {Choices = "D", Text = "Groenveld"}
                    },
                    RightChoices = "A"
                };
                _context.QHindiaBelanda.Add(question7);
                _context.AHindiaBelanda.AddRange(question7.Answer);

                var question8 = new qHindiaBelanda()
                {
                    Questions = "Kemanakah tujuan utama 'The Punjab Regiment' saat melarikan diri dari serangan jepang pada tanggal 25 desember?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda() {Choices = "A", Text = "Pangkalanbun"},
                        new aHindiaBelanda() {Choices = "B", Text = "Singkawang"},
                        new aHindiaBelanda() {Choices = "C", Text = "Lutong"},
                        new aHindiaBelanda() {Choices = "C", Text = "Kuching"}
                    },
                    RightChoices = "A"
                };
                _context.QHindiaBelanda.Add(question8);
                _context.AHindiaBelanda.AddRange(question8.Answer);

                var question9 = new qHindiaBelanda()
                {
                    Questions =
                        "Pada tanggal berapakah pasukan inggris dan belanda menyerah yang menandakan berakhirnya perang borneo?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda() {Choices = "A", Text = "1 Maret 1942"},
                        new aHindiaBelanda() {Choices = "B", Text = "2 Maret 1942"},
                        new aHindiaBelanda() {Choices = "C", Text = "2 April 1942"},
                        new aHindiaBelanda() {Choices = "D", Text = "1 April 1942"}
                    },
                    RightChoices = "D"
                };
                _context.QHindiaBelanda.Add(question9);
                _context.AHindiaBelanda.AddRange(question9.Answer);

                var question10 = new qHindiaBelanda()
                {
                    Questions =
                        "Pada tanggal berapakah, Belanda dengan proklamasi publiknya mendeklarasi perang terhadap jepang?",
                    Answer = new List<aHindiaBelanda>()
                    {
                        new aHindiaBelanda() {Choices = "A", Text = "10 Desember 1941"},
                        new aHindiaBelanda() {Choices = "B", Text = "10 November 1941"},
                        new aHindiaBelanda() {Choices = "C", Text = "8 Desember 1942"},
                        new aHindiaBelanda() {Choices = "D", Text = "8 Desember 1941"}
                    },
                    RightChoices = "D"
                };
                _context.QHindiaBelanda.Add(question10);
                _context.AHindiaBelanda.AddRange(question10.Answer);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {

                }
            }

            if (!_context.QTarakanBattle.Any())
            {
                var question1 = new qTarakanBattle()
                {
                    Questions = "Tarakan merupakan sebuah pulau kecil berbentuk?",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle(){ Choices = "A", Text = "Persegi"},
                        new aTarakanBattle(){ Choices = "B", Text = "Segitiga"},
                        new aTarakanBattle(){ Choices = "C", Text = "Rawa"},
                        new aTarakanBattle(){ Choices = "D", Text = "Bujur Sangkar"}
                    },
                    RightChoices = "B"
                };
                _context.QTarakanBattle.Add(question1);
                _context.ATarakanBattle.AddRange(question1.Answer);

                var question2 = new qTarakanBattle()
                {
                    Questions = "Berapa banyak tambang minyak yang dimiliki Tarakan sehingga diincar Jepang pada saat perang Pasifik?",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle() {Choices = "A", Text = "700"},
                        new aTarakanBattle() {Choices = "B", Text = "500"},
                        new aTarakanBattle() {Choices = "C", Text = "600"},
                        new aTarakanBattle() {Choices = "D", Text = "800"}
                    },
                    RightChoices = "A"
                };
                _context.QTarakanBattle.Add(question2);
                _context.ATarakanBattle.AddRange(question2.Answer);

                var question3 = new qTarakanBattle()
                {
                    Questions = "Apakah nama operasi yang dilakukan Australia untuk mengambil alih Tarakan pada tahun 1945?",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle() { Choices = "A", Text = "Operation Alba One"},
                        new aTarakanBattle() { Choices = "B", Text = "Operation Oboe One"},
                        new aTarakanBattle() { Choices = "C", Text = "Operation Holo One"},
                        new aTarakanBattle() { Choices = "D", Text = "Operation KNIL"}
                    },
                    RightChoices = "B"
                };
                _context.QTarakanBattle.Add(question3);
                _context.ATarakanBattle.AddRange(question3.Answer);

                var question4 = new qTarakanBattle()
                {
                    Questions = "Siapakah nama pasukan Australia yang mengamankan daerah 'Green Beach'?",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle() {Choices = "A", Text = "26th Brigade"},
                        new aTarakanBattle() {Choices = "B", Text = "32th Brigade"},
                        new aTarakanBattle() {Choices = "C", Text = "2/48th Battalion"},
                        new aTarakanBattle() {Choices = "D", Text = "2/23rd Battalion"}
                    },
                    RightChoices = "D"
                };
                _context.QTarakanBattle.Add(question4);
                _context.ATarakanBattle.AddRange(question4.Answer);

                var question5 = new qTarakanBattle()
                {
                    Questions = "Siapakah nama pasukan Australia yang mengamankan daerah 'Red Beach'?",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle() {Choices = "A", Text = "26th Brigade"},
                        new aTarakanBattle() {Choices = "B", Text = "32th Brigade"},
                        new aTarakanBattle() {Choices = "C", Text = "2/48th Battalion"},
                        new aTarakanBattle() {Choices = "D", Text = "2/23rd Battalion"}
                    },
                    RightChoices = "C"
                };
                _context.QTarakanBattle.Add(question5);
                _context.ATarakanBattle.AddRange(question5.Answer);

                var question6 = new qTarakanBattle()
                {
                    Questions = "Setelah Australia berhasil mengamankan Tarakan, apakah tanggapan warga Tarakan kepada Australia?",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle() {Choices = "A", Text = "Diktator"},
                        new aTarakanBattle() {Choices = "B", Text = "Dewa"},
                        new aTarakanBattle() {Choices = "C", Text = "Penjajah"},
                        new aTarakanBattle() {Choices = "D", Text = "Pembebas"}
                    },
                    RightChoices = "D"
                };
                _context.QTarakanBattle.Add(question6);
                _context.ATarakanBattle.AddRange(question6.Answer);

                var question7 = new qTarakanBattle()
                {
                    Questions = "Siapakah nama komandan yang memimpin Ekspedisi Australia pada perang Tarakan 1945?",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle() {Choices = "A", Text = "Martin Morrison"},
                        new aTarakanBattle() {Choices = "B", Text = "Samuel Milestain"},
                        new aTarakanBattle() {Choices = "C", Text = "Samuel Elliot Morrison"},
                        new aTarakanBattle() {Choices = "D", Text = "Joseph Stalin"}
                    },
                    RightChoices = "C"
                };
                _context.QTarakanBattle.Add(question7);
                _context.ATarakanBattle.AddRange(question7.Answer);

                var question8 = new qTarakanBattle()
                {
                    Questions = "Apakah yang dilakukan pasukan Australia saat kendaraannya terjebak di pantai?",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle() {Choices = "A", Text = "Memanggil Bantuan"},
                        new aTarakanBattle() {Choices = "B", Text = "Meninggalkannya"},
                        new aTarakanBattle() {Choices = "C", Text = "Mendorongnya hingga ke daratan"},
                        new aTarakanBattle() {Choices = "C", Text = "Menyalahkan komandan"}
                    },
                    RightChoices = "B"
                };
                _context.QTarakanBattle.Add(question8);
                _context.ATarakanBattle.AddRange(question8.Answer);

                var question9 = new qTarakanBattle()
                {
                    Questions =
                        "Sampai bulan apakah Tarakan dipegang oleh Jepang?",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle() {Choices = "A", Text = "Mei 1945"},
                        new aTarakanBattle() {Choices = "B", Text = "Maret 1945"},
                        new aTarakanBattle() {Choices = "C", Text = "April 1945"},
                        new aTarakanBattle() {Choices = "D", Text = "Februari 1945"}
                    },
                    RightChoices = "A"
                };
                _context.QTarakanBattle.Add(question9);
                _context.ATarakanBattle.AddRange(question9.Answer);

                var question10 = new qTarakanBattle()
                {
                    Questions =
                        "Kenapa pasukan Jepang mengeksekusi mati pasukan KNIL di Tarakan? ",
                    Answer = new List<aTarakanBattle>()
                    {
                        new aTarakanBattle() {Choices = "A", Text = "Karena menghancurkan instalasi minyak"},
                        new aTarakanBattle() {Choices = "B", Text = "Karena mencoba melawan tentara Jepang"},
                        new aTarakanBattle() {Choices = "C", Text = "Karena mengebom pesawat tempur Jepang secara diam-diam"},
                        new aTarakanBattle() {Choices = "D", Text = "Karena Jepang dendam terhadap belanda"}
                    },
                    RightChoices = "A"
                };
                _context.QTarakanBattle.Add(question10);
                _context.ATarakanBattle.AddRange(question10.Answer);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
