using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Kogane
{
    public sealed class DisposableAction : IDisposableAction
    {
        private Action m_value;

        public DisposableAction()
        {
        }

        public DisposableAction( Action value )
        {
            m_value = value;
        }

        public void Add( GameObject gameObject, Action value )
        {
            Add( value ).AddTo( gameObject );
        }

        public void Add( Component component, Action value )
        {
            Add( value ).AddTo( component );
        }

        [MustUseReturnValue]
        public IDisposable Add( Action value )
        {
            m_value += value;
            return Disposable.Create( () => m_value -= value );
        }

        public void Invoke()
        {
            m_value?.Invoke();
        }
    }

    public sealed class DisposableAction<T> : IDisposableAction<T>
    {
        private Action<T> m_value;

        public DisposableAction()
        {
        }

        public DisposableAction( Action<T> value )
        {
            m_value = value;
        }

        public void Add( GameObject gameObject, Action<T> value )
        {
            Add( value ).AddTo( gameObject );
        }

        public void Add( Component component, Action<T> value )
        {
            Add( value ).AddTo( component );
        }

        [MustUseReturnValue]
        public IDisposable Add( Action<T> value )
        {
            m_value += value;
            return Disposable.Create( () => m_value -= value );
        }

        public void Invoke( T arg1 )
        {
            m_value?.Invoke( arg1 );
        }
    }

    public sealed class DisposableAction<T1, T2> : IDisposableAction<T1, T2>
    {
        private Action<T1, T2> m_value;

        public DisposableAction()
        {
        }

        public DisposableAction( Action<T1, T2> value )
        {
            m_value = value;
        }

        public void Add( GameObject gameObject, Action<T1, T2> value )
        {
            Add( value ).AddTo( gameObject );
        }

        public void Add( Component component, Action<T1, T2> value )
        {
            Add( value ).AddTo( component );
        }

        [MustUseReturnValue]
        public IDisposable Add( Action<T1, T2> value )
        {
            m_value += value;
            return Disposable.Create( () => m_value -= value );
        }

        public void Invoke( T1 arg1, T2 arg2 )
        {
            m_value?.Invoke( arg1, arg2 );
        }
    }
}