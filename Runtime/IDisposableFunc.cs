using System;
using UnityEngine;

namespace Kogane
{
    public interface IDisposableFunc<in TResult>
    {
        void        Add( GameObject    gameObject, Func<TResult> value );
        void        Add( Component     component,  Func<TResult> value );
        IDisposable Add( Func<TResult> value );
    }

    public interface IDisposableFunc<out T, in TResult>
    {
        void        Add( GameObject       gameObject, Func<T, TResult> value );
        void        Add( Component        component,  Func<T, TResult> value );
        IDisposable Add( Func<T, TResult> value );
    }

    public interface IDisposableFunc<out T1, out T2, in TResult>
    {
        void        Add( GameObject            gameObject, Func<T1, T2, TResult> value );
        void        Add( Component             component,  Func<T1, T2, TResult> value );
        IDisposable Add( Func<T1, T2, TResult> value );
    }
}