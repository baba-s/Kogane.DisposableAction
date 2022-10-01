using System;
using UnityEngine;

namespace Kogane
{
    public interface IDisposableAction
    {
        void        Add( GameObject gameObject, Action value );
        void        Add( Component  component,  Action value );
        IDisposable Add( Action     value );
    }

    public interface IDisposableAction<out T>
    {
        void        Add( GameObject gameObject, Action<T> value );
        void        Add( Component  component,  Action<T> value );
        IDisposable Add( Action<T>  value );
    }

    public interface IDisposableAction<out T1, out T2>
    {
        void        Add( GameObject     gameObject, Action<T1, T2> value );
        void        Add( Component      component,  Action<T1, T2> value );
        IDisposable Add( Action<T1, T2> value );
    }
}