package exam_26_May_2014;

import java.util.Scanner;

public class p2_Pythagorean_Numbers {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		int[] numbers = new int[n];
		boolean foundNumbers = false;
		
		for (int i = 0; i < n; i++) {
			int number = scan.nextInt();
			numbers[i] = number;
		}
		
		for (int a = 0; a < numbers.length; a++) {
			for (int b = 0; b < numbers.length; b++) {
				if (numbers[a] <= numbers[b]) {
					for (int c = 0; c < numbers.length; c++) {
						
						int aPlusB = numbers[a]*numbers[a] + numbers[b]*numbers[b]; 
						if (aPlusB == numbers[c] * numbers[c]) {
							System.out.printf("%1$d*%1$d + %2$d*%2$d = %3$d*%3$d\n", numbers[a], numbers[b], numbers[c]);
							foundNumbers = true;
						}
					}
				}
			}
		}
		
		if (!foundNumbers) {
			System.out.println("No");
		}
	}

}
