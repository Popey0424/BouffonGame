using System.Collections;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject Image_Visuel;  // Faites r�f�rence � votre prefab d'image dans l'inspecteur Unity

    [Header("Move Speed Parameters")]
    public int moveSpeed;
    public int maxMoveSpeed;
    public int Multiplicateur_moveSpeed;

    [Header("Cocher = DROITE sinon GAUCHE")]
    public bool Right;
    [Header("Liste de temps entre 2 apparitions")]
    [Header("T'es mon prefere Simon le dis pas")]
    public float[] Timer_Spawn;

    private int compteur = 0;
    public Transform canvasTransform;

    [Header("Touches pas Simon ou Pauline")]
    public float X;
    public float Y;

    void Start()
    {
        SpawnImage();
    }

    private void Update()
    {
        if (compteur == 0)
        {
            // Si le compteur est � z�ro, d�marrez le processus de spawn
            StartCoroutine(SpawnImageWithTimer());

            compteur = 1;
        }
    }


    //Temps entre 2 apparitions
    IEnumerator SpawnImageWithTimer()
    {
        // Attendre pendant la dur�e sp�cifi�e dans le tableau Timer_Spawn
        yield return new WaitForSeconds(Timer_Spawn[Random.Range(0, Timer_Spawn.Length)]);

        // Lorsque le temps est �coul�, appeler la fonction SpawnImage
        SpawnImage();

        // R�initialiser le compteur pour permettre un nouveau spawn
        compteur = 0;

    }



    void SpawnImage()
    {
        // Cr�ez une nouvelle instance de votre prefab d'image dans le transform du Canvas
        GameObject newImageGO = Instantiate(Image_Visuel);

        // Ajoutez un composant Image � l'objet nouvellement cr��
        Image newImageComponent = newImageGO.AddComponent<Image>();

        // Ajoutez un composant RectTransform � l'objet nouvellement cr��
        RectTransform rectTransform = newImageGO.GetComponent<RectTransform>();

        // Modifiez la position initiale en fonction de Spawn_Position
        rectTransform.anchoredPosition = new Vector2(X, Y);

        // Activez l'objet nouvellement cr��
        newImageGO.SetActive(true);
        ImproveMoveSpeed();
        // D�placez l'image en fonction de la direction (vers la droite ou vers la gauche)
        StartCoroutine(Right ? MoveImage(rectTransform) : MoveImage_2(rectTransform));
    }

    //Move de l'image vers la droite
    IEnumerator MoveImage(RectTransform rectTransform)
    {
        // D�placement continu vers la droite
        while (true)
        {
            rectTransform.anchoredPosition += Vector2.right * moveSpeed * Time.deltaTime;

            // Attendez jusqu'au prochain frame
            yield return null;
        }
    }

    //Move de l'image vers la gauche
    IEnumerator MoveImage_2(RectTransform rectTransform)
    {
        // D�placement continu vers la gauche
        while (true)
        {
            rectTransform.anchoredPosition += Vector2.left * moveSpeed * Time.deltaTime;

            // Attendez jusqu'au prochain frame
            yield return null;
        }



    }

    //Augmente la speed a chauqe image spawn

    void ImproveMoveSpeed()
    {
        Debug.Log("ImproveSpeed " + moveSpeed);


        if (moveSpeed <= maxMoveSpeed)
        {
            moveSpeed += Multiplicateur_moveSpeed;

        }
    }
}