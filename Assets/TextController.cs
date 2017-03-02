using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TextController : MonoBehaviour 
{
	
	public Text text;
	
	//IF START ISNT AN ENUM STATE, YOU CANNOT RUN IT ON THE FUCKING SCREEN
	private enum States {start, cell_0, sheets_0, sheets_1 , lock_0, mirror_1a, got_it_all, lock_1a, 
						freedom, mirror_0, cell_mirror_bleeding, lock_0a, lock_0b, lock_1, 
						death_0, death_1a, sheets_2 , sheets_2a , death_1, death_0a, freedom_0,	
						ending, corridor_0, corridor_1, corridor_2, cell_A0, cell_B0, cell_C0,
						cell_A1, cell_A1gold, cell_B1, cell_C1, cell_A2, cell_B2, cell_C2, cell_C3a, 
						cell_C3b, bed_B0, skeleton_B0, mirror_B0, mirror_A1, mirror_C3, bed_A1, bed_C3,
						lock_C3, stairs_0, stairs_1, freedom_1, envelope_0, death_C0, death_C1,
						death_C2, death_C3, death_B0};
						
	private States myState;
	private bool hasStartedGame = false;
	
	// Use this for initialization
	void Start () {
		text.text = "A game about getting out. \n\n" +
			"Press X to begin.";
	
	}
	
	// Update is called once per frame
	void Update () {
		if 		(!hasStartedGame && Input.GetKeyUp(KeyCode.X))		{hasStartedGame = true;myState = States.cell_0;
				print (myState);}
		
		else if (myState == States.cell_0)					{cell_0();} 
		else if (myState == States.sheets_0)				{sheets_0();}
		else if (myState == States.sheets_1)				{sheets_1();}
		else if (myState == States.sheets_2)				{sheets_2();}
		else if (myState ==	States.sheets_2a)				{sheets_2a();} 
		else if (myState == States.lock_0)					{lock_0();}
		else if (myState == States.lock_0a)					{lock_0a();}
		else if (myState == States.lock_0b)					{lock_0b();}
		else if (myState == States.lock_1)					{lock_1();}
		else if (myState == States.lock_1a)					{lock_1a();}
		else if (myState == States.mirror_0)				{mirror_0();}
		else if (myState == States.mirror_1a)				{mirror_1a();}
		else if (myState == States.cell_mirror_bleeding)	{cell_mirror_bleeding();}
		else if (myState == States.death_0)					{death_0();}
		else if (myState == States.death_0a)				{death_0a();}
		else if (myState == States.death_1)					{death_1();}
		else if (myState == States.death_1a)				{death_1a();}
		else if (myState == States.got_it_all)				{got_it_all();}
		else if (myState == States.freedom_0)				{freedom_0();}
		else if (myState == States.ending)					{ending();}
		//		End of chapter I:			
		
		else if (myState == States.corridor_0)				{corridor_0();}
		else if (myState == States.corridor_1)				{corridor_1();}
		else if (myState == States.corridor_2)				{corridor_2();}
		else if (myState == States.cell_A0)					{cell_A0();}
		else if (myState == States.cell_B0)					{cell_B0();}
		else if (myState == States.cell_C0)					{cell_C0();}
		else if (myState == States.cell_A1)					{cell_A1();}
		else if (myState == States.cell_A1gold)				{cell_A1gold();}
		else if (myState == States.cell_B1)					{cell_B1();}
		else if (myState == States.cell_C1)					{cell_C1();}
		else if (myState == States.cell_A2)					{cell_A2();}
		else if (myState == States.cell_B2)					{cell_B2();}
		else if (myState == States.cell_C2)					{cell_C2();}
		else if (myState == States.cell_C3a)				{cell_C3a();}
		else if (myState == States.cell_C3b)				{cell_C3b();}
		else if (myState == States.bed_B0)					{bed_B0();}
		else if (myState == States.skeleton_B0)				{skeleton_B0();}
		else if (myState == States.mirror_B0)				{mirror_B0();}
		else if (myState == States.death_B0)				{death_B0();}	
		else if (myState == States.mirror_A1)				{mirror_A1();}
		else if (myState == States.mirror_C3)				{mirror_C3();}
		else if (myState == States.bed_A1)					{bed_A1();}
		else if (myState == States.bed_C3)					{bed_C3();}
		else if (myState == States.lock_C3)					{lock_C3();}
		else if (myState == States.stairs_0)				{stairs_0();}
		else if (myState == States.stairs_1)				{stairs_1();}
		else if (myState == States.freedom_1)				{freedom_1();}
		else if (myState == States.envelope_0)				{envelope_0();}
		//End Chapter II:
		//End Game:
	}
	
	void cell_0()
	{
		text.text = "Disoriented, you wake up in a cell with not a sound to be heard. " +
					"Your surroundings dictate that escape is essential for your survival. " +
					"There is a bed behind you made with filthy sheets, " +
					"a mirrior on the wall, and a locked door.\n\n" +
					"Press S to view Sheets, M to view Mirror, L to view Lock.";	
		
		
		
		if 		(Input.GetKeyDown (KeyCode.S))				{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.M))				{myState = States.mirror_0;}
		else if (Input.GetKeyDown (KeyCode.L))				{myState = States.lock_0;}  
	}
	
	void sheets_0()
	{
		text.text = "Blood, urine, is that, chocolate?. " +
					"Hopefully not yours.\n\n " +
					"Press R to view Return to roaming your cell, L to " +
					"look at Lock, T to tear and Take a clean section of sheeting.";
			
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_0;}
		else if (Input.GetKeyDown (KeyCode.T))				{myState = States.sheets_1;}
		else if (Input.GetKeyDown (KeyCode.L))				{myState = States.lock_0a;}
		}
	
	void sheets_1 ()
	{
		text.text = "Tearing across the grain, you fashion yourself a nice "+
					"little roll of some-what clean-ish fabric.\n\n " +
					"Press R to return searching the sheets, " +
					"M to look at Mirror.";
		
		if 	 (Input.GetKeyDown (KeyCode.R))					{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.M))				{myState = States.mirror_1a;}
			
		}
		
	void lock_0()
	{
		text.text = "You run your hands through the bars. Feeling around " +
			"notice push buttons on the locking mechanism. " +
				"You could randomly guess at the code, but there must " +
				"be a better way. \n\n " +
				"Press R to view Return to roaming in your cell, " +
				"Press L to enter a 3 digit keycode.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_0;} // Remove this curly brace when toggling next line comment
//															securityPanelContainer.SetActive(false);}
	}
	
	
	void mirror_1a()
	{
		text.text = "A cracked mirror, garnished with smears of dried blood. " +
					"'What prison allowes broken glass in a cell?' you think, " +
					"before realizing you aren't meant to leave, alive.\n\n " +
					"Press R to return searching the sheets, " +
					"B to use Bandage roll and take mirror safetly.";
				
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.sheets_1;}
		else if (Input.GetKeyDown (KeyCode.B))				{myState = States.got_it_all;}
	}
	void got_it_all()
	{
		text.text = "Feeling better about your perdipredicament you realize you " +
					"have what it takes to be the star in one of those 'Escape from...' " +
					"movies. Staring at the door ahead the answer comes to you-\n\n " +
					"Press M to use mirror with bars. " +
					"X to Retrace your steps from the beginning." ;
		
		if 		(Input.GetKeyDown (KeyCode.M))				{myState = States.lock_1a;}
		else if	(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
	}
	
	void lock_1a()
	{
		text.text = "Looking in the mirrors reflection you see crusty brown fingerprints on the " +
			"numbers '1' and '0'... as well as the surrounting panel. \n\n" +
				"Press L to enter a 3 digit keycode. ";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_0;} // Remove this curly brace when toggling next line comment
//															securityPanelContainer.SetActive(false);}
	}
	
	void mirror_0()
	{ 
		text.text = "A cracked mirror, garnished with smears of dried blood. " +
			"'What prison allowes broken glass in a cell?' you think, " +
				"before realizing you aren't meant to leave, alive. \n\n" +
				"Press R to view Return to roaming your cell, T to Take mirror.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_0;}
		else if (Input.GetKeyDown (KeyCode.T))				{myState = States.cell_mirror_bleeding;}
	}	
	
	void cell_mirror_bleeding()
	{
		text.text = "Upon removing a nice sized slice of mirror from the wall, the wall  " +
					"removed a nice sized slice of flesh from your finger with the, now, " +
					"broken mirror. \n\n" +
					"Press R to Return to roaming your cell, "+
					"L to look at Lock, S to inspect the Sheets";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.death_0;}
		else if (Input.GetKeyDown (KeyCode.L))				{myState = States.lock_0b;}
		else if (Input.GetKeyDown (KeyCode.S))				{myState = States.sheets_2;}
	}
	
	void lock_0a()// User attemptsCode 
	{
		text.text = "You run your hands through the bars. Feeling around " +
			"notice push buttons on the locking mechanism. " +
				"You could randomly guess at the code, but there must " +
				"be a better way. \n\n " +
				"Press R to rifle through the Sheets again. ";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.sheets_0;}
	}
	
	void lock_0b()
	{
		text.text = "You run your hands through the bars. Feeling around " +
					"notice push buttons on the locking mechanism. " +
					"You could randomly guess at the code, but there must " +
					"be a better way. \n\n " +
					"Press R to Return to roaming your cell, " +
					"M to use Mirror with bars.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.death_1;}
		else if (Input.GetKeyDown (KeyCode.M))				{myState = States.lock_1;}
	}
	
	void lock_1()
	{
		text.text = "Your wet, warm hand, now coated with your own blood, causes you to " + 
			"lose your grip on the mirror. It hits the ground shatters outside the " +
				"cell door. You look down in disbelief only to notice a more severe problem. " +
				"Press R to return to cell, F to look at your finger. ";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.death_0a;}
		else if (Input.GetKeyDown (KeyCode.F))				{myState = States.death_1a;}
	}
	
	void death_0() 
	{
		text.text = "You have entered an incorrect code. " +
			"You hear a *buzz* and the what sounds like a popping sound. " +
				"Smoke is coming out of the keypad as it appears to be " +
				"permanently damaged. You wait out your days in the cell " +
				"until hunger patiently claims your life. \n\n" +
				"Please press X to view to restart. ";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
	}
	
	void death_1a()
	{
		text.text = "That slice of finger you were missing seemed to have been " +
			"just the beginning. The broken piece of mirror carved your hand " +
				"like a holiday ham. You are losing a severe amount of blood which " +
				"in turn result in your death. \n\n" +
				"Please press X to view to restart. ";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
	}
	
		
	void sheets_2 ()
	{
		text.text = "Adding more color to the sheets with every grab  "+
			"you notice its not entirely covered in filth." + 
				"Feeling weak you consider your next steps.. .\n\n " +
				"Press R to return to roaming your cell, " +
				"T to Triage the your finger.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.death_1;}
		else if (Input.GetKeyDown (KeyCode.T))				{myState = States.sheets_2a;}
	}
	
	void sheets_2a ()
	{
		text.text = "You rip a section of cloth and fashion it around your " +
			"bleeding finger. The bandage soaks a great deal of blood, " +
				"but at least now it can coagulate and form a scab. \n\n " +
				"Press R to retrace your steps from the very beginning., " +
				"B to rest a moment and let your bandage work its magic.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_0;}
		else if	(Input.GetKeyDown (KeyCode.B))				{myState = States.got_it_all;}
	} 
	
	void death_1()
	{
		text.text = "You sit for a bit and wonder about why you are sitting " +
			"on such a filthy bed. A bit turns into a few seconds, " +
				"seconds into minutes and you eventually pass out. " +
				"The amount of blood loss during your nap causes brain " +
				"failure and your cell becomes your grave.\n\n " +
				"Please press X to view to restart. ";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
	}
	
	void death_0a()
	{
		text.text = "You press a few random numbers and the buttons feel wet. " +
			"You have ruined any chances of seeing the combination " +
				"by smearing blood on the keys. You spend the rest of your " +
				"days wondering if your actions were spend efficiently. Your " +
				"finger becomes gangrenous and you die a painful death from " +
				"infection.\n\n " +
				"Please press X to view to restart. ";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
	}
	
	void freedom_0()
	{
		text.text = "You hear the sweet sounds of unlocking immediatly followed by a *POP* " +
			"and smoke emitting from the lock. But the door is now open. " +
				"CONGRATULATIONS, YOU HAVE ESCAPED YOUR CELL! But, are you free? \n\n" +
				"Press P push open the door. ";
		
		if 		(Input.GetKeyDown (KeyCode.P))				{myState = States.ending;}
	}
	
	void ending()
	{
		text.text = "You have escaped your cell only to find " +
			"you are still in Prison. Alone. All the following " +
				"cells are locked, each containing a single skeleton. " +
				"You celebrate your freedom with a little hop and skip " +
				"down the corridors as you wonder what comes next. \n\n " +
				"Please press X to continue planning your escape.";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.corridor_0;}
	}
	
	// End Chapter 1 [Maybe use as checkpoint]
	
	void corridor_0()
	{
		text.text = "You've skipped and hopped, and skipped some more. " +
			"You always seem to find your way back in front of " +
				"your cell...\n\n" +
				"You suppose now would be a good time as any to visit " +
				"your neighbors, doesn't seem like they're going anywhere " +
				"anytime soon.\n\n" +
				"Press A to inspect cell A, B to inspect cell B, and " + 
				"C to inspect cell C.";
		
		if 		(Input.GetKeyDown (KeyCode.A))				{myState = States.cell_A0;}
		else if	(Input.GetKeyDown (KeyCode.B))				{myState = States.cell_B0;}
		else if	(Input.GetKeyDown (KeyCode.C))				{myState = States.cell_C0;}
	}
	
	
	void corridor_1()
	{
		text.text = "You pocket the key and make for the cell door. " +
			"Ignoring your reflection as you pass the mirror, a  " +
				"bit of guilt creeps into the back of your head " +
				"for taking something that wasn't yours. But who could " +
				"resist such tempting words spoken with a Golden tongue?.\n\n"+
				"Press A to inspect cell A, B to inspect cell B, and " +
				"C to inspect cell C.";
		
		if 		(Input.GetKeyDown (KeyCode.A))				{myState = States.cell_A2;}
		else if	(Input.GetKeyDown (KeyCode.B))				{myState = States.cell_B2;}
		else if	(Input.GetKeyDown (KeyCode.C))				{myState = States.cell_C2;}
	}
	
	void corridor_2()
	{
		text.text = "'Hello?!' you yell, but dead silence is the only reply. " +
			"Having searched all but the last cell, your insticnt to  " +
				"is to assess its situation, but with free will and all " +
				"you decide to...\n\n" +
				"Press A to check cell A, press B to check cell B, " +
				"and C to check cell C";
		
		if 		(Input.GetKeyDown (KeyCode.A))				{myState = States.cell_A2;}
		else if	(Input.GetKeyDown (KeyCode.B))				{myState = States.cell_B2;}
		else if	(Input.GetKeyDown (KeyCode.C))				{myState = States.cell_C2;}
	}
	
	void cell_A0()
	{
		text.text = "[LOCKED]\n\n" +
			"The heavily damaged push-button lock was replaced with a small " +
				"golden lock, strangly. The area around (and most likely behind) " +
				"the lock is riddled with very deep gouge marks. You give a nice" +
				"little tug on but quickly realize will not open without a key.\n\n" +
				"Press R to Return to the corridor.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_0;}
	}
	
	void cell_B0()
	{
		text.text = "Cell B appears to be have value! The skeleton at the far end " +
			"grinning at you bears a gold tooth. You stare at it intently but " +
				"its gleaming blurs your vision. Blinking your eyes hard you hear a " +
				"whisper in your ear. Neither words nor a voice, but a whisper none " +
				"the less. !!STARTLED!! you jump forward and bump into Cell B Door " +
				"to find it flying open, You spin around and see absolutely nothing. " +
				"Unsure if you are relieved or sad that you're still alone. You calm " +
				"your nerves and realize there is not a soul around.\n\n" +					
				"As you take notice to the cell the same lovely decor yours. " +
				"A bed with filthy sheets, a mirror, and a skeleton. Well, and "+
				"very old prisoner with a gold tooth.\n\n" +					
				"Press R to return to corridor, B to inspect the Bed, " +
				"M to view mirror and K to check the Skeleton.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_0;}
		else if	(Input.GetKeyDown (KeyCode.B))				{myState = States.bed_B0;}
		else if	(Input.GetKeyDown (KeyCode.M))				{myState = States.mirror_B0;}
		else if	(Input.GetKeyDown (KeyCode.K))				{myState = States.skeleton_B0;}
	}
	
	void cell_C0() // User attemptsCode
	{
		text.text = "[LOCKED]\n\n" +
			"The skeleton in this cell is in very poor shape " +
				"and everything is covered in dust, ash or some kind. " +
				"of powdery residue. You would need a closer look to " +
				"know for sure.\n\n" +
				"Press R to Return to corridor" + 
				"T to enter a 3 digit combination.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_0;} // Remove this curly brace when toggling next line comment
//															securityPanelContainer.SetActive(false);}
	}

	void cell_A1()
	{
		text.text = "This cell’s occupant appears to be hiding under the covers! " +
					"You can barely get a good view of the mirror, you think it " +
					"might be cracked or marred as well.\n\n" +
					"Press R to return to corridor, G to use the Gold key in lock";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_0;}
		else if	(Input.GetKeyDown (KeyCode.G))				{myState = States.cell_A1gold;}
		
	}
	
	void cell_A1gold()
	{
		text.text = "You enter the cell and there is a crunching under your " +
					"feet. You stop to look down and notice a very broken mirror. " +
					"Ahead, a bed, with what looks like a person (or rather, " +
					"skeleton) covered in sheets. Stepping back you notice that" +
					"a majority of the cell is marked in dried blood. You don’t feel " +
					"sick, but the hairs on the back of your neck start to tingle.\n\n" +
					"Press R to return to the corridor, M to check the mirror, and " +
					"B to search the bed.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_1;}
		else if	(Input.GetKeyDown (KeyCode.M))				{myState = States.mirror_A1;}
		else if	(Input.GetKeyDown (KeyCode.B))				{myState = States.bed_A1;}
	}
	
	void cell_B1()
	{
		text.text = "Shiver your timbers! You certainly do NOT want to go back in there " +
					"You have what you need and hopefully have learned an important lesson.\n\n" +
					"Press R to return to corridor.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_1;}
	}
	
	void cell_C1() // User attemptsCode
	{
		text.text = "[LOCKED]\n\n" +
					"Still in very poor condition, the skeleton, as well as " +
					"everything, is covered in dust, ash or some kind. " +
					"know for sure.\n\n" +
					"Press R to Return to corridor" + 
					"T to enter a 3 digit combination.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_1;} // Remove this curly brace when toggling next line comment
//																securityPanelContainer.SetActive(false);}

	}
	
	void cell_A2()
	{
		text.text = "When you left, you made sure that you pulled " +
			"the cell door shut. You heard a *click* and " +
				"double checked	with a light push. Securing the " +
				"door upon exit calmed your nerves enough " +
				"to get back to the task at hand... escaping.\n\n" +
				"Press R to return to the corridor";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_2;}
	}
	
	void cell_B2()
	{
		text.text = "To think you almost got locked in this cell... " +
			"No bother dwelling on past. Perhaps in another " +
				"life time that was you that sang words of gold, " +
				"coaxing other inmates into YOUR cell. And with that " +
				"last ridiculous tought, you return to the corridor.\n\n" +
				"Press R to return to corridor.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_2;}					
	}
	
	
	void cell_C2() //User attemptsCode
	{
		text.text = "[LOCKED]\n\n" +
			"Finally, the last cell." +
				"You wonder how much longer you have to endure this " +
				"fun-house of... un-fun. An UnFun House, if you will. " +
				"Staring at the little display reading [ENTER CODE:] " +
				"for, hopefully, the last time you...\n\n" +
				"Press R to Return to corridor" + 
				"T to enter a 3 digit combination.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_1;} // Remove this curly brace when toggling next line comment
//															securityPanelContainer.SetActive(false);}
	}
	
	void cell_C3a()
	{
		text.text = "Phew! You entered the correct code. Breaching the entrance " + 
			"you could have sworn there was a skeleton in here every  " +
				"other time you passed this cell, but when you try to  " +
				"remember you cant quite place where it was when " +
				"you DID see it.\n\n" +
				"As usual, you see a mirror, a bed with sheets " +
				"and a door with a lock. your journey has " +
				"come full circle...\n\n" +
				"Press R to return to the corridor, M to view Mirror " +
				"B to check the bed, and L to inspect the Lock.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_2;}
		else if	(Input.GetKeyDown (KeyCode.M))				{myState = States.mirror_C3;}
		else if	(Input.GetKeyDown (KeyCode.B))				{myState = States.bed_C3;}
		else if	(Input.GetKeyDown (KeyCode.L))				{myState = States.lock_C3;}				
	}
	
	// Remember to try to include BLACKOUTS	
	void cell_C3b()
	{
		text.text = "You hear an ear piercing *BEEP*, as well " +
			"as the sounds of all the other cell doors unlocking " +
				"and opening. In the corridor a set of what you  " +
				"consider ‘secret’ stairs start to form with the " +
				"lowering of each panel in the floor.\n\n" +
				"Press R to return to cell inspection, "+
				"S to descend the secret stairs!";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_C3a;}
		else if	(Input.GetKeyDown (KeyCode.S))				{myState = States.stairs_0;}			
	}
	
	void bed_B0()
	{
		text.text = "Surprisingly clean-er sheets than your own.\n\n" +
			"Press R to return to inspecting cell B";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_B0;}
	}
	
	
	
	void skeleton_B0()
	{
		text.text = "Upon approaching the skeleton, you realize it isn't a gold " +
			"tooth in its grin, but rather a small gold key in its mouth! " +
				"You take a moment to consider corrective lenses when you get out,  " +
				"but of course, there is that still that... the escape. \n\n" +
				"Press G to take the gold key, R to return roaming the cell. ";
		
		if 		(Input.GetKeyDown (KeyCode.G))				{myState = States.corridor_1;}
		else if	(Input.GetKeyDown (KeyCode.R))				{myState = States.death_B0;}
	}
	
	void mirror_B0()
	{
		text.text = "You check out the mirror but it is scratched matte! " +
			"There must be millions of fine scratch marks swirling " +
				"the entire surface. This is probably why this prisoner " +
				"is still here.\n\n " +	
				"Press R to continue inspecting cell B";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_B0;}
	}
	
	void mirror_A1()
	{
		text.text = "It looks like a disco ball had	a seizure in here. You " +
			"wonder if this prisoner was not as fortunate...\n\n" +
				"Press R to return to cell inspection.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_A1;}			
	}
	
	void mirror_C3()
	{
		text.text = "You look in the mirror and see your reflection. " +
			"‘At least im not a vampire.' you think to yourself. " +
				"What you ALSO see is the skeleton, BEHIND YOU, with " +
				"-00l- etched into its skull. Frightend, you spin around " +
				"with your arms up in defense only to find you are alone, " +
				"STILL. Your heart is slowly returning to its normal rate of " +
				"blood pumping yet you still feel very on edge...\n\n" +
				"Press R to return to cell C.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_C3a;}
	}
	
	//135 cell C entry code	(would be nice to code as random interger every play through)
	void bed_A1()
	{
		text.text = "You lift up the sheets to reveal a HEAVILY blood stained " +
			"bed and skeleton. Oddly, the skeleton is face down, clutching " +
				"the bed, and tightly. You can't help but wonder if this prisoner "+
				"is hiding something as well. Pulling hard on the far shoulder to " +
				"flip it over the mattress is flipped as well revealing the " +
				"numbers 135 smeared in blood. The tingling is now full blown chills " +
				"and you don't particulalry care to stick around to see what happens " +
				"next.\n\n" +
				"Press R to RUN out of the cell into the corridor!";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.corridor_2;}
	}
	
	void bed_C3()
	{
		text.text = "Neatly made and fairly sanitary you see nothing of importance in, " +
			"on, or around this bed.\n\n" +
				"Press R to return to inspecting cell C";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_C3a;}
	}
	
	void lock_C3() // User attemptsCode
	{
		text.text = "Same push button lock as the other cells. " +
			"What code would you like to enter?\n\n" +
				"Press R to continue inspecting cell C, " +
				"T to try a combination.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_C3a;}
		else if	(Input.GetKeyDown (KeyCode.T))				{myState = States.stairs_0;}//change stairs_0 to attemptCode_C3
		//		else if	(Input.GetKeyDown (KeyCode.T))				{myState = States.attemptCode_C3;} //correct code leads to {stairs_0}
	}				
	
	void stairs_0()
	{
		text.text = "You hear an ear piercing beep, as well as the sounds of all " +
			"the other cell doors unlocking and opening. In the corridor " +
				"a set of what you consider ‘secret’ stairs start to form with " +
				"each lowering of panel in the floor.\n\n" +
				"Press R to resume inspecting cell C, " +
				"press S to descend the secret stairs.";
		
		if 		(Input.GetKeyDown (KeyCode.R))				{myState = States.cell_C3a;}
		else if	(Input.GetKeyDown (KeyCode.S))				{myState = States.stairs_1;}
	}
	
	void stairs_1()
	{
		text.text = "You reach the bottom step and you feel a button depress. Nervously, you " +
			"lift your foot and you hear 3 distict screams simulteneously from the " +
				"corridor above. Your heart is either trying to kill you or give you the " +
				"little adrenaline boost you need to survive. But survive what? You don't " +
				"care to know. You scan the room and notice on one far end a door that is " +
				"closing, and on the other is a steel table with a manilla envelope that " +
				"says Cell D - Body Snatcher.\n\n" +
				"You must decide your fate now before you have no longer have a choice.\n\n" +
				"Press D to make a daring Dash for the closing door, or " +
				"M to pick up the manilla envelope.";
		
		if 		(Input.GetKeyDown (KeyCode.D))				{myState = States.freedom_1;}
		else if	(Input.GetKeyDown (KeyCode.M))				{myState = States.envelope_0;}
	}
	
	void freedom_1()
	{
		text.text = "You bolt for the door and it closes on your heels. You stand outside a moment " +
			"and enjoy the warm sun hitting your face. You are in the middle of a " +
				"desert and are unsure how you are going to survive. You are free, but at what " +
				"cost?\n\n" +
				"You spend the rest of your days roaming the desert. The vultures overhead are not " +
				"a sign of good things to come. Parched and starving you collapse on the sand and " +
				"start thinking of what your life was like before you were in that cell, except you" +
				"can only remember only ever being in that cell.\n\n" +
				"In the far distance you see two very small figures. Unsure of whether they are " +
				"coming towards you or away you try to open your mouth to yell, but are too fatigued " +
				"and delirious to to push breath past your lips. You shut your eyes one last time, " +
				"and return to the void.\n\n" +
				"Press X to continue.";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
	}
	
	void envelope_0()
	{
		text.text = "You attempted to grab the manilla envelope AND reach the door in same time, " +
			"but alas, it was already half closed and the decision you made is now haunting " +
				"you. The howling screams and footsteps above seem to be getting closer, albeit " +
				"a bit slow, so you decide open the envelope and see its contents while you \n\n" +
				"contemplate. You tear open the top and start reading a profile... about you! " +
				"A photo and standard information you'd find on a doctors form are contained in "+
				"this file and at the very bottom in small type that reads: *see also: pages 2-13* \n\n" +
				"you flip to the other pages, and every single photo is familiar, as if its " +
				"been your own reflection! Hands shaking, you drop the envelope on the floor as " +
				"three skeletons come clamoring in, speaking in tongues, without tongues! One grabs " +
				"you and you reciprocate the gesture in retaliation, trying to push it off. Your vision" +
				"starts to blurr, hands, arms, and shoulders start to lose sensation as well as " +
				"the rest of your body. You're eyes are open yet you see nothing, " +
				"you let go of the skeleton and collapse to the floor. \n\n" +
				"Press X to continue.";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
		
		
	}
	
	void death_C0()
	{
		text.text = "*BZZZ*\n" +
			"*CODE INCORRECT*\n\n" +
				"A green mist fills the prison and you pass out.\n\n" +
				"Press X to continue.";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
		else if (Input.GetKeyDown (KeyCode.Z))			{myState = States.cell_C0;} //cheat to go back a step. secret code perhaps?
		
	}
	
	void death_C1()
	{
		text.text = "*BZZZ*\n" +
			"*CODE INCORRECT*\n\n" +
				"A green mist fills the prison and you pass out.\n\n" +
				"Press X to continue.";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
		else if (Input.GetKeyDown (KeyCode.Z))			{myState = States.cell_C1;} //cheat to go back a step.
	}
	
	void death_C2()
	{
		text.text = "*BZZZ*\n" +
			"*CODE INCORRECT*\n\n" +
				"A green mist fills the prison and you pass out.\n\n" +
				"Press X to continue.";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
		else if (Input.GetKeyDown (KeyCode.Z))			{myState = States.cell_C2;} //cheat to go back a step.
	}
	
	void death_C3()
	{
		text.text = "*BZZZ*\n" +
			"*CODE INCORRECT*\n\n" +
				"A green mist fills the prison and you pass out.\n\n" +
				"Press X to continue.";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
		else if (Input.GetKeyDown (KeyCode.Z))			{myState = States.cell_C3a;}//cheat to go back a step.
		
	}
	
	void death_B0()
	{
		text.text = "Your'e guilt ridden and decide against taking what isn't yours. " +
			"Turning to look back at the cell and you hear the cell door close " +
				"and click! You run over to push on the bars with all your " +
				"weight but they are locked solid. You spend the rest of your days in " +
				"the company of your prison mate. You swore you heard sounds at the " +
				"moment of your death, but what good would that do at such a time?\n\n " +
				"Press X to continue.";
		
		if 		(Input.GetKeyDown (KeyCode.X))				{myState = States.cell_0;}
		else if (Input.GetKeyDown (KeyCode.Z))			{myState = States.cell_B0;}
	}
	
	
	
	
	
	
	
	
}