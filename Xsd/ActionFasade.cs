

using System;

namespace Console1_FileWatch
{
    public class ActionFasade<TIn, TOut>
    {
        public Predicate<TIn> InputSource;
        public Predicate<TOut> OutputTarget;
        public Func<TIn, TOut> ToDo;
    }
}
