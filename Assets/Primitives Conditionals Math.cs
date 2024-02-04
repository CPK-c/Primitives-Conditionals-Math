using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;

public class PrimitivesConditionalsMath : MonoBehaviour
{
        
    
    
    
        // Declare the variables that can be set in the Editor
        public string characterName; // The name of the character
        public int proficiencyBonus; // The proficiency bonus of the character
        public bool usingFinesseWeapon; // Whether the character is using a finesse weapon or not
        public int strModifier; // The strength modifier of the character
        public int dexModifier; // The dexterity modifier of the character
        
        // Declare some constants for the game logic
        private const int D20 = 20; // The number of sides of a D20 dice
        private const int MIN_AC = 10; // The minimum value of an enemy's armor class
        private const int MAX_AC = 20; // The maximum value of an enemy's armor class
    
    void Start()
    {
         {
            // Calculate the hit modifier of the character based on the weapon and the modifiers
            int hitModifier;
            if (usingFinesseWeapon)
            {
                // Use the higher of STR or DEX
                hitModifier = Mathf.Max(strModifier, dexModifier) + proficiencyBonus;
            }
            else
            {
                // Use STR
                hitModifier = strModifier + proficiencyBonus;
            }

            // Print out the hit modifier
            Debug.Log(characterName + "'s hit modifier is " + hitModifier);

            // Choose a random enemy AC between the min and max values
            int enemyAC = Random.Range(MIN_AC, MAX_AC + 1);

            // Simulate rolling a D20 by picking a random value between 1 and 20
            int d20Roll = Random.Range(1, D20 + 1);

            // Add the hit modifier to the D20 roll
            int attackRoll = d20Roll + hitModifier;

            // Print out the enemy's AC and the attack roll
            Debug.Log("The enemy's AC is " + enemyAC);
            Debug.Log(characterName + " rolled a " + d20Roll + " and added " + hitModifier + " for a total of " + attackRoll);

            // Check if the attack roll is greater than or equal to the enemy's AC
            if (attackRoll >= enemyAC)
            {
                // The attack hits
                Debug.Log(characterName + " hits the enemy!");
            }
            else
            {
                // The attack misses
                Debug.Log(characterName + " misses the enemy!");
            }
         }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
