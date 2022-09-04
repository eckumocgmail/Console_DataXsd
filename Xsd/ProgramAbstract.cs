using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1_FileWatch
{
    abstract class ProgramAbstract : IDisposable
    {
        private ConcurrentQueue<string> args = new ConcurrentQueue<string>( Environment.GetCommandLineArgs() );
        private ConcurrentStack<string> state = new ConcurrentStack<string>();
        private ConcurrentStack<string> history = new ConcurrentStack<string>();

        protected ProgramAbstract(params string[] args)
        {        
            foreach (string arg in args)
            {
                if (arg.StartsWith("/"))
                {
                    Set(arg);
                }
            }
        }

        /// <param name="command">IDataController</param>
        public abstract void OnSet(string arg);
        private void Set(string arg)
        {
            state.Push(arg);
            OnSet(arg);
        }

 
        /// <param name="command">ICommandRunner</param>
        internal abstract void OnRun(string command);
        internal void Run(string command)
        {
            this.history.Push(command);
            this.OnRun(command);
        }
        internal void Run(string[] args)
        {
            foreach(var arg in args)
            {
                if (arg.StartsWith("-"))
                {
                    Run(arg);
                }
            }
        }
        public void Dispose() => OnDispose();
        internal abstract void OnDispose();

    }
}
