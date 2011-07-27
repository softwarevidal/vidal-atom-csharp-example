using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomTester
{
   public class Lppr
    {
        public int id;
        public String name;
        public String actCode;
        private String code;
        private int coef;
        private float refundBase;
        private String service;

        public Lppr(int id, String name, String actCode, String code, int coef, float refundBase, String service)
        {
            this.id = id;
            this.name = name;
            this.actCode = actCode;
            this.code = code;
            this.coef = coef;
            this.refundBase = refundBase;
            this.service = service;
        }

        public String Service
        {
            get { return service; }
        }
        public float RefundBase
        {
            get { return refundBase; }
        }
        public int Coef
        {
            get { return coef; }
        }
        public String Name
        {
            get { return name; }
        }
        public String ActCode
        {
            get { return actCode; }
        }
        public String Code
        {
            get { return code; }
        }

    }
}
