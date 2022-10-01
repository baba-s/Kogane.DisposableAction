using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Kogane
{
    public sealed class DisposableFunc<TResult> : IDisposableFunc<TResult>
    {
        private Func<TResult> m_value;

        public DisposableFunc()
        {
        }

        public DisposableFunc( Func<TResult> value )
        {
            m_value = value;
        }

        public void Add( GameObject gameObject, Func<TResult> value )
        {
            Add( value ).AddTo( gameObject );
        }

        public void Add( Component component, Func<TResult> value )
        {
            Add( value ).AddTo( component );
        }

        [MustUseReturnValue]
        public IDisposable Add( Func<TResult> value )
        {
            m_value += value;
            return Disposable.Create( () => m_value -= value );
        }

        public TResult Invoke()
        {
            return m_value != null ? m_value.Invoke() : default;
        }
    }

    public sealed class DisposableFunc<T, TResult> : IDisposableFunc<T, TResult>
    {
        private Func<T, TResult> m_value;

        public DisposableFunc()
        {
        }

        public DisposableFunc( Func<T, TResult> value )
        {
            m_value = value;
        }

        public void Add( GameObject gameObject, Func<T, TResult> value )
        {
            Add( value ).AddTo( gameObject );
        }

        public void Add( Component component, Func<T, TResult> value )
        {
            Add( value ).AddTo( component );
        }

        [MustUseReturnValue]
        public IDisposable Add( Func<T, TResult> value )
        {
            m_value += value;
            return Disposable.Create( () => m_value -= value );
        }

        public TResult Invoke( T arg1 )
        {
            return m_value != null ? m_value.Invoke( arg1 ) : default;
        }
    }

    public sealed class DisposableFunc<T1, T2, TResult> : IDisposableFunc<T1, T2, TResult>
    {
        private Func<T1, T2, TResult> m_value;

        public DisposableFunc()
        {
        }

        public DisposableFunc( Func<T1, T2, TResult> value )
        {
            m_value = value;
        }

        public void Add( GameObject gameObject, Func<T1, T2, TResult> value )
        {
            Add( value ).AddTo( gameObject );
        }

        public void Add( Component component, Func<T1, T2, TResult> value )
        {
            Add( value ).AddTo( component );
        }

        [MustUseReturnValue]
        public IDisposable Add( Func<T1, T2, TResult> value )
        {
            m_value += value;
            return Disposable.Create( () => m_value -= value );
        }

        public TResult Invoke( T1 arg1, T2 arg2 )
        {
            return m_value != null ? m_value.Invoke( arg1, arg2 ) : default;
        }
    }
}