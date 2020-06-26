using System;

namespace demo.net {
    public abstract class PhuongTienDiLai {
        public abstract void DiChuyen ();
    }

    public class OTo : PhuongTienDiLai {
        public override void DiChuyen () {
            Console.WriteLine ("ô tô");
        }
    }

    public class XeMay : PhuongTienDiLai {
        public override void DiChuyen () {
            Console.WriteLine ("Xe máy");
        }
    }
}