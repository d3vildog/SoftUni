package exam_1_June_2014;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.TreeSet;

public class p4_Logs_Aggregator {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		scan.nextLine();
		TreeMap<String, TreeSet<String>> ipsLogs = new TreeMap<>();
		TreeMap<String, Integer> durationOfLogs = new TreeMap<>();
		
		for (int i = 0; i < n; i++) {
			String[] inputLine = scan.nextLine().split(" ");
			
			// initializing the variables name ipAdress and duration
			String name = inputLine[1];
			String ipAdress = inputLine[0];
			String duration = inputLine[2];
			
			// adding the ip's the the user
			TreeSet<String> ipSet = ipsLogs.get(name);
			if (ipSet == null) {
				ipSet = new TreeSet<>();
			}
			ipSet.add(ipAdress);
			ipsLogs.put(name, ipSet);
			
			// adding duration's to the user
			Integer oldDuration = durationOfLogs.get(name);
			if (oldDuration == null) {
				oldDuration = 0;
			}
			durationOfLogs.put(name, oldDuration + Integer.parseInt(duration));
		}
		
		// outputting the result as needed
		for (String key : ipsLogs.keySet()) {
			System.out.println(key + ": " + durationOfLogs.get(key) + " " + ipsLogs.get(key));
		}
	}

}
