using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image ýmage;

    public TextMeshProUGUI manaText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI attackText;
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;

        ýmage.sprite = card.ýmage;

        manaText.text = card.mana.ToString();
        healthText.text = card.health.ToString();
        attackText.text = card.attack.ToString();
    }


}
