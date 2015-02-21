package exam_1_June_2014;

import java.util.HashMap;
import java.util.Scanner;

public class p2_Sum_Cards {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		String[] cards = scan.nextLine().replaceAll("[SHDC]+", "").concat(" 1982377").split(" ");		
		int counter = 1;
		int sumOfCards = 0;
		
		for (int i = 1; i < cards.length; i++) {
			int prev = convertToPoint(cards[i - 1]);
			int next = convertToPoint(cards[i]);
			
			if (prev == next) {
				counter++;
			}else {
				if (counter > 1) {
					sumOfCards += ((counter * prev) * 2);
				}else {
					sumOfCards += prev;
				}
				counter = 1;
			}
			
		}
		
		System.out.println(sumOfCards);
	}

	private static int convertToPoint(String card) {
		int number = 0;
		
		HashMap<String, Integer> faces = new HashMap<>();
		faces.put("J", 12);
		faces.put("Q", 13);
		faces.put("K", 14);
		faces.put("A", 15);
		
		if (faces.containsKey(card)) {
			number = faces.get(card);
		}else {
			number = Integer.parseInt(card);
		}
		
		return number;
	}

}
