import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		int sum = 0;
		Scanner a = new Scanner(System.in);
		int d = a.nextInt();
        for(int i=d; i>0; i--){
            for(int j=i; j>1; j--) {
            	System.out.print(" ");
            }
            for(int k=0;k<=d-i;k++) {
            	System.out.print("*");
            }
            System.out.println();
        }
	}

}