package exam_3_sept_2014;

import java.util.Collection;
import java.util.Collections;
import java.util.Scanner;
import java.util.TreeSet;

public class p3_Biggest_3_Prime_Numbers {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		boolean primesFound = false;
		String[] numbers = scan.nextLine().split("[( )]+");
		TreeSet<Integer> primeNumber = new TreeSet<>(Collections.reverseOrder());
		
		// adding all the numbers to the set 
		for (int i = 0; i < numbers.length; i++) {
			if (!numbers[i].equals("")) {
				primeNumber.add(Integer.parseInt(numbers[i]));
			}
		}
		
		// searching for three prime numbers                  // 9 8 7 6 5 4 3 2 1 0
		int count = 0;
		int sumOfPrimes = 0;
		for (Integer currNumber : primeNumber) {
			if (currNumber <= 1 || count == 3) {
				primesFound = true;
				break;
			}			
			
			boolean isPrime = true;
			for (int i = 2; i < currNumber; i++) {
				if (currNumber % i == 0) {
					isPrime = false;
					break;
				}
			}
			
			if (isPrime) {
				sumOfPrimes += currNumber;
				count++;
			}
		}
		
		// if no 3 primes had been found
		if (count == 3) {
			// print the sum of primes if there any
			System.out.println(sumOfPrimes);			
		}else {
			System.out.println("No");
		}
	}

}
