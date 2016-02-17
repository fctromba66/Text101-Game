using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestController : MonoBehaviour {

	public Text text;
	private enum States {
		aquarium, rays_0, rays_1, hippo_0, hippo_1, cafe, food_cafe, hallway_0, tunnel_0, tunnel_1,
		tunnel_2, giftshop, mega_teeth, hallway_1, hallway_2, hallway_3, movie_out, movie_in
		};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.aquarium;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.aquarium) 		{aquarium();}
		else if (myState == States.rays_0) 			{rays_0();}
		else if (myState == States.rays_1)			{rays_1();}
		else if (myState == States.hippo_0) 		{hippo_0();}
		else if (myState == States.hippo_1)			{hippo_1();}
		else if (myState == States.cafe)			{cafe();}
		else if (myState == States.food_cafe)		{food_cafe();}
		else if (myState == States.hallway_0)		{hallway_0();}
		else if (myState == States.tunnel_0)		{tunnel_0();}
		else if (myState == States.tunnel_1)		{tunnel_1();}
		else if (myState == States.tunnel_2)		{tunnel_2();}
		else if (myState == States.giftshop)		{giftshop();}
		else if (myState == States.mega_teeth)		{mega_teeth();}
		else if (myState == States.hallway_1)		{hallway_1();}
		else if (myState == States.hallway_2)		{hallway_2();}
		else if (myState == States.hallway_3)		{hallway_3();}
		else if (myState == States.movie_in)		{movie_in();}
		else if (myState == States.movie_out)		{movie_out();}
	}
	void movie_out () {
		text.text = "You found your way to a movie theater where they are playing" +
					" a movie about penguins looking for a mate, which you will be " +
					"very educational.\n\n" +
					"Press F to continue on to finish the Aquarium, or H to return to " +
					"the Hallway.";
		if 		(Input.GetKeyDown(KeyCode.H))		{myState = States.hallway_2;}
		else if (Input.GetKeyDown(KeyCode.F))		{myState = States.hallway_3;}
	}
	void movie_in () {
		text.text = "Looks like you want to watch the movie. But you do not have a ticket" +
					" guess you have to go back and buy a ticket to the movie.\n\n" +
					"Press H to return to the Hallway.";
		if 		(Input.GetKeyDown(KeyCode.H))		{myState = States.hallway_0;}
	}
	void hallway_3 () {
		text.text = "You have made it through the Aquarium and are now on your way " +
					"to the end and finally get to pick out your gift from the giftshop" +
					"and have something to remember your journey and education.\n\n" +
					"Press G to go to the Giftshop, or B to go and see the movie again.";
		if 		(Input.GetKeyDown(KeyCode.G))		{myState = States.giftshop;}
		else if (Input.GetKeyDown(KeyCode.B))		{myState = States.movie_out;}
	}
	void hallway_2 () {
		text.text = "In the hallway again after watching the movie and learning alot. " +
					"Hopefully you can make it to the Giftshop before the Aquarium closes.\n\n" +
					"Press W to go watch the movie, or T to journey on to the Shark Tunnel.";
		if 		(Input.GetKeyDown(KeyCode.W))		{myState = States.movie_out;}
		else if (Input.GetKeyDown(KeyCode.T))		{myState = States.tunnel_2;}
	}
	void hallway_1 () {
		text.text = "On your way to the Shark Tunnel and you notice that there are many" +
					" other animals all around. They have an Octopus, Moon Jellyfish and " +
					"a station where you can pet some Starfish and Horseshoe Crabs.\n\n" +
					"Press B to go see the movie, or T to continue your journey to the Shark" +
					" Tunnel.";				
		if 		(Input.GetKeyDown(KeyCode.B))		{myState = States.movie_out;}
		else if (Input.GetKeyDown(KeyCode.T))		{myState = States.tunnel_1;}
	}
	void mega_teeth () {
		text.text = "You see a Replica of the Megalodon Shark Teeth. You ask some other visitors" +
					" to take a photo of you inside the teeth.\n\n" +
					"Press H to Return to the Hallway, or P to Continue to the Shark Tunnel.";
		if 		(Input.GetKeyDown(KeyCode.H))		{myState = States.hallway_0;}
		else if (Input.GetKeyDown(KeyCode.P))		{myState = States.hallway_1;}
	}
	void giftshop () {
		text.text = "What an incredible adventure, you saw everything that the Aquarium," +
					" from petting the StingRays to walking through the Shark Tunnel. Now" +
					" you get to pick your gift from the Giftshop. What will you choose, a " +
					"stuffed animal penguin, a T-Shirt with a shark on it, or a Mug with your" +
					" name on it. Look around and choose.\n\n" +
					"Press A to revisit the Aquarium.";
		if 		(Input.GetKeyDown(KeyCode.A))		{myState = States.aquarium;}
	}
	void tunnel_0 () {
		text.text = "As you journey through the Shark Tunnel, the Hammerhead Shark swims " +
					"right over top of you. You start to get scared because its your first" +
					" time you have ever been down here.\n\n" +
					"Press H to return to the Hallway.";
		if 		(Input.GetKeyDown(KeyCode.H))		{myState = States.hallway_0;}
	}
	void tunnel_1 () {
		text.text = "After being scared by the Hammerhead Shark the first time, you try again" +
					" and you get halfway through when you see a Giant StingRay swim over " +
					"you and you run out of the Tunnel.\n\n" +
					"Press H to return to the Hallway.";
		if 		(Input.GetKeyDown(KeyCode.H))		{myState = States.hallway_1;}
	}
	void tunnel_2 () {
		text.text = "This is your third attempt to make it through the Shark Tunnel. This time " +
					"you feel that you can make it through without being scared. This time you are" +
					" almost at the other side of the tunnel, and you see this huge shadow come over" +
					"you and get so spooked that you run the wrong way down to the beginning of the " +
					"tunnel.\n\n" +
					"Press H to return to the Hallway.";
		if 		(Input.GetKeyDown(KeyCode.H))		{myState = States.hallway_2;}
	}
	void aquarium () {
		text.text = "You are at the Aquarium and need to see everything before " +
					"getting a gift at the end of your visit. There will be many" +
					" things that you see and pet within your journey.\n\n" +
					"Press P to pet the StingRays, C to go to the Cafe, or H to go to Hippo Haven.";
		if 		(Input.GetKeyDown(KeyCode.P)) 		{myState = States.rays_0;}
		else if (Input.GetKeyDown(KeyCode.C))		{myState = States.cafe;}
		else if (Input.GetKeyDown(KeyCode.H))		{myState = States.hippo_0;}
	}
	void cafe () {
		text.text = "As you journey through the Aquarium you start to get hungry and " +
					"decide to get some food. At the cafe you notice french fries and" +
					" drinks that look delicious. You can even get a souvenir cup.\n\n" +
					"Press E to eat at the Cafe or A to continue exploring the Aquarium.";
		if 		(Input.GetKeyDown(KeyCode.E))		{myState = States.food_cafe;}
		else if (Input.GetKeyDown(KeyCode.A))		{myState = States.aquarium;}
	}
	void food_cafe () {
		text.text = "Now that you have a full stomach. You can continue your journey " +
			"through the aquarium and finish having fun, but don't forget about" +
				" your gift.\n\n" +
				"Press P to pet the StingRays, or H to visit Hippo Haven.";
		if 		(Input.GetKeyDown(KeyCode.P))		{myState = States.rays_1;}
		if 		(Input.GetKeyDown(KeyCode.H))		{myState = States.hippo_1;}
	}
	void rays_0 () {
		text.text = "The StingRays are very playful and the instructor says that they " +
					"need a five minute break before you can pet them. But the instructor" +
					" also mentions that if you return you will be able to feed the StingRays.\n\n" +
					"Press A to continue exploring the Aquarium.";
		if 		(Input.GetKeyDown(KeyCode.A))		{myState = States.aquarium;}
	}
	void rays_1 () {
		text.text = "The StingRays are very playful and the instructor says only " +
					"touch with two fingers. You are very gentle and get picked to" +
					" feed them and take your shoes off and hop in. You have so " +
					"much fun and don't want to leave but you know there is alot to see.\n\n" +
					"Press A to continue exploring the Aquarium.";
		if 		(Input.GetKeyDown(KeyCode.A)) 		{myState = States.food_cafe;}
	}
	void hippo_0 () {
		text.text = "Your journey continues and you find yourself visiting the Hippos" +
					" who are swimming around with their fishy friends. You see them " +
					"having fun with a lot of toys.\n\n" +
					"Press A to continue exploring the Aquarium.";
		if 		(Input.GetKeyDown(KeyCode.A)) 		{myState = States.aquarium;}
	}
	void hippo_1 () {
		text.text = "The Hippos are adorable and love to have fun. You take a better look " +
					" and climb the stairs to the observation deck and what's that on the " +
					"land moving around, it's the Porcupine which you never ever see!!!\n\n" +
					"Press H to enter the hallway towards the Shark Tunnel, or E to continue" +
					" exploring the Aquarium.";
		if 		(Input.GetKeyDown(KeyCode.H))		{myState = States.hallway_0;}
		else if (Input.GetKeyDown(KeyCode.E)) 		{myState = States.food_cafe;}
	}
	void hallway_0 () {
		text.text = "You are now starting your journey to the Shark Tunnel. There are many " +
					"exhibits on your way to the Shark Tunnel that you will visit.\n\n" +
					"Press B to buy a ticket to the movie, L to go see the Megalodon Teeth, or H to" +
					" continue to the Shark Tunnel.";
		if 		(Input.GetKeyDown(KeyCode.H))		{myState = States.tunnel_0;}
		else if (Input.GetKeyDown(KeyCode.L))		{myState = States.mega_teeth;}
		else if (Input.GetKeyDown(KeyCode.B))		{myState = States.movie_in;}
	}
}