package exam_27_May_2014;

import java.util.Scanner;

public class p1_Count_Beers {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		int totalBeers = 0;
		
		while (true) {
			String inputLine = scan.nextLine();
			if (inputLine.equals("End")) {
				break;
			}
			String[] lineElements = inputLine.split(" ");
			
			if (lineElements[1].equals("stacks")) {
				totalBeers += Integer.parseInt(lineElements[0]) * 20;
				
			}else if (lineElements[1].equals("beers")) {
				totalBeers += Integer.parseInt(lineElements[0]);
				
			}
		}
		
		int beers = totalBeers % 20;
		int stacks = totalBeers / 20;
		System.out.printf("%1$d stacks + %2$d beers", stacks, beers);
	}

}
