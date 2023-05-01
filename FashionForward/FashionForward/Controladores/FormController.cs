using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionForward.Controladores
{
    public class FormController
    {
        private static Form1 form1;
        private static Form2 form2;
        private static Form3 form3;

        public static Form1 Form1 
        { 
            get {
                if(form1 == null)
                {
                    form1 = new Form1();
                }
                
                return form1;
            }

        }


        public static Form2 Form2
        {
            get
            {
                if (form2 == null)
                {
                    form2 = new Form2();
                }

                return form2;
            }

        }


        public static Form3 Form3
        {
            get
            {
                if (form3 == null)
                {
                    form3 = new Form3();
                }

                return form3;
            }

        }
    }
}
