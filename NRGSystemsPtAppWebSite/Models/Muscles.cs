namespace NRGSystemsPtAppWebSite.Models
{
    public class Muscles
    {
        public static List<Muscle> MuscleList = GetMuscles();
    
        public Muscle Adductors { get; set; }
        public Muscle AdductorsRear { get; set; }
        public Muscle BicepsBrachii { get; set; }
        public Muscle Brachialis { get; set; }
        public Muscle Brachioradialis { get; set; }
        public Muscle DeltoidAnterior { get; set; }
        public Muscle DeltoidLateral { get; set; }
        public Muscle DeltoidPosterior { get; set; }
        public Muscle ErectorSpinae { get; set; }
        public Muscle Gastrocnemius { get; set; }
        public Muscle GluteusMaximus { get; set; }
        public Muscle GluteusMedius { get; set; }
        public Muscle GluteusMinimus { get; set; }
        public Muscle Gracilis { get; set; }
        public Muscle Hamstrings { get; set; }
        public Muscle Iliopsoas { get; set; }
        public Muscle IliopsoasAnterior { get; set; }
        public Muscle Infraspinatus { get; set; }
        public Muscle LatissimusDorsi { get; set; }
        public Muscle LevatorScapulae { get; set; }
        public Muscle Obliques { get; set; }
        public Muscle Pectineus { get; set; }
        public Muscle PectoralisClavicular { get; set; }
        public Muscle PectoralisMinor { get; set; }
        public Muscle PectoralisSternal { get; set; }
        public Muscle Quadriceps { get; set; }
        public Muscle RectusAbdominis { get; set; }
        public Muscle Rhomboids { get; set; }
        public Muscle Sartorius { get; set; }
        public Muscle SerratusAnterior { get; set; }
        public Muscle SerratusAnteriorSide { get; set; }
        public Muscle SpeniusHalf { get; set; }
        public Muscle Soleus { get; set; }
        public Muscle Splenius { get; set; }
        public Muscle Sternocleidomastoid { get; set; }
        public Muscle Subscapularis { get; set; }
        public Muscle Supraspinatus { get; set; }
        public Muscle TensorFasciaeLatae { get; set; }
        public Muscle TeresMajor { get; set; }
        public Muscle TeresMinor { get; set; }
        public Muscle TibialisAnterior { get; set; }
        public Muscle TrapeziusLower { get; set; }
        public Muscle TrapeziusMiddle { get; set; }
        public Muscle TrapeziusUpper { get; set; }
        public Muscle TricepsBrachii { get; set; }
        public Muscle WristExtensors { get; set; }
        public Muscle WristFlexors { get; set; }


        public Muscles()
        { }
        public static List<Muscle> GetMuscles()
        {
            List<Muscle> returnList =
            [  //].Add(new Muscle()
         new Muscle()        // ErectorSpinae
         {
             Name = "ErectorSpinae",
             Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/erector_spinae.gif",
             StringName = "Erector Spinae",
             Location = "Back Middle",
             Insertion = "Ribs, Cervical Vertebrae, Transverse Processes, " +
                        "Spinous Processes, Thoracic Vertebrae, Transverse Processes," +
                        "Spinous Processes, Skull, Mastoid Process, Occipital Bone",
             Origin = "Sacrum, Lower Posterior Surface, Transverse Processes, Ribs, " +
                     "Lumbar Vertebrae, Transverse Processes, Thoracic Vertebrae, " +
                     "Transverse Processes, Cervical Vertebrae, Transverse Processes, " +
                     "Ligamentum Nuchae",
             IsChecked = false
         },
            new Muscle()        // LatissimusDorsi
            {
                Name = "LatissimusDorsi",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/latissimus_dorsi_side.gif",
                StringName = "Latissimus Dorsi",
                Location = "Back Outer",
                Insertion = "Humerus",
                Origin = "Ilium, Sacrum, Vertebral Column, Ribs",
                IsChecked = false
            },
            new Muscle()        // LatissimusDorsi
            {
                Name = "LevatorScapulae",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/levator_scap_half.gif",
                StringName = "Levator Scapulae",
                Location = "Neck",
                Insertion = "Scapula",
                Origin = "Cervical Vertebrae",
                IsChecked = false
            },
            new Muscle()        // LatissimusDorsi
            {
                Name = "Rhomboids",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/rhomboids_half.gif",
                StringName = "Rhomboids",
                Location = "Upper Mid Back",
                Insertion = "Scapula",
                Origin = "Spine",
                IsChecked = false
            },
            new Muscle()        // LatissimusDorsi
            {
                Name = "SpeniusHalf",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/spenius_half.gif",
                StringName = "Spenius Half",
                Location = "Neck",
                Insertion = "Spine, Skull",
                Origin = "Spine, Neck",
                IsChecked = false
            },
            new Muscle()        // LatissimusDorsi
            {
                Name = "Splenius",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/splenius_spine.gif",
                StringName = "Splenius",
                Location = "Neck",
                Insertion = "Spine, Skull",
                Origin = "Spine, Neck",
                IsChecked = false
            },
            new Muscle()        // LatissimusDorsi
            {
                Name = "TrapeziusLower",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/trap_lower_half.gif",
                StringName = "Trapezius Lower",
                Location = "Back Inner",
                Insertion = "Scapula",
                Origin = "Spine",
                IsChecked = false
            },
            new Muscle()        // LatissimusDorsi
            {
                Name = "TrapeziusMiddle",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/trap_middle_half.gif",
                StringName = "Trapezius Middle",
                Location = "Back Upper",
                Insertion = "Scapula",
                Origin = "Spine",
                IsChecked = false
            },
            new Muscle()        // TrapeziusUpper
            {
                Name = "TrapeziusUpper",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/trap_upper_half.gif",
                StringName = "Trapezius Upper",
                Location = "Shoulders",
                Insertion = "Clavicle",
                Origin = "Skull, Ligamentum",
                IsChecked = false
            },
                new Muscle()
            {
                Name = "Gracilis",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/gracilis_anterior.gif",
                StringName = "Gracilis",
                Location = "Inner Thigh",
                Insertion = "Tibia",
                Origin = "Pubis",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Pectineus",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/pectineus_anterior.gif",
                StringName = "Pectineus",
                Location = "Thigh",
                Insertion = "Femur",
                Origin = "Pubis",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Quadriceps",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/quadriceps_anterior.gif",
                StringName = "Quadriceps",
                Location = "Inner Thigh",
                Insertion = "Tibia",
                Origin = "Ilium, Femur",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Sartorius",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/sartorius_anterior.gif",
                StringName = "Sartorius",
                Location = "Thigh",
                Insertion = "Tibia",
                Origin = "Ilium",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "TensorFasciaeLatae",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/tensor_fasciae_lataea.gif",
                StringName = "Tensor Fasciae Latae ",
                Location = "Outer Thigh",
                Insertion = "Tibia",
                Origin = "Ilium",
                IsChecked = false
            },
                new Muscle()
            {
                Name = "Adductors",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/adductor_anterior.gif",
                StringName = "Adductors",
                Location = "Inner Thigh",
                Insertion = "Femur (medial)",
                Origin = "Pubis",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "AdductorsRear",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/adductor_posterior.gif",
                StringName = "Adductors Rear",
                Location = "Inner Thigh",
                Insertion = "Femur",
                Origin = "Pubis",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "GluteusMaximus",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/gluteus_maximus_posterior.gif",
                StringName = "Gluteus Maximus",
                Location = "Arse",
                Insertion = "Femur, Tibia",
                Origin = "ilium, Sacrum, Fascia of the lumbar",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "GluteusMedius",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/gluteus_medius_posterior.gif",
                StringName = "Gluteus Medius",
                Location = "Arse",
                Insertion = "Femur",
                Origin = "Ilium",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "GluteusMinimus",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/gluteus_minimus.gif",
                StringName = "Gluteus Minimus",
                Location = "Arse",
                Insertion = "Femur",
                Origin = "Ilium",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Hamstrings",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/hamstring_posterior.gif",
                StringName = "Hamstrings",
                Location = "Rear Thigh",
                Insertion = "Tibia, Fibula",
                Origin = "Ishium, Femur",
                IsChecked = false
            },
                new Muscle()
            {
                Name = "Gastrocnemius",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/gastrocnemius_lateral.gif",
                StringName = "Gastrocnemius",
                Location = "Lower Leg",
                Insertion = "Calcaneous",
                Origin = "Femur",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Soleus",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/soleus_lateral.gif",
                StringName = "Soleus",
                Location = "Lower Leg",
                Insertion = "Calcaneous",
                Origin = "Tibia, Fibula",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "TibialisAnterior",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/tibialis_anterior.gif",
                StringName = "Tibialis Anterior",
                Location = "Lower Leg",
                Insertion = "Tarsal",
                Origin = "Tibia",
                IsChecked = false
            },
                new Muscle()
            {
                Name = "DeltoidAnterior",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/deltoid_anterior_front.gif",
                StringName = "Deltoid Anterior",
                Location = "Shoulder",
                Insertion = "Humerous",
                Origin = "Clavicle",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "DeltoidLateral",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/deltoid_lateral_back.gif",
                StringName = "Deltoid Lateral",
                Location = "Shoulder",
                Insertion = "Humerous",
                Origin = "Scapula",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "DeltoidPosterior",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/deltoid_posterior_back.gif",
                StringName = "Deltoid Posterior",
                Location = "Shoulder",
                Insertion = "Humerous",
                Origin = "Scapula",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Infraspinatus",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/infraspinatus.gif",
                StringName = "Infraspinatus",
                Location = "Rotator Cuff",
                Insertion = "Humerous",
                Origin = "Scapula",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Subscapularis",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/subscapularis.gif",
                StringName = "Subscapularis",
                Location = "Rotator Cuff",
                Insertion = "Humerus",
                Origin = "Scapula",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Supraspinatus",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/supraspinatus_back.gif",
                StringName = "Supraspinatus",
                Location = "Rotator Cuff",
                Insertion = "Humerus",
                Origin = "Scapula",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "TeresMajor",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/teres_major.gif",
                StringName = "Teres Major",
                Location = "Shoulder",
                Insertion = "Humerus",
                Origin = "Scapula",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "TeresMinor",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/teres_minor.gif",
                StringName = "Teres Minor",
                Location = "Rotator Cuff",
                Insertion = "Humerus",
                Origin = "Scapula",
                IsChecked = false
            },
                new Muscle()
            {
            Name = "BicepsBrachii",
            Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/biceps_inside.gif",
            StringName = "Biceps Brachii",
            Location = "Upper Arm",
            Insertion = "Radius",
            Origin = "Scapula",
            IsChecked = false
            },
            new Muscle()
            {
                Name = "Brachialis",
            Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/brachialis_inside.gif",
            StringName = "Brachialis",
            Location = "Upper Arm",
            Insertion = "Ulna",
            Origin = "Humerous",
            IsChecked = false
            },
            new Muscle()
            {
                Name = "Brachioradialis",
            Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/brachioradialis_outside.gif",
            StringName = "Brachioradialis",
            Location = "Forearm",
            Insertion = "Radius",
            Origin = "Humerous",
            IsChecked = false
            },
            new Muscle()
            {
                Name = "TricepsBrachii",
            Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/triceps_outside.gif",
            StringName = "Triceps Brachii",
            Location = "Arms Rear",
            Insertion = "Ulna",
            Origin = "Scapula, Humerous",
            IsChecked = false
            },
            new Muscle()
            {
                Name = "WristExtensors",
            Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/wrist_extensors_sup.gif",
            StringName = "Wrist Extensors",
            Location = "Forearm",
            Insertion = "Fingers, Thumb, Metacarpals",
            Origin = "Humerus, Ulna, Radius",
            IsChecked = false
            },
            new Muscle()
            {
                Name = "WristFlexors",
            Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/wrist_flexor_neut.gif",
            StringName = "Wrist Flexors",
            Location = "Forearm",
            Insertion = "Fingers, Thumb, Metacarpals",
            Origin = "Humerus, Ulna, Radius",
            IsChecked = false
        },
                new Muscle()
            {
                Name = "Iliopsoas",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/iliopsoas.gif",
                StringName = "Iliopsoas",
                Location = "Hip Flexor",
                Insertion = "Femur",
                Origin = "Ilium, Sacrum, Vertebral Column",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "IliopsoasAnterior",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/iliopsoas_anterior.gif",
                StringName = "Iliopsoas Anterior",
                Location = "Hip Flexor",
                Insertion = "Femur",
                Origin = "Ilium, Sacrum, Vertebral Column",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Obliques",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/oblique_side.gif",
                StringName = "Obliques",
                Location = "Core",
                Insertion = "Rectus Abdominis Fascia, Ilium, Anterior Crest, " +
                        "Inguinal Ligament, Pubis, Crest, Conjoint Tendon, " +
                        "Ribs, Inferior borders, Linea Alba",
                Origin = "Ribs, External Surfaces, Thoracolumbar Fascia, Ilium, " +
                     "Illiac Crest",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "RectusAbdominis",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/rectus_abdominis_waist.gif",
                StringName = "Rectus Abdominis",
                Location = "Core",
                Insertion = "Ribs, Xipoid Process",
                Origin = "Pubis",
                IsChecked = false
            },
                new Muscle()
            {
                Name = "PectoralisClavicular",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/pectoralis_clavicle.gif",
                StringName = "Pectoralis Clavicular",
                Location = "Chest",
                Insertion = "Humerous",
                Origin = "Clavicle",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "PectoralisMinor",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/pectoralis_minor.gif",
                StringName = "Pectoralis Minor",
                Location = "Chest",
                Insertion = "Scaplula",
                Origin = "Ribs",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "PectoralisSternal",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/pectoralis_sternal.gif",
                StringName = "Pectoralis Sternal",
                Location = "Chest",
                Insertion = "Humerus",
                Origin = "Sternum, Ribs",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "SerratusAnterior",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/serratus_anterior_pull.gif",
                StringName = "Serratus Anterior",
                Location = "Chest",
                Insertion = "Scapula",
                Origin = "Ribs",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "SerratusAnteriorSide",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/serratus_anterior_side.gif",
                StringName = "Serratus AnteriorSide",
                Location = "Chest",
                Insertion = "Scapula",
                Origin = "Ribs",
                IsChecked = false
            },
            new Muscle()
            {
                Name = "Sternocleidomastoid",
                Image = "https://nrgptappstorage.blob.core.windows.net/exercisevids/sterno_side.gif",
                StringName = "Sternocleidomastoid",
                Location = "Neck",
                Insertion = "Skull",
                Origin = "Sternum, Clavicle",
                IsChecked = false
            } // ,
            //    new Muscle()
            //{
            //    Name = "Adductors",
            //    Image = "adductor_anterior.gif",
            //    StringName = "Adductors",
            //    Location = "Inner Thigh",
            //    Insertion = "Femur (medial)",
            //    Origin = "Pubis",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "AdductorsRear",
            //    Image = "adductor_posterior.gif",
            //    StringName = "Adductors Rear",
            //    Location = "Inner Thigh",
            //    Insertion = "Femur",
            //    Origin = "Pubis",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "BicepsBrachii",
            //    Image = "biceps_inside.gif",
            //    StringName = "Biceps Brachii",
            //    Location = "Upper Arm",
            //    Insertion = "Radius",
            //    Origin = "Scapula",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Brachialis",
            //    Image = "brachialis_inside.gif",
            //    StringName = "Brachialis",
            //    Location = "Upper Arm",
            //    Insertion = "Ulna",
            //    Origin = "Humerous",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Brachioradialis",
            //    Image = "brachioradialis_outside.gif",
            //    StringName = "Brachioradialis",
            //    Location = "Forearm",
            //    Insertion = "Radius",
            //    Origin = "Humerous",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "DeltoidAnterior",
            //    Image = "deltoid_anterior_front.gif",
            //    StringName = "Deltoid Anterior",
            //    Location = "Shoulder",
            //    Insertion = "Humerous",
            //    Origin = "Clavicle",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "DeltoidLateral",
            //    Image = "deltoid_lateral_back.gif",
            //    StringName = "Deltoid Lateral",
            //    Location = "Shoulder",
            //    Insertion = "Humerous",
            //    Origin = "Scapula",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "DeltoidPosterior",
            //    Image = "deltoid_posterior_back.gif",
            //    StringName = "Deltoid Posterior",
            //    Location = "Shoulder",
            //    Insertion = "Humerous",
            //    Origin = "Scapula",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "ErectorSpinae",
            //    Image = "erector_spinae.gif",
            //    StringName = "Erector Spinae",
            //    Location = "Back Middle",
            //    Insertion = "Ribs, Cervical Vertebrae, Transverse Processes, " +
            //                "Spinous Processes, Thoracic Vertebrae, Transverse Processes," +
            //                "Spinous Processes, Skull, Mastoid Process, Occipital Bone",
            //    Origin = "Sacrum, Lower Posterior Surface, Transverse Processes, Ribs, " +
            //             "Lumbar Vertebrae, Transverse Processes, Thoracic Vertebrae, " +
            //             "Transverse Processes, Cervical Vertebrae, Transverse Processes, " +
            //             "Ligamentum Nuchae",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Gastrocnemius",
            //    Image = "gastrocnemius_lateral.gif",
            //    StringName = "Gastrocnemius",
            //    Location = "Lower Leg",
            //    Insertion = "Calcaneous",
            //    Origin = "Femur",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "GluteusMaximus",
            //    Image = "gluteus_maximus_posterior.gif",
            //    StringName = "Gluteus Maximus",
            //    Location = "Arse",
            //    Insertion = "Femur, Tibia",
            //    Origin = "ilium, Sacrum, Fascia of the lumbar",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "GluteusMedius",
            //    Image = "gluteus_medius_posterior.gif",
            //    StringName = "Gluteus Medius",
            //    Location = "Arse",
            //    Insertion = "Femur",
            //    Origin = "Ilium",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "GluteusMinimus",
            //    Image = "gluteus_minimus.gif",
            //    StringName = "Gluteus Minimus",
            //    Location = "Arse",
            //    Insertion = "Femur",
            //    Origin = "Ilium",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Gracilis",
            //    Image = "gracilis_anterior.gif",
            //    StringName = "Gracilis",
            //    Location = "Inner Thigh",
            //    Insertion = "Tibia",
            //    Origin = "Pubis",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Hamstrings",
            //    Image = "hamstring_posterior.gif",
            //    StringName = "Hamstrings",
            //    Location = "Rear Thigh",
            //    Insertion = "Tibia, Fibula",
            //    Origin = "Ishium, Femur",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Iliopsoas",
            //    Image = "iliopsoas.gif",
            //    StringName = "Iliopsoas",
            //    Location = "Hip Flexor",
            //    Insertion = "Femur",
            //    Origin = "Ilium, Sacrum, Vertebral Column",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "IliopsoasAnterior",
            //    Image = "iliopsoas_anterior.gif",
            //    StringName = "Iliopsoas Anterior",
            //    Location = "Hip Flexor",
            //    Insertion = "Femur",
            //    Origin = "Ilium, Sacrum, Vertebral Column",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Infraspinatus",
            //    Image = "infraspinatus.gif",
            //    StringName = "Infraspinatus",
            //    Location = "Rotator Cuff",
            //    Insertion = "Humerous",
            //    Origin = "Scapula",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "LatissimusDorsi",
            //    Image = "latissimus_dorsi_side.gif",
            //    StringName = "Latissimus Dorsi",
            //    Location = "Back Outer",
            //    Insertion = "Humerus",
            //    Origin = "Ilium, Sacrum, Vertebral Column, Ribs",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "LevatorScapulae",
            //    Image = "levator_scap_half.gif",
            //    StringName = "Levator Scapulae",
            //    Location = "Neck",
            //    Insertion = "Scapula",
            //    Origin = "Cervical Vertebrae",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Obliques",
            //    Image = "oblique_side.gif",
            //    StringName = "Obliques",
            //    Location = "Core",
            //    Insertion = "Rectus Abdominis Fascia, Ilium, Anterior Crest, " +
            //            "Inguinal Ligament, Pubis, Crest, Conjoint Tendon, " +
            //            "Ribs, Inferior borders, Linea Alba",
            //    Origin = "Ribs, External Surfaces, Thoracolumbar Fascia, Ilium, " +
            //         "Illiac Crest",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Pectineus",
            //    Image = "pectineus_anterior.gif",
            //    StringName = "Pectineus",
            //    Location = "Thigh",
            //    Insertion = "Femur",
            //    Origin = "Pubis",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "PectoralisClavicular",
            //    Image = "pectoralis_clavicle.gif",
            //    StringName = "Pectoralis Clavicular",
            //    Location = "Chest",
            //    Insertion = "Humerous",
            //    Origin = "Clavicle",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "PectoralisMinor",
            //    Image = "pectoralis_minor.gif",
            //    StringName = "Pectoralis Minor",
            //    Location = "Chest",
            //    Insertion = "Scaplula",
            //    Origin = "Ribs",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "PectoralisSternal",
            //    Image = "pectoralis_sternal.gif",
            //    StringName = "Pectoralis Sternal",
            //    Location = "Chest",
            //    Insertion = "Humerus",
            //    Origin = "Sternum, Ribs",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Quadriceps",
            //    Image = "quadriceps_anterior.gif",
            //    StringName = "Quadriceps",
            //    Location = "Inner Thigh",
            //    Insertion = "Tibia",
            //    Origin = "Ilium, Femur",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "RectusAbdominis",
            //    Image = "rectus_abdominis_waist.gif",
            //    StringName = "Rectus Abdominis",
            //    Location = "Core",
            //    Insertion = "Ribs, Xipoid Process",
            //    Origin = "Pubis",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Rhomboids",
            //    Image = "rhomboids_half.gif",
            //    StringName = "Rhomboids",
            //    Location = "Upper Mid Back",
            //    Insertion = "Scapula",
            //    Origin = "Spine",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Sartorius",
            //    Image = "sartorius_anterior.gif",
            //    StringName = "Sartorius",
            //    Location = "Thigh",
            //    Insertion = "Tibia",
            //    Origin = "Ilium",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "SerratusAnterior",
            //    Image = "serratus_anterior_pull.gif",
            //    StringName = "Serratus Anterior",
            //    Location = "Chest",
            //    Insertion = "Scapula",
            //    Origin = "Ribs",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "SerratusAnteriorSide",
            //    Image = "serratus_anterior_side.gif",
            //    StringName = "Serratus AnteriorSide",
            //    Location = "Chest",
            //    Insertion = "Scapula",
            //    Origin = "Ribs",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "SpeniusHalf",
            //    Image = "spenius_half.gif",
            //    StringName = "Spenius Half",
            //    Location = "Neck",
            //    Insertion = "Spine, Skull",
            //    Origin = "Spine, Neck",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Splenius",
            //    Image = "splenius_spine.gif",
            //    StringName = "Splenius",
            //    Location = "Neck",
            //    Insertion = "Spine, Skull",
            //    Origin = "Spine, Neck",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Soleus",
            //    Image = "soleus_lateral.gif",
            //    StringName = "Soleus",
            //    Location = "Lower Leg",
            //    Insertion = "Calcaneous",
            //    Origin = "Tibia, Fibula",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Sternocleidomastoid",
            //    Image = "sterno_side.gif",
            //    StringName = "Sternocleidomastoid",
            //    Location = "Neck",
            //    Insertion = "Skull",
            //    Origin = "Sternum, Clavicle",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Subscapularis",
            //    Image = "subscapularis.gif",
            //    StringName = "Subscapularis",
            //    Location = "Rotator Cuff",
            //    Insertion = "Humerus",
            //    Origin = "Scapula",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "Supraspinatus",
            //    Image = "supraspinatus_back.gif",
            //    StringName = "Supraspinatus",
            //    Location = "Rotator Cuff",
            //    Insertion = "Humerus",
            //    Origin = "Scapula",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "TensorFasciaeLatae",
            //    Image = "tensor_fasciae_lataea.gif",
            //    StringName = "Tensor Fasciae Latae ",
            //    Location = "Outer Thigh",
            //    Insertion = "Tibia",
            //    Origin = "Ilium",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "TeresMajor",
            //    Image = "teres_major.gif",
            //    StringName = "Teres Major",
            //    Location = "Shoulder",
            //    Insertion = "Humerus",
            //    Origin = "Scapula",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "TeresMinor",
            //    Image = "teres_minor.gif",
            //    StringName = "Teres Minor",
            //    Location = "Rotator Cuff",
            //    Insertion = "Humerus",
            //    Origin = "Scapula",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "TibialisAnterior",
            //    Image = "tibialis_anterior.gif",
            //    StringName = "Tibialis Anterior",
            //    Location = "Lower Leg",
            //    Insertion = "Tarsal",
            //    Origin = "Tibia",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "TrapeziusLower",
            //    Image = "trap_lower_half.gif",
            //    StringName = "Trapezius Lower",
            //    Location = "Back Inner",
            //    Insertion = "Scapula",
            //    Origin = "Spine",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "TrapeziusMiddle",
            //    Image = "trap_middle_half.gif",
            //    StringName = "Trapezius Middle",
            //    Location = "Back Upper",
            //    Insertion = "Scapula",
            //    Origin = "Spine",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "TrapeziusUpper",
            //    Image = "trap_upper_half.gif",
            //    StringName = "Trapezius Upper",
            //    Location = "Shoulders",
            //    Insertion = "Clavicle",
            //    Origin = "Skull, Ligamentum",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "TricepsBrachii",
            //    Image = "triceps_outside.gif",
            //    StringName = "Triceps Brachii",
            //    Location = "Arms Rear",
            //    Insertion = "Ulna",
            //    Origin = "Scapula, Humerous",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "WristExtensors",
            //    Image = "wrist_extensors_sup.gif",
            //    StringName = "Wrist Extensors",
            //    Location = "Forearm",
            //    Insertion = "Fingers, Thumb, Metacarpals",
            //    Origin = "Humerus, Ulna, Radius",
            //    IsChecked = false
            //},
            //new Muscle()
            //{
            //    Name = "WristFlexors",
            //    Image = "wrist_flexor_neut.gif",
            //    StringName = "Wrist Flexors",
            //    Location = "Forearm",
            //    Insertion = "Fingers, Thumb, Metacarpals",
            //    Origin = "Humerus, Ulna, Radius",
            //    IsChecked = false
            //},
        ];

            return returnList;
        }
    }
}

