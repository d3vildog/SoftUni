package exam_26_May_2014;

import java.util.Scanner;

public class p1_Video_Duration {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		int totalMinutes = 0;
		
		while (true) {
			String inputLine = scan.nextLine();
			if (inputLine.equals("End")) {
				break;
			}
			String[] time = inputLine.split(":");
			int hour = Integer.parseInt(time[0]);
			int minute = Integer.parseInt(time[1]);
			
			totalMinutes += hour * 60;
			totalMinutes += minute;
		}
		
		int hours = totalMinutes / 60;
		int minutes = totalMinutes % 60;
		
		System.out.printf("%d:%02d", hours, minutes);
	}

}
