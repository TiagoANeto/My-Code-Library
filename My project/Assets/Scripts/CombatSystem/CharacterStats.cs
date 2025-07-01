using UnityEngine;

/// <summary>
/// Classe responsavel pelos status de cada personagem que pode estar em combate,
/// seja ele player ou inimigo.
/// </summary>
public class CharacterStats : MonoBehaviour
{
    private int hp;
    private int maxHp;
    private int mana;
    private string characterName;
    private int damage;
    private int level;

    #region Getters e Setters
    public int Hp
    {
        get => hp;
        set => hp = value;
    }

    public int MaxHp
    {
        get => maxHp;
        set => maxHp = value;
    }

    public int Mana
    {
        get => mana;
        set => mana = value;
    }

    public string CharacterName
    {
        get => characterName;
        set => characterName = value;
    }

    public int Damage
    {
        get => damage;
        set => damage = value;
    }

    public int Level
    {
        get => level;
        set => level = value;
    }

    #endregion

}
