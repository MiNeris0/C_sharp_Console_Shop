using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Shop
{
    public class ShopFiller
    {
        private string[] _names;
        private ProductType[] _types;
        private string[] _descriptions;
        private int[] _prices;
        private int[] _id;

        public ShopFiller()
        {
            _names = new string[50];
            _types = new ProductType[50];
            _descriptions = new string[50];
            _prices = new int[50];
            _id = new int[50];
            GetNames(ref _names);
            GetTypes(ref _types);
            GetDescriptions(ref _descriptions);
            GetPrices(ref _prices);
            GetId(ref _id);
        }

        public Product GetProduct(int i, Product _product)
        {
            _product.ProductName = _names[i];
            _product.Type = _types[i];
            _product.ProductDescription = _descriptions[i];
            _product.Price = _prices[i];
            _product.ProductId = _id[i];

            return _product;
        }

        private void GetNames( ref string[] _names)
        {
            _names[0] = "Memories of 1917-1918";
            _names[1] = "The Templars. The birth and death of the order";
            _names[2] = "Hitler and Stalin. Tyrants and the Second World War";
            _names[3] = "Homo sapiens. A brief history of mankind";
            _names[4] = "History of the world from ancient times to the present";
            _names[5] = "The long XIX century: resistance to assimilation";
            _names[6] = "Ukrainian Junkershafts: Training of the Ukrainian officer corps in the SS";
            _names[7] = "An outline of the history of the Ukrainian people";
            _names[8] = "The Cossack Wars of the Late 16th Century in Ukraine";
            _names[9] = "Children of Targitai. Scythian army and wars of the VII-III centuries BC.";
            _names[10] = "Sanguinius: The Great Angel";
            _names[11] = "Rogal Dorn: The Emperor's Crusader";
            _names[12] = "Mortarion: The Pale King";
            _names[13] = "Alpharius: Head of the Hydra";
            _names[14] = "Lion El Jonson: Lord of the First";
            _names[15] = "Sigismund: The Eternal Crusader";
            _names[16] = "Renegades of the Long War";
            _names[17] = "Angron: The Red Angel";
            _names[18] = "Kasrkin";
            _names[19] = "Awakenings";
            _names[20] = "Tides of Darkness";
            _names[21] = "Rise of the Horde";
            _names[22] = "Arthas - Rise of the Lich King";
            _names[23] = "Diablo: Legacy of Blood";
            _names[24] = "The Shattering: Book One of Cataclysm";
            _names[25] = "War Crimes";
            _names[26] = "Jaina Proudmoore: Tides of War";
            _names[27] = "Thrall: Twilight of the Aspects";
            _names[28] = "Wolfheart";
            _names[29] = "Night of the Dragon";
            _names[30] = "The Republic";
            _names[31] = "The art of war";
            _names[32] = "Dialogues";
            _names[33] = "So said Zarathustra";
            _names[34] = "The will to power";
            _names[35] = "Seneca Moral letters to Lucilius";
            _names[36] = "Principles of warfare";
            _names[37] = "Philosophy of the sacred";
            _names[38] = "Marcus Aurelius. Alone with myself";
            _names[39] = "Two treatises on government";
            _names[40] = "The dream of Rome";
            _names[41] = "Why do nations decline? The origin of power, wealth and poverty";
            _names[42] = "Political order in changing societies";
            _names[43] = "In high technology camps. How do minorities live in China?";
            _names[44] = "Foreign policy in the era of transformations";
            _names[45] = "The Prince";
            _names[46] = "About public administration in China. Volume 1";
            _names[47] = "National system of political economy";
            _names[48] = "How to build relations with Asian countries";
            _names[49] = "Trump and the post-truth era";
        }

        private void GetTypes(ref ProductType[] _types)
        {  
            for (int i = 0; i < _types.Length; i++)
            {
                if (i < 10)
                {
                    _types[i] = ProductType.History;
                }
                else if (i >= 10 && i < 20)
                {
                    _types[i] = ProductType.SciFi;
                }
                else if (i >= 20 && i < 30)
                {
                    _types[i] = ProductType.Fantasy;
                }
                else if (i >= 30 && i < 40)
                {
                    _types[i] = ProductType.Philosophy;
                }
                else
                {
                    _types[i] = ProductType.Politics;
                }
            }
        }

        private void GetDescriptions(ref string[] _descriptions)
        {
            _descriptions = new string[50];
            _descriptions[0] = "It was the fourth year of the World War. Tired of the events, Lieutenant General Pavlo Skoropadsky of the Russian Imperial Army, a descendant of an ancient foreman's family, did not know that he would become the hetman of an independent Ukrainian state. The era of change that revolutionaries of all stripes were suicidally bringing about turned into an apocalypse, a war of all against all, but Skoropadsky had the courage to take on the thankless task of state-building. The attempt ended in complete and expected failure, but some of the hetman's initiatives have survived to this day.";
            _descriptions[1] = "The Templars were one of the many religious orders that arose in Europe and the East during the Middle Ages, but without a doubt the most famous and mysterious. From humble beginnings, the Order of the Temple quickly grew into the most powerful organization of its time, with its knights becoming semi-legendary figures. The destruction of the order at the beginning of the XIV century shocked the Christian world. The end of the Templars came so suddenly and was so cruel that it gave rise to new legends about them.";
            _descriptions[2] = "Two 20th century tyrants stand apart from all the rest in terms of their ruthlessness and the degree to which they changed the world around them. Briefly allies during World War II, Adolph Hitler and Josef Stalin then tried to exterminate each other in sweeping campaigns unlike anything the modern world had ever seen, affecting soldiers and civilians alike. Millions of miles of Eastern Europe were ruined in their fight to the death, millions of lives sacrificed.";
            _descriptions[3] = "This short history of mankind is not a traditional chronological list of events and rulers, as seen in many textbooks and popular science publications. Yuval Noah Harari gradually reveals to the reader how Homo sapiens evolved from an unremarkable ape species into a Human being and reached the current heights of economic, technological, and intellectual development. ";
            _descriptions[4] = "This lavishly illustrated and thoroughly researched volume analyzes a millennia-long period of human history: prehistory and theories of human origins, the rise of agriculture in the Nile Valley and the emergence of states in the Middle Kingdom, the fall of ancient Rome and the development of science in the Islamic world, international trade along the Great Silk Road and the Enlightenment, world wars and revolutions of the modern era, and contemporary issues. ";
            _descriptions[5] = "The monograph covers the history of Ukraine in the nineteenth century, comprehensively examines the main aspects of the historical development of the Ukrainian people, including the issues of social and political system, economy, and culture. A prominent place is occupied by the coverage of the formation of social and political movements in Greater Ukraine and Galicia. The author convincingly demonstrates that for a number of reasons the national-state tradition did not become dominant in Ukrainian society in the nineteenth century. It gave way to the nationalist concepts of Ukraine's national development.";
            _descriptions[6] = "In 1943-1945, the Germans invested considerable resources in the training of Ukrainian officers of the SS Volunteer Division \"Galicia\". At that time, in the eyes of many patriotic Ukrainians, this division looked like the germ of the future Ukrainian army. And the backbone of any army is its officer corps, which Ukrainians did not have at the beginning of the war. This was the reason why several hundred volunteers from Ukraine were sent to various German officer training courses, which resulted in hundreds of Ukrainians receiving officer ranks in the SS.";
            _descriptions[7] = "The book covers the thousand-year history of Ukrainians from prehistoric times and the princely period to the era of the modern Ukrainian revival in the nineteenth and early twentieth centuries. Original interpretations of the most important historical events and characteristics of prominent figures of national history are the most detailed and comprehensive study of the formation and development of the Ukrainian people.";
            _descriptions[8] = "The book is dedicated to the first and one of the largest Cossack movements in the history of Ukraine. It examines in detail the causes of the Polish-Cossack conflict, the uprising of Kryshtof Kosinski in 1591-1593, the Moldavian campaigns of 1594-1595, international contacts of the Cossacks, their activities in Ukraine and Belarus in the winter of 1595-1596, the course of the Polish-Cossack war in the spring of 1596, and the impact of the Cossack wars of the late sixteenth century on public consciousness.";
            _descriptions[9] = "The Scythian horsemen controlled vast areas, subjugated various peoples, and raided neighboring lands. From this book, you will learn who the Scythian warriors were, how and with what they fought, whether Scythian Amazons really existed, and whether the Scythians were the oldest cataphracts - the heavy armored cavalry of Eurasia. The publication describes Scythian weapons, scaly armor, and trophy helmets of Scythian warriors.";
            _descriptions[10] = "Sanguinius, the very image of an angel, has chosen to obscure the origins of his Legion, and prevents outsiders from setting foot on his home world. A remembrancer attempts to discover why.";
            _descriptions[11] = "The Master of Mankind tasks four primarchs with the dangerous mission of securing the worlds of the Occluda Noctis – hundreds of star systems on the far side of the Northern Major Warp Storm, whose warp-churning presence casts a shadow on the guiding light of the Astronomican and blinds even the Emperor’s psychic sight. Rogal Dorn leads his Imperial Fists directly into the heart of this cosmic twilight. Isolated, battling a foe the likes of which nobody has encountered before, Dorn must use all of his strategic genius and irresistible will to conquer the darkness in the name of the Emperor.";
            _descriptions[12] = "Mortarion, newly uplifted to commander of the Death Guard, descended upon the world, and with him came a slaughter of untold proportions. The sheer brutality of Mortarion’s campaign left the Imperium appalled. Seeking to understand its horrors, two noble primarchs have come to Galaspar, summoning their brother to account for his actions. But the Pale King brooks no challenge to his methods, for when the scythe falls, it reaps a gruesome toll.";
            _descriptions[13] = "Legends abound of the glorious – or infamous – deeds of the Emperor's sons. Yet almost nothing is known of Alpharius, the most mysterious of them all, for the Lord of the Alpha Legion is unparalleled in the art of obfuscation. Such are his gifts of secrecy and deceit that even his rediscovery has remained an enigma – until now.";
            _descriptions[14] = "Lion El’Jonson is the paragon of what it is to be a primarch. His Legion, pre-eminent for most of their long history, typify the virtues of temperance, pride, and martial excellency that the Lion embodies. They are the Emperor’s last line and final sanction. They are His Dark Angels. Now, while the Emperor gathers His mightiest sons for an assault on Ullanor Prime, the Lord of the First instead draws his Legion to the farthest reaches of the known galaxy, seeking to subdue a single rebellious world.";
            _descriptions[15] = "As the Imperial armies fight the final battles of the age, Remembrancer Solomon Voss seeks the answer to one question – why does Sigismund, First Captain of the Imperial Fists and greatest champion of the Legions, believe that war will not end?";
            _descriptions[16] = "The Long War has raged for 10,000 years, and the traitorous champions of the World Eaters, Emperor’s Children, and Alpha Legion have been fighting in it without pause. There are many paths to damnation, and these novels explore just a few of them, chronicling the exploits of notorious renegades from the Traitor Legions.";
            _descriptions[17] = "In the darkness of Imperium Nihilus, across half a million worlds cut off from the dim light of Holy Terra, a beacon is lit. The Red Angel returns to an unsteady galaxy and his scattered sons heed the call to slaughter. Aboard the World Eaters’ flagship, Kossolax the Foresworn, self-appointed lord regent of the XII, fights to keep the old dreams of the Legion alive, but finds the return of his hated father both an opportunity and a threat to the warriors’ fragile unity.";
            _descriptions[18] = "An elite squad of Cadian Kasrkin are tasked with a critical mission behind enemy lines. They must rescue their general in xenos-held territory before his dangerous knowledge falls into enemy hands. But not all is as it seems…";
            _descriptions[19] = "Inquisitor Astor Sabbathiel has a problem: she’s been dead for nearly a hundred years… or so everyone believes. The last thing she remembers is being shot at point-blank range just as a roiling warp storm engulfed the Calaphrax Cluster. Now, she finds herself awakening on a distant Ecclesiarchy stronghold and indebted to a magos called Metik, who has brought her back from the brink of death.";
            _descriptions[20] = "After killing the corrupt Warchief Blackhand, Orgrim Doomhammer was quick to seize control over the Orcish Horde. Now he is determined to conquer the rest of Azeroth so that his people will once again have a home of their own in the... Anduin Lothar, former Champion of Stormwind, has left his shattered homeland behind and led his people across the Great Sea to the shores of Lordaeron. There, with the aid of the noble King Terenas, he forges a mighty Alliance with the other human nations.";
            _descriptions[21] = "Though the young Warchief Thrall ended the demon curse that had plagued his people for generations, the orcs still wrestle with the sins of their bloody past. As the rampaging Horde, they waged a number of devastating wars against their perennial enemy - the Alliance. Yet the rage and bloodlust that drove the orcs to destroy everything in their path nearly consumed them as well. Long ago, on the idyllic world of Draenor, the noble orc clans lived in relative peace with their enigmatic neighbors, the draenei. ";
            _descriptions[22] = "When a plague of undeath threatened all that he loved, Arthas was driven to pursue an ill-fated quest for a runeblade powerful enough to save his homeland. Yet the object of his search would exact a heavy price from its new master, beginning a horrifying descent into damnation. Arthas's path would lead him through the arctic northern wastes toward the Frozen Throne, where he would face, at long last, the darkest of destinies.";
            _descriptions[23] = "Since the beginning of time, the angelic hosts of the High Heavens and the demonic hordes of the Burning Hells have been locked in a struggle for the fate of all creation. That struggle has now come to the mortal realm...and neither man nor demon nor angel will be left unscathed....";
            _descriptions[24] = "Thrall, wise shaman and the war chief of the Horde, has sensed a disturbing change . . . Long ago, Azeroth's destructive native elementals raged across the world until the benevolent titans imprisoned them within the Elemental Plane. Despite the titans' intervention, many elementals have ended up back on Azeroth. Over the ages, shaman like Thrall have communed with these spirits and, through patience and dedication, learned to soothe roaring infernos, bring rain to sun-scorched lands, and otherwise temper the elementals' ruinous influence on the world of Azeroth. Now Thrall has discovered that the elementals no longer heed the shaman's call.";
            _descriptions[25] = "The brutal siege of Orgrimmar is over. Alliance and Horde forces have stripped Garrosh Hellscream, one of the most reviled figures on Azeroth, of his title as warchief. His thirst for conquest devastated cities, nearly tore the Horde apart, and destroyed countless lives throughout the World of Warcraft. Now, on the legendary continent of Pandaria, he will stand trial for his transgressions.";
            _descriptions[26] = "What does it take to turn the peacekeeper into a warmonger? Jaina Proudmoore: Tides of War gives World of Warcraft fans the opportunity to see what happens when a beloved peacekeeper is pressed to the limit by an inconceivable horror. Will it change her forever? Break her? Or redefine her role on Azeroth? Do different times call for different ethical standards?";
            _descriptions[27] = "More than 10,000 years ago, a betrayal by the maddened black Dragon Aspect, Deathwing, shattered the strength and unity of the dragonflights. His most recent assault on Azeroth—the Cataclysm—has left the world in turmoil. At the Maelstrom, the center of Azeroth's instability, former Horde warchief Thrall and other accomplished shaman struggle to keep the world from tearing apart in the wake of Deathwing's attack. Yet a battle also rages within Thrall regarding his new life in the shamanic Earthen Ring, hampering his normally unparalleled abilities.";
            _descriptions[28] = "Wolfheart is the story of King Varian Wrynn's struggle to accept the worgen of Gilneas into the Alliance and come to terms with the wolf within himself. As the Horde threat emerges in Ashenvale, Varian's ability to triumph over his own failings will determine the fate of the entire Alliance.";
            _descriptions[29] = "Grim Batol: Its dark legacy stretches back into the mists of Azeroth's past. But most know it as the site of a terrible tragedy - where the vile orcs corrupted the hatchlings of the noble Dragonqueen, Alexstrasza, and used them as weapons of war. Though a band of heroes, led by the enigmatic mage, Krasus, defeated the orcs and freed the captive dragons, the cursed mountain stands as another ravaged landmark within the....";
            _descriptions[30] = "In this work, Plato presents his own concept of the ideal state, which has been hotly debated in all ages and has had both ardent supporters and equally ardent detractors. Written in the 360-370s BC, Plato's Republic remains one of the most controversial, original, and daring political treatises in human history. It is not surprising that Plato's work has been a source of a wide variety of ideas and inspiration for scientific research since its creation to this day.";
            _descriptions[31] = "Sun Tzu's book \"The Art of War\" is rightly considered to be the true source of Eastern wisdom. The book \"The Art of War\" by the Chinese philosopher Sun Tzu teaches, first of all, strategies, tactics and methods of negotiation, which are considered classic in China and Chinese philosophical thought.";
            _descriptions[32] = "Plato is considered not only a philosopher, but also a great writer of antiquity. He is most famous as a master of dialogue. The conversation in most dialogues is conducted by Plato's teacher Socrates, who effortlessly leads the interlocutors to deep philosophical conclusions and at the same time gives the reader the opportunity to independently search for the truth...";
            _descriptions[33] = "The themes of good and evil, superhumans, revaluation of all values are embodied in this monument of world literature in a mythical-symbolic, highly poetic form.";
            _descriptions[34] = "The Desire for Power is Nietzsche's last work, an ardent apology for man, a protest against all forms of spiritual slavery, including religious slavery.";
            _descriptions[35] = "Lucius Annaeus Seneca was a Roman philosopher and writer, an outstanding representative of Stoicism. In his \"Moral Letters to Lucilius\" there are appeals to live in harmony with nature, steadfastly bear the blows of fate, and follow the path of constant spiritual improvement. Philosophical and ethical views developed in \"Letters\" belong to the origins of Christian ideology.";
            _descriptions[36] = "In his book, the author comprehensively examines the nature of war, emphasizing the decisive importance of military genius in the outcome of the battle. Clearly and clearly explaining the importance of the war plan, the relationship between war and politics, the strategy and tactics of warfare, including the organization of battle, the types and methods of attack and defense, Clausewitz defines and explains the terms of professional military language, giving his book the character of an excellent reference guide. .";
            _descriptions[37] = "You and I have no idea what depths Ukrainian philosophical thought reaches. From the reinterpretation of historical eras to the formation of a full-blooded worldview doctrine and the sacralization of its individual elements - this is exactly the spectrum of thoughts that the reader of this book can grasp. We present to your attention a unique work for those who want to know the depth of Ukrainian philosophy, distancing themselves from the consumerist world of simplified illusions.";
            _descriptions[38] = "In the literature of medieval Byzantium, the pagan Mark Aurelius appears as a sage knowledgeable in many sciences and a righteous man full of virtues, who lacks little to convert to the true faith. Renaissance Europe saw in Marcus Aurelius a perfect example of a humanist ruler, whose prudence in managing the state is based on comprehensive education and a philanthropic outlook.";
            _descriptions[39] = "John Locke is the father of political liberalism, he wrote a work in which he questioned the divinity of the monarch's power. Moreover, he argued that power depends on human will and is subject to natural law. His views changed the constitution of a number of countries, including the United States: American ideas of freedom originate from Locke's philosophy.";
            _descriptions[40] = "The Dreamed Rome is a book by politician, journalist, and former British Prime Minister Boris Johnson, in which he describes how the Roman Empire achieved political and cultural unity in Europe and compares it to what he sees as the European Union's failure to do the same.";
            _descriptions[41] = "Why are some nations rich and others poor? What are the criteria for determining this? prosperity and poverty, high and low levels of health care, sufficient food and lack of it? What is the reason for this-culture, climatic conditions, geography, or perhaps wrong policies? There are nations in the world that have not been able to succeed throughout their history. Instead, we see other countries that are constantly growing and developing, and their living standards are much higher than others.";
            _descriptions[42] = "The book is dealing with the role of political institutions in changing political systems. Huntington stated that ”the most important political distinction among countries concerns not their form of government but their degree of government”.";
            _descriptions[43] = "More than a million and a half Uyghurs and other ethnic minorities have disappeared into internment camps and related factories due to new forms of state violence and colonization that have been unfolding in China's vast northwestern region for years. Darren Byler reveals how a vast web of technology provided by private companies -- facial surveillance, voice recognition and other smartphone data -- has allowed the state and corporations to blacklist more than a million Uyghurs because of their religious and cultural practices since 2017.";
            _descriptions[44] = "The world has entered a period of global transformations, the main features of which are a crisis of leadership, nationalism and populism, mutual distrust, unprecedented inequality in the distribution of public goods, and the primacy of force over law. Ukraine has become an arena of conflicts of interests of global world players. However, in the times of radical changes, opportunities are opening up for our country to overcome the path from the tragic past to the dream future.";
            _descriptions[45] = "16th-century political treatise written by Italian diplomat and political theorist Niccolò Machiavelli as an instruction guide for new princes and royals. The general theme of The Prince is of accepting that the aims of princes – such as glory and survival – can justify the use of immoral means to achieve those ends.";
            _descriptions[46] = "At the XIX Congress of the CPC, Xi Jinping's idea of socialism with Chinese characteristics of the new era was approved as the guiding ideology that the party will adhere to in the long term. In this way, a new ideological leap was made in unison with the movement of time, a clear roadmap was provided for decisive actions to fully build a middle-class society, to start a new campaign for the comprehensive construction of a socialist modernized state, and the realization of the great revival of the Chinese nation. Xi Jinping is the main creator of the idea of socialism with Chinese characteristics of the new era.";
            _descriptions[47] = "The author explored the almost thousand-year period of Western civilization: from the rise of Venice, Genoa and Florence to the world power of the British Empire and the first steps of the United States that challenged the British. The letter proves that powerful countries have implemented similar economic policies that can be replicated and scaled. As a German patriot, he proposes in the book a plan of measures for the economic revival of Germany, and as a statesman, he initiates the creation of the German Trade and Industry Union.";
            _descriptions[48] = "Asia is the largest continent in terms of territory and population, with a complex history and a turbulent present. The Asian vector of Ukraine's foreign policy requires an understanding of the peculiarities of the states of this region and a strategy for building relations with them on the basis of common interests. In this book, the author summarizes his observations on economic, social and cultural features that will help to create a complete picture of what interaction with the countries of Southeast and East Asia can be like.";
            _descriptions[49] = "We are in a strange new world of post-truth, fake news and anxiety. In this book, American philosopher and spiritual leader Ken Wilber offers a conceptual key to understanding contemporary political and cultural events. Do not be confused by the fact that it is written for Americans on American material: the conceptual apparatus proposed by the author and the political phenomena he writes about are universal. In overseas realities, you will recognize many domestic ones.";
        }

        private void GetPrices(ref int[] _prices)
        {
            _prices[0] = 350;
            _prices[1] = 471;
            _prices[2] = 495;
            _prices[3] = 450;
            _prices[4] = 903;
            _prices[5] = 430;
            _prices[6] = 479;
            _prices[7] = 332;
            _prices[8] = 414;
            _prices[9] = 180;
            _prices[10] = 483;
            _prices[11] = 527;
            _prices[12] = 650;
            _prices[13] = 488;
            _prices[14] = 399;
            _prices[15] = 690;
            _prices[16] = 950;
            _prices[17] = 860;
            _prices[18] = 1050;
            _prices[19] = 1200;
            _prices[20] = 665;
            _prices[21] = 424;
            _prices[22] = 513;
            _prices[23] = 316;
            _prices[24] = 804;
            _prices[25] = 915;
            _prices[26] = 390;
            _prices[27] = 472;
            _prices[28] = 630;
            _prices[29] = 1387;
            _prices[30] = 584;
            _prices[31] = 186;
            _prices[32] = 270;
            _prices[33] = 344;
            _prices[34] = 219;
            _prices[35] = 648;
            _prices[36] = 713;
            _prices[37] = 465;
            _prices[38] = 324;
            _prices[39] = 325;
            _prices[40] = 240;
            _prices[41] = 455;
            _prices[42] = 599;
            _prices[43] = 334;
            _prices[44] = 241;
            _prices[45] = 420;
            _prices[46] = 900;
            _prices[47] = 469;
            _prices[48] = 254;
            _prices[49] = 287;
        }

        private void GetId(ref int[] _id)
        {
            for (int i = 0, j = 1; i < _id.Length; i++, j++)
            {
                _id[i] = j;
            }
        }
    }
}
