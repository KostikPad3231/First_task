using UnityEngine;
using UnityEngine.UI;

public class DisplayImages : MonoBehaviour
{
    [SerializeField] private GameObject imagePrefab;
    [SerializeField] private Sprite[] images;

    [SerializeField] private float imageWidth;

    private void Start()
    {
        if (imageWidth == 0)
        {
            imageWidth = GetComponent<RectTransform>().rect.width;
        }


        foreach (Sprite image in images)
        {
            GameObject newImage = Instantiate(imagePrefab, transform);
            Image newImageComponent = newImage.GetComponent<Image>();
            newImageComponent.sprite = image;

            float aspectRatio = image.rect.width / image.rect.height;
            float imageHeight = imageWidth / aspectRatio;

            RectTransform imgTransform = newImage.GetComponent<RectTransform>();
            imgTransform.sizeDelta = new Vector2(imageWidth, imageHeight);
        }
    }
}