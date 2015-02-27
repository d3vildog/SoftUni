package exam_3_sept_2014;

import java.util.Scanner;

public class p1_DozenEggs {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		int totalEggs = 0;
		int dozens = 0;
		int eggs = 0;
		
		// initializing constant variables for the the exact input of 7 lines
		int inputLines = 7;
		
		// inputting the list of eggs or dozens
		for (int i = 0; i < inputLines; i++) {
			String[] currentLine = scan.nextLine().split(" ");
						
			// checking if the input is dozens or eggs and doing the needed action
			if (currentLine[1].equals("dozens")) {
				totalEggs += 12 * Integer.parseInt(currentLine[0]);
			}else if (currentLine[1].equals("eggs")) {
				totalEggs += Integer.parseInt(currentLine[0]);
			}
		}
		
		// splitting the total eggs to dozens and left eggs
		dozens = totalEggs / 12;
		eggs = totalEggs % 12;
		String format = String.format("%1$d dozens + %2$d eggs", dozens, eggs);
		System.out.printf(format);				
	}

}
