namespace NRGSystemsPtAppWebSite.Models
{
    public class Synergist
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; } = false;
    }
    public class Synergists
    {
        //internal static List<Synergist> SyntList = new();
        public static List<Synergist> SyngergistList;

        public static List<Synergist> GetSynergists()
        {
            synList();
            //foreach (var item in SyntList)
            //{
            //    if (!SyngergistList.Contains(item))
            //        SyngergistList.Add(item);
            //}
            //SyngergistList.Sort();

            return SyngergistList;
        }

        public static void synList()
        {
            SyngergistList = new List<Synergist>
            {
                new Synergist() { Name = "Adductor Brevis", IsChecked = false },
                    new Synergist() { Name = "Adductor Longus", IsChecked = false },
                        new Synergist() { Name = "Adductor Brevis", IsChecked = false },
                            new Synergist() { Name = "Adductor Magnus", IsChecked = false },
                new Synergist() { Name = "Adductor Magnus(lead leg)", IsChecked = false },
                new Synergist() { Name = "Biceps Brachii", IsChecked = false },
                new Synergist() { Name = "Biceps Brachii, Short Head", IsChecked = false },
                new Synergist() { Name = "Brachialis", IsChecked = false },
                new Synergist() { Name = "Brachioradialis", IsChecked = false },
                new Synergist() { Name = "Posterior Deltoid", IsChecked = false },
                new Synergist() { Name = "Anterior Deltoid", IsChecked = false },
                new Synergist() { Name = "Lateral Deltoid", IsChecked = false },
                new Synergist() { Name = "Erector Spinae", IsChecked = false },
                new Synergist() { Name = "Gluteus Medius", IsChecked = false },
                new Synergist() { Name = "Gluteus Minimus", IsChecked = false },
                new Synergist() { Name = "Gluteus Maximus", IsChecked = false },
                new Synergist() { Name = "Gastrocnemius", IsChecked = false },
                new Synergist() { Name = "Hamstrings", IsChecked = false },
                new Synergist() { Name = "Iliocastalis lumborum", IsChecked = false },
                new Synergist() { Name = "Iliocastalis thoracis", IsChecked = false },
                new Synergist() { Name = "Iliopsoas", IsChecked = false },
                new Synergist() { Name = "Infraspinatus", IsChecked = false },
                new Synergist() { Name = "Latissimus Dorsi", IsChecked = false },
                new Synergist() { Name = "Levator Scapulae", IsChecked = false },
                new Synergist() { Name = "Obliques", IsChecked = false },
                new Synergist() { Name = "Pectineus", IsChecked = false },
                new Synergist() { Name = "Pectoralis Major, Clavicular", IsChecked = false },
                new Synergist() { Name = "Pectoralis Major, Sternal", IsChecked = false },
                new Synergist() { Name = "Pectoralis Minor", IsChecked = false },
                new Synergist() { Name = "Psoas Major", IsChecked = false },
                new Synergist() { Name = "Pectoralis Minor", IsChecked = false },
                new Synergist() { Name = "Quadriceps", IsChecked = false },
                new Synergist() { Name = "Rectus Abdominis", IsChecked = false },
                new Synergist() { Name = "Rectus Femoris", IsChecked = false },
                new Synergist() { Name = "Rhomboids", IsChecked = false },
                new Synergist() { Name = "Sartorius", IsChecked = false },
                new Synergist() { Name = "Serratus Anterior", IsChecked = false },
                new Synergist() { Name = "Soleus", IsChecked = false },
                new Synergist() { Name = "Supraspinatus", IsChecked = false },
                new Synergist() { Name = "Tensor Fasciae Latae", IsChecked = false },
                new Synergist() { Name = "Teres Major", IsChecked = false },
                new Synergist() { Name = "Teres Minor", IsChecked = false },
                new Synergist() { Name = "Tibialis Anterior", IsChecked = false },
                new Synergist() { Name = "Trapezius, Lower", IsChecked = false },
                new Synergist() { Name = "Trapezius, Middle", IsChecked = false },
                new Synergist() { Name = "Trapezius, Upper", IsChecked = false },
                new Synergist() { Name = "Triceps Brachii", IsChecked = false },
                new Synergist() { Name = "Triceps, Long Head", IsChecked = false }
            };
        }
    }
}





//SyntList.Add("Adductor Brevis");
//SyntList.Add("Adductor Longus");
//SyntList.Add("Adductor Magnus");
//SyntList.Add("Adductor Magnus(lead leg)");
//SyntList.Add("Adductors(extended leg)");

//        SyntList.Add("Biceps Brachii");
//        SyntList.Add("Biceps Brachii, Short Head");
//        SyntList.Add("Brachialis");
//        SyntList.Add("Brachioradialis");

//        SyntList.Add("Deltoid, Posterior");
//        SyntList.Add("Deltoid, Anterior");
//        SyntList.Add("Deltoid, Lateral");

//        SyntList.Add("Erector Spinae");

//        SyntList.Add("Gluteus Medius");
//        SyntList.Add("Gluteus Minimus");
//        SyntList.Add("Gluteus Maximus");
//        SyntList.Add("Gastrocnemius");

//        SyntList.Add("Hamstrings");

//        SyntList.Add("Iliocastalis lumborum");
//        SyntList.Add("Iliocastalis thoracis");
//        SyntList.Add("Iliopsoas");
//        SyntList.Add("Infraspinatus");

//        SyntList.Add("Latissimus Dorsi");
//        SyntList.Add("Levator Scapulae");

//        SyntList.Add("Obliques");

//        SyntList.Add("Pectineus");
//        SyntList.Add("Pectoralis Major, Clavicular");
//        SyntList.Add("Pectoralis Major, Sternal");
//        SyntList.Add("Pectoralis Minor");
//        SyntList.Add("Psoas Major");
//        SyntList.Add("Pectoralis Minor");

//        SyntList.Add("Quadriceps");

//        SyntList.Add("Rectus Abdominis");
//        SyntList.Add("Rectus Femoris");
//        SyntList.Add("Rhomboids");

//        SyntList.Add("Sartorius");
//        SyntList.Add("Serratus Anterior");
//        SyntList.Add("Soleus");
//        SyntList.Add("Supraspinatus");

//        SyntList.Add("Tensor Fasciae Latae");
//        SyntList.Add("Teres Major");
//        SyntList.Add("Teres Minor");
//        SyntList.Add("Tibialis Anterior");
//        SyntList.Add("Trapezius, Lower");
//        SyntList.Add("Trapezius, Middle");
//        SyntList.Add("Trapezius, Upper");
//        SyntList.Add("Triceps Brachii");
//        SyntList.Add("Triceps, Long Head");
//    }
//}

