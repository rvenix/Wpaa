

using Builder;
using WarriorFactory;

var piechur1 = new PiechurBuilder("Piechur1");
var piechur1Post = new WarriorPost(piechur1);

var piechur2 = new PiechurBuilder("Piechur2");
var piechur2Post = new WarriorPost(piechur2);


var strzelec1 = new StrzelecBuilder("Strzelec1");
var strzelec1Post = new WarriorPost(strzelec1);

var strzelec2 = new StrzelecBuilder("Strzelec2");
var strzelec2Post = new WarriorPost(strzelec2);

var konny1 = new KonnyBuilder("Konny1");
var konny1Post = new WarriorPost(konny1);

var konny2 = new KonnyBuilder("Konny2");
var konny2Post = new WarriorPost(konny2);

List<IWarrior> armia = new List<IWarrior>();

armia.Add(piechur1Post.warrior);
armia.Add(piechur2Post.warrior);
armia.Add(strzelec1Post.warrior);
armia.Add(strzelec2Post.warrior);
armia.Add(konny1Post.warrior);
armia.Add(konny2Post.warrior);

foreach (var item in armia)
{
    Console.WriteLine($"Wojownik o imieniu {item.Nazwa} ma specjalność {item.GetType()}");
}