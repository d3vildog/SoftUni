package exam_22_June_2014;

import java.util.HashSet;
import java.util.Scanner;

public class p1_Cognate_Words {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		String[] elements = scan.nextLine().split("[^a-zA-Z]+");
		boolean foundCognateWords = false;
		HashSet<String> cognateWords = new HashSet<>();
		
		for (int a = 0; a < elements.length; a++) {
			String wordA = elements[a];
			for (int b = 0; b < elements.length; b++) {
				String wordB = elements[b];
				for (int c = 0; c < elements.length; c++) {
					String concatWord = elements[c];
					
					if (a != b && (wordA + wordB).equals(concatWord)) {
						foundCognateWords = true;
						cognateWords.add(wordA + "|" + wordB + "=" + concatWord);
					}
				}
			}
		}		
		
		if (cognateWords.isEmpty()) {
			System.out.println("No");
		}else {
			for (String word : cognateWords) {
				System.out.println(word);
			}
		}
	}

}
