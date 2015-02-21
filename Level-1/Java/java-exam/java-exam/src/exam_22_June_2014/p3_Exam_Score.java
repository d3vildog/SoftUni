package exam_22_June_2014;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.HashMap;
import java.util.Scanner;

public class p3_Exam_Score {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		HashMap<String, HashMap<String, ArrayList<Integer>>> grades = new HashMap<>();
		HashMap<String, ArrayList<Integer>> test = new HashMap<>();
		test.put("grades", new ArrayList<>(Arrays.asList(5, 2 , 5)));
		
		//grades.put("Dani", (HashMap<String, Double>) new HashMap<>().put("Wow", 5.4));
		grades.put("Dani", test);
		
		for (String some : grades.keySet()) {
			System.out.println(some + " " + grades.get(some).keySet() + " " + grades.get(some).values());
			Collection<ArrayList<Integer>> gr = grades.get(some).values();
			
			gr.stream().forEach(x -> System.out.println(x));
		}
	}

}
