using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1_FileWatch
{
    internal abstract class ProgramDelegate: ProgramAbstract 
    {
        private Predicate<string[]> SingleProxy;
        public Predicate<string[]> MultiProxy;

        internal override void OnRun(string arg) => 
            SingleProxy(new string[1] { arg });

        protected ProgramDelegate(Predicate<string[]> SingleProxy, Predicate<string[]> MultiProxy)
        {
            this.SingleProxy = SingleProxy;
            this.MultiProxy = MultiProxy;
        }
        
    }
}
