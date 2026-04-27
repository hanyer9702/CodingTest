import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		int sum = 0;
		Scanner a = new Scanner(System.in);
		int d = a.nextInt();
        for(int i=1; i<=d; i++){
            sum += i;
        }
        System.out.println(""+sum);
	}

}