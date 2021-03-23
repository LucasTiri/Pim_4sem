package exemploWHile;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class exemploWHile {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int a=1;
		int b=2;
		int c=3;
		
		int soma= a+b+c;
		System.out.println(soma);
		int soma1= a++ + b++ + c++;
		System.out.println(soma1);
		int soma2=++a + --b + --c;
		System.out.println(soma2);
	}

}
