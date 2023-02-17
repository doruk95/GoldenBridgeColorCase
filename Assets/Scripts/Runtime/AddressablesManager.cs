using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressablesManager : MonoBehaviour
{
    public GameEventPage pagelaodedEvent;
    public GameEventBook booklaodedEvent;

    public static AddressablesManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }


    public void LoadBook(string addressableName)
    {
        Addressables.LoadAssetAsync<BookTemplate>(addressableName).Completed += BookLoaded;
    }

    private void BookLoaded(AsyncOperationHandle<BookTemplate> obj)
    {
        booklaodedEvent.Raise(obj.Result);
    }

    public void LoadPage(string addressableName)
    {
        Addressables.LoadAssetAsync<PageTemplate>(addressableName).Completed += PageLoaded;
    }

    private void PageLoaded(AsyncOperationHandle<PageTemplate> obj)
    {
        pagelaodedEvent.Raise(obj.Result);
    }


    public void ReleaseAddressableAsset(PageTemplate page)
    {
        Addressables.Release(page);
    }

    public void ReleaseAddressableAsset(BookTemplate book)
    {
        Addressables.Release(book);
    }
    
}
