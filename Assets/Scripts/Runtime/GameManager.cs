using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] BookTemplate currentBook;
    [SerializeField] PageTemplate currentPage;

    private List<GameObject> instantiatedGOs = new List<GameObject>();

    public static GameManager instance { get; private set; }

    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void DogPageButtonClick()
    {
        AddressablesManager.instance.LoadPage("Dog Page");
    }

    public void DogRedPageButtonClick()
    {
        AddressablesManager.instance.LoadPage("Dog Red Page");
    }

    public void InitializePage(PageTemplate newPage)
    {
        ClearPrevPage();
        currentPage = newPage;
        instantiatedGOs.Add(Instantiate(currentPage.Background).gameObject);
        instantiatedGOs.Add(Instantiate(currentPage.ColoredImage).gameObject);
        instantiatedGOs.Add(Instantiate(currentPage.BlackAndWhiteImage).gameObject);
        instantiatedGOs.Add(Instantiate(currentPage.StaticMasks));
        instantiatedGOs.Add(Instantiate(currentPage.DynamicMasks));
    }
    private void ClearPrevPage()
    {
        if (currentPage == null) return;
        AddressablesManager.instance.ReleaseAddressableAsset(currentPage);

        foreach (GameObject item in instantiatedGOs)
        {
            Destroy(item);
        }
        instantiatedGOs.Clear();
    }
}
