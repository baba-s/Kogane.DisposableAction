# Kogane Disposable Action

破棄処理に対応した Action / Func

## 使用例

### Before

```csharp
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public sealed class ButtonEvent :
    MonoBehaviour,
    IPointerClickHandler
{
    public Action OnClick { get; set; }

    void IPointerClickHandler.OnPointerClick( PointerEventData eventData )
    {
        OnClick?.Invoke();
    }
}
```

```csharp
using UnityEngine;

public class Example : MonoBehaviour
{
    public ButtonEvent m_buttonEvent;

    private void Awake()
    {
        m_buttonEvent.OnClick += OnClick;
    }

    private void OnDestroy()
    {
        m_buttonEvent.OnClick -= OnClick;
    }

    private void OnClick()
    {
        Debug.Log( "ピカチュウ" );
    }
}
```

### After

```csharp
using Kogane;
using UnityEngine;
using UnityEngine.EventSystems;

public sealed class ButtonEvent :
    MonoBehaviour,
    IPointerClickHandler
{
    private readonly DisposableAction m_onClick = new();

    public IDisposableAction OnClick => m_onClick;

    void IPointerClickHandler.OnPointerClick( PointerEventData eventData )
    {
        m_onClick.Invoke();
    }
}
```

```csharp
using UnityEngine;

public class Example : MonoBehaviour
{
    public ButtonEvent m_buttonEvent;

    private void Awake()
    {
        m_buttonEvent.OnClick.Add( gameObject, () => Debug.Log( "ピカチュウ" ) );
    }
}
```

## 依存しているパッケージ

* https://github.com/baba-s/Kogane.Disposable
* https://github.com/baba-s/Kogane.IDisposableAddToExtensionMethods