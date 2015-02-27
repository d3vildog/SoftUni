package exam_27_May_2014;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.jar.Attributes.Name;

public class p4_Orders {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		scan.nextLine();
		String[] lineElements;
		HashMap<String, TreeMap<String, Integer>> orders = new HashMap<>();
		ArrayList<String> orderedProduct = new ArrayList<>();
		
		for (int i = 0; i < n; i++) {
			String inputLine = scan.nextLine();
			lineElements = inputLine.split("\\s");
			
			// splitting in different variables
			String name = lineElements[0];
			int amount = Integer.parseInt(lineElements[1]);
			String product = lineElements[2];
			if (!orderedProduct.contains(product)) {
				orderedProduct.add(product);
			}
			TreeMap<String, Integer> customerAndProduct = orders.get(product);
			if (customerAndProduct == null) {
				customerAndProduct = new TreeMap<>();
			}
			
			// getting the amount of given customer
			Integer oldAmount = customerAndProduct.get(name);
			if (oldAmount == null) {
				oldAmount = 0;
			}
			customerAndProduct.put(name, oldAmount + amount);
			orders.put(product, customerAndProduct);
		}
		
		// beers: alex 5, bob 10, kiro 1, mimi 2
		int count = 0;
		for (String prod : orderedProduct) {
			System.out.print(prod + ": ");
			for (String name : orders.get(prod).keySet()) {
				count++;
				if (count < 2) {
					System.out.print(name + " " + orders.get(prod).get(name));
				}else{
					System.out.print(", " + name + " " + orders.get(prod).get(name));
				}
			}
			System.out.println();
			count = 0;
		}
	}

}
