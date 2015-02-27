package exam_3_sept_2014;

import java.util.Scanner;

public class p2_Adding_Angles {

	public static void main(String[] args) {
		
		// initializing variables and input variables
		Scanner scan = new Scanner(System.in);
		int numberOfAngles = scan.nextInt();
		int[] angles = new int[numberOfAngles];
		boolean foundRotation = false;
		
		// inputting the angles
		for (int i = 0; i < numberOfAngles; i++) {
			int angle = scan.nextInt();
			// adding the angle to the array
			angles[i] = angle;
		}
		
		// making 3 in line for loops and checking if there're any full rotations
		for (int first = 0; first < angles.length; first++) {
			for (int second = first + 1; second < angles.length; second++) {
				for (int third = second + 1; third < angles.length; third++) {
					int sumOfAngles = angles[first] + angles[second] + angles[third];
					
					if (sumOfAngles % 360 == 0) {
						foundRotation = true;
						System.out.printf("%1$d + %2$d + %3$d = %4$d degrees\n", angles[first], angles[second], angles[third], sumOfAngles);
					}
				}
			}
		}
		
		// printing no if "No" rotations had been found
		if (!foundRotation) {
			System.out.println("No");
		}
	}

}
