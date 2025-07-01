using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Classe refatorada para ser o Character e lidar com a vida, atk, def, morte e etc... de personagens jogáveis
/// inimigos e tudo que possa estar envolvido no combate
/// </summary>
public class Character : MonoBehaviour
{
    protected CharacterStats characterStats;

    protected virtual void Awake()
    {
        characterStats = GetComponent<CharacterStats>();
    }

    protected virtual void Start()
    {
        characterStats.Hp= characterStats.MaxHp;
        HUDManager.hudManager.playerHpBar.maxValue = characterStats.MaxHp;
        HUDManager.hudManager.playerHpBar.value = characterStats.Hp;
    }

    protected virtual void TakeDamage(int damageValue)
    {
        characterStats.Hp-= damageValue;
        HUDManager.hudManager?.UpdateHP(characterStats.Hp);
        
        if(characterStats.Hp<= 0)
        {
            Destroy(gameObject);
            //Lógica de morte certinha tem que entrar aqui depois
        }
    }

    protected virtual void IncreaseHP(int value)
    {
        characterStats.Hp+= value;
        HUDManager.hudManager?.UpdateHP(characterStats.Hp);
    }

    protected virtual void IncreaseMana(int value)
    {
        characterStats.Mana += value;
        HUDManager.hudManager?.UpdateMana(characterStats.Mana);
    }

    /// <summary>
    /// Botões para testes rápidos de coisas relacionadas a vida do boneco
    /// </summary>
    public void AddStatsHP()
    {
        characterStats.Hp+= 5;
        HUDManager.hudManager?.UpdateHP(characterStats.Hp);
    }

    public void RemoveStatsHP()
    {
        characterStats.Hp-=5;
        HUDManager.hudManager?.UpdateHP(characterStats.Hp);
    }
}
