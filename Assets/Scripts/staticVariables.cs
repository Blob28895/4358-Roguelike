using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticVariables : MonoBehaviour
{
	//default stats from other scripts
    public static int currHealth = Player.maxHealth;
	public static int baseDamage = PlayerCombat.attackDamage;
	public static int maxSouls = 8;
	public static int currSouls = 0;
	public static float lightDamage = 34f;
	public static float heavyDamage = 100f;
	//upgrades
	public static float damageMultiplier = 1f;
	public static int extraHealth = 0;
	public static bool dashDamage = false;
	public static float movementMultiplier = 1f;
	public static bool heavyAtkEnabled = false;
	public static bool moveSpeedEnabled = false;
	public static float dashDistanceMult = 1f;
	//enemy slow
	public static float enemySlowMult = 0.6f;
	public static float enemySlowTime = 2f;

	public void Start()
	{
		
	}
	void Update()
	{
	}
}
