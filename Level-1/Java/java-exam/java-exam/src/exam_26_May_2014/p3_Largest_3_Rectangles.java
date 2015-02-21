package exam_26_May_2014;

import java.util.Scanner;

public class p3_Largest_3_Rectangles {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		String inputLine = scan.nextLine();
		String[] numbers = inputLine.split("[\\[x\\] ,]+");
		int maxArea = Integer.MIN_VALUE;
		
		for (int first = 2; first < numbers.length; first+=2) {
			int firstRect = getArea(numbers[first], numbers[first-1]);
			int secondRect = 0;
			if (first + 2 < numbers.length) {
				secondRect = getArea(numbers[first + 1], numbers[first + 2]);
			}
			int thirdRect = 0;
			if (first + 4 < numbers.length) {
				thirdRect = getArea(numbers[first + 3], numbers[first + 4]);
			}
			
			int area = firstRect + secondRect + thirdRect;
			maxArea = Math.max(area, maxArea);	
		}
		
		System.out.println(maxArea);
	}

	private static int getArea(String string, String string2) {
		int area = 0;
		
		int first = Integer.parseInt(string);
		int second = Integer.parseInt(string2);
		area = first * second;
		
		return area;
	}

}
