package exam_27_May_2014;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Locale;
import java.util.Scanner;
import java.util.TreeSet;

public class p2_Three_Largest_Numbers {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.ROOT);
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		ArrayList<BigDecimal> numbers = new ArrayList<>();
		
		for (int i = 0; i < n; i++) {
			BigDecimal inputNumb = scan.nextBigDecimal();
			numbers.add(inputNumb);
		}
		
		Collections.sort(numbers, Collections.reverseOrder());
		
		int count = 0;
		for (BigDecimal numb : numbers) {
			System.out.println(numb.toPlainString());
			count++;
			if (count == 3) {
				break;
			}
		}
	}

}
